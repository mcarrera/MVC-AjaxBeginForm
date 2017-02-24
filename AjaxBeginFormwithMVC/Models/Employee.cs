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
        [Display(Name = "Name (fail to simulate a server error)")]
        public string Name { get; set; }
    
        public string City { get; set; }
        
        public string Address { get; set; }
    }
}
