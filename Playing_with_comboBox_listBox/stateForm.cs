using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playing_with_comboBox_listBox
{
    public partial class stateForm : Form
    {
        List<string> items = new List<string>();
        public stateForm()
        {
            InitializeComponent();
        }

        private void stateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                items.Add(stateComboBox.Text);
                stateListBox.DataSource = null;
                stateListBox.DataSource = items;
                stateComboBox.Items.RemoveAt(stateComboBox.SelectedIndex);
            
            if (stateComboBox.Items.Count <= 0)
            {
                MessageBox.Show("There are no more states in the combo box"+
                    "\nThe program will terminate","Important Message");
                Application.Exit();
            }
            
        }

    }
}
