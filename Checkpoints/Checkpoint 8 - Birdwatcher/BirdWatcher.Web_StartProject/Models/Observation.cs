﻿using System;

namespace BirdWatcher.Web.Models
{
    public class Observation
    {
        public int Id { get; set; }
        public string  Specie { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public string Note { get; set; }

    }
}
