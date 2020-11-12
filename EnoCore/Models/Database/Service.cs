﻿namespace EnoCore.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Service
    {
        public Service(
            long id,
            string name,
            long flagsPerRound,
            long noisesPerRound,
            long havocsPerRound,
            long flagStores,
            bool active)
        {
            this.Id = id;
            this.Name = name;
            this.FlagsPerRound = flagsPerRound;
            this.NoisesPerRound = noisesPerRound;
            this.HavocsPerRound = havocsPerRound;
            this.FlagStores = flagStores;
            this.Active = active;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long FlagsPerRound { get; set; }
        public long NoisesPerRound { get; set; }
        public long HavocsPerRound { get; set; }
        public long FlagStores { get; set; }
        public bool Active { get; set; }
    }
}
