using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Patient
    {
        [Key]
        [Range(5,5)]
        public int CodePatient { get; set; }
        public string EmailPatient { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Informations supplémentaires")]
        public string Informations {  get; set; }
        public string NomComplet {  get; set; }
        public string NumeroTel {  get; set; }
        public ICollection<Bilan> BilanList { get; set; }



    }
}
