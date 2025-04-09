using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{  
    public enum Specialite
    {
        Hematologie,
        Biochimie,
        Autre
    }
    public class Infirimier
    {
        public int InfirimierId { get; set; }
        public string NomComplet {  get; set; }
        public Specialite Specialite { get; set; }

        public ICollection<Bilan> BilanList { get; set; }
        public Laboratoire Laboratoire { get; set; }
        [ForeignKey("Laboratoire")]
        public int LaboratoireId { get; set; }
    }
}
