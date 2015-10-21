﻿// Seq Client for .NET - Copyright 2014 Continuous IT Pty Ltd
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;

namespace Seq.Client.Slab
{
    class SeqEventPayload
    {
        public uint EventType { get { return 0x000051AB; } }
        public string Level { get; set; }
        public string Timestamp { get; set; }
        public string MessageTemplate { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
}
