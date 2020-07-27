using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari.LogCenter.Business.Models
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public string Login { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return (this.Login == login && this.Senha == senha);
        }
    }
}
