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
//     Runtime Version:4.0.30319.34014
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
    
    
    public class PSVM
    {
        
        internal Microsoft.Azure.Batch.IVM omObject;
        
        private PSStartTaskInformation startTaskInformation;
        
        private IEnumerable<PSTaskInformation> recentTasks;
        
        private PSStartTask startTask;
        
        private IEnumerable<PSCertificateReference> certificateReferences;
        
        private IEnumerable<PSVMError> vMErrors;
        
        internal PSVM(Microsoft.Azure.Batch.IVM omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public string Name
        {
            get
            {
                return this.omObject.Name;
            }
        }
        
        public string Url
        {
            get
            {
                return this.omObject.Url;
            }
        }
        
        public Microsoft.Azure.Batch.Common.TVMState State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
        
        public System.DateTime? LastBootTime
        {
            get
            {
                return this.omObject.LastBootTime;
            }
        }
        
        public System.DateTime VMAllocationTime
        {
            get
            {
                return this.omObject.VMAllocationTime;
            }
        }
        
        public string IPAddress
        {
            get
            {
                return this.omObject.IPAddress;
            }
        }
        
        public string AffinityId
        {
            get
            {
                return this.omObject.AffinityId;
            }
        }
        
        public string VMSize
        {
            get
            {
                return this.omObject.VMSize;
            }
        }
        
        public System.Int32? TotalTasksRun
        {
            get
            {
                return this.omObject.TotalTasksRun;
            }
        }
        
        public PSStartTaskInformation StartTaskInformation
        {
            get
            {
                if (((this.startTaskInformation == null) 
                            && (this.omObject.StartTaskInformation != null)))
                {
                    this.startTaskInformation = new PSStartTaskInformation(this.omObject.StartTaskInformation);
                }
                return this.startTaskInformation;
            }
        }
        
        public IEnumerable<PSTaskInformation> RecentTasks
        {
            get
            {
                if (((this.recentTasks == null) 
                            && (this.omObject.RecentTasks != null)))
                {
                    List<PSTaskInformation> list;
                    list = new List<PSTaskInformation>();
                    IEnumerator<Microsoft.Azure.Batch.TaskInformation> enumerator;
                    enumerator = this.omObject.RecentTasks.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSTaskInformation(enumerator.Current));
                    }
                    this.recentTasks = list;
                }
                return this.recentTasks;
            }
        }
        
        public PSStartTask StartTask
        {
            get
            {
                if (((this.startTask == null) 
                            && (this.omObject.StartTask != null)))
                {
                    this.startTask = new PSStartTask(this.omObject.StartTask);
                }
                return this.startTask;
            }
        }
        
        public IEnumerable<PSCertificateReference> CertificateReferences
        {
            get
            {
                if (((this.certificateReferences == null) 
                            && (this.omObject.CertificateReferences != null)))
                {
                    List<PSCertificateReference> list;
                    list = new List<PSCertificateReference>();
                    IEnumerator<Microsoft.Azure.Batch.ICertificateReference> enumerator;
                    enumerator = this.omObject.CertificateReferences.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSCertificateReference(enumerator.Current));
                    }
                    this.certificateReferences = list;
                }
                return this.certificateReferences;
            }
        }
        
        public IEnumerable<PSVMError> VMErrors
        {
            get
            {
                if (((this.vMErrors == null) 
                            && (this.omObject.VMErrors != null)))
                {
                    List<PSVMError> list;
                    list = new List<PSVMError>();
                    IEnumerator<Microsoft.Azure.Batch.VMError> enumerator;
                    enumerator = this.omObject.VMErrors.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSVMError(enumerator.Current));
                    }
                    this.vMErrors = list;
                }
                return this.vMErrors;
            }
        }
    }
}
