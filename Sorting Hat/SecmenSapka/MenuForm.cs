using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecmenSapka
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Train_Btn_Click(object sender, EventArgs e)
        {
            TrainForm train = new TrainForm();
            this.Hide();
            train.Show();
        }

        private void Test_Btn_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm();
            this.Hide();
            test.Show();
        }
    }
}
