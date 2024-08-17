namespace FirstCRUD
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radUrgent = new System.Windows.Forms.RadioButton();
            this.radNotUrgent = new System.Windows.Forms.RadioButton();
            this.labelTaskDesc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTaskDescription = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radNotImportant = new System.Windows.Forms.RadioButton();
            this.radImportant = new System.Windows.Forms.RadioButton();
            this.HasDeadline = new System.Windows.Forms.GroupBox();
            this.radDeadline = new System.Windows.Forms.RadioButton();
            this.radNoDeadline = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.textTaskId = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.HasDeadline.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 411);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(689, 222);
            this.dataGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 365);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Manager";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.77105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.22895F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTaskDesc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textTaskName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textTaskDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HasDeadline, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radUrgent);
            this.groupBox2.Controls.Add(this.radNotUrgent);
            this.groupBox2.Location = new System.Drawing.Point(103, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 38);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // radUrgent
            // 
            this.radUrgent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radUrgent.AutoSize = true;
            this.radUrgent.Location = new System.Drawing.Point(6, 12);
            this.radUrgent.Name = "radUrgent";
            this.radUrgent.Size = new System.Drawing.Size(57, 17);
            this.radUrgent.TabIndex = 7;
            this.radUrgent.TabStop = true;
            this.radUrgent.Text = "Urgent";
            this.radUrgent.UseVisualStyleBackColor = true;
            // 
            // radNotUrgent
            // 
            this.radNotUrgent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radNotUrgent.AutoSize = true;
            this.radNotUrgent.Location = new System.Drawing.Point(110, 12);
            this.radNotUrgent.Name = "radNotUrgent";
            this.radNotUrgent.Size = new System.Drawing.Size(77, 17);
            this.radNotUrgent.TabIndex = 8;
            this.radNotUrgent.TabStop = true;
            this.radNotUrgent.Text = "Not Urgent";
            this.radNotUrgent.UseVisualStyleBackColor = true;
            // 
            // labelTaskDesc
            // 
            this.labelTaskDesc.AutoSize = true;
            this.labelTaskDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTaskDesc.Location = new System.Drawing.Point(3, 186);
            this.labelTaskDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.labelTaskDesc.Name = "labelTaskDesc";
            this.labelTaskDesc.Size = new System.Drawing.Size(94, 141);
            this.labelTaskDesc.TabIndex = 12;
            this.labelTaskDesc.Text = "Task Description";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Importancy";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urgency";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deadline";
            // 
            // textTaskName
            // 
            this.textTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textTaskName.Location = new System.Drawing.Point(103, 13);
            this.textTaskName.Name = "textTaskName";
            this.textTaskName.Size = new System.Drawing.Size(571, 20);
            this.textTaskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Name";
            // 
            // textTaskDescription
            // 
            this.textTaskDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTaskDescription.Location = new System.Drawing.Point(103, 187);
            this.textTaskDescription.Multiline = true;
            this.textTaskDescription.Name = "textTaskDescription";
            this.textTaskDescription.Size = new System.Drawing.Size(571, 137);
            this.textTaskDescription.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radNotImportant);
            this.groupBox3.Controls.Add(this.radImportant);
            this.groupBox3.Location = new System.Drawing.Point(103, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 38);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // radNotImportant
            // 
            this.radNotImportant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radNotImportant.AutoSize = true;
            this.radNotImportant.Location = new System.Drawing.Point(110, 12);
            this.radNotImportant.Name = "radNotImportant";
            this.radNotImportant.Size = new System.Drawing.Size(89, 17);
            this.radNotImportant.TabIndex = 8;
            this.radNotImportant.TabStop = true;
            this.radNotImportant.Text = "Not Important";
            this.radNotImportant.UseVisualStyleBackColor = true;
            // 
            // radImportant
            // 
            this.radImportant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radImportant.AutoSize = true;
            this.radImportant.Location = new System.Drawing.Point(6, 12);
            this.radImportant.Name = "radImportant";
            this.radImportant.Size = new System.Drawing.Size(69, 17);
            this.radImportant.TabIndex = 11;
            this.radImportant.TabStop = true;
            this.radImportant.Text = "Important";
            this.radImportant.UseVisualStyleBackColor = true;
            // 
            // HasDeadline
            // 
            this.HasDeadline.Controls.Add(this.radDeadline);
            this.HasDeadline.Controls.Add(this.radNoDeadline);
            this.HasDeadline.Controls.Add(this.datePicker);
            this.HasDeadline.Location = new System.Drawing.Point(103, 49);
            this.HasDeadline.Name = "HasDeadline";
            this.HasDeadline.Size = new System.Drawing.Size(446, 38);
            this.HasDeadline.TabIndex = 16;
            this.HasDeadline.TabStop = false;
            // 
            // radDeadline
            // 
            this.radDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radDeadline.AutoSize = true;
            this.radDeadline.Location = new System.Drawing.Point(110, 12);
            this.radDeadline.Name = "radDeadline";
            this.radDeadline.Size = new System.Drawing.Size(89, 17);
            this.radDeadline.TabIndex = 8;
            this.radDeadline.TabStop = true;
            this.radDeadline.Text = "Has Deadline";
            this.radDeadline.UseVisualStyleBackColor = true;
            this.radDeadline.CheckedChanged += new System.EventHandler(this.radDeadline_CheckedChanged);
            // 
            // radNoDeadline
            // 
            this.radNoDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radNoDeadline.AutoSize = true;
            this.radNoDeadline.Location = new System.Drawing.Point(6, 12);
            this.radNoDeadline.Name = "radNoDeadline";
            this.radNoDeadline.Size = new System.Drawing.Size(84, 17);
            this.radNoDeadline.TabIndex = 7;
            this.radNoDeadline.TabStop = true;
            this.radNoDeadline.Text = "No Deadline";
            this.radNoDeadline.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(205, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(97, 20);
            this.datePicker.TabIndex = 6;
            // 
            // textTaskId
            // 
            this.textTaskId.Location = new System.Drawing.Point(18, 384);
            this.textTaskId.Name = "textTaskId";
            this.textTaskId.Size = new System.Drawing.Size(228, 20);
            this.textTaskId.TabIndex = 8;
            this.textTaskId.Text = "Enter the ID of the task";
            this.textTaskId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textTaskId_MouseDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(252, 382);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(388, 381);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(469, 381);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 11;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(626, 382);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(741, 645);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.textTaskId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.HasDeadline.ResumeLayout(false);
            this.HasDeadline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTaskName;
        private System.Windows.Forms.TextBox textTaskDescription;
        private System.Windows.Forms.Label labelTaskDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTaskId;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radUrgent;
        private System.Windows.Forms.RadioButton radNotUrgent;
        private System.Windows.Forms.RadioButton radImportant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radNotImportant;
        private System.Windows.Forms.GroupBox HasDeadline;
        private System.Windows.Forms.RadioButton radDeadline;
        private System.Windows.Forms.RadioButton radNoDeadline;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}

