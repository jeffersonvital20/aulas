using System;
using System.Collections.Generic;
using modulo2.Models;

namespace modulo2.ViewModels {
    public class ClientesPedidosViewModel {
        public Cliente Cliente { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}