using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSimulationApp.DAL.DTOs
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public string Email { get; set; } = null!;
        public IEnumerable<CreditoDTO> Creditos { get; set; }
    }
}
