using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using healthcare_app;

namespace healthcare_app
{
    public partial class Form1 : Form
    {
        Person person;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            decimal height = numericUpDown1.Value;
            decimal weight = numericUpDown2.Value;
            bool male = true;
            bool female = false;
            decimal age = numericUpDown3.Value;

            if(radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                male = true;
            }

            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                female = true;
            }

            person = new Person(name, weight, height, male, female, age);

            textBox1.Text = person.getMassIndex().ToString();
            textBox2.Text = person.getCalories().ToString();
            textBox3.Text = person.getWaterNorm().ToString();

            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(person.getName()+".txt"))
            {
                sw.WriteLine("Рекомендації для {0}", person.getName());
                sw.WriteLine("Вік {0}", person.getAge().ToString());
                sw.WriteLine("------------------------------------");
                sw.WriteLine("Індекс маси тіла: {0}", person.getMassIndex());
                sw.WriteLine("Денна норма калорій: {0}", person.getCalories());
                sw.WriteLine("Денна норма води: {0}", person.getWaterNorm());
            }

            MessageBox.Show("Звіт створено!");
        }
    }
}
