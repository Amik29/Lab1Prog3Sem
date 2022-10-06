using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1Prog3Sem
{
    public partial class TaskForm : Form
    {
        public TaskForm(string Name,string SecondName, string ClassNum, decimal CountOfTask, bool Easy)
        {
            
            InitializeComponent();
            if (Easy)
            {
                TaskBox.Enabled = false; // Способ убирать один из вариантов
                TaskBox.Visible = false;
            }
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Text = $"{SecondName} {Name} {ClassNum}";





        }

        private void ContinuingButton_Click(object sender, EventArgs e)
        {

        }
    }
}
