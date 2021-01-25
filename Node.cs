using System.Collections.Generic;


namespace MessageManager
{
    public enum ThresholdType
    {
        CPUUsage,
        Connections,
        Storage
    }

    public class Node{

        public string Name;
        public string IpAddress {set; get;}
        public int TotalConnections {set; get;}
        public int AvailableConnections {set; get;}
        public List<Channel> Channels {set; get;}
        public float TotalStorage {set; get;}
        public float AvailableStorage {set; get;}
        public float CPUUsage {set; get;}
        public ThresholdType ThresholdType {set; get;}

        public Node(string Name){
            this.Name = Name;
            this.TotalConnections = 0;
            this.AvailableConnections = 0;
            this.TotalStorage = 0.00f;
            this.AvailableStorage = 0.00f;
            this.CPUUsage = 0.00f;
            this.Channels = new List<Channel>();
            this.ThresholdType = ThresholdType.Connections;             
        }

        public int GetChannelCount(){
            return this.Channels.Count;
        }

        public int AddChannel(string Name){
            Channel newChannel = new Channel(Name);
            try
            {
                this.Channels.Add(newChannel);
                return 1;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        public List<Channel> GetAllChannels(){
            return this.Channels;
        }

        public Channel GetChannelByName(){
            return new Channel("Hey");
        }
        
    }
}