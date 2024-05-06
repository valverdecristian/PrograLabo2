using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
            //Recargar();
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta; // 30
        }

        private void SetTinta(short tinta)
        {
            if ((this.tinta - tinta) >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                this.tinta -= tinta; // 30
            }
        }

        public void Recargar()
        {
            tinta = cantidadTintaMaxima;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            if(tinta <= 0)
            {
                dibujo = new string(' ', gasto);
            }
            dibujo = new string('*', gasto);
            
            if (tinta >= gasto)
            {
                SetTinta(gasto); // 50 - 20
                Console.ForegroundColor = color;
                Console.WriteLine(dibujo);
                Console.ResetColor();
                return true;
            }
            return false;

        }
    }
}
