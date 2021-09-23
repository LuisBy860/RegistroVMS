using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistroVMS.Models.ViewModels
{
    public class PersonaViewModel
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string N_Educativo { get; set; }
    }
}