using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHackers_DRRIC.Models
{
    public class BadReports
    {

     [Key]
     public string uid { get; set; }

     [Required(ErrorMessage = "Please enter wallet address")]
     public string CoinAddress { get; set; }

     public string Hash { get; set; }

    // Make required: Name, DOB, and Address 

     public string FirstName { get; set; }

     public string LastName { get; set; }

     public string DOB { get; set; }

     public string IPAddress { get; set; }

     public string CurrencyID { get; set; }
     public Cryptocurrency Cryptocurrency { get; set; }

     public string CategoryID { get; set; }
     public Category Category { get; set; }

     [Required(ErrorMessage = "Please enter posting licensee")]
     public string LicenseeID { get; set; }
     public PostingLicensee PostingLicensee { get; set; }

    }
}
