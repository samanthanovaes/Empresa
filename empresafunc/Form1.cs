using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace empresafunc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse(dateTimePicker1.Text);
            double salario = Convert.ToDouble(textBox12.Text);
            Funcionario s = new Funcionario(textBox1.Text, textBox2.Text, maskedTextBox1.Text, textBox5.Text, textBox3.Text, textBox6.Text, textBox7.Text, textBox8.Text,
            textBox9.Text, dateTime, textBox10.Text, comboBox1.Text, salario);
            if (Validacao.CPF(maskedTextBox1.Text))
            {
                if (Validacao.Email(textBox6.Text))
                {
                    MessageBox.Show("Salvo com sucesso.");

                }
                else
                {
                    MessageBox.Show("Email inváido. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Erro. CPF falso.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}