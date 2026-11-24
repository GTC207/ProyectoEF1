using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace ProyectEF1
{
    public class gestortramites
    {
            public tramites[] Tramites = new tramites[50];
            public int cantidad = 0;
            ArchivoTramites Archivo = new ArchivoTramites();

            public void GuardarTexto(string ruta)
            {
                Archivo.GuardarTexto(ruta, Tramites, cantidad);
            }

            public void LeerTexto(string ruta)
            {
                cantidad = Archivo.LeerTexto(ruta, Tramites);
            }

            public void GuardarBinario(string ruta)
            {
                Archivo.GuardarBinario(ruta, Tramites);
            }

            public void LeerBinario(string ruta)
            {
                Tramites = Archivo.LeerBinario(ruta);
                cantidad = 0;
                for (int i = 0; i < Tramites.Length; i++)
                {
                    if (Tramites[i] != null)
                    {
                        cantidad++;
                    }
                }
            }

        public void GuardarTodo()
        {
            GuardarTexto("tramites.txt");
            GuardarBinario("tramites.bin");
        }
        public string Formateo(string nl)
        {
            int espacio = nl.IndexOf(' ');
            string n_l = nl.Substring(0, espacio);
            string n_l2 = nl.Substring(espacio + 1);

            n_l = char.ToUpper(n_l[0]) + n_l.Substring(1);
            n_l2 = char.ToUpper(n_l2[0]) + n_l2.Substring(1);

            return n_l + " " + n_l2;
        }

        public bool Agregar(tramites t)
        {
            if(cantidad >= Tramites.Length)
            {
                return false;
            }
            Tramites[cantidad] = t;
            cantidad++;
            return true;
        }

        public int BuscarIndice(string codigo)
        {
            for(int i = 0; i< cantidad; i++)
            {
                if (Tramites[i].CodigoAlumno == codigo.ToUpper())
                {
                    return i;
                }
            }
            return -1;
        }


        public void Eliminar(int indice)
        {
            for(int i = indice; i < cantidad - 1; i++)
            {
                Tramites[i] = Tramites[i + 1];
            }
            Tramites[cantidad - 1] = null;
            cantidad--;
        }


        public void OrdenamientoBurbuja()
        {
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (Tramites[j].Notas > Tramites[j + 1].Notas)
                    {
                        tramites aux = Tramites[j];
                        Tramites[j] = Tramites[j + 1];
                        Tramites[j + 1] = aux;

                    }
                }
            }
           
        }

        public void OrdenamientoSeleccion()
        {
            for (int i = 0; i < cantidad - 1; i++)
            {
                int mayor = i;

                for (int j = i + 1; j < cantidad; j++)
                {
                    if (Tramites[j].Notas > Tramites[mayor].Notas)
                    {
                        mayor = j;
                    }
                }
                tramites aux = Tramites[i];
                Tramites[i] = Tramites[mayor];
                Tramites[mayor] = aux;

                
            }
        }

    }
}