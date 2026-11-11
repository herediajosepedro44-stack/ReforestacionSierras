using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReforestacionSierras.BA
{
    public class Arboles
    {
        public DataTable ListaDT { get; set; } = new DataTable();

        public Arboles() 
        {
            ListaDT.TableName = "ListaArboles";
            ListaDT.Columns.Add("Id", typeof(int));
            ListaDT.Columns.Add("Especie");
            ListaDT.Columns.Add("Zona");
            ListaDT.Columns.Add("Fecha");
            LeerArchivo();
        }

        public void LeerArchivo() 
        {
            if(System.IO.File.Exists("Arboles.xml")) 
            {
                ListaDT.ReadXml("Arboles.xml");
            }
        }

        public void InsertArbol(Arbol aArbol) 
        {
            int id = NuevoId();

            ListaDT.Rows.Add();
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Id"]=id;
            ListaDT.Rows[NuevoRenglon]["Especie"] = aArbol.Especie;
            ListaDT.Rows[NuevoRenglon]["Zona"] = aArbol.Zona;
            ListaDT.Rows[NuevoRenglon]["Fecha"] = aArbol.Fecha;

            ListaDT.WriteXml("Arboles.xml");
        }

        private int NuevoId() 
        {
            int NuevoId = 0;

            foreach (DataRow fila in ListaDT.Rows) 
            { 
                if (NuevoId < Convert.ToInt32(fila["Id"])) 
                { 
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }
            NuevoId ++;
            return NuevoId;
        }

        public Arbol Buscar(string aId) 
        {
            int id = Convert.ToInt32(aId);

            Arbol arb = new Arbol();

            foreach (DataRow fila in ListaDT.Rows) 
            { 
                if (Convert.ToInt32(fila["Id"]) == id) 
                {
                    arb.Id = Convert.ToInt32(fila["Id"]);
                    arb.Especie = Convert.ToString(fila["Especie"]);
                    arb.Zona = Convert.ToString(fila["Zona"]);
                    arb.Fecha = Convert.ToString(fila["Fecha"]);
                    break;
                }
            }

            return arb;
        }
    }
}
