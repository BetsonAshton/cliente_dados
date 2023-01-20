using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compra.Entities
{
    public class Pedido
    {
        private Guid _idPedido;
        private DateTime? dataPedido;
        private decimal? _valorPedido;
        private Cliente? _cliente;
        private Endereco? _endereco;

        public Guid Id { get => _idPedido; set => _idPedido = value; }
        public DateTime? DataPedido { get => dataPedido; set => dataPedido = value; }
        public decimal? ValorPedido { get => _valorPedido; set => _valorPedido = value; }
        public Cliente? Cliente { get => _cliente; set => _cliente = value; }
        public Endereco? Endereco { get => _endereco; set => _endereco = value; }
    }
}
