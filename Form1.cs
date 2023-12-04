namespace ObjectManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("THE TEXT BOX IS EMPTY!");
            }
            else
            {
                MessageBox.Show("THE TEXT BOX HAS TEXT INSIDE.");
            }
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            this.fullNameTextBox.Text = this.firstNameTextBox.Text + " " + this.lastNameTextBox.Text;
        }

        private void addBtnComboBox_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add(this.comboBoxTextBox.Text);
        }

        private void clearBtnComboBox_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }

        private void addBtnListBox_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.listBoxTextBox.Text);
        }

        private void clearBtnListBox_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked == true)
            {
                this.checkBox4.Checked = false;

                this.checkBox1.Checked = true;
                this.checkBox2.Checked = true;
                this.checkBox3.Checked = true;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked == true)
            {
                this.checkBox5.Checked = false;

                this.checkBox1.Checked = false;
                this.checkBox2.Checked = false;
                this.checkBox3.Checked = false;

            }
        }

        private void clickBtnSample1_Click(object sender, EventArgs e)
        {
            this.outputTextBoxSample1.Text = "CLICK EVENT";
        }

        private void textBoxSample1_TextChanged(object sender, EventArgs e)
        {
            this.outputTextBoxSample1.Text = this.textBoxSample1.Text;
        }

        private void clickBtnSample2_Click(object sender, EventArgs e)
        {
            this.outputTextBoxSample2.Text = "CLICK EVENT";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.outputTextBoxSample2.Text = this.comboBox2.Text;
        }
    }
}