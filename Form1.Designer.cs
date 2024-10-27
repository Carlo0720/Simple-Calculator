namespace Calculator
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
            TxtDisplay = new TextBox();
            btn_7 = new Button();
            btn_8 = new Button();
            btn_9 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            plus_btn = new Button();
            btn_0 = new Button();
            minus_btn = new Button();
            divide_btn = new Button();
            multiply_btn = new Button();
            clear_btn = new Button();
            equals_btn = new Button();
            SuspendLayout();
            // 
            // TxtDisplay
            // 
            TxtDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDisplay.Location = new Point(12, 12);
            TxtDisplay.Multiline = true;
            TxtDisplay.Name = "TxtDisplay";
            TxtDisplay.Size = new Size(282, 66);
            TxtDisplay.TabIndex = 0;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_7.Location = new Point(12, 117);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(66, 52);
            btn_7.TabIndex = 1;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_8.Location = new Point(84, 117);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(66, 52);
            btn_8.TabIndex = 2;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_9.Location = new Point(156, 117);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(66, 52);
            btn_9.TabIndex = 3;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_6.Location = new Point(12, 175);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(66, 52);
            btn_6.TabIndex = 4;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_5.Location = new Point(84, 175);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(66, 52);
            btn_5.TabIndex = 5;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_4.Location = new Point(156, 175);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(66, 52);
            btn_4.TabIndex = 6;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_3.Location = new Point(12, 233);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(66, 52);
            btn_3.TabIndex = 7;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_2.Location = new Point(84, 233);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(66, 52);
            btn_2.TabIndex = 8;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_1.Location = new Point(156, 233);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(66, 52);
            btn_1.TabIndex = 9;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // plus_btn
            // 
            plus_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            plus_btn.Location = new Point(228, 291);
            plus_btn.Name = "plus_btn";
            plus_btn.Size = new Size(66, 52);
            plus_btn.TabIndex = 10;
            plus_btn.Text = "+";
            plus_btn.UseVisualStyleBackColor = true;
            plus_btn.Click += plus_btn_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_0.Location = new Point(84, 291);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(66, 52);
            btn_0.TabIndex = 11;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // minus_btn
            // 
            minus_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            minus_btn.Location = new Point(228, 233);
            minus_btn.Name = "minus_btn";
            minus_btn.Size = new Size(66, 52);
            minus_btn.TabIndex = 12;
            minus_btn.Text = "-";
            minus_btn.UseVisualStyleBackColor = true;
            minus_btn.Click += minus_btn_Click;
            // 
            // divide_btn
            // 
            divide_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            divide_btn.Location = new Point(228, 175);
            divide_btn.Name = "divide_btn";
            divide_btn.Size = new Size(66, 52);
            divide_btn.TabIndex = 13;
            divide_btn.Text = "/";
            divide_btn.UseVisualStyleBackColor = true;
            divide_btn.Click += divide_btn_Click;
            // 
            // multiply_btn
            // 
            multiply_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiply_btn.Location = new Point(228, 117);
            multiply_btn.Name = "multiply_btn";
            multiply_btn.Size = new Size(66, 52);
            multiply_btn.TabIndex = 14;
            multiply_btn.Text = "*";
            multiply_btn.UseVisualStyleBackColor = true;
            multiply_btn.Click += multiply_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clear_btn.Location = new Point(12, 291);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(66, 52);
            clear_btn.TabIndex = 15;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // equals_btn
            // 
            equals_btn.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            equals_btn.Location = new Point(156, 291);
            equals_btn.Name = "equals_btn";
            equals_btn.Size = new Size(66, 52);
            equals_btn.TabIndex = 16;
            equals_btn.Text = "=";
            equals_btn.UseVisualStyleBackColor = true;
            equals_btn.Click += equals_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 358);
            Controls.Add(equals_btn);
            Controls.Add(clear_btn);
            Controls.Add(multiply_btn);
            Controls.Add(divide_btn);
            Controls.Add(minus_btn);
            Controls.Add(btn_0);
            Controls.Add(plus_btn);
            Controls.Add(btn_1);
            Controls.Add(btn_2);
            Controls.Add(btn_3);
            Controls.Add(btn_4);
            Controls.Add(btn_5);
            Controls.Add(btn_6);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(TxtDisplay);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtDisplay;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button plus_btn;
        private Button btn_0;
        private Button minus_btn;
        private Button divide_btn;
        private Button multiply_btn;
        private Button clear_btn;
        private Button equals_btn;
    }
}