using BusinessLogic2;
using Ninject;
using SimpleConfiqModuleNamespace;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Decanat
{
    public partial class Form2 : Form
    {
        IKernel ninjectKernel = new StandardKernel(new SimpleConfiqModule());
        Logic logic { get; set; }

        public Form2()
        {
            logic = ninjectKernel.Get<Logic>();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int id = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string speciality = textBox3.Text;
            string group = textBox4.Text;
            Logic.AddStudent(id, name, speciality, group);*/
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                string name = textBox2.Text;
                string speciality = textBox3.Text;
                string group = textBox4.Text;


                //List<string> specialityName = new List<string>() { Logic.GetAll().ElementAt(id) };
                int kol = 0;
                for (int i = 0; i < logic.GetAll().Count; i++)
                {
                    if (logic.GetAll().ElementAt(i) == id.ToString())
                    {
                        kol++;
                    }
                }
                if (kol > 0)
                {
                    MessageBox.Show("Человек с таким айди уже есть");
                }
                else logic.AddStudent(id, name, speciality, group);
                logic.GetAll();

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
