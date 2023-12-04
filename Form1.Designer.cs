namespace ObjectManipulation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            verifyBtn = new Button();
            clearBtn = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            fullNameTextBox = new TextBox();
            joinBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            clearBtnComboBox = new Button();
            addBtnComboBox = new Button();
            label4 = new Label();
            comboBoxTextBox = new TextBox();
            groupBox4 = new GroupBox();
            listBox1 = new ListBox();
            clearBtnListBox = new Button();
            addBtnListBox = new Button();
            label6 = new Label();
            listBoxTextBox = new TextBox();
            groupBox5 = new GroupBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox6 = new GroupBox();
            label8 = new Label();
            outputTextBoxSample1 = new TextBox();
            clickBtnSample1 = new Button();
            label7 = new Label();
            textBoxSample1 = new TextBox();
            groupBox7 = new GroupBox();
            clickBtnSample2 = new Button();
            label9 = new Label();
            outputTextBoxSample2 = new TextBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(verifyBtn);
            groupBox1.Controls.Add(clearBtn);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "CLEARING THE TEXT ON THE TEXT BOX";
            // 
            // verifyBtn
            // 
            verifyBtn.BackColor = Color.FromArgb(255, 128, 255);
            verifyBtn.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            verifyBtn.ForeColor = SystemColors.ControlLightLight;
            verifyBtn.Location = new Point(545, 16);
            verifyBtn.Name = "verifyBtn";
            verifyBtn.Size = new Size(75, 34);
            verifyBtn.TabIndex = 8;
            verifyBtn.Text = "VERIFY";
            verifyBtn.UseVisualStyleBackColor = false;
            verifyBtn.Click += verifyBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(255, 128, 255);
            clearBtn.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.ForeColor = SystemColors.ControlLightLight;
            clearBtn.Location = new Point(437, 16);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 34);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(37, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 24);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 255);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(fullNameTextBox);
            groupBox2.Controls.Add(joinBtn);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lastNameTextBox);
            groupBox2.Controls.Add(firstNameTextBox);
            groupBox2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "CONCATENATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(579, 20);
            label3.Name = "label3";
            label3.Size = new Size(100, 17);
            label3.TabIndex = 11;
            label3.Text = "FULL NAME";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameTextBox.Location = new Point(491, 44);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(254, 24);
            fullNameTextBox.TabIndex = 10;
            // 
            // joinBtn
            // 
            joinBtn.BackColor = Color.FromArgb(255, 128, 255);
            joinBtn.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            joinBtn.ForeColor = SystemColors.ControlLightLight;
            joinBtn.Location = new Point(368, 38);
            joinBtn.Name = "joinBtn";
            joinBtn.Size = new Size(75, 34);
            joinBtn.TabIndex = 9;
            joinBtn.Text = "JOIN";
            joinBtn.UseVisualStyleBackColor = false;
            joinBtn.Click += joinBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(165, 19);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 4;
            label2.Text = "LAST NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 3;
            label1.Text = "FIRST NAME";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(165, 44);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(140, 24);
            lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(19, 44);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(140, 24);
            firstNameTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(255, 192, 255);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(clearBtnComboBox);
            groupBox3.Controls.Add(addBtnComboBox);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(comboBoxTextBox);
            groupBox3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "COMBO BOX MANIPULATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(486, 20);
            label5.Name = "label5";
            label5.Size = new Size(134, 17);
            label5.TabIndex = 16;
            label5.Text = "SAMPLE COMBO";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(437, 52);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 25);
            comboBox1.TabIndex = 15;
            // 
            // clearBtnComboBox
            // 
            clearBtnComboBox.BackColor = Color.FromArgb(255, 128, 255);
            clearBtnComboBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtnComboBox.ForeColor = SystemColors.ButtonHighlight;
            clearBtnComboBox.Location = new Point(209, 60);
            clearBtnComboBox.Name = "clearBtnComboBox";
            clearBtnComboBox.Size = new Size(75, 34);
            clearBtnComboBox.TabIndex = 14;
            clearBtnComboBox.Text = "CLEAR";
            clearBtnComboBox.UseVisualStyleBackColor = false;
            clearBtnComboBox.Click += clearBtnComboBox_Click;
            // 
            // addBtnComboBox
            // 
            addBtnComboBox.BackColor = Color.FromArgb(255, 128, 255);
            addBtnComboBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtnComboBox.ForeColor = SystemColors.ButtonHighlight;
            addBtnComboBox.Location = new Point(209, 23);
            addBtnComboBox.Name = "addBtnComboBox";
            addBtnComboBox.Size = new Size(75, 34);
            addBtnComboBox.TabIndex = 13;
            addBtnComboBox.Text = "ADD";
            addBtnComboBox.UseVisualStyleBackColor = false;
            addBtnComboBox.Click += addBtnComboBox_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 23);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 12;
            label4.Text = "INPUT TEXT";
            // 
            // comboBoxTextBox
            // 
            comboBoxTextBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxTextBox.Location = new Point(19, 53);
            comboBoxTextBox.Name = "comboBoxTextBox";
            comboBoxTextBox.Size = new Size(184, 24);
            comboBoxTextBox.TabIndex = 11;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 192, 255);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Controls.Add(clearBtnListBox);
            groupBox4.Controls.Add(addBtnListBox);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(listBoxTextBox);
            groupBox4.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(12, 298);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "LIST BOX MANIPULATION";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(480, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 89);
            listBox1.TabIndex = 17;
            // 
            // clearBtnListBox
            // 
            clearBtnListBox.BackColor = Color.FromArgb(255, 128, 255);
            clearBtnListBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtnListBox.ForeColor = SystemColors.ControlLightLight;
            clearBtnListBox.Location = new Point(230, 59);
            clearBtnListBox.Name = "clearBtnListBox";
            clearBtnListBox.Size = new Size(75, 36);
            clearBtnListBox.TabIndex = 16;
            clearBtnListBox.Text = "CLEAR";
            clearBtnListBox.UseVisualStyleBackColor = false;
            clearBtnListBox.Click += clearBtnListBox_Click;
            // 
            // addBtnListBox
            // 
            addBtnListBox.BackColor = Color.FromArgb(255, 128, 255);
            addBtnListBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addBtnListBox.ForeColor = SystemColors.ControlLightLight;
            addBtnListBox.Location = new Point(230, 22);
            addBtnListBox.Name = "addBtnListBox";
            addBtnListBox.Size = new Size(75, 31);
            addBtnListBox.TabIndex = 15;
            addBtnListBox.Text = "ADD";
            addBtnListBox.UseVisualStyleBackColor = false;
            addBtnListBox.Click += addBtnListBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 42);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 13;
            label6.Text = "INPUT TEXT";
            // 
            // listBoxTextBox
            // 
            listBoxTextBox.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxTextBox.Location = new Point(19, 60);
            listBoxTextBox.Name = "listBoxTextBox";
            listBoxTextBox.Size = new Size(184, 24);
            listBoxTextBox.TabIndex = 12;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(255, 192, 255);
            groupBox5.Controls.Add(checkBox5);
            groupBox5.Controls.Add(checkBox4);
            groupBox5.Controls.Add(checkBox3);
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(12, 441);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(776, 100);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "CHECK BOX MANIPULATION";
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox5.Location = new Point(19, 37);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(81, 21);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "CHECK";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox4.Location = new Point(131, 37);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(104, 21);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "UNCHECK";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox3.Location = new Point(452, 72);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(100, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox2.Location = new Point(452, 47);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(100, 21);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(452, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(100, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(255, 192, 255);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(outputTextBoxSample1);
            groupBox6.Controls.Add(clickBtnSample1);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(textBoxSample1);
            groupBox6.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(12, 562);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(387, 130);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "CHANGE VS CLICK EVENT SAMPLE 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 73);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 19;
            label8.Text = "OUTPUT";
            // 
            // outputTextBoxSample1
            // 
            outputTextBoxSample1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            outputTextBoxSample1.Location = new Point(19, 91);
            outputTextBoxSample1.Name = "outputTextBoxSample1";
            outputTextBoxSample1.Size = new Size(331, 24);
            outputTextBoxSample1.TabIndex = 18;
            // 
            // clickBtnSample1
            // 
            clickBtnSample1.BackColor = Color.FromArgb(255, 128, 255);
            clickBtnSample1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clickBtnSample1.ForeColor = SystemColors.ControlLightLight;
            clickBtnSample1.Location = new Point(259, 30);
            clickBtnSample1.Name = "clickBtnSample1";
            clickBtnSample1.Size = new Size(75, 41);
            clickBtnSample1.TabIndex = 17;
            clickBtnSample1.Text = "CLICK";
            clickBtnSample1.UseVisualStyleBackColor = false;
            clickBtnSample1.Click += clickBtnSample1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 21);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 14;
            label7.Text = "TYPE HERE";
            // 
            // textBoxSample1
            // 
            textBoxSample1.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxSample1.Location = new Point(19, 39);
            textBoxSample1.Name = "textBoxSample1";
            textBoxSample1.Size = new Size(168, 24);
            textBoxSample1.TabIndex = 13;
            textBoxSample1.TextChanged += textBoxSample1_TextChanged;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.FromArgb(255, 192, 255);
            groupBox7.Controls.Add(clickBtnSample2);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(outputTextBoxSample2);
            groupBox7.Controls.Add(comboBox2);
            groupBox7.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(416, 562);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(372, 130);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "CHANGE VS CLICK EVENT SAMPLE 2";
            // 
            // clickBtnSample2
            // 
            clickBtnSample2.BackColor = Color.FromArgb(255, 128, 255);
            clickBtnSample2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clickBtnSample2.ForeColor = SystemColors.ControlLightLight;
            clickBtnSample2.Location = new Point(253, 30);
            clickBtnSample2.Name = "clickBtnSample2";
            clickBtnSample2.Size = new Size(75, 40);
            clickBtnSample2.TabIndex = 19;
            clickBtnSample2.Text = "CLICK";
            clickBtnSample2.UseVisualStyleBackColor = false;
            clickBtnSample2.Click += clickBtnSample2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(33, 73);
            label9.Name = "label9";
            label9.Size = new Size(71, 17);
            label9.TabIndex = 18;
            label9.Text = "OUTPUT";
            // 
            // outputTextBoxSample2
            // 
            outputTextBoxSample2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            outputTextBoxSample2.Location = new Point(24, 91);
            outputTextBoxSample2.Name = "outputTextBoxSample2";
            outputTextBoxSample2.Size = new Size(317, 24);
            outputTextBoxSample2.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Kristen ITC", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(24, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 25);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 710);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OBJECT MANIPULATION";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button verifyBtn;
        private Button clearBtn;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox fullNameTextBox;
        private Button joinBtn;
        private Label label2;
        private Label label1;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private GroupBox groupBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Button clearBtnComboBox;
        private Button addBtnComboBox;
        private Label label4;
        private TextBox comboBoxTextBox;
        private GroupBox groupBox4;
        private ListBox listBox1;
        private Button clearBtnListBox;
        private Button addBtnListBox;
        private Label label6;
        private TextBox listBoxTextBox;
        private GroupBox groupBox5;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox6;
        private Label label8;
        private TextBox outputTextBoxSample1;
        private Button clickBtnSample1;
        private Label label7;
        private TextBox textBoxSample1;
        private GroupBox groupBox7;
        private Button clickBtnSample2;
        private Label label9;
        private TextBox outputTextBoxSample2;
        private ComboBox comboBox2;
    }
}