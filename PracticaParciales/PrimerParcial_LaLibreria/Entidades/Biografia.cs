using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        // muy bien interpredado el tema de usar la base en cada constructor, ya que no tengo atributos
        public Biografia(string nombre) : base(nombre)
        {

        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {

        }

        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        {

        }

        protected override bool EsColor // no olvidar el override
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                if(stock > 0)
                {
                    return true;
                }    
                return false;
            }
        }

        public static explicit operator Biografia (string nombre)
        {
            return new Biografia(nombre);
        }



    }
}
