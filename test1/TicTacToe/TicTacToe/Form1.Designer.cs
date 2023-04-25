namespace TicTacToe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            c1 = new Button();
            c2 = new Button();
            c3 = new Button();
            restart = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(a1, 0, 0);
            tableLayoutPanel1.Controls.Add(a2, 0, 1);
            tableLayoutPanel1.Controls.Add(a3, 0, 2);
            tableLayoutPanel1.Controls.Add(b1, 1, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 1);
            tableLayoutPanel1.Controls.Add(b3, 1, 2);
            tableLayoutPanel1.Controls.Add(c1, 2, 0);
            tableLayoutPanel1.Controls.Add(c2, 2, 1);
            tableLayoutPanel1.Controls.Add(c3, 2, 2);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(273, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // a1
            // 
            a1.Dock = DockStyle.Fill;
            a1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            a1.Location = new Point(3, 3);
            a1.Name = "a1";
            a1.Size = new Size(84, 64);
            a1.TabIndex = 0;
            a1.Tag = "0,0";
            a1.Text = " ";
            a1.UseVisualStyleBackColor = true;
            a1.Click += button_Click;
            // 
            // a2
            // 
            a2.Dock = DockStyle.Fill;
            a2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            a2.Location = new Point(3, 73);
            a2.Name = "a2";
            a2.Size = new Size(84, 64);
            a2.TabIndex = 1;
            a2.Tag = "1,0";
            a2.Text = " ";
            a2.UseVisualStyleBackColor = true;
            a2.Click += button_Click;
            // 
            // a3
            // 
            a3.Dock = DockStyle.Fill;
            a3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            a3.Location = new Point(3, 143);
            a3.Name = "a3";
            a3.Size = new Size(84, 67);
            a3.TabIndex = 2;
            a3.Tag = "2,0";
            a3.Text = " ";
            a3.UseVisualStyleBackColor = true;
            a3.Click += button_Click;
            // 
            // b1
            // 
            b1.Dock = DockStyle.Fill;
            b1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(93, 3);
            b1.Name = "b1";
            b1.Size = new Size(85, 64);
            b1.TabIndex = 3;
            b1.Tag = "0,1";
            b1.Text = " ";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button_Click;
            // 
            // b2
            // 
            b2.Dock = DockStyle.Fill;
            b2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(93, 73);
            b2.Name = "b2";
            b2.Size = new Size(85, 64);
            b2.TabIndex = 4;
            b2.Tag = "1,1";
            b2.Text = " ";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button_Click;
            // 
            // b3
            // 
            b3.Dock = DockStyle.Fill;
            b3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(93, 143);
            b3.Name = "b3";
            b3.Size = new Size(85, 67);
            b3.TabIndex = 5;
            b3.Tag = "2,1";
            b3.Text = " ";
            b3.UseVisualStyleBackColor = true;
            b3.Click += button_Click;
            // 
            // c1
            // 
            c1.Dock = DockStyle.Fill;
            c1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            c1.Location = new Point(184, 3);
            c1.Name = "c1";
            c1.Size = new Size(86, 64);
            c1.TabIndex = 6;
            c1.Tag = "0,2";
            c1.Text = " ";
            c1.UseVisualStyleBackColor = true;
            c1.Click += button_Click;
            // 
            // c2
            // 
            c2.Dock = DockStyle.Fill;
            c2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            c2.Location = new Point(184, 73);
            c2.Name = "c2";
            c2.Size = new Size(86, 64);
            c2.TabIndex = 7;
            c2.Tag = "1,2";
            c2.Text = " ";
            c2.UseVisualStyleBackColor = true;
            c2.Click += button_Click;
            // 
            // c3
            // 
            c3.Dock = DockStyle.Fill;
            c3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            c3.Location = new Point(184, 143);
            c3.Name = "c3";
            c3.Size = new Size(86, 67);
            c3.TabIndex = 8;
            c3.Tag = "2,2";
            c3.Text = " ";
            c3.UseVisualStyleBackColor = true;
            c3.Click += button_Click;
            // 
            // restart
            // 
            restart.Location = new Point(68, 230);
            restart.Name = "restart";
            restart.Size = new Size(132, 32);
            restart.TabIndex = 1;
            restart.Text = "restart";
            restart.UseVisualStyleBackColor = true;
            restart.Click += restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 274);
            Controls.Add(restart);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(100, 100);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button a1;
        private Button a2;
        private Button a3;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button c1;
        private Button c2;
        private Button c3;
        private Button restart;
    }
}