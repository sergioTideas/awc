// AWC V2.0

using System;
using System.Windows.Forms;


namespace Automatic_Weight_Checker
{
    public partial class EPF : Form
    {
        public EPF()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        public static String EPFNUMBER = string.Empty;

        private void EPF_Load(object sender, EventArgs e)
        {
           
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EPFNUMBER = textBox1.Text;

                if (EPFNUMBER == "")
                {
                    MessageBox.Show("Debes ingresar tu número de empleado");
                    return;

                }
                else if (EPFNUMBER.Length > 6 ){
                    
                    MessageBox.Show("Tu número de empleado no puede exceder de 6 Caracteres");
                    return;

                } else
                {
                    this.Hide();
                    Form1 FB = new Form1();
                    FB.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void nuevoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EPF FB = new EPF();
            FB.ShowDialog();
            this.Close();
        }
    }
}
