namespace Calculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            expressionOnTopTextBox = new TextBox();
            displayTextBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            clearButton = new Button();
            squareButton = new Button();
            reciprocalButton = new Button();
            divideButton = new Button();
            MultiplyButton = new Button();
            SubtractButton = new Button();
            AddButton = new Button();
            equalButton = new Button();
            decimalPointButton = new Button();
            button0 = new Button();
            changeSignButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.4552841F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.5447159F));
            tableLayoutPanel1.Size = new Size(284, 361);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(expressionOnTopTextBox, 0, 0);
            tableLayoutPanel2.Controls.Add(displayTextBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.375F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.625F));
            tableLayoutPanel2.Size = new Size(278, 96);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // expressionOnTopTextBox
            // 
            expressionOnTopTextBox.BackColor = SystemColors.Control;
            expressionOnTopTextBox.BorderStyle = BorderStyle.None;
            expressionOnTopTextBox.Dock = DockStyle.Fill;
            expressionOnTopTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            expressionOnTopTextBox.ForeColor = SystemColors.WindowFrame;
            expressionOnTopTextBox.Location = new Point(3, 3);
            expressionOnTopTextBox.Name = "expressionOnTopTextBox";
            expressionOnTopTextBox.ReadOnly = true;
            expressionOnTopTextBox.ScrollBars = ScrollBars.Horizontal;
            expressionOnTopTextBox.Size = new Size(272, 28);
            expressionOnTopTextBox.TabIndex = 0;
            expressionOnTopTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // displayTextBox
            // 
            displayTextBox.BackColor = SystemColors.Control;
            displayTextBox.BorderStyle = BorderStyle.None;
            displayTextBox.Dock = DockStyle.Fill;
            displayTextBox.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            displayTextBox.Location = new Point(3, 36);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.ScrollBars = ScrollBars.Horizontal;
            displayTextBox.Size = new Size(272, 64);
            displayTextBox.TabIndex = 1;
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(button1, 0, 3);
            tableLayoutPanel3.Controls.Add(button2, 1, 3);
            tableLayoutPanel3.Controls.Add(button3, 2, 3);
            tableLayoutPanel3.Controls.Add(button4, 0, 2);
            tableLayoutPanel3.Controls.Add(button5, 1, 2);
            tableLayoutPanel3.Controls.Add(button6, 2, 2);
            tableLayoutPanel3.Controls.Add(button7, 0, 1);
            tableLayoutPanel3.Controls.Add(button8, 1, 1);
            tableLayoutPanel3.Controls.Add(button9, 2, 1);
            tableLayoutPanel3.Controls.Add(clearButton, 0, 0);
            tableLayoutPanel3.Controls.Add(squareButton, 1, 0);
            tableLayoutPanel3.Controls.Add(reciprocalButton, 2, 0);
            tableLayoutPanel3.Controls.Add(divideButton, 3, 0);
            tableLayoutPanel3.Controls.Add(MultiplyButton, 3, 1);
            tableLayoutPanel3.Controls.Add(SubtractButton, 3, 2);
            tableLayoutPanel3.Controls.Add(AddButton, 3, 3);
            tableLayoutPanel3.Controls.Add(equalButton, 3, 4);
            tableLayoutPanel3.Controls.Add(decimalPointButton, 2, 4);
            tableLayoutPanel3.Controls.Add(button0, 1, 4);
            tableLayoutPanel3.Controls.Add(changeSignButton, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 105);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(278, 253);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 153);
            button1.Name = "button1";
            button1.Size = new Size(63, 44);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += NumberOrOperationButton_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(72, 153);
            button2.Name = "button2";
            button2.Size = new Size(63, 44);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += NumberOrOperationButton_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(141, 153);
            button3.Name = "button3";
            button3.Size = new Size(63, 44);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += NumberOrOperationButton_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLightLight;
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Fill;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(3, 103);
            button4.Name = "button4";
            button4.Size = new Size(63, 44);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += NumberOrOperationButton_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLightLight;
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Fill;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(72, 103);
            button5.Name = "button5";
            button5.Size = new Size(63, 44);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += NumberOrOperationButton_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLightLight;
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Fill;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(141, 103);
            button6.Name = "button6";
            button6.Size = new Size(63, 44);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += NumberOrOperationButton_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLightLight;
            button7.Cursor = Cursors.Hand;
            button7.Dock = DockStyle.Fill;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(3, 53);
            button7.Name = "button7";
            button7.Size = new Size(63, 44);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += NumberOrOperationButton_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLightLight;
            button8.Cursor = Cursors.Hand;
            button8.Dock = DockStyle.Fill;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(72, 53);
            button8.Name = "button8";
            button8.Size = new Size(63, 44);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += NumberOrOperationButton_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLightLight;
            button9.Cursor = Cursors.Hand;
            button9.Dock = DockStyle.Fill;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(141, 53);
            button9.Name = "button9";
            button9.Size = new Size(63, 44);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += NumberOrOperationButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Orange;
            clearButton.Cursor = Cursors.Hand;
            clearButton.Dock = DockStyle.Fill;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(3, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(63, 44);
            clearButton.TabIndex = 9;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // squareButton
            // 
            squareButton.BackColor = SystemColors.ControlLight;
            squareButton.Cursor = Cursors.Hand;
            squareButton.Dock = DockStyle.Fill;
            squareButton.FlatAppearance.BorderSize = 0;
            squareButton.FlatStyle = FlatStyle.Flat;
            squareButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            squareButton.Location = new Point(72, 3);
            squareButton.Name = "squareButton";
            squareButton.Size = new Size(63, 44);
            squareButton.TabIndex = 10;
            squareButton.Text = "x²";
            squareButton.UseVisualStyleBackColor = false;
            squareButton.Click += SquareButton_Click;
            // 
            // reciprocalButton
            // 
            reciprocalButton.BackColor = SystemColors.ControlLight;
            reciprocalButton.Cursor = Cursors.Hand;
            reciprocalButton.Dock = DockStyle.Fill;
            reciprocalButton.FlatAppearance.BorderSize = 0;
            reciprocalButton.FlatStyle = FlatStyle.Flat;
            reciprocalButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            reciprocalButton.Location = new Point(141, 3);
            reciprocalButton.Name = "reciprocalButton";
            reciprocalButton.Size = new Size(63, 44);
            reciprocalButton.TabIndex = 11;
            reciprocalButton.Text = "1/x";
            reciprocalButton.UseVisualStyleBackColor = false;
            reciprocalButton.Click += ReciprocalButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = SystemColors.ControlLight;
            divideButton.Cursor = Cursors.Hand;
            divideButton.Dock = DockStyle.Fill;
            divideButton.FlatAppearance.BorderSize = 0;
            divideButton.FlatStyle = FlatStyle.Flat;
            divideButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            divideButton.Location = new Point(210, 3);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(65, 44);
            divideButton.TabIndex = 12;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += NumberOrOperationButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.BackColor = SystemColors.ControlLight;
            MultiplyButton.Cursor = Cursors.Hand;
            MultiplyButton.Dock = DockStyle.Fill;
            MultiplyButton.FlatAppearance.BorderSize = 0;
            MultiplyButton.FlatStyle = FlatStyle.Flat;
            MultiplyButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MultiplyButton.Location = new Point(210, 53);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(65, 44);
            MultiplyButton.TabIndex = 13;
            MultiplyButton.Text = "*";
            MultiplyButton.UseVisualStyleBackColor = false;
            MultiplyButton.Click += NumberOrOperationButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.BackColor = SystemColors.ControlLight;
            SubtractButton.Cursor = Cursors.Hand;
            SubtractButton.Dock = DockStyle.Fill;
            SubtractButton.FlatAppearance.BorderSize = 0;
            SubtractButton.FlatStyle = FlatStyle.Flat;
            SubtractButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SubtractButton.Location = new Point(210, 103);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(65, 44);
            SubtractButton.TabIndex = 14;
            SubtractButton.Text = "-";
            SubtractButton.UseVisualStyleBackColor = false;
            SubtractButton.Click += NumberOrOperationButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.ControlLight;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Fill;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(210, 153);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(65, 44);
            AddButton.TabIndex = 15;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += NumberOrOperationButton_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.SkyBlue;
            equalButton.Cursor = Cursors.Hand;
            equalButton.Dock = DockStyle.Fill;
            equalButton.FlatAppearance.BorderSize = 0;
            equalButton.FlatStyle = FlatStyle.Flat;
            equalButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            equalButton.Location = new Point(210, 203);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(65, 47);
            equalButton.TabIndex = 16;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += NumberOrOperationButton_Click;
            // 
            // decimalPointButton
            // 
            decimalPointButton.BackColor = SystemColors.ControlLightLight;
            decimalPointButton.Cursor = Cursors.Hand;
            decimalPointButton.Dock = DockStyle.Fill;
            decimalPointButton.FlatAppearance.BorderSize = 0;
            decimalPointButton.FlatStyle = FlatStyle.Flat;
            decimalPointButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            decimalPointButton.Location = new Point(141, 203);
            decimalPointButton.Name = "decimalPointButton";
            decimalPointButton.Size = new Size(63, 47);
            decimalPointButton.TabIndex = 17;
            decimalPointButton.Text = ",";
            decimalPointButton.UseVisualStyleBackColor = false;
            decimalPointButton.Click += NumberOrOperationButton_Click;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlLightLight;
            button0.Cursor = Cursors.Hand;
            button0.Dock = DockStyle.Fill;
            button0.FlatAppearance.BorderSize = 0;
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(72, 203);
            button0.Name = "button0";
            button0.Size = new Size(63, 47);
            button0.TabIndex = 18;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += NumberOrOperationButton_Click;
            // 
            // changeSignButton
            // 
            changeSignButton.BackColor = SystemColors.ControlLightLight;
            changeSignButton.Cursor = Cursors.Hand;
            changeSignButton.Dock = DockStyle.Fill;
            changeSignButton.FlatAppearance.BorderSize = 0;
            changeSignButton.FlatStyle = FlatStyle.Flat;
            changeSignButton.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            changeSignButton.Location = new Point(3, 203);
            changeSignButton.Name = "changeSignButton";
            changeSignButton.Size = new Size(63, 47);
            changeSignButton.TabIndex = 19;
            changeSignButton.Text = "+/-";
            changeSignButton.UseVisualStyleBackColor = false;
            changeSignButton.Click += ChangeSignButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(300, 400);
            Name = "CalculatorForm";
            Text = "Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox expressionOnTopTextBox;
        private TextBox displayTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button clearButton;
        private Button squareButton;
        private Button reciprocalButton;
        private Button divideButton;
        private Button MultiplyButton;
        private Button SubtractButton;
        private Button AddButton;
        private Button equalButton;
        private Button decimalPointButton;
        private Button button0;
        private Button changeSignButton;
    }
}