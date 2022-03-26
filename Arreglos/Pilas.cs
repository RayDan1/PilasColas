using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{   
    public class Pilas

    {
        private string[] array;
        private int max;
        private int tope;

        public Pilas(int tamaño)
        {
           array = new string[tamaño];
            max = array.Length - 1;
            tope = 0;

        }
        private bool ValidaVacio()
        {
            //if (tope < 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return (tope < 1);
        }

        private bool ValidaLleno()
        {
            return (tope > max);
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo lleno");
            }
            array[tope] = dato;
            tope++;

        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo vacio");
            }

            tope--;
            array[tope] = null;

        }

        public string Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return "Arreglo vacio";
            }
            for( int i = 0; i < tope; i++)
            {
                if (i> 0)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {array[i]}";
            }

            return datos;
        }

    }
}
