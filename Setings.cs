using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_polish_notation
{
    abstract class Setings
    {
        protected List <string> _Symbol = new List <string> { "*", "/", "+", "-", "." };
        private double _Number1;
        private double _Number2;
        protected List<string> _Sample = new List<string>();
        private double _Total;
        private int _SampleCount;

        private void CopySample(string string_sample)
        {

            for (var i = 0; i < string_sample.Length; i++)
            {
                _Sample.Add(Convert.ToString(string_sample[i]));
            }

        }

        protected string FindNumbers(string string_sample)
        {
            CopySample(string_sample);

            int j = 0;
            _SampleCount = _Sample.Count;

            for (var i = 0; i < _SampleCount; i++)
            {

                if (_Symbol.Contains(_Sample[i]))
                {

                    j = i;
                    j--;
                    _Number2 = Convert.ToDouble(_Sample[j]);
                    j--;
                    _Number1= Convert.ToDouble(_Sample[j]);
                    Calculate(_Sample[i]);
                    i = j;
                    _Sample.Insert(j, Convert.ToString(_Total));
                    j++;
                    _Sample.RemoveRange(j, 3);
                    _SampleCount = _Sample.Count;

                }

            }
            return _Sample[0];
          
        }

        private void Calculate(string symbol)
        {

            switch (symbol)
            {
                case "+":
                    {
                        _Total = _Number1 + _Number2;
                        break;
                    }

                case "-":
                    {
                        _Total = _Number1 - _Number2;
                        break;
                    }

                case "*":
                    {
                        _Total = _Number1 * _Number2;
                        break;
                    }

                case "/":
                    {
                        _Total = _Number1 / _Number2;
                        break;
                    }

            }

        }
    }
}
