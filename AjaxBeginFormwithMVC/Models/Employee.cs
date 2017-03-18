using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxBeginFormwithMVC.Models
{
   public class Employee
    {

        [Required]
        [Display(Name = "First Name (fail to throw an error)")]
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
        
        public string Comments { get; set; }
    }
}
