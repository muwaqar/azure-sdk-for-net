// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// The response model for the list of devices.
    /// </summary>
    public partial class DeviceListResponse : AzureOperationResponse, IEnumerable<DeviceInfo>
    {
        private IList<DeviceInfo> _devices;
        
        /// <summary>
        /// Optional. The collection of Device Infos
        /// </summary>
        public IList<DeviceInfo> Devices
        {
            get { return this._devices; }
            set { this._devices = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeviceListResponse class.
        /// </summary>
        public DeviceListResponse()
        {
            this.Devices = new List<DeviceInfo>();
        }
        
        /// <summary>
        /// Gets the sequence of Devices.
        /// </summary>
        public IEnumerator<DeviceInfo> GetEnumerator()
        {
            return this.Devices.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Devices.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}