using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace componentesBA
{
    public class componentes
    {
        public DataTable lista { get; set; }
        public static int ultimoid { get; set; } = 0;
        public componentes()
        {
            lista = new DataTable();
            lista.TableName = "componentes";
            lista.Columns.Add("id");
            lista.Columns.Add("nombre");
            lista.Columns.Add("capacidad");
            lista.Columns.Add("tipo");
            lista.Columns.Add("velocidad");

           
            
            Leerarchivo();
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                if (Convert.ToInt32(lista.Rows[i][0]) > ultimoid)
                {
                    ultimoid = Convert.ToInt32(lista.Rows[i][0]);
                }

            }
        }

        private void Leerarchivo()
        {

            if (System.IO.File.Exists("componentes.xml"))
            {
                lista.ReadXml("componentes.xml");
            }
        }
        public void insert(componente componente)
        {

            lista.Rows.Add();
            ultimoid++;
            int nuevorenglon = lista.Rows.Count - 1;
            lista.Rows[nuevorenglon]["id"] = ultimoid;
            lista.Rows[nuevorenglon]["nombre"] = componente.Nombre;
            lista.Rows[nuevorenglon]["capacidad"] = componente.Capacidad;
            lista.Rows[nuevorenglon]["tipo"] = componente.Tipo;
            lista.Rows[nuevorenglon]["velocidad"] = componente.Velocidad;

            lista.WriteXml("componentes.xml");
        }
        public void Borrar(int idaeliminar)
        { 
            DataRow[] filas = lista.Select($"id = {idaeliminar}");

            foreach (DataRow fila in filas)
            {
                lista.Rows.Remove(fila);
            }

            lista.WriteXml("componentes.xml");
        }

       public void Update(componente componente) {
            DataRow[] filas = lista.Select($"id = {componente.id}");

            foreach (DataRow fila in filas)
            {
                fila[1] = componente.Nombre;
                fila[2]= componente.Capacidad;
                fila[3]= componente.Tipo;
                fila[4]= componente.Velocidad;
            }

            lista.WriteXml("componentes.xml");
        }
    }
}


