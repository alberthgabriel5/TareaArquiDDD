using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NCapasDDD.Dominio.Core
{
    public class Casa
    {
        [Required] 
        public int CasaID { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required, StringLength(300)]
        public String Calle { get; set; }
        [Required]
        public int NumeroHabitaciones { get; set; }
        [Required]
        public int NumeroBaños { get; set; }
        [Required]
        public int Pisos { get; set; }
        [Required]
        public decimal MetrosCuadrados { get; set; }
    }
}
