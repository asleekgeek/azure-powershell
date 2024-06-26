// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Microsoft.Azure.Management.Maintenance.Models;

namespace Microsoft.Azure.Commands.Maintenance.Models
{
    public partial class PSConfigurationAssignment
    {
        public string Location { get; set; }
        public string MaintenanceConfigurationId { get; set; }
        public string ResourceId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FilterTag { get; set; }
        public string FilterOperator { get; set; }
        public string[] FilterResourceType { get; set; }
        public string[] FilterLocation { get; set; }
        public string[] FilterResourceGroup { get; set; }
        public string[] FilterOsType { get; set; }
    }
}
