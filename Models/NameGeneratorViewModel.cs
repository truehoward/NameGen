﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGen.Models
{
    public class NameGeneratorViewModel
    {
        public string InputText { get; set; }
        public string Name { get; set; }
        public string[] AllFirstNames { get; set; }
        public string[] FemaleFirstNames { get; set; }
        public string[] MaleFirstNames { get; set; }
    }
}