namespace Lab1Prog3Sem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GeneratTask(object sender, EventArgs e)
        {
            if (FirstNameBox.Text.Length == 0)
            {
                MessageBox.Show("Не введено имя");
                return;
            }
            else if (SecondNameBox.Text.Length == 0)
            {
                MessageBox.Show("Не введена фамилия");
                return;

            }
            else if (SurnameBox.Text.Length == 0)
            {
                MessageBox.Show("Не введено отчество");
                return;
            }
            else if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Не выбран класс");
                return;
            }
            else if (!EzradioButton1.Checked && !HardradioButton2.Checked)
            {
                MessageBox.Show("Не выбрана сложность задания");
                return;
            }
            TaskForm tf = new TaskForm(
                FirstNameBox.Text,
                SecondNameBox.Text,
                comboBox1.Text,
                CountOfEx.Value,
                EzradioButton1.Checked
                );
            tf.ShowDialog();
                
                    
                
            
            
        }
    }
}