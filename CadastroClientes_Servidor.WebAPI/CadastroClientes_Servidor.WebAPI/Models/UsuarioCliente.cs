using ProjetoTeste.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.Model
{
    public class UsuarioCliente
    {

        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }

    }
}
