using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sage_HW4.Models
{
    public class Suggestion
    { 
        //get and set variables
        public string Name { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; }

        //Phone Validation
        [Required]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number. Please use the following format: XXX-XXX-XXXX")]
        public string RestPhone { get; set; }
    }
}
