using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;

//   Bulk parameters

//                                     Moon         Earth      Ratio (Moon/Earth)
//   Mass (1024 kg)                    0.07346       5.9724     0.0123    
//   Volume (1010 km3)                 2.1958      108.321      0.0203
//   Equatorial radius (km)	           1738.1        6378.1    0.2725      
//   Polar radius (km)                 1736.0        6356.8    0.2731
//   Volumetric mean radius (km)       1737.1        6371.0    0.2727
//   Ellipticity (Flattening)          0.0012        0.00335    0.36    
//   Mean density (kg/m3)              3344          5514      0.606      
//   Surface gravity (m/s2)            1.62          9.80       0.165    
//   Surface acceleration (m/s2)       1.62          9.78       0.166    
//   Escape velocity (km/s)            2.38          11.2        0.213    
//   GM (x 106 km3/s2)                 0.00490       0.39860    0.0123 
//   Bond albedo                       0.11          0.306      0.360
//   Visual geometric albedo           0.12          0.367      0.330    
//   Visual magnitude V(1,0)          +0.21         -3.86          -
//   Solar irradiance (W/m2)            1361.0        1361.0    1.000      
//   Black-body temperature (K)          270.4         254.0    1.065      
//   Topographic range (km)               20            20      1.000      
//   Moment of inertia (I/MR2)         0.394         0.3308     1.191
//   J2 (x 10-6)                     202.7        1082.63        0.187  


namespace MoonAndBackCalculatorApplication.Engine
{

    public enum PI_ENGINE_TYPE
    {
         ArcTangentEngine,
         DotNetEngine,  
         EgyptianPyramidEngine,
         GregoryLeibnizEngine,
         MonteCarlo2DEngine,
         MonteCarlo3DEngine
    }

    // STRATEGY DESIGN PATTERN PYTHAGORUS CALCULATION
    public interface IconstantEngine
    {
        CalculatorResultModel Calculate();
        CalculatorResultModel Calculate(Int64 precision);
    }

    public class DotNetEngine : IconstantEngine
    {
        public CalculatorResultModel Calculate()
        {
            Stopwatch watch = Stopwatch.StartNew();
            double rcode = System.Math.PI;
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(rcode, rtime);
        }

        //THE ITERATION FIELD IS IGNORED
        public CalculatorResultModel Calculate(Int64 precision)
        {
            return this.Calculate();
        }
    }

    public class EgyptianPyramidEngine : IconstantEngine
    {
        // PI CAN BE REPRESENTED AS THE FOLLOWING FRACTIONS
        // (22/7) (333/106) (355/113) (52163/16604) (103993/33102) (245850922/78256779)
        // PYRAMID ENGINEERS DOING MANUAL CALCULATIONS SOMETIMES USED THESE FRACTIONS

        
        public CalculatorResultModel Calculate()
        {
            Stopwatch watch = Stopwatch.StartNew();
            double rcode = 245850922.0d / 78256779.0d;
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(rcode, rtime);
        }
        //THE ITERATION FIELD IS IGNORED
        public CalculatorResultModel Calculate(Int64 precision)
        {
            return this.Calculate();
        }
    }

    public class GregoryLeibnizEngine : IconstantEngine
    {
        // INFINITE SERIES
        // PI = 4/1 - 4/3 + 4/5 - 4/7 + 4/9 - 4/11 + 4/13 + ...

        enum PIOPERATOR { PLUS, MINUS };


        //THE ITERATION FIELD SET TO 100 MILLION BY DEFAULT
        public CalculatorResultModel Calculate()
        {
            return this.Calculate(100 * 1000000);
        }
       
        public CalculatorResultModel Calculate(Int64 precision)
        {
            Stopwatch watch = Stopwatch.StartNew();

            //FIRST APPROXIMATION OF PI IS 4
            double pi_approx = 4.0;

            PIOPERATOR OP = PIOPERATOR.MINUS;

            // PRECISION CALCULATIONS
            for (double i = 3; i < precision; i += 2)
            {
                if (OP == PIOPERATOR.MINUS)
                {
                    OP = PIOPERATOR.PLUS;
                    pi_approx = pi_approx - (4.0d / i);
                }
                else
                {
                    OP = PIOPERATOR.MINUS;
                    pi_approx = pi_approx + (4.0d / i);
                }
            } //FOR LOOP
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(pi_approx, rtime);
        }
    }

    public class ArcTangentEngine : IconstantEngine
    {
        // ARCTANGENT ENGINE
        // .
        // . .
        // .   .
        // .     .
        // .       .
        // .         .
        // .           .
        // .             .
        // .               .
        // . . . . . . . . . .
        //
        // You have a right angled triangle. 
        // What do the two non 90 degree angles add up to? 
        // 90 degrees. 90 degrees obviously = pi/2 radians. 
        // Arctan(x) finds one of the angles, 
        // Arctan(1/x) finds the other. 
        //
        // Reference 
        // https://www.physicsforums.com/threads/most-elegant-proof-of-arctan-x-arctan-1-x.143695/
        // Look at the 3-4-5 right triangle. The two acute angles add to pi/2, i.e. to 90 degrees. One of the acute angles is arctan(3/4). The other acute angle is arctan(4/3). Done. 
        // PI = 4 ARTAN (1)

