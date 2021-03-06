// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> REST API operation. </summary>
    public partial class Operation
    {
        /// <summary> Initializes a new instance of Operation. </summary>
        internal Operation()
        {
        }

        /// <summary> Initializes a new instance of Operation. </summary>
        /// <param name="name"> Operation name: {provider}/{resource}/{operation}. </param>
        /// <param name="display"> The object that represents the operation. </param>
        internal Operation(string name, OperationDisplay display)
        {
            Name = name;
            Display = display;
        }

        /// <summary> Operation name: {provider}/{resource}/{operation}. </summary>
        public string Name { get; }
        /// <summary> The object that represents the operation. </summary>
        public OperationDisplay Display { get; }
    }
}
