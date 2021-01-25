using System;
using System.Linq;
using System.Collections.Generic;
// Re-Add when Productionalizing
//using Apache.Ignite.Core;

namespace MessageManager
{
    class Program
    {
        static void Main(string[] args)
        {

            //StartIgniteCache();
            Region globalRegions = new Region();
            globalRegions = MockData();


            //Get Channels
            List<Node> nodeList = new List<Node>();
            nodeList = globalRegions.GetByChannel("Default");
            foreach (var item in nodeList){
                Console.WriteLine(item.Name);
                Console.WriteLine(item.IpAddress);
            }
        }

        static void StartIgniteCache(){
            //Re-enable when productionalizing
            //var ignite = Ignition.Start();
            //var cache = ignite.GetOrCreateCache<string, string>("my-cache");
            //cache.Put("test-message", "Hello, World");
            //Console.WriteLine(cache.Get("test-message"));
        }

        static Region MockData(){
            Region southCentRegion = new Region("South-Cent-US");
            Node newNodeOne = new Node("newNodeOne");
            newNodeOne.AddChannel("Default");
            Node newNodeTwo = new Node("newNodeTwo");
            newNodeTwo.AddChannel("Test-Channel-1");
            southCentRegion.Nodes.Add(newNodeOne);
            southCentRegion.Nodes.Add(newNodeTwo);
            Region eastUsRegion = new Region("East-US");
            List<Region> regionList = new List<Region>();
            regionList.Add(southCentRegion);
            regionList.Add(eastUsRegion);
            return southCentRegion;
        }
    }


}