        public CalculatorResultModel Calculate()
        {
            Stopwatch watch = Stopwatch.StartNew();
            double rcode = 4.0 * System.Math.Atan( 1 ) ;
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(rcode, rtime);
        }
        //THE ITERATION FIELD IS IGNORED
        public CalculatorResultModel Calculate(Int64 precision)
        {
            return this.Calculate();
        }

    }

    public class MonteCarloEngine : IconstantEngine
    {
        // THE MONTE CARLO METHOD USES A GAMBLER ENGINE AND RANDOMLY PUTS POINTS
        // INSIDE A SQUARE WITH THE LARGEST CIRCLE POSSIBLE INSIDE IT AS A MODEL
           
        // INSTEAD WE WILL USE A SIEVE OF POINTS AND COUNT THOSE INSIDE AND OUTSIDE THE CIRCLE
           
        // ENCLOSE A CIRCLE INSIDE A SQUARE WE WILL CHECK IF A SIEVE OF POINTS
        // IS EITHER INSIDE THE CIRCLE OR OUTSIDE THE CIRCLE THEN CALCULATE PI
        // FROM THE RATIO (THIS COULD BE DONE WITH RANDOM X AND Y AS WELL) 

        // CIRCLE OF RADIUS R INSIDE A SQUARE OF LENGTH 2 R

        // CIRCLE AREA = PI * R^2
        // SQUARE AREA = R^2 + R^2 + R^2 + R^2 = 4 * R^2
        // THEREFORE:
        // CIRCLE AREA / SQUARE AREA = PI / 4
        // THEREFORE:
        // PI = RATIO * 4

        // PI IS 4 TIMES THE RATIO OF THE AREA INSIDE OUTSIDE THE CIRCLE TO TOTAL AREA
        // OF A SQUARE WITH THE LARGEST CIRCLE IT CAN CONTAIN


        // THE ITERATION FIELD IS RELEVANT
        public CalculatorResultModel Calculate(Int64 precision)
        {
            Stopwatch watch = Stopwatch.StartNew();
            double pi_approx = 0d;
            double radius = precision;

            Int64 inside = 0;
            Int64 outside = 0;

            MonteCarloCalculate_Worker work = new MonteCarloCalculate_Worker(radius);

            inside = work.inside;
            outside = work.outside;

            double ratioInOut = ((double)inside / (double)(outside + inside));

            pi_approx = 4.0d * (ratioInOut);
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(pi_approx, rtime);
        }

        public CalculatorResultModel Calculate() {
            return this.Calculate(1000);  // X * Y  == 1000 * 1000 == O(n)^2
         }
   
          class MonteCarloCalculate_Worker
    {
        private Int64 _inside;
        private Int64 _outside;

        public Int64 inside { get { return _inside; } }
        public Int64 outside { get { return _outside; } }

        //CONSTRUCTOR


        //CACHE RADIUS, INSIDE      , OUTSIDE    , COMPLETED_CALC , CALC_DURATION 
        //   10000.0d , 314159017   , 85840983   ,
        //  100000.0d , 31415925413 , 8584074587
              
        public MonteCarloCalculate_Worker(double radius)
        {
            //---------------------------------------
            //HARD CODED CACHING DETERMINISTIC RESULT
            //SHOULD BE STORED IN SOME FORM OF REPOSITORY       
            //---------------------------------------
            
            if (radius == 10000.0d)
            {
                _inside = 314159017;
                _outside = 85840983;
                return;
            }

            if (radius == 100000.0d)
            {
                _inside = 31415925413;
                _outside = 8584074587;
                return;
            }

            //---------------------------------------

            double radiusTimesTwo = radius * 2;

            for (int x = 0; x < radiusTimesTwo; x++)
            {
                for (int y = 0; y < radiusTimesTwo; y++)
                {

                    //%ToDo
                    //OPTIMIZE:
                    //X^2 Y^2 IS POSITIVE ABS NOT REQUIRED
                    
                    if (Math.Sqrt(
                        (Math.Pow(Math.Abs(radius - x), 2) +
                         Math.Pow(Math.Abs(radius - y), 2)
                         ))
                         < radius)
                    { _inside++; }
                    else
                    { _outside++; }
                }
            }
        }
    }
    }







    public class MonteCarloCubicEngine : IconstantEngine
    {
        // THIS IS AN EXTENSION OF THE PREVIOUS MONTE CARLO ENGINE
        // INSTEAD OF USING A 2D MODEL WE WILL USE A 3D MODEL
        // OF A SPHERE RADIUS R INSIDE A CUBE OR LENGTH 2R

        // WE WILL USE A SIEVE OF POINTS AGAIN AND COUNT THOSE INSIDE AND OUTSIDE THE SPHERE

        // ENCLOSE A SPHERE INSIDE A CUBE WE WILL CHECK IF A SIEVE OF POINTS
        // IS EITHER INSIDE THE SPHERE OR OUTSIDE THE SPHERE THEN CALCULATE PI
        // FROM THE RATIO (THIS COULD BE DONE WITH RANDOM X Y AND Z AS WELL) 

        // SPHERE OF RADIUS R INSIDE A CUBE OF SIDE LENGTH 2 R

        // SPHERE VOLUME = (4/3) * PI  R^3   = (4/3) PI R^3
        // CUBE VOLUME   = 4 * R^2 * 2R      =    8     R^3
        // THEREFORE:
        // SPHERE VOLUME / CUBE VOLUME = PI / 6
        // THEREFORE:
        // PI = RATIO * 6

        // PI IS 6 TIMES THE RATIO OF THE VOLUME INSIDE OUTSIDE THE SPHERE 
        // TO TOTAL VOLUME OF A CUBE WITH THE LARGEST SPHERE IT CAN CONTAIN

        // THE ITERATION FIELD IS RELEVANT
        public CalculatorResultModel Calculate(Int64 precision)
        {
            Stopwatch watch = Stopwatch.StartNew();
            double pi_approx = 0d;
            double radius = precision;

            Int64 inside = 0;
            Int64 outside = 0;

            MonteCarloCubicCalculate_Worker work = new MonteCarloCubicCalculate_Worker(radius);

            inside = work.inside;
            outside = work.outside;

            double ratioInOut = ((double)inside / (double)(outside + inside));

            pi_approx = 6.0d * (ratioInOut);
            watch.Stop();
            double rtime = watch.ElapsedMilliseconds;
            return new CalculatorResultModel(pi_approx, rtime);
        }

        //BECAUSE 3D CALCULATIONS ITERATIONS MUST BE SMALLER
        public CalculatorResultModel Calculate()
        {
            return this.Calculate(100);  // X * Y * Z == 100 * 100 * 100 == O(n)^3
        }

        class MonteCarloCubicCalculate_Worker
        {
            private Int64 _inside;
            private Int64 _outside;

            public Int64 inside { get { return _inside; } }
            public Int64 outside { get { return _outside; } }

            //CONSTRUCTOR

            public MonteCarloCubicCalculate_Worker(double radius)
            {
               
                double radiusTimesTwo = radius * 2;

                for (int x = 0; x < radiusTimesTwo; x++)
                {
                    for (int y = 0; y < radiusTimesTwo; y++)
                    {
                        for (int z = 0; z < radiusTimesTwo; z++)
                        {

                            //%ToDo
                            //OPTIMIZE:
                            //X^2 Y^2 Z^2  IS POSITIVE ABS NOT REQUIRED

                            if (Math.Sqrt(
                                (Math.Pow(Math.Abs(radius - x), 2) +
                                 Math.Pow(Math.Abs(radius - y), 2) + 
                                 Math.Pow(Math.Abs(radius - z), 2)
                                 ))
                                 < radius)
                            { _inside++; }
                            else
                            { _outside++; }
                        }
                    }
                }
            }
        }
    }







    public class constantModel
    {
        // THE REQUESTOR OF THE ENGINE USED DETERMINES THE ALGORITHM 
        // USED STRATEGY DESIGN PATTERN

        public IconstantEngine GetconstantEngine()
        {
            IconstantEngine constantEngine = null;
            constantEngine = new DotNetEngine();
            return constantEngine;
        }
        
         public IconstantEngine GetconstantEngine(PI_ENGINE_TYPE enginetype)
        {
            IconstantEngine constantEngine = null;
            switch (enginetype) {
 
                case PI_ENGINE_TYPE.ArcTangentEngine :
                    constantEngine = new ArcTangentEngine();
                    break;

                case PI_ENGINE_TYPE.DotNetEngine : 
                    constantEngine = new DotNetEngine();
                    break;

                 case PI_ENGINE_TYPE.EgyptianPyramidEngine:
                    constantEngine = new EgyptianPyramidEngine();
                    break;

                case PI_ENGINE_TYPE.GregoryLeibnizEngine: 
                    constantEngine = new GregoryLeibnizEngine();
                    break;

                case PI_ENGINE_TYPE.MonteCarlo2DEngine:
                    constantEngine = new MonteCarloEngine();
                    break;

                case PI_ENGINE_TYPE.MonteCarlo3DEngine:
                    constantEngine = new MonteCarloCubicEngine();
                    break;
           
                default:
                    constantEngine = new DotNetEngine();
                    break;
            }
            return constantEngine;
        }
    }
}

