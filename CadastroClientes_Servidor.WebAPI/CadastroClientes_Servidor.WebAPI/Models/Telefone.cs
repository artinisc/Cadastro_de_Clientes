using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.model
{
    public class Telefone
    {
        [Key]
        public int id { get; set; }
        public int ddd { get; set; }
        public int numero { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
