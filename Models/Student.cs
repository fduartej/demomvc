using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demomvc.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Por favor ingrese su nombre")]
		[StringLength(40)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Por favor ingrese su apellido")]
		[StringLength(40)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Por favor ingrese genero")]
        public string Genero { get; set; }
    }

}