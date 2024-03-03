using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTER_FINAL
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LEARN METHOD: WSM BUTTON DIAGRAM

            pictureBox1.Image = Properties.Resources.WSM_steps__Diagram_;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
