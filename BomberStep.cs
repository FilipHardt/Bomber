using Microsoft.FSharp.Core;
using NBomber.Contracts;
using NBomber.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
    public class BomberStep : BomberBaseGuid
    {
        public string Name { get; protected set; }
        public string Result { get; protected set; }
        public string Expected_Result { get; protected set; }
        public string EndpointRoute { get; protected set; }
        public BomberStep(string name , string expected_Result , string endpointRoute)
        {
            this.Name = name;

            this.Expected_Result = expected_Result;

            this.EndpointRoute = endpointRoute;
        }

        public IStep GetStep()
        {
            return Step.Create(Name, async context =>
            {
                var result = BomberCallEndpoint.CallEndpointAsync(EndpointRoute).Result;

                if (result != Expected_Result)
                {
                    return Response.Fail();
                }

                return Response.Ok();

            });
        }
    }

}
