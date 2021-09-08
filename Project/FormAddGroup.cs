using System;
using System.Windows.Forms;

namespace Project
{
    public partial class FormAddGroup : Form
    {
        public bool GroupAdded = false;
        public FormAddGroup()
        {
            InitializeComponent();
        }
        private void FormAddGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {

                ConfirmButton_Click(sender, e);
            }
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (GroupBox.Text != "")
            {
                GroupAdded = true;
                this.Close();
            }
        }
    }
}
