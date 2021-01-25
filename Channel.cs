using System.Threading.Tasks;
using System;

namespace MessageManager{
    public class Channel{
        public string Name {set; get;}
        public string ShortName {set; get;}
        public int Connections {set; get;}

        public Channel(string Name){
            this.Name = Name;
            this.ShortName = Name.ToLower();
            this.Connections = 0;
        }

    }

}

