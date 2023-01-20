using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra.Entities
{
    public class Cliente
    {
        private Guid _Idcliente;
        private string? _Namecliente;
        private string? _cpf;
        private string? _email;
        private string? _telefone;
        private Pedido? _pedido;

        public Guid Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public string? Namecliente { get => _Namecliente; set => _Namecliente = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Telefone { get => _telefone; set => _telefone = value; }
        public Pedido? Pedido { get => _pedido; set => _pedido = value; }
    }
}
