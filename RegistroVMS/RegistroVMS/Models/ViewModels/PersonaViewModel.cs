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
        [Required (ErrorMessage = "Este campo es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Este campo es requerido")]

        public string Sexo { get; set; }

        [Display(Name = "N_Educativo")]
        [Required(ErrorMessage = "Este campo es requerido")]

        public string N_Educativo { get; set; }
    
    }
}