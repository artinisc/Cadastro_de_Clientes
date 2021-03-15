using ProjetoTeste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.model
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public List<UsuarioCliente> UsuariosClientes { get; set; }

    }
}
