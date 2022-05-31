// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Caching settings for a caching-type route. To disable caching, do not provide a cacheConfiguration object. </summary>
    public partial class AfdRouteCacheConfiguration
    {
        /// <summary> Initializes a new instance of AfdRouteCacheConfiguration. </summary>
        public AfdRouteCacheConfiguration()
        {
        }

        /// <summary> Initializes a new instance of AfdRouteCacheConfiguration. </summary>
        /// <param name="queryStringCachingBehavior"> Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings. </param>
        /// <param name="queryParameters"> query parameters to include or exclude (comma separated). </param>
        /// <param name="compressionSettings"> compression settings. </param>
        internal AfdRouteCacheConfiguration(AfdQueryStringCachingBehavior? queryStringCachingBehavior, string queryParameters, RouteCacheCompressionSettings compressionSettings)
        {
            QueryStringCachingBehavior = queryStringCachingBehavior;
            QueryParameters = queryParameters;
            CompressionSettings = compressionSettings;
        }

        /// <summary> Defines how Frontdoor caches requests that include query strings. You can ignore any query strings when caching, ignore specific query strings, cache every request with a unique URL, or cache specific query strings. </summary>
        public AfdQueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }
        /// <summary> query parameters to include or exclude (comma separated). </summary>
        public string QueryParameters { get; set; }
        /// <summary> compression settings. </summary>
        public RouteCacheCompressionSettings CompressionSettings { get; set; }
    }
}
