using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Threading;
using System.Data.Odbc; //my


namespace Automatic_Weight_Checker
{
    public partial class FAIL : Form
    {
        public FAIL()
        {
            InitializeComponent();
            P_WD = Form1.G_WD;
            A = Form1.A;
            label3.Text = "Diferencia: " + P_WD + " Kilogramos";
            G_EPF = EPF.EPFNUMBER;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //PsssSignalFals();

        }
        public static String G_EPF = string.Empty;
        public static string A = string.Empty;
        string P_WD = string.Empty;
        OdbcConnection ODBC_LKA_PTDB = new OdbcConnection(@"Dsn=YKK_Lanka;Uid=ITLKA01;Pwd=YKK@1234"); // Base de Producción
        //OdbcConnection ODBC_LKA_PTDB = new OdbcConnection(@"Dsn=YKK_Lanka;Uid=SA;Pwd=Tideas01$"); // Base de Desarrollo
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(() => { Thread.Sleep(2000); Invoke(new Action(MyCode)); });
        }

        private void MyCode()
        {
            //------ CambiadoInputFromArduino();
        }

        private void PsssSignalFals()
        {
            SerialPort SP;
            SP = new SerialPort();
            try
            {
                SP.PortName = "COM5";
                SP.Encoding = Encoding.ASCII;
                SP.BaudRate = 9600;
                SP.DataBits = 8;
                SP.StopBits = StopBits.One;
                SP.Parity = Parity.None;
                SP.ReadBufferSize = 4096;
                SP.NewLine = "\r\n";
                SP.Handshake = Handshake.XOnXOff;
                SP.ReceivedBytesThreshold = 100000;

                SP.Open();
                SP.WriteLine("F");
                SP.Close();

            }
            catch (Exception EX)
            {
                SP.Close();
                MessageBox.Show(EX.Message.ToString());

            }
            finally
            {

            }

        }

        private void InputFromArduino()
        {
            SerialPort SPS;
            SPS = new SerialPort();
            SPS.PortName = "COM5";
            SPS.BaudRate = 9600;
            try
            {
                SPS.Open();
                while (true)
                {
                    if (SPS.ReadExisting().ToString() == "H")
                    {
                        SPS.Close();
                        this.Hide();
                        Form1 FB = new Form1();
                        FB.ShowDialog();
                        this.Close();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {
                SPS.Close();
            }
            finally
            {
                //this.Hide();
                //Form1 FB = new Form1();
                //FB.ShowDialog();
                //this.Close();
            }
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FB = new Form1();
            FB.ShowDialog();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FAIL_Load(object sender, EventArgs e)
        {

        }
        //private void FailSaveToWINGSHistory()
        //{
        //    string DATE = System.DateTime.Now.Date.ToString("yyyyMMdd");

        //    string Time = System.DateTime.Now.ToString("HHmmss");

        //    try
        //    {
        //        OdbcCommand ReadOdbc10 = new OdbcCommand("UPDATE VCS87V1 SET  AWCNV1='" + A + "0001" + "',AWCWV1=20, AWCGV1=10, AWCUV1='" + G_EPF + "', AWCFV1='FAIL', AWCDV1=" + DATE + ", AWCTV1=" + Time + " WHERE DECNV1 = '" + A + "'", ODBC_LKA_PTDB);
        //        ReadOdbc10.Connection.Open();
        //        OdbcDataAdapter sda = new OdbcDataAdapter(ReadOdbc10);
        //        OdbcDataReader Dread2;
        //        Dread2 = ReadOdbc10.ExecuteReader();
        //        ReadOdbc10.Connection.Close();


        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //} // AWS
    }
}
