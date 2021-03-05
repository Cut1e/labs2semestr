using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    [Serializable]
    public abstract class Transport
    {
      protected  string name;
        public string Name { set { name = value; } get { return name; } }
     
    }
    [Serializable]
    public abstract class GroundTransport:Transport
    {
        protected int countwheels;
        public int Countwheels { set { countwheels = value; } get { return countwheels; } }

        public GroundTransport (string name, int count)
        {
            this.name = name;
            this.countwheels = count;
        }
        public abstract string Go00();

    }
    [Serializable]
    public abstract class WaterTransport:Transport
    {
        protected bool sail; 
        public bool Sail { set { sail = value; } get { return sail; } }
public WaterTransport (string name , bool sail)
        {
            this.name = name;
            this.sail = sail;
        }
        public abstract string Swim();
        
    }
    
}
