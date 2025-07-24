using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_autoposter
{
    public partial class GroupLines : UserControl
    {
        public GroupLines()
        {
            InitializeComponent();
        }

        private void SendText_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.Initialize(SendText.Text);
        }

        public void Initialize(string[] values)
        {
            groupNameLabel.Text = values[0];
            linkLabel1.Text = values[1];
            SendText.Text = values[2];
        }
    }
}
