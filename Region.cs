using System.Collections.Generic;
using System.Linq;
using System;

namespace MessageManager
{
    public class Region
    {
        public string Name{set; get;}
        public List<Node> Nodes {set; get;}

        public Region(){}

        public Region(string Name){
            this.Name = Name;
            this.Nodes = new List<Node>();
        }

        public List<Node> GetByRegionChannel(string Region, string Channel){
            //var nodes = 
            //    (from c in this.Name
            //    where c.Name == Node
            //    select c).ToList();
            //    (from c in this.Channels
            //    where c.Name == Channel
            //    select c).ToList();
            return this.Nodes;
        }

        public List<Node> GetByChannel(string channel){
            //var nodes = 
            //    (from c in this.Name
            //    where c.Name == Node
            //    select c).ToList();
            //    (from c in this.Channels
            //    where c.Name == Channel
            //    select c).ToList();
            Console.WriteLine(channel);
            
            //    (
            //        from n in this.Nodes
            //        from c in n.Channels
            //        where c.Name == channel
            //        select n
            //    ).ToList();
            //return this.Nodes;

            List<Node> nodes = (
                from node in this.Nodes
                from c in node.Channels
                where c.Name == channel
                select node
            ).ToList();
            
            return nodes;
        }
        
    }
}