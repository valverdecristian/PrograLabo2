using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        
        
        public float GetArea()
        {
            if (area == 0)
            {
                float baseRect = Math.Abs(vertice1.GetX() - vertice2.GetX());
                float alturaRect = Math.Abs(vertice1.GetY() - vertice4.GetY());
                area = baseRect * alturaRect;
            }
            return area;
        }

        public float GetPerimetro()
        {
            if (perimetro == 0)
            {
                float baseRect = Math.Abs(vertice1.GetX() - vertice2.GetX());
                float alturaRect = Math.Abs(vertice1.GetY() - vertice4.GetY());
                perimetro = 2 * (baseRect + alturaRect);
            }
            return perimetro;
        }

        public Rectangulo (Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }
    }

}
