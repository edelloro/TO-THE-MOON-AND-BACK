using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoonAndBackCalculatorApplication.Model;


namespace MoonAndBackCalculatorApplication.CalculatorEngine
{

    class CalculationEngine
    {

        // STRATEGY DESIGN PATTERN MOON VOLUME CALCULATION
        public interface IconstantEngine
        {
            string InputJson();
            double Calculate();
        }
    }
}
