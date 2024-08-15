namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
              
                if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxCorreo.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxMensaje.Text))
                {
                    
                    LabelEstado.Text = "Por favor, complete todos los campos.";
                    LabelEstado.ForeColor = Color.Red;
                }
                else
                {
                    
                    LabelEstado.Text = "Formulario enviado correctamente.";
                    LabelEstado.ForeColor = Color.Green;

                  
                    TextBoxNombre.Clear();
                    TextBoxCorreo.Clear();
                    TextBoxMensaje.Clear();
                }
            }

        }
    }
