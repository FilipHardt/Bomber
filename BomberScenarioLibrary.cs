using NBomber.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
    public static class BomberScenarioLibrary
    {
        public static Scenario OrderScenario = new BomberScenario(
            new List<BomberStep>() { 
                new BomberStep("GetOrderStep" , BomberCallEndpoint.CallEndpointAsync("https://localhost:5001/api/debug/orders").Result, "https://localhost:5001/api/debug/orders") } ,
            new BomberLoadSimulation(20 , 1 ,LoadSimulationType.InjectPerSec) ,
            "OrdersScenario" )
            .GetScenario();

    }
}
