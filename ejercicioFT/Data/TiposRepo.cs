using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ejercicioFT.Models;

namespace ejercicioFT.Data
{
    public class TiposRepo
    {
        private static readonly List<Tipo> _tipos;
        public List<Tipo> ObtenerTodos()
        {

            return _tipos;
        }

        static TiposRepo()
        {

            _tipos = new List<Tipo>
            {
                new Tipo {
                    Id = 1, Descripcion="Herramientas"                    
                },
                new Tipo {
                    Id = 1, Descripcion="Electricidad"
                },
                new Tipo {                    
                    Id = 1, Descripcion="Construccion"
                },
                new Tipo {
                    Id = 1, Descripcion="Jardineria"
                },
             };
        }

        public Tipo ObtenerPorId(int tipoId)
        {
            return _tipos.Where(x => x.Id == tipoId).FirstOrDefault();
        }
    }
}