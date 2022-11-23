using BusinessLogic2;
using Ninject;
using SimpleConfiqModuleNamespace;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Decanat
{
    public partial class Form1 : Form
    {
        IKernel ninjectKernel = new StandardKernel(new SimpleConfiqModule());
        Logic logic { get; set; }
        public Form1()
        {
            InitializeComponent();
            logic = ninjectKernel.Get<Logic>();
            RefreshLi();
        }
        public void RefreshLi()
        {
            listView1.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Имя", 100);
            listView1.Columns.Add("Cпециальность", 100);
            listView1.Columns.Add("Группа", 80);

            for (int i = 0; i < logic.GetAll().Count(); i++)

            {
                ListViewItem newitem = new ListViewItem(logic.GetAll().ElementAt(i).Split());
                newitem.SubItems.Add(logic.GetAll().ElementAt(i));
                //newitem.SubItems.Add(Convert.ToString(logic.GetAll().ElementAt(i)));
                newitem.SubItems.Add(logic.GetAll().ElementAt(i));
                newitem.SubItems.Add(logic.GetAll().ElementAt(i));

                listView1.Items.Add(newitem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*listView1.Items.Add("List item text", 3);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            logic.DeleteStudent(id);
            RefreshLi();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

            RefreshLi();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            List<string> speciality = new List<string>();
            for (int i = 0; i < logic.students.Count; i++)
                speciality.Add(logic.students[i].Speciality);

            Graph.Form2 form1 = new Graph.Form2(speciality);
            form1.Show();
        }*/
    }
}
