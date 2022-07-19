﻿namespace NZWalks.Modules.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public long population { get; set; }

        //navigation property
        public IEnumerable<walk> Walks{ get; set; }


    }
}
