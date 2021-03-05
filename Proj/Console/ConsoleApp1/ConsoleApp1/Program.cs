using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        protected static void Serealize(object ab,FileStream fs)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (fs)
            {
                formatter.Serialize(fs, ab);
            }
            fs.Close();
        }

        protected static object Deserealize(FileStream fs)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (fs)
            {
                return (object)formatter.Deserialize(fs);
            }

        }
        static void Main(string[] args)
        {
            List<Trackless> tracklesses = new List<Trackless>();
            //tracklesses.Add(new Trackless("Машина", 4));
            //tracklesses.Add(new Trackless("Мотоцикл", 2));

            FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate);

            tracklesses=(List<Trackless>)Deserealize(fs);

            foreach (Trackless ab in tracklesses)
                Console.WriteLine(ab.ToString());
            Console.ReadLine();


        }
    }
}


//BinaryFormatter formatter = new BinaryFormatter();
//            using (FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate))
//            {
//                formatter.Serialize(fs, ab);

//            }
 // десериализация из файла trackless.dat
//            using (FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate))
//            {
//                Trackless abb = (Trackless)formatter.Deserialize(fs);
//Console.WriteLine(abb.ToString());
//            }
            
//            Console.ReadLine();