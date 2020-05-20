using System;
using System.ComponentModel.DataAnnotations;

namespace NCapasDDD.Aplicacion.Core
{
    public class CasaDTO
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
