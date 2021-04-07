using NBomber.Contracts;
using NBomber.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
    public class BomberScenario : BomberBaseGuid
    {
        public string Name { get; protected set; }
        public List<IStep> ScenarioSteps  { get; protected set; }
        public BomberLoadSimulation LoadSimulation { get; protected set; }

        public BomberScenario(List<BomberStep> steps, BomberLoadSimulation loadSimulation, string name)
        {
            this.Name = name;

            this.ScenarioSteps = steps.Select(x => x.GetStep()).ToList();

            this.LoadSimulation = loadSimulation;
        }

        public Scenario GetScenario()
        {
            return ScenarioBuilder
                .CreateScenario(Name, ScenarioSteps.ToArray())
                 .WithLoadSimulations(LoadSimulation.GetSimulation());
        }
    }
}
