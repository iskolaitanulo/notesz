using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menuk_12B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string szovegsug = "Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. " +
                "At lectus urna duis convallis convallis tellus id. Risus in hendrerit gravida rutrum quisque non tellus orci ac. " +
                "Suspendisse in est ante in nibh. Enim neque volutpat ac tincidunt vitae semper. Sit amet tellus cras adipiscing enim eu. " +
                "Congue mauris rhoncus aenean vel elit scelerisque mauris pellentesque. At ultrices mi tempus imperdiet nulla malesuada " +
                "pellentesque elit. At risus viverra adipiscing at in tellus. Tellus elementum sagittis vitae et leo duis ut.";
            richTextBox1.Text = szovegsug;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
