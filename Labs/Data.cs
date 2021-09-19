using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Data
    {
        private double mass;
        private double density;
        private double radius;
        public double Mass
        {
            get 
            {
                return mass;
            }
            set
            {
                if (value > 10000)
                {
                    throw new ExtremelyHighValueExeption("Значение превышает допустимое.");
                }
                else if (value <= 0)
                {
                    throw new ExtremelyLowValueExeption("Значение ниже минимально допустимого.");
                }
                else mass = value;
            }
        }
        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                if (value > 10000)
                {
                    throw new ExtremelyHighValueExeption("Значение превышает допустимое");
                }
                else if (value <= 0)
                {
                    throw new ExtremelyLowValueExeption("Значение ниже минимально допустимого");
                }
                else density = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 10000)
                {
                    throw new ExtremelyHighValueExeption("Значение превышает допустимое");
                }
                else if (value <= 0)
                {
                    throw new ExtremelyLowValueExeption("Значение ниже минимально допустимого");
                }
                else radius = value;
            }
        }
    }
}
