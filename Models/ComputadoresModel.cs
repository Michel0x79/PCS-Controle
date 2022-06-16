using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePCS.Models
{
    internal class ComputadoresModel
    {
        public int Id { get; set; }
        public int Piso { get; set; }
        public string? Local { get; set; }
        public string? Dono { get; set; }
        public string? Hostname{ get; set; }
        public string? IP { get; set; }
        public string? Mac { get; set; }
        public string? SO { get; set; }

    }
}
