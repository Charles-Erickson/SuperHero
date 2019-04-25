using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHero
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string HeroName { get; set; }
        public string AlterEgo { get; set; }
        public string SuperPower { get; set; }
        public string SecondaryPower { get; set; }
        public string Catchphrase { get; set; }
    }
}