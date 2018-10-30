using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using modulo2.Models;
using modulo2.ViewModels;

namespace modulo2.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Detalhe()
        {
            Cliente cliente = new Cliente(){
                id =1,
                nome ="jefferson",
                email = "jeffersonvital20@gmail.com"
            };
            var pedidos = new List<Pedido>{
                new Pedido{ Descricao = "Pedido 1"},
                new Pedido{ Descricao = "Pedido 2"}
            };
            var viewModel = new ClientesPedidosViewModel
            {
                Cliente = cliente,
                Pedidos = pedidos
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Index(Cliente cliente){
            return View();
        }

    }
}