using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsApp.Dto.DtoResponse
{
    //RE = response
    public class ContractDtoRE
    {
        public int Id { get; set; }
        public string CourseCode { get; set; } = null!;
        public DateTime FechaAlta { get; set; }
        public int CantidadEgresados { get; set; }        
        public DateOnly FechaEntrega { get; set; }
        public string ColegioNivel { get; set; } = null!;
        public string ColegioNombre { get; set; } = null!;
        public string ColegioCurso { get; set; } = null!;
        public string ColegioLocalidad { get; set; } = null!;
        public decimal Total { get; set; }

        public virtual ICollection<ItemDtoRE> Items { get; set; } = new List<ItemDtoRE>();
    }
}
