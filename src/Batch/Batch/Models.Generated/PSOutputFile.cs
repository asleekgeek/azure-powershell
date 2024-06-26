﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSOutputFile
    {
        
        internal Microsoft.Azure.Batch.OutputFile omObject;
        
        private PSOutputFileDestination destination;
        
        private PSOutputFileUploadOptions uploadOptions;
        
        public PSOutputFile(string filePattern, PSOutputFileDestination destination, PSOutputFileUploadOptions uploadOptions)
        {
            this.omObject = new Microsoft.Azure.Batch.OutputFile(filePattern, destination.omObject, uploadOptions.omObject);
        }
        
        internal PSOutputFile(Microsoft.Azure.Batch.OutputFile omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public PSOutputFileDestination Destination
        {
            get
            {
                if (((this.destination == null) 
                            && (this.omObject.Destination != null)))
                {
                    this.destination = new PSOutputFileDestination(this.omObject.Destination);
                }
                return this.destination;
            }
        }
        
        public string FilePattern
        {
            get
            {
                return this.omObject.FilePattern;
            }
        }
        
        public PSOutputFileUploadOptions UploadOptions
        {
            get
            {
                if (((this.uploadOptions == null) 
                            && (this.omObject.UploadOptions != null)))
                {
                    this.uploadOptions = new PSOutputFileUploadOptions(this.omObject.UploadOptions);
                }
                return this.uploadOptions;
            }
        }
    }
}
