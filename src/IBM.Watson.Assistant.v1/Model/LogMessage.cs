/**
* Copyright 2018, 2019 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.Cloud.SDK.Core.Model;
using Newtonsoft.Json;

namespace IBM.Watson.Assistant.v1.Model
{
    /// <summary>
    /// Log message details.
    /// </summary>
    public class LogMessage : DynamicModel<object>
    {
        /// <summary>
        /// The severity of the log message.
        /// </summary>
        public class LevelEnumValue
        {
            /// <summary>
            /// Constant INFO for info
            /// </summary>
            public const string INFO = "info";
            /// <summary>
            /// Constant ERROR for error
            /// </summary>
            public const string ERROR = "error";
            /// <summary>
            /// Constant WARN for warn
            /// </summary>
            public const string WARN = "warn";
            
        }

        /// <summary>
        /// The severity of the log message.
        /// Constants for possible values can be found using LogMessage.LevelEnumValue
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }
        /// <summary>
        /// The text of the log message.
        /// </summary>
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Msg { get; set; }
    }

}
