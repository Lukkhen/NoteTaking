namespace NoteTaking
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
            Title = new Label();
            Message = new Label();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            dataGridView1 = new DataGridView();
            bttnNew = new Button();
            bttnSave = new Button();
            bttnRead = new Button();
            bttnDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(35, 78);
            Title.Name = "Title";
            Title.Size = new Size(42, 16);
            Title.TabIndex = 0;
            Title.Text = "Title";
            Title.Click += label1_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Courier New", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Message.Location = new Point(15, 120);
            Message.Name = "Message";
            Message.Size = new Size(63, 16);
            Message.TabIndex = 1;
            Message.Text = "Message";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(83, 78);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(126, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(83, 120);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(261, 163);
            txtMessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(403, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(160, 205);
            dataGridView1.TabIndex = 4;
            // 
            // bttnNew
            // 
            bttnNew.Location = new Point(106, 316);
            bttnNew.Name = "bttnNew";
            bttnNew.Size = new Size(75, 23);
            bttnNew.TabIndex = 5;
            bttnNew.Text = "New";
            bttnNew.UseVisualStyleBackColor = true;
            bttnNew.Click += bttnNew_Click;
            // 
            // bttnSave
            // 
            bttnSave.Location = new Point(214, 316);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(75, 23);
            bttnSave.TabIndex = 6;
            bttnSave.Text = "Save";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnRead
            // 
            bttnRead.Location = new Point(322, 316);
            bttnRead.Name = "bttnRead";
            bttnRead.Size = new Size(75, 23);
            bttnRead.TabIndex = 7;
            bttnRead.Text = "Read";
            bttnRead.UseVisualStyleBackColor = true;
            bttnRead.Click += bttnRead_Click;
            // 
            // bttnDelete
            // 
            bttnDelete.Location = new Point(434, 316);
            bttnDelete.Name = "bttnDelete";
            bttnDelete.Size = new Size(75, 23);
            bttnDelete.TabIndex = 8;
            bttnDelete.Text = "Delete";
            bttnDelete.UseVisualStyleBackColor = true;
            bttnDelete.Click += bttnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(186, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 62);
            label1.TabIndex = 9;
            label1.Text = "NoteTaking";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(611, 450);
            Controls.Add(label1);
            Controls.Add(bttnDelete);
            Controls.Add(bttnRead);
            Controls.Add(bttnSave);
            Controls.Add(bttnNew);
            Controls.Add(dataGridView1);
            Controls.Add(txtMessage);
            Controls.Add(txtTitle);
            Controls.Add(Message);
            Controls.Add(Title);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Message;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private DataGridView dataGridView1;
        private Button bttnNew;
        private Button bttnSave;
        private Button bttnRead;
        private Button bttnDelete;
        private Label label1;
    }
}
