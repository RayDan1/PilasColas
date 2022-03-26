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

        private bool validaLleno()
        {
            return (tope > max);
        }

    }
}
