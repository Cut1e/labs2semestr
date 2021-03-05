using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public List<Trackless> tracklesses = new List<Trackless>();
        public List<Rail> rails = new List<Rail>();
        public List<AWater> aWaters = new List<AWater>();
        public List<UWater> uWaters = new List<UWater>();
        public List<AirTransport> airTransports = new List<AirTransport>();
        int numberclass = 0;
        protected static void Serealize(object ab, FileStream fs)
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
            public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //List<Trackless> tracklesses = new List<Trackless>();
            //tracklesses.Add(new Trackless("Машина", 4));
            //tracklesses.Add(new Trackless("Мотоцикл", 2));

            //FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberclass = 1;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Кол-во колес";
            int i = 0;
            foreach (Trackless ab in tracklesses)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = ab.Name;
                dataGridView1.Rows[i].Cells[1].Value = ab.Countwheels;
                i++;
            }
            dataGridView1.RowCount++;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate);
            tracklesses =(List<Trackless>)Deserealize(fs);
            fs = new FileStream("rails.dat", FileMode.OpenOrCreate);
            rails = (List<Rail>)Deserealize(fs);
            fs = new FileStream("awates.dat", FileMode.OpenOrCreate);
            aWaters = (List<AWater>)Deserealize(fs);
            fs = new FileStream("uwaters.dat", FileMode.OpenOrCreate);
            uWaters = (List<UWater>)Deserealize(fs);
            fs = new FileStream("airs.dat", FileMode.OpenOrCreate);
            airTransports = (List<AirTransport>)Deserealize(fs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberclass = 2;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Кол-во колес";
            int i = 0;
            foreach (Rail ab in rails)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = ab.Name;
                dataGridView1.Rows[i].Cells[1].Value = ab.Countwheels;
                i++;
            }
            dataGridView1.RowCount++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberclass = 3;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Парус";
            int i = 0;
            foreach (AWater ab in aWaters)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = ab.Name;
                dataGridView1.Rows[i].Cells[1].Value =  (ab.Sail?"Да":"Нет") ;
                i++;
            }
            dataGridView1.RowCount++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberclass = 4;
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Парус";
            int i = 0;
            foreach (UWater ab in uWaters)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = ab.Name;
                dataGridView1.Rows[i].Cells[1].Value = (ab.Sail ? "Да" : "Нет");
                i++;
            }
            dataGridView1.RowCount++;
        }

        private  void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("trackless.dat", FileMode.OpenOrCreate);
            Serealize(tracklesses,fs);
            fs = new FileStream("rails.dat", FileMode.OpenOrCreate);
            Serealize(rails, fs);
            fs = new FileStream("awates.dat", FileMode.OpenOrCreate);
            Serealize(aWaters, fs);
            fs = new FileStream("uwaters.dat", FileMode.OpenOrCreate);
            Serealize(uWaters, fs);
            fs = new FileStream("airs.dat", FileMode.OpenOrCreate);
            Serealize(airTransports, fs);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numberclass = 5;
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 0;
            dataGridView1.Columns[0].HeaderText = "Название";
            int i = 0;
            foreach (AirTransport ab in airTransports)
            {
                dataGridView1.RowCount++;
                dataGridView1.Rows[i].Cells[0].Value = ab.Name;
                i++;
            }
            dataGridView1.RowCount++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch(numberclass)
            {
                case 1: { tracklesses.Add(new Trackless(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString(),Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[1].Value))); } break;
                case 2: { rails.Add(new Rail(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[1].Value))); } break;
                case 3: { aWaters.Add(new AWater(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString(), (dataGridView1.Rows[dataGridView1.RowCount-1].Cells[1].Value.ToString().Equals("Да")?true:false))); } break;
                case 4: { uWaters.Add(new UWater(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString(), (dataGridView1.Rows[dataGridView1.RowCount-1].Cells[1].Value.ToString().Equals("Да") ? true : false))); } break;
                case 5: { airTransports.Add(new AirTransport(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value.ToString())); } break;
            }
            MessageBox.Show("Сохранено");
            dataGridView1.RowCount++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (numberclass)
            {
                case 1: { tracklesses.RemoveAt(dataGridView1.CurrentRow.Index); tracklesses.Insert(dataGridView1.CurrentRow.Index,new Trackless(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value))); } break;
                case 2: { rails.RemoveAt(dataGridView1.CurrentRow.Index); rails.Insert(dataGridView1.CurrentRow.Index,new Rail(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value))); } break;
                case 3: { aWaters.RemoveAt(dataGridView1.CurrentRow.Index); aWaters.Insert(dataGridView1.CurrentRow.Index, new AWater(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString(), (dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value.ToString().Equals("Да") ? true : false))); } break;
                case 4: { uWaters.RemoveAt(dataGridView1.CurrentRow.Index); uWaters.Insert(dataGridView1.CurrentRow.Index, new UWater(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString(), (dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value.ToString().Equals("Да") ? true : false))); } break;
                case 5: { airTransports.RemoveAt(dataGridView1.CurrentRow.Index); airTransports.Insert(dataGridView1.CurrentRow.Index, new AirTransport(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString())); } break;
            }
            MessageBox.Show("Изменено");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (numberclass)
            {
                case 1: { tracklesses.RemoveAt(dataGridView1.CurrentRow.Index); button1_Click(this, new EventArgs()); } break;
                case 2: { rails.RemoveAt(dataGridView1.CurrentRow.Index); button2_Click(this, new EventArgs()); } break;
                case 3: { aWaters.RemoveAt(dataGridView1.CurrentRow.Index); button3_Click(this, new EventArgs()); } break;
                case 4: { uWaters.RemoveAt(dataGridView1.CurrentRow.Index); button4_Click(this, new EventArgs()); } break;
                case 5: { airTransports.RemoveAt(dataGridView1.CurrentRow.Index); button10_Click(this, new EventArgs()); } break;
            }
            MessageBox.Show("Удалено");
        }
    }
}
