﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Entidades;
using GameStore.RepositoriosBD;

namespace GameStore.Servicios.Implementaciones
{
    public class ServicioMarca : Servicio<Marca> , IServicioMarca
    {
        private IRepositorioMarca _repositorioMarca;

        public ServicioMarca(IRepositorioMarca repositorioMarca) : base (repositorioMarca)
        {
            _repositorioMarca = repositorioMarca;
        }

        public List<Marca> ListarMarcas()
        {
            return _repositorioMarca.GetTodos().ToList();
        }
    }
}
