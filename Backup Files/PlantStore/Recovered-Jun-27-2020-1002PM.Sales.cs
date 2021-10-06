using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantStore
{
    public partial class Sales : Form
    {
        PlantsProperty pp = new PlantsProperty();

        public Sales()
        {
            InitializeComponent();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            pp.potted_Bamboo -= pp.potted_Bamboo;

        }
    }
}
