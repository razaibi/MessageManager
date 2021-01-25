using Apache.Ignite.Core;

namespace MessageManager
{
    public class ChannelMap
    {
        public string Channel{get;set;}
        public string ClientId{get;set;}
        public ChannelMap(){}

        public int AddMap(string Region, string Node, string Channel){
            string regionNode = Region.ToLower() + "-" + Node.ToLower();
            var ignite = Ignition.Start();
            var cache = ignite.GetOrCreateCache<string, string>(Region.ToLower());

            try
            {
                cache.Put(Node, Channel);
                return 1;
            }
            catch (System.Exception)
            {
                return 0;
            }

        }

    }
}