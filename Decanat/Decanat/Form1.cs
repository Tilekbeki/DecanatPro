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
using System.Runtime.Remoting.Messaging;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Decanat
{
    
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        public Form1(Logic Logic)
        {
            logic = Logic;
            InitializeComponent();
            RefreshLi();
        }
        public void RefreshLi()
        {
            listView1.Clear();

            listView1.View = View.Details;

            listView1.Columns.Add("ID",50);
            listView1.Columns.Add("ФИО", 100);
            listView1.Columns.Add("Cпециальность", 50);
            listView1.Columns.Add("Группа", 50);

            for (int i = 0; i < logic.GetAll().Count(); i++)

            {
                ListViewItem newitem = new ListViewItem(logic.GetAll().ElementAt(i)[0]);
                newitem.SubItems.Add(Convert.ToString(logic.GetAll().ElementAt(i)[1]));

                newitem.SubItems.Add(Convert.ToString(logic.GetAll().ElementAt(i)[2]));
                newitem.SubItems.Add(Convert.ToString(logic.GetAll().ElementAt(i)[3]));
                






                listView1.Items.Add(newitem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(logic);
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
            //string id = textBox1.Text;
            int main_id = Convert.ToInt32(textBox1.Text);
            logic.DeleteStudent(main_id);
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
