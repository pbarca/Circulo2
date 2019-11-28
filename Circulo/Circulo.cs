using System;

namespace Circulo
{
    class Circulo
    {
        private double _R;
        public double Raio { set => _R = value; get => _R; }
        public double Diametro => _R * 2;
        public double Area => Math.PI * _R * _R;
        public double Perimetro => 2 * Math.PI * _R;
    }
}
