﻿using EnoCore.Models.Database;
using EnoCore.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace EnoCore.Models.Json
{
    public class JsonConfiguration
    {
#pragma warning disable CS8618
        public string Title { get; set; }
        public long FlagValidityInRounds { get; set; }
        public int CheckedRoundsPerRound { get; set; }
        public int RoundLengthInSeconds { get; set; }
        public string DnsSuffix { get; set; }
        public int TeamSubnetBytesLength { get; set; }
        public string FlagSigningKey { get; set; }
        public string NoiseSigningKey { get; set; }
        [JsonPropertyName("Encoding")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FlagEncoding Encoding { get; set; }
        public List<JsonConfigurationTeam> Teams { get; set; } = new List<JsonConfigurationTeam>();
        public List<JsonConfigurationService> Services { get; set; } = new List<JsonConfigurationService>();
        public Dictionary<long, string[]> Checkers = new Dictionary<long, string[]>();
#pragma warning restore CS8618

        public void BuildCheckersDict()
        {
            foreach (var service in Services)
            {
                Checkers.Add(service.Id, service.Checkers);
            }
        }
    }
}
