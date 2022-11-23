using BusinessLogic2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Decanat
{
    public partial class Form2 : Form
    {
        public Logic logic;
        public Form2(Logic Logic)
        {
            logic = Logic;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBox1.Text,out id))
            {
                string name = textBox2.Text;
                string speciality = textBox3.Text;
                string group = textBox4.Text;

                foreach (var a in logic.GetAll())
                {
                    if (a[0] == id.ToString())
                    {
                        MessageBox.Show("Человек с таким айди уже есть");
                        break;
                    }
                    else
                    {
                        logic.AddStudent(id, name, speciality, group);
                        break;
                    }
                }




            }
            else
            {
                MessageBox.Show("invalid ID");
            }
            
            this.Close();
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
