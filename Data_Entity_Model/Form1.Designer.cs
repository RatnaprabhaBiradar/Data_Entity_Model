namespace Data_Entity_Model
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_Save = new System.Windows.Forms.Button();
            this.button2_Update = new System.Windows.Forms.Button();
            this.button3_Search = new System.Windows.Forms.Button();
            this.button4_Delete = new System.Windows.Forms.Button();
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_Salary = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // button1_Save
            // 
            this.button1_Save.Location = new System.Drawing.Point(136, 309);
            this.button1_Save.Name = "button1_Save";
            this.button1_Save.Size = new System.Drawing.Size(75, 23);
            this.button1_Save.TabIndex = 3;
            this.button1_Save.Text = "Save";
            this.button1_Save.UseVisualStyleBackColor = true;
            this.button1_Save.Click += new System.EventHandler(this.button1_Save_Click);
            // 
            // button2_Update
            // 
            this.button2_Update.Location = new System.Drawing.Point(266, 309);
            this.button2_Update.Name = "button2_Update";
            this.button2_Update.Size = new System.Drawing.Size(107, 48);
            this.button2_Update.TabIndex = 4;
            this.button2_Update.Text = "Save Changes/Update";
            this.button2_Update.UseVisualStyleBackColor = true;
            this.button2_Update.Click += new System.EventHandler(this.button2_Update_Click);
            // 
            // button3_Search
            // 
            this.button3_Search.Location = new System.Drawing.Point(410, 309);
            this.button3_Search.Name = "button3_Search";
            this.button3_Search.Size = new System.Drawing.Size(75, 23);
            this.button3_Search.TabIndex = 5;
            this.button3_Search.Text = "Search";
            this.button3_Search.UseVisualStyleBackColor = true;
            this.button3_Search.Click += new System.EventHandler(this.button3_Search_Click);
            // 
            // button4_Delete
            // 
            this.button4_Delete.Location = new System.Drawing.Point(542, 309);
            this.button4_Delete.Name = "button4_Delete";
            this.button4_Delete.Size = new System.Drawing.Size(75, 23);
            this.button4_Delete.TabIndex = 6;
            this.button4_Delete.Text = "Delete";
            this.button4_Delete.UseVisualStyleBackColor = true;
            this.button4_Delete.Click += new System.EventHandler(this.button4_Delete_Click);
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(257, 107);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(100, 22);
            this.textBox1_ID.TabIndex = 7;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(257, 168);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox2_Name.TabIndex = 8;
            // 
            // textBox3_Salary
            // 
            this.textBox3_Salary.Location = new System.Drawing.Point(257, 220);
            this.textBox3_Salary.Name = "textBox3_Salary";
            this.textBox3_Salary.Size = new System.Drawing.Size(100, 22);
            this.textBox3_Salary.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(454, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1_showAll
            // 
            this.button1_showAll.Location = new System.Drawing.Point(673, 309);
            this.button1_showAll.Name = "button1_showAll";
            this.button1_showAll.Size = new System.Drawing.Size(75, 23);
            this.button1_showAll.TabIndex = 11;
            this.button1_showAll.Text = "Show All";
            this.button1_showAll.UseVisualStyleBackColor = true;
            this.button1_showAll.Click += new System.EventHandler(this.button1_showAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_showAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3_Salary);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox1_ID);
            this.Controls.Add(this.button4_Delete);
            this.Controls.Add(this.button3_Search);
            this.Controls.Add(this.button2_Update);
            this.Controls.Add(this.button1_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_Save;
        private System.Windows.Forms.Button button2_Update;
        private System.Windows.Forms.Button button3_Search;
        private System.Windows.Forms.Button button4_Delete;
        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox3_Salary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_showAll;
    }
}

