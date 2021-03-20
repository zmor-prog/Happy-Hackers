using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHackers_DRRIC.Models
{
    public class PostingLicensee
    {
        [Key]
        public string LicenseeID { get; set; }

        public string LicenseeName { get; set; }
    }
}
