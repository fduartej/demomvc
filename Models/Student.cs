using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter last name")]
		[StringLength(40)]
        public string Name { get; set; }
    }

}