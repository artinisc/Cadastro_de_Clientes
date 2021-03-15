using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProjetoTeste.model;

namespace ProjetoTeste.Model
{
    public class Endereco
    {
        [Key]
        public int id { get; set; }
        public string Descricao { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

    }
}
