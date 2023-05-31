using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MSAPP.Models
{
    public class Employee
    {
    
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Email { get; set; }
        public Dept? Department { get; set; }
        public string EMPPhoto { get; set; }



    }
}
