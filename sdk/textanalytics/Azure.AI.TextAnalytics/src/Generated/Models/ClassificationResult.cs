// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The ClassificationResult. </summary>
    internal partial class ClassificationResult
    {
        /// <summary> Initializes a new instance of ClassificationResult. </summary>
        /// <param name="category"> Classification type. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the recognized class. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="category"/> is null. </exception>
        public ClassificationResult(string category, double confidenceScore)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            Category = category;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Classification type. </summary>
        public string Category { get; set; }
        /// <summary> Confidence score between 0 and 1 of the recognized class. </summary>
        public double ConfidenceScore { get; set; }
    }
}
