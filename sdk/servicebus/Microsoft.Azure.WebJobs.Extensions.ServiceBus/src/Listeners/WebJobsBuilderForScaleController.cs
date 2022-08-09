// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.WebJobs.Extensions.ServiceBus.Listeners
{
    // ServiceBusExtensions using ServiceBusWebJobsStartup with Modifying the Attribute class.
    // So that we can create a simple bulder that inherit IWebJobsBuilder to use the Extension method.
    internal class WebJobsBuilderForScaleController : IWebJobsBuilder
    {
        // Original Implementation is just tracking the change. Microsoft.Azure.WebJobs.Host.WebJobsBuilder (internal scope)
        public WebJobsBuilderForScaleController(IServiceCollection services)
        {
            Services = services;
        }
        public IServiceCollection Services { get; }
    }
}
