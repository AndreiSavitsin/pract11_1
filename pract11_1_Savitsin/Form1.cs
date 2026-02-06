using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract11_1_Savitsin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student((double)numericUpDown1.Value);
            stud.name = textBox1.Text;
            if (stud.name == "")
            {
                label4.Text = "Не введены фамилия и имя";
            }
            else
            {
                stud.height = (double)numericUpDown1.Value;
                stud.Stud1((double)numericUpDown2.Value);
                stud.foodWeight = (double)numericUpDown3.Value;
                stud.SetEat(stud.foodWeight);
                MessageBox.Show(string.Format($"Студент {stud.name} съел {stud.foodWeight} кг, станет: \nРост {stud.height} см \nВес {stud.GetEat()} кг"));
            }
        }
    }
}
