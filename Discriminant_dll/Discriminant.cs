using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant_dll
{
    public class Discriminant: IDisposable
    {
        public (double D, double x1, double x2) CalculationDiscriminant(double a, double b, double c)
        {
            var _discriminant = (D:0.0, x1:0.0, x2:0.0);
            _discriminant.D = Math.Pow(b, 2) - 4 * a * c;

            if (_discriminant.D < 0)
            {
                _discriminant.x1 = 0;
                _discriminant.x2 = 0;
            }
            else if (_discriminant.D > 0)
            {
                if (a == 0)
                {
                    _discriminant.x1 = 0;
                    _discriminant.x2 = 0;
                }
                else
                {
                    _discriminant.x1 = -Math.Round((b + Math.Sqrt(_discriminant.D)) / (2 * a), 2);
                    _discriminant.x2 = -Math.Round((b - Math.Sqrt(_discriminant.D)) / (2 * a), 2);
                }
            }
            else 
            {
                if (a == 0)
                {
                    _discriminant.x1 = 0;
                    _discriminant.x2 = 0;
                }
                else
                {
                    _discriminant.x1 = -Math.Round((b + Math.Sqrt(_discriminant.D)) / (2 * a), 2);
                    _discriminant.x2 = 0;
                }
            }
            //var temp = _discriminant.x1.ToString();

            return _discriminant;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
