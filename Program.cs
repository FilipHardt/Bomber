using AutoMapper;
using Bflow.Approvals.Application.IntegrationTests;
using Bflow.Approvals.Application.OrderTypes.Queries.GetOrderTypes;
using Bflow.Approvals.Application.Users.Commands.CreateUser;
using Bflow.Approvals.Application.Users.Queries.GetUsers;
using Bflow.Approvals.Domain.Entities;
using MediatR;
using NBomber.Contracts;
using NBomber.CSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Stresstest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load testing via Bomber");
            Console.WriteLine("---------------------------------------------------------------");

            var scenario = BomberScenarioLibrary.OrderScenario;

            NBomberRunner
             .RegisterScenarios(scenario)
              .Run();
        }
    }
}
