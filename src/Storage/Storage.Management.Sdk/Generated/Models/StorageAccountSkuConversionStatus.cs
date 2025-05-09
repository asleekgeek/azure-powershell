// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// This defines the sku conversion status object for asynchronous sku
    /// conversions.
    /// </summary>
    public partial class StorageAccountSkuConversionStatus
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountSkuConversionStatus class.
        /// </summary>
        public StorageAccountSkuConversionStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountSkuConversionStatus class.
        /// </summary>

        /// <param name="skuConversionStatus">This property indicates the current sku conversion status.
        /// Possible values include: &#39;InProgress&#39;, &#39;Succeeded&#39;, &#39;Failed&#39;</param>

        /// <param name="targetSkuName">This property represents the target sku name to which the account sku is
        /// being converted asynchronously.
        /// Possible values include: &#39;Standard_LRS&#39;, &#39;Standard_GRS&#39;, &#39;Standard_RAGRS&#39;,
        /// &#39;Standard_ZRS&#39;, &#39;Premium_LRS&#39;, &#39;Premium_ZRS&#39;, &#39;Standard_GZRS&#39;,
        /// &#39;Standard_RAGZRS&#39;, &#39;StandardV2_LRS&#39;, &#39;StandardV2_GRS&#39;, &#39;StandardV2_ZRS&#39;,
        /// &#39;StandardV2_GZRS&#39;, &#39;PremiumV2_LRS&#39;, &#39;PremiumV2_ZRS&#39;</param>

        /// <param name="startTime">This property represents the sku conversion start time.
        /// </param>

        /// <param name="endTime">This property represents the sku conversion end time.
        /// </param>
        public StorageAccountSkuConversionStatus(string skuConversionStatus = default(string), string targetSkuName = default(string), string startTime = default(string), string endTime = default(string))

        {
            this.SkuConversionStatus = skuConversionStatus;
            this.TargetSkuName = targetSkuName;
            this.StartTime = startTime;
            this.EndTime = endTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets this property indicates the current sku conversion status. Possible values include: &#39;InProgress&#39;, &#39;Succeeded&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "skuConversionStatus")]
        public string SkuConversionStatus {get; private set; }

        /// <summary>
        /// Gets or sets this property represents the target sku name to which the
        /// account sku is being converted asynchronously. Possible values include: &#39;Standard_LRS&#39;, &#39;Standard_GRS&#39;, &#39;Standard_RAGRS&#39;, &#39;Standard_ZRS&#39;, &#39;Premium_LRS&#39;, &#39;Premium_ZRS&#39;, &#39;Standard_GZRS&#39;, &#39;Standard_RAGZRS&#39;, &#39;StandardV2_LRS&#39;, &#39;StandardV2_GRS&#39;, &#39;StandardV2_ZRS&#39;, &#39;StandardV2_GZRS&#39;, &#39;PremiumV2_LRS&#39;, &#39;PremiumV2_ZRS&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetSkuName")]
        public string TargetSkuName {get; set; }

        /// <summary>
        /// Gets this property represents the sku conversion start time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public string StartTime {get; private set; }

        /// <summary>
        /// Gets this property represents the sku conversion end time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public string EndTime {get; private set; }
    }
}