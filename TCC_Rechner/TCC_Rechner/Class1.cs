using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Rechner
{
    internal class Class1
    {
        private double _Zahl1, _Zahl2;

        public Class1()
        {
            _Zahl1 = 0;
            _Zahl2 = 0;
        }

        public double Zahl1
        {
            set { _Zahl1 = value; }
            get { return _Zahl1; }
        }

        public double Zahl2
        {
            set { _Zahl2 = value; }
            get { return _Zahl2; }
        }

        public double Addieren()
        {
            return _Zahl1 + _Zahl2;
        }

        public double Subtrahieren()
        {
            return _Zahl1 - _Zahl2;
        }

        public double Multiplizieren()
        {
            return _Zahl1 * _Zahl2;
        }

        public double Dividieren()
        {
            return _Zahl1 / _Zahl2;
        }
    }
}