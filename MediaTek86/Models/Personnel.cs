using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaTek86.Models
{
    public class Personnel
    {
        public int IdPersonnel { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdMotif { get; set; }
    }
}