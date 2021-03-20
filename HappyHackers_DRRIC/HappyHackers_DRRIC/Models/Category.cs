﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHackers_DRRIC.Models
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }

        public string Crime { get; set; }
    }
}
