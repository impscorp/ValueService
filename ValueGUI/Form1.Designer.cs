namespace ValueGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.UserInputWhitout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.precision = new System.Windows.Forms.NumericUpDown();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.precision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "With postfactor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(12, 712);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(470, 39);
            this.UserInput.TabIndex = 3;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // UserInputWhitout
            // 
            this.UserInputWhitout.Location = new System.Drawing.Point(12, 619);
            this.UserInputWhitout.Name = "UserInputWhitout";
            this.UserInputWhitout.Size = new System.Drawing.Size(212, 39);
            this.UserInputWhitout.TabIndex = 6;
            this.UserInputWhitout.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "without postfactor";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(12, 778);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(676, 39);
            this.result.TabIndex = 7;
            // 
            // precision
            // 
            this.precision.Location = new System.Drawing.Point(382, 619);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(100, 39);
            this.precision.TabIndex = 8;
            this.precision.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(230, 618);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(146, 40);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(681, 546);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(708, 849);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.precision);
            this.Controls.Add(this.result);
            this.Controls.Add(this.UserInputWhitout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.precision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox UserInput;
        private TextBox UserInputWhitout;
        private Label label2;
        private Button button2;
        private TextBox result;
        private NumericUpDown precision;
        private ComboBox comboBox;
        private DataGridView dataGridView1;
    }
}