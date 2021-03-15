using ProjetoTeste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoTeste.model
{
    public class Usuario
    {
        [Key]       
        public int id { get; set; }
        public string nome { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public List<UsuarioCliente> UsuariosClientes { get; set; }
        public List<Telefone> Telefones { get; set; }


    }
}
