using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts;

namespace Classes
{
    [Serializable]
    public class Trackless:GroundTransport
    {
           public Trackless (string name, int count)
        :base(name,count)
        {

        }
        public override string ToString()
        {
            return String.Format("Колесный транспорт с названием " + this.name + " Количество колес " + this.countwheels);
        }
        public override string Go00()
        {
            return String.Format(name + " Едет по дороге");
        }
    }
    [Serializable]
    public class Rail:GroundTransport
    {
        public Rail(string name, int count)
      : base(name, count)
        {

        }

        public override string ToString()
        {
            return String.Format("ЖД транспорт с названием " + this.name + " Количество колес " + this.countwheels);
        }
        public override string Go00()
        {
            return String.Format(name + " Едет по железной дороге");
        }
    }
    [Serializable]
    public class AWater:WaterTransport
    {
        public AWater(string name, bool sail)
    : base(name,sail )
        {

        }

        public override string ToString()
        {
            return String.Format("Надводный транспорт с названием " + this.name + " Парус " + (this.sail ?"Есть":"Нет") );
        }
        public override string Swim()
        {
            return String.Format(name + " Плывет по воде");
        }
    }
    [Serializable]
    public class UWater:WaterTransport
    {
        public UWater(string name, bool sail)
    : base(name, sail)
        {

        }

        public override string ToString()
        {
            return String.Format("Подводный транспорт с названием " + this.name + " Парус " + (this.sail ? "Есть" : "Нет"));
        }
        public override string Swim()
        {
            return String.Format(name + " Плывет под водой");
        }
    }
    [Serializable]
    public class AirTransport : Transport
    {
        public AirTransport(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return String.Format("Воздушный транспорт с названием " + this.name );
        }
        public string Fly()
        {
            return String.Format(name + " Летит");
        }
    }
}
