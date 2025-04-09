using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Analyse
    {
        public int AnalyseId {  get; set; }
        public int DureeResultat { get; set; }
        public double PrixAnalyse {  get; set; }
        public string TypeAnalyse {  get; set; }
        public float ValeurAnalyse {  get; set; }
        public float ValuerMaxNormale {  get; set; }
        public float ValuerMinNormale { get;set; }
        public Bilan Bilan { get; set; }

    }
}
