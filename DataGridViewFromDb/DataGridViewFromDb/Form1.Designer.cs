namespace DataGridViewFromDb
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
            dataGridView1 = new DataGridView();
            ROLL_NUMBER = new DataGridViewTextBoxColumn();
            NAME = new DataGridViewTextBoxColumn();
            TAMIL = new DataGridViewTextBoxColumn();
            ENGLISH = new DataGridViewTextBoxColumn();
            MATHS = new DataGridViewTextBoxColumn();
            SCIENCE = new DataGridViewTextBoxColumn();
            SSEIENCE = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            RESULT = new DataGridViewTextBoxColumn();
            PERCENTAGE = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ROLL_NUMBER, NAME, TAMIL, ENGLISH, MATHS, SCIENCE, SSEIENCE, TOTAL, RESULT, PERCENTAGE });
            dataGridView1.Location = new Point(38, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1304, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ROLL_NUMBER
            // 
            ROLL_NUMBER.HeaderText = "ROLL NUMBER";
            ROLL_NUMBER.MinimumWidth = 6;
            ROLL_NUMBER.Name = "ROLL_NUMBER";
            ROLL_NUMBER.ReadOnly = true;
            ROLL_NUMBER.Width = 125;
            // 
            // NAME
            // 
            NAME.HeaderText = "NAME";
            NAME.MinimumWidth = 6;
            NAME.Name = "NAME";
            NAME.ReadOnly = true;
            NAME.Width = 125;
            // 
            // TAMIL
            // 
            TAMIL.HeaderText = "TAMIL";
            TAMIL.MinimumWidth = 6;
            TAMIL.Name = "TAMIL";
            TAMIL.ReadOnly = true;
            TAMIL.Width = 125;
            // 
            // ENGLISH
            // 
            ENGLISH.HeaderText = "ENGLISH";
            ENGLISH.MinimumWidth = 6;
            ENGLISH.Name = "ENGLISH";
            ENGLISH.ReadOnly = true;
            ENGLISH.Width = 125;
            // 
            // MATHS
            // 
            MATHS.HeaderText = "MATHS";
            MATHS.MinimumWidth = 6;
            MATHS.Name = "MATHS";
            MATHS.ReadOnly = true;
            MATHS.Width = 125;
            // 
            // SCIENCE
            // 
            SCIENCE.HeaderText = "SCIENCE";
            SCIENCE.MinimumWidth = 6;
            SCIENCE.Name = "SCIENCE";
            SCIENCE.ReadOnly = true;
            SCIENCE.Width = 125;
            // 
            // SSEIENCE
            // 
            SSEIENCE.HeaderText = "HISTORY";
            SSEIENCE.MinimumWidth = 6;
            SSEIENCE.Name = "SSEIENCE";
            SSEIENCE.ReadOnly = true;
            SSEIENCE.Width = 125;
            // 
            // TOTAL
            // 
            TOTAL.HeaderText = "TOTAL";
            TOTAL.MinimumWidth = 6;
            TOTAL.Name = "TOTAL";
            TOTAL.ReadOnly = true;
            TOTAL.Width = 125;
            // 
            // RESULT
            // 
            RESULT.HeaderText = "RESULT";
            RESULT.MinimumWidth = 6;
            RESULT.Name = "RESULT";
            RESULT.ReadOnly = true;
            RESULT.Width = 125;
            // 
            // PERCENTAGE
            // 
            PERCENTAGE.HeaderText = "PERCENTAGE";
            PERCENTAGE.MinimumWidth = 6;
            PERCENTAGE.Name = "PERCENTAGE";
            PERCENTAGE.ReadOnly = true;
            PERCENTAGE.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(1221, 485);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 1;
            button1.Text = "View Records";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(419, 54);
            label1.Name = "label1";
            label1.Size = new Size(514, 46);
            label1.TabIndex = 2;
            label1.Text = "Students Records From Database";
            // 
            // button2
            // 
            button2.Location = new Point(1039, 485);
            button2.Name = "button2";
            button2.Size = new Size(176, 29);
            button2.TabIndex = 3;
            button2.Text = "Student Registeration";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 535);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private DataGridViewTextBoxColumn ROLL_NUMBER;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn TAMIL;
        private DataGridViewTextBoxColumn ENGLISH;
        private DataGridViewTextBoxColumn MATHS;
        private DataGridViewTextBoxColumn SCIENCE;
        private DataGridViewTextBoxColumn SSEIENCE;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn RESULT;
        private DataGridViewTextBoxColumn PERCENTAGE;
        private Button button2;
    }
}