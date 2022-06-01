// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> The configuration settings of the app registration for providers that have app ids and app secrets. </summary>
    public partial class AppRegistration
    {
        /// <summary> Initializes a new instance of AppRegistration. </summary>
        public AppRegistration()
        {
        }

        /// <summary> Initializes a new instance of AppRegistration. </summary>
        /// <param name="appId"> The App ID of the app used for login. </param>
        /// <param name="appSecretSettingName"> The app setting name that contains the app secret. </param>
        internal AppRegistration(string appId, string appSecretSettingName)
        {
            AppId = appId;
            AppSecretSettingName = appSecretSettingName;
        }

        /// <summary> The App ID of the app used for login. </summary>
        public string AppId { get; set; }
        /// <summary> The app setting name that contains the app secret. </summary>
        public string AppSecretSettingName { get; set; }
    }
}
