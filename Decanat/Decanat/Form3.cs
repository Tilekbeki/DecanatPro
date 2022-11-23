using BusinessLogic2;
using Ninject;
using SimpleConfiqModuleNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Decanat
{
    public partial class Form3 : Form
    {
        IKernel ninjectKernel = new StandardKernel(new SimpleConfiqModule());
        Logic logic { get; set; }
        public Form3()
        {
            logic = ninjectKernel.Get<Logic>();
            InitializeComponent();
            DrawGraph();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void zedGraphControl1_Load_1(object sender, EventArgs e)
        {

        }

        public void DrawGraph()
        {
            int kol = 0;
            List<string> specialityName = new List<string>();
            for (int i = 0; i < logic.GetAll().Count; i++)
            {
                int kolName = 0;
                for (int j = 0; j < specialityName.Count; j++)
                {
                    if (logic.GetAll().ElementAt(i).Split()[2] == specialityName[j]) kolName++;
                }
                if (kolName == 0) specialityName.Add(logic.GetAll().ElementAt(i).Split()[2]);
            }
            for (int i = 0; i < specialityName.Count; i++)
            {
                for (int j = 0; j < logic.GetAll().Count; j++)
                {
                    if (specialityName[i] == logic.GetAll().ElementAt(j).Split()[2]) kol++;
                }
                chart1.Series.Add(specialityName[i]);
                chart1.Series[i].Points.AddY(kol);
                kol = 0;
            }
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
