namespace Kalkulator_BMI
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
            label_wzrost = new Label();
            label_waga = new Label();
            button_oblicz = new Button();
            textBox_wzrost = new TextBox();
            textBox_waga = new TextBox();
            label_bmi = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label_wzrost
            // 
            label_wzrost.AutoSize = true;
            label_wzrost.Font = new Font("Segoe UI", 15F);
            label_wzrost.Location = new Point(138, 103);
            label_wzrost.Name = "label_wzrost";
            label_wzrost.Size = new Size(108, 28);
            label_wzrost.TabIndex = 0;
            label_wzrost.Text = "Wzrost [m]";
            // 
            // label_waga
            // 
            label_waga.AutoSize = true;
            label_waga.Font = new Font("Segoe UI", 15F);
            label_waga.Location = new Point(358, 103);
            label_waga.Name = "label_waga";
            label_waga.Size = new Size(101, 28);
            label_waga.TabIndex = 1;
            label_waga.Text = "Waga [kg]";
            // 
            // button_oblicz
            // 
            button_oblicz.Font = new Font("Segoe UI", 15F);
            button_oblicz.Location = new Point(197, 200);
            button_oblicz.Name = "button_oblicz";
            button_oblicz.Size = new Size(200, 37);
            button_oblicz.TabIndex = 2;
            button_oblicz.Text = "Oblicz BMI";
            button_oblicz.UseVisualStyleBackColor = true;
            button_oblicz.Click += button_oblicz_Click;
            // 
            // textBox_wzrost
            // 
            textBox_wzrost.Location = new Point(138, 134);
            textBox_wzrost.Name = "textBox_wzrost";
            textBox_wzrost.Size = new Size(100, 23);
            textBox_wzrost.TabIndex = 3;
            // 
            // textBox_waga
            // 
            textBox_waga.Location = new Point(358, 134);
            textBox_waga.Name = "textBox_waga";
            textBox_waga.Size = new Size(100, 23);
            textBox_waga.TabIndex = 4;
            // 
            // label_bmi
            // 
            label_bmi.AutoSize = true;
            label_bmi.Font = new Font("Segoe UI", 15F);
            label_bmi.Location = new Point(192, 265);
            label_bmi.Name = "label_bmi";
            label_bmi.Size = new Size(105, 28);
            label_bmi.TabIndex = 5;
            label_bmi.Text = "Twoje BMI:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(138, 342);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(293, 43);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label_bmi);
            Controls.Add(textBox_waga);
            Controls.Add(textBox_wzrost);
            Controls.Add(button_oblicz);
            Controls.Add(label_waga);
            Controls.Add(label_wzrost);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private ProgressBar progressBar1;
        private Button button_oblicz;
        private Label label_waga;
        private Label label_wzrost;
        private TextBox textBox_wzrost;
        private TextBox textBox_waga;
        private Label label_bmi;
    }
}
