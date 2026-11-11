using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReforestacionSierras.BA
{
    public class Arbol
    {
        public int Id { get; set; }
        public string Especie { get; set; }
        public string Zona { get; set; }
        public string Fecha { get; set; }

        public void Agregar (string aEspecie,
                             string aZona,
                             string aFecha)
        {
            Especie = aEspecie;
            Zona = aZona;
            Fecha = aFecha;
        }
    }
}
