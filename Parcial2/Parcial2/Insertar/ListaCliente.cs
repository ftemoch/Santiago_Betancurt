using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Parcial2.Models;

namespace Parcial2.Insertar
{
    public class ListaCliente
    {
        public Cliente Clientes()
        {
            return new Cliente()
            {
                Lista = "Lista de clientes",
                Nombre = "Santiago",
                Apellido = "Bentancurt",
                Sueldo = 200000,
            };
        }
    }
}