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
        public string GroupName;
        public string GroupLink;
        public string GroupText;

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
            GroupName = values[0];
            GroupLink = values[1];
            GroupText = values[2];
            groupNameLabel.Text = GroupName;
            linkLabel1.Text = GroupLink;
            SendText.Text = GroupText;
        }
    }
}
