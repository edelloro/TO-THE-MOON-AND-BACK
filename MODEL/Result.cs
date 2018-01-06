using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// 1,737km Moon Radius

namespace MoonAndBackCalculatorApplication.Model
{
    // RESULT OBJECT FOR SENDING BACK
    public class CalculatorResult
    {
        double _pi_constant  = 0d;
        double _time_elapsed = 0d;
        double _moon_Radius  = 1737.0d;
        double _moon_Volume  = 0d;

        public double PI
        {
            get { return _pi_constant; }
            set { _pi_constant = value; }
        }

        public double CalculationTime
        {
            get { return _time_elapsed; }
            set { _time_elapsed = value; }
        }

        public double MoonRadius
        {
            get { return _moon_Radius; }
            set { _moon_Radius = value; }
        }

        //Cubic Kilometers
        public double MoonVolume
        {
             get {
                 _moon_Volume =  (4.0d / 3.0d ) * _pi_constant * 
                                 Math.Pow(_moon_Radius,3) ;
                 return _moon_Volume;
                 }

             set { 
                 _moon_Volume = value; 
                 }
        }

      
        public CalculatorResult() { }

        public CalculatorResult(double pi , double elapsed_time  )
        {

            _pi_constant  = pi;
            _time_elapsed = elapsed_time;
          
        }    
    }
}



