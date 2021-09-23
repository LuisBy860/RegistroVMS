using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroVMS.Models.ViewModels
{
    public class PersonaViewModel
    {
        [Display (Name = "Nombre")]
        [Required (ErrorMessage = "estos campos son requeridos")]
        public string Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "estos campos son requeridos")]
        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "estos campos son requeridos")]

        public string Sexo { get; set; }

        [Display(Name = "N_Educativo")]
        [Required(ErrorMessage = "estos campos son requeridos")]

        public string N_Educativo { get; set; }
    
    }
}