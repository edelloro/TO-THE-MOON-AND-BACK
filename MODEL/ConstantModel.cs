using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Configuration;
using MoonAndBackCalculatorApplication.Model;


namespace MoonAndBackCalculatorApplication.ConstantEngine
{
  
    public class ConstantModel
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
            switch (enginetype)
            {

                case PI_ENGINE_TYPE.NilakanthaEngine:
                    constantEngine = new NilakanthaEngine();
                    break;

                case PI_ENGINE_TYPE.ArcTangentEngine:
                    constantEngine = new ArcTangentEngine();
                    break;

                case PI_ENGINE_TYPE.DotNetEngine:
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

                case PI_ENGINE_TYPE.Triangle2DEngine:
                    constantEngine = new TriangleEngine2D();
                    break;

                case PI_ENGINE_TYPE.Triangle3DEngine:
                    constantEngine = new TriangleEngine3D();
                    break;

                default:
                    constantEngine = new DotNetEngine();
                    break;
            }
            return constantEngine;
        }
    }

}
