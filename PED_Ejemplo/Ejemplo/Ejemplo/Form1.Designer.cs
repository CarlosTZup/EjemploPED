namespace Ejemplo
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
            nombrebox = new TextBox();
            edadbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idbox = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // nombrebox
            // 
            nombrebox.Location = new Point(60, 152);
            nombrebox.Name = "nombrebox";
            nombrebox.Size = new Size(125, 27);
            nombrebox.TabIndex = 0;
            // 
            // edadbox
            // 
            edadbox.Location = new Point(60, 250);
            edadbox.Name = "edadbox";
            edadbox.Size = new Size(125, 27);
            edadbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 110);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 208);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 17);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // idbox
            // 
            idbox.Location = new Point(60, 60);
            idbox.Name = "idbox";
            idbox.Size = new Size(125, 27);
            idbox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(54, 324);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(446, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(546, 356);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1030, 476);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(idbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(edadbox);
            Controls.Add(nombrebox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombrebox;
        private TextBox edadbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idbox;
        private Button button1;
        private DataGridView dataGridView1;
    }
}