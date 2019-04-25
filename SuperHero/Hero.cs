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
    }
}