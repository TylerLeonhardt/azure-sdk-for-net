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
using Hyak.Common;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// Value object for saved search results.
    /// </summary>
    public partial class SavedSearchProperties
    {
        private string _category;
        
        /// <summary>
        /// Optional. Gets or sets the category.
        /// </summary>
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Gets or sets the display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _query;
        
        /// <summary>
        /// Optional. Gets or sets the query.
        /// </summary>
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }
        
        private IList<Tag> _tags;
        
        /// <summary>
        /// Optional. Gets or sets the tags attached to the saved search.
        /// </summary>
        public IList<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }
        
        private long? _version;
        
        /// <summary>
        /// Optional. Gets or sets the version number.
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SavedSearchProperties class.
        /// </summary>
        public SavedSearchProperties()
        {
            this.Tags = new LazyList<Tag>();
        }
    }
}