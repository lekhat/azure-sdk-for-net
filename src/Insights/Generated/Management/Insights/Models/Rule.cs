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
using System.Linq;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// An alert rule.
    /// </summary>
    public partial class Rule
    {
        private RuleAction _action;
        
        /// <summary>
        /// Optional. The action that is performed when the alert rule becomes
        /// active, and when an alert condition is resolved.
        /// </summary>
        public RuleAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }
        
        private RuleCondition _condition;
        
        /// <summary>
        /// Optional. The condition that results in the alert rule being
        /// activated.
        /// </summary>
        public RuleCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Description of the alert rule that will be included in
        /// the alert email.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private bool _isEnabled;
        
        /// <summary>
        /// Optional. Indicates whether the alert rule is enabled.
        /// </summary>
        public bool IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }
        
        private DateTime _lastUpdatedTime;
        
        /// <summary>
        /// Optional. Last time the rule was updated.
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the alert rule.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Rule class.
        /// </summary>
        public Rule()
        {
        }
    }
}
