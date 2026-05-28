using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaTek86.Models
{
    public class Absence
    {
        public int IdAbsence { get; set; }
        public int IdPersonnel { get; set; }
        public int IdMotif { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
    }
}