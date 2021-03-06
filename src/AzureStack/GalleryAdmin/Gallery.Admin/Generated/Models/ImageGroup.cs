// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Gallery.Admin.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Group of images.
    /// </summary>
    public partial class ImageGroup
    {
        /// <summary>
        /// Initializes a new instance of the ImageGroup class.
        /// </summary>
        public ImageGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageGroup class.
        /// </summary>
        /// <param name="context">Image group identifier.</param>
        /// <param name="items">List of images.</param>
        public ImageGroup(string context = default(string), IList<Image> items = default(IList<Image>))
        {
            Context = context;
            Items = items;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets image group identifier.
        /// </summary>
        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        /// <summary>
        /// Gets list of images.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<Image> Items { get; private set; }

    }
}
