// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Text;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Azure.WebJobs.Host.Scale;
using Microsoft.Azure.WebJobs.ServiceBus;
using Microsoft.Azure.WebJobs.ServiceBus.Listeners;

using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Host;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners
{
    public class ServiceBusScaleMonitorProviderForScaleController : IScaleMonitorProviderForScaleController
    {
        public IScaleMonitor Create(ScaleMonitorContext context)
        {
            // This time, Service Bus extension looks modifying the option on Startup
            // var serviceBusOption = context.GetExtensionOption<ServiceBusOptions>("serviceBus");
            // This method is fine
            var attribute = context.GetTriggerAttribute<ServiceBusTriggerAttribute>();

            var builder = new HostBuilder()
                .ConfigureHostConfiguration((configurationBuilder) =>
                {
                    configurationBuilder.AddConfiguration(context.Configration);
                })
                .ConfigureServices((servcies) =>
                {
                    var webJobsBuilder = new WebJobsBuilderForScaleController(servcies);
                    webJobsBuilder.AddServiceBus();
                });
            var host = builder.Build();

            var clientFacotry = host.Services.GetRequiredService<Config.ServiceBusClientFactory>();

            var messagingProvider = host.Services.GetRequiredService<MessagingProvider>();

            // Configure serviceBusOptions through the DI.
            var servcieBusOptions = host.Services.GetRequiredService <IOptions<ServiceBusOptions>>()?.Value;

            string entityPath = null;
            string queueName = null;
            string topicName = null;
            string subscriptionName = null;
            ServiceBusEntityType entityType;
            if (attribute.QueueName != null)
            {
                queueName = Resolve(context.NameResolver, attribute.QueueName);
                entityPath = queueName;
                entityType = ServiceBusEntityType.Queue;
            }
            else
            {
                topicName = Resolve(context.NameResolver, attribute.TopicName);
                subscriptionName = Resolve(context.NameResolver, attribute.SubscriptionName);
                entityPath = EntityNameFormatter.FormatSubscriptionPath(topicName, subscriptionName);
                entityType = ServiceBusEntityType.Topic;
            }

            // NOTE: original code modify attribute directory that is not recommended.
            var client = new Lazy<ServiceBusClient>(() => clientFacotry.CreateClientFromSetting(attribute.Connection));
            var batchReceiver = new Lazy<ServiceBusReceiver>(
                () => messagingProvider.CreateBatchMessageReceiver(
                    client.Value,
                    entityPath,
                    servcieBusOptions.ToReceiverOptions()));

            // Problem client factory. We can use the same logic for the DI related configuration.
            return new ServiceBusScaleMonitor(context.FunctionId, entityType, entityPath, attribute.Connection, batchReceiver, context.LoggerFactory, clientFacotry);
        }

        private static string Resolve(INameResolver resolver, string queueName)
        {
            if (resolver == null)
            {
                return queueName;
            }

            return resolver.ResolveWholeString(queueName);
        }
    }
}
