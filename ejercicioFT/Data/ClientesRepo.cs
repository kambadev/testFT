using ejercicioFT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ejercicioFT.Data
{
    public class ClientesRepo
    {

        private static readonly List<Cliente> _clientes;
        public List<Cliente> ObtenerTodos()
        {

            return _clientes;
        }

        static ClientesRepo()
        {

            _clientes = new List<Cliente>
            {
                new Cliente {
                    Id = 1, Nombre="Cliente Generico"
                },
             };
        }

        public Cliente ObtenerPorId(int clienteId)
        {
            return _clientes.Where(x => x.Id == clienteId).FirstOrDefault();
        }
    }
}