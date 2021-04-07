using NBomber.Contracts;
using NBomber.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stresstest
{
    public class BomberLoadSimulation
    {
        public double During { get; protected set; }
        public int Parameter { get; protected set; }
        public LoadSimulationType Type { get; protected set; }
        public BomberLoadSimulation(double during, int parametr, LoadSimulationType type)
        {
            this.During = during;

            this.Parameter = parametr;

            this.Type = type;
        }

        public LoadSimulation GetSimulation()
        {
            switch (Type)
            {
                case LoadSimulationType.RampConstant:
                    return Simulation.RampConstant(copies: Parameter, TimeSpan.FromSeconds(During));

                case LoadSimulationType.KeepConstant:
                    return Simulation.KeepConstant(copies: Parameter, during: TimeSpan.FromSeconds(During));

                case LoadSimulationType.RampPerSec:
                    return Simulation.RampPerSec(rate: Parameter, during: TimeSpan.FromSeconds(During));

                case LoadSimulationType.InjectPerSec: 
                default:
                    return Simulation.InjectPerSec(rate: Parameter, during: TimeSpan.FromSeconds(During));
            }
        }
    }

}
