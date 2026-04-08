namespace Kalkulator_BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 16;
            progressBar1.Maximum = 40;
        }

        private void oblicz_button_Click(object sender, EventArgs e)
        {

        }

        private void button_oblicz_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_waga.Text, out double waga))
            {
                if (double.TryParse(textBox_wzrost.Text, out double wzrost))
                {
                    if (!(waga > 0 && wzrost > 0))
                    {
                        MessageBox.Show("wzrost i waga muszą być większe od 0");
                        return;
                    }

                    double BMI = waga / (wzrost * wzrost);
                    label_bmi.Text = "Twoje BMI: " + $"{BMI:F2}";

                    BMI = Math.Clamp(BMI, 16, 40);
                    progressBar1.Value = (int)BMI;

                    if (BMI < 16)
                    {
                        label_bmi.Text += " - wygłodzenie";
                    }
                    else if (BMI < 17)
                    {
                        label_bmi.Text += " - wychudzenie";
                    }
                    else if (BMI < 18.5)
                    {
                        label_bmi.Text += " - niedowaga";
                    }
                    else if (BMI < 25)
                    {
                        label_bmi.Text += " - pożądana masa ciała";
                    }
                    else if (BMI < 30)
                    {
                        label_bmi.Text += " - nadwaga";
                    }
                    else if (BMI < 35)
                    {
                        label_bmi.Text += " - otyłość 1 stopnia";
                    }
                    else if (BMI < 40)
                    {
                        label_bmi.Text += " - otyłość 2 stopnia";
                    }
                    else
                    {
                        label_bmi.Text += " - otyłość 3 stopnia";
                    }
                }
                else
                {
                    MessageBox.Show("Źle wpisano wzrost");
                }
            }
            else
            {
                MessageBox.Show("Źle wpisano wage");
            }
        }
    }
}
