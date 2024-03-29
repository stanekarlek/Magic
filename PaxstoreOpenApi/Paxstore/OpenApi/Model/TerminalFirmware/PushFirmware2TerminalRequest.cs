﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paxstore.OpenApi.Model
{
    public class PushFirmware2TerminalRequest
    {
        [JsonProperty("tid")]
        public string TID { get; set; }

        [JsonProperty("serialNo")]
        public string SerialNo { get; set; }

        [JsonProperty("fmName")]
        public string FirmwareName { get; set; }

        [JsonProperty("wifiOnly")]
        public bool WifiOnly { get; set; }

        [JsonProperty("effectiveTime")]
        public DateTime EffectiveTime { get; set; }

        [JsonProperty("expiredTime")]
        public DateTime ExpiredTime { get; set; }
    }
}
