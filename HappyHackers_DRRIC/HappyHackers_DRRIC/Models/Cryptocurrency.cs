using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHackers_DRRIC.Models
{
    public class Cryptocurrency
    {
        [Key]
        public string CurrencyID { get; set; }

        public string Code { get; set; }
    }
}
