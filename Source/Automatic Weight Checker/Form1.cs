// AWC V2.0
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Data.Odbc;
using System.Configuration;

namespace Automatic_Weight_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            G_EPF = EPF.EPFNUMBER;
            F_LD_EPFNUMBER.Text = EPF.EPFNUMBER;
        }

        public static String G_EPF = string.Empty;
        public static String G_Static = string.Empty;
        public static String G_PsNumber = string.Empty;
        public static String G_BoxType = string.Empty;
        public static String G_WD = string.Empty;
        public static decimal G_ActWeigh = 0;
        public static decimal G_SysWeigh = 0;
        public static String G_ATMP = "";
        public static decimal G_SUM_PKH = 0;
        public static string A = string.Empty;
        public static string pkg = string.Empty;
        public static string B = string.Empty;
        public static string G_DateTime = string.Empty;
        public static decimal G_WTU = 0 + Convert.ToDecimal(ConfigurationManager.AppSettings["weightThresholdUp"]);
        public static decimal G_WTD = 0 - Convert.ToDecimal(ConfigurationManager.AppSettings["weightThresholdDown"]);
        public static decimal WD_G = 0;
        public static uint paquetes = 0;

        SqlConnection SQL_LKA_AWS = new SqlConnection(@"Server = 10.241.135.170; Database=LKA_AWS;User Id = weightChecker; password=weightChecker01$");// Base de Producción
        SqlConnection SQL_LKA_PTDB = new SqlConnection(@"Server = 10.241.135.170; Database=APLTSP;User Id = weightChecker; password=weightChecker01$"); // Base de Producción
        OdbcConnection ODBC_LKA_PTDB = new OdbcConnection(@"Dsn=YKK_Lanka;Uid=ITLKA01;Pwd=YKK@1234"); // Base de Producción
        
        private void pkgTxt_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            { 
                if (pkgTxt.TextLength == 10) { 
                    try
                        {
                            G_PsNumber = pkgTxt.Text;
                            A = pkgTxt.Text.Substring(0, 10);
                            pkg = A;
                            pkgLbl.Text = "PKG NO.: " + A;
                            GetSySWeight();
                        }
                    catch (Exception EX)
                        {
                            MessageBox.Show(EX.Message.ToString(), "KeyDown");
                            this.Hide();
                            Form1 FB = new Form1();
                            FB.ShowDialog();
                            this.Close();
                        }
                    finally
                        {
                            G_Static = string.Empty;
                            //G_PsNumber = string.Empty;
                            G_ActWeigh = 0;
                            G_SysWeigh = 0;
                           // A = string.Empty;
                            //B = string.Empty;
                        }
                } else
                    {
                        MessageBox.Show("En número de paquete debe de ser de 10 Caracteres");
                        this.Hide();
                        Form1 FB = new Form1();
                        FB.ShowDialog();
                        this.Close();
                }
            }
        }

        private void GetSySWeight()
        {
            OdbcCommand ReadOdbc10 = new OdbcCommand("SELECT  DCSNV1 AS SUBNUMBER,ITMCV1 AS ITEM,LNGVV1 AS LENGTH,LUNCV1 AS UOL,CLRCV1 AS COLOR ,QTYQV1 AS QTY,QUNCV1 AS UOQ,NETWV1 AS WEIGHT FROM VCS87V1 WHERE DECNV1 = '" + A + "'", ODBC_LKA_PTDB);
            try
            {

                valoresGv.Visible = true;
                validarBtn.Visible = true;
                pictureBox1.Visible = false;
                ReadOdbc10.Connection.Open();
                OdbcDataAdapter sda = new OdbcDataAdapter(ReadOdbc10);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0) {

                    valoresGv.AutoGenerateColumns = false;
                    valoresGv.DataSource = dt;
                    DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                    checkBoxColumn.HeaderText = "";
                    checkBoxColumn.Width = 30;
                    checkBoxColumn.Name = "checkBoxColumn";
                    valoresGv.Columns.Insert(0, checkBoxColumn);
                } else
                {
                    MessageBox.Show("El PK no existe");

                }
                ReadOdbc10.Connection.Close();
            }
            catch (Exception EX)
            {
                ReadOdbc10.Connection.Close();
                MessageBox.Show(EX.Message.ToString(), "GetSySWeight");
            }
            finally
            {

            }

            ReadOdbc10 = new OdbcCommand("SELECT AWCNV1 AS ATTEMPT FROM VCS87V1 WHERE DECNV1 = '" + A + "' GROUP BY AWCNV1", ODBC_LKA_PTDB);
            try
            {
                ReadOdbc10.Connection.Open();
                OdbcDataAdapter sda = new OdbcDataAdapter(ReadOdbc10);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow[] dr = dt.Select();
                    foreach (DataRow row in dr) {
                        G_ATMP = row["ATTEMPT"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("El PK no existe");

                }
                ReadOdbc10.Connection.Close();
            }
            catch (Exception EX)
            {
                ReadOdbc10.Connection.Close();
                MessageBox.Show(EX.Message.ToString(), "GetSySWeight");
            }
            finally
            {

            }
        }
        private void GetActWeight()
        {
            SerialPort SP;
            SP = new SerialPort();
            try
            {

                SP.PortName = "COM5";
                SP.Encoding = System.Text.Encoding.ASCII;
                SP.BaudRate = 9600;
                SP.DataBits = 8;
                SP.Parity = Parity.None;
                SP.NewLine = "\r\n";
                SP.Open();
                SP.ReadTimeout = 5000;
                label1.Text = "";
                string message = SP.ReadLine();
                
               label1.Text = message.Trim(new char[] { 'S', 'g', ' ', 'D', 'w', 'W', 'K', 'G', 'k', 'g' });

               G_ActWeigh = (Convert.ToDecimal(message.Trim(new char[] { 'S', 'g', ' ', 'D', 'w', 'W', 'K', 'G', 'k', 'g','=','(',')' })));

                SP.Close();

                GetStatic();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString(), "GetActWeight");
            }
        } 
        private void GetStatic()
        {
          try
            {
               G_Static = "111";
                ItemChecker();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString(), "GetStatic");
            }
        } 

        private void ItemChecker()
        {
            decimal WD = G_ActWeigh - G_SUM_PKH;
            WD_G = WD;
            G_WD = WD.ToString();
            try
            {
                if (G_Static == "111")
                {
                   if (WD < G_WTD || WD > G_WTU )
                    {
                    
                    FailSaveToSQLHistory();
                    FailSaveToWINGSHistory();
                    this.Hide();
                    FAIL FB = new FAIL();
                    FB.ShowDialog();
                    this.Close();
                    }
                    else
                    {
                        PsssSaveToSQLHistory();
                        PassSaveToWINGSHistory();
                        this.Hide();
                        PASS FB = new PASS();
                        FB.ShowDialog();
                        this.Close();
                    }
                }
               
                else
                {
                    MessageBox.Show("Pls, Check Manual weight");
                }
               
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString(), "ItemChecker2");
            }
        } 
        private void PsssSaveToSQLHistory()
        {
            string DATE = System.DateTime.Now.Date.ToString("yyyy-MM-dd");

            string Time = System.DateTime.Now.ToString("HH:mm:ss");

            G_DateTime = DATE + " " + Time;
            try
            {
                string SQLC = "INSERT INTO AWDATAH (PSNUMH,SYSWGH,ACTWGH,RESULH,REGDTA,REGTMA,EPFNMH ) values('" + G_PsNumber + "', '" + G_SysWeigh.ToString() + "', '" + G_ActWeigh.ToString() + "', '1','" + DATE + "','" + Time + "','" + G_EPF + "')";

                SQL_LKA_AWS.Open();
                SqlCommand Dread = new SqlCommand(SQLC, SQL_LKA_AWS);
                SqlDataReader Dread2;
                Dread2 = Dread.ExecuteReader();
                SQL_LKA_AWS.Close();

                string SQLCC = "INSERT INTO AWDATAT (PSNUMT,SYSWGT,ACTWGT,RESULT,REGDTT,REGTMT,EPFNMT ) values('" + G_PsNumber + "', '" + G_SysWeigh.ToString() + "', '" + G_ActWeigh.ToString() + "', '1','" + DATE + "','" + Time + "','" + G_EPF + "')";

                SQL_LKA_AWS.Open();
                SqlCommand DreadD = new SqlCommand(SQLCC, SQL_LKA_AWS);
                SqlDataReader Dread2D;
                Dread2D = DreadD.ExecuteReader();
                SQL_LKA_AWS.Close();


            }
            catch (Exception)
            {
                SQL_LKA_AWS.Close();


                string SQLC1 = "UPDATE AWDATAT set ACTWGT='" + G_ActWeigh.ToString() + "',RESULT='1',REGDTT='" + DATE + "',REGTMT='" + Time + "',EPFNMT='" + G_EPF + "' WHERE PSNUMT='" + G_PsNumber + "' ";

                SQL_LKA_AWS.Open();
                SqlCommand Dread = new SqlCommand(SQLC1, SQL_LKA_AWS);
                _ = Dread.ExecuteReader();
                SQL_LKA_AWS.Close();
            }
        } // AWS

        private void PassSaveToWINGSHistory()
        {
            uint fecha = Convert.ToUInt32(System.DateTime.Now.Date.ToString("yyyyMMdd"));
            uint ATMP;
            if ( String.IsNullOrWhiteSpace(G_ATMP) )
            {
              ATMP   = 1;
            } else
            {
                ATMP = Convert.ToUInt32(G_ATMP.Remove(0, 10)) + 1;
            }
            
            string F_ATMP = pkg + ATMP.ToString().PadLeft(3, '0');
            uint hora = Convert.ToUInt32(System.DateTime.Now.ToString("HHmmss"));
            
            try
            {
                OdbcCommand ReadOdbc10 = new OdbcCommand("UPDATE WAVEDLIB.VCS87V1 SET AWCNV1='" + F_ATMP + "',AWCWV1=" + G_ActWeigh + ", AWCGV1=" + WD_G + ", AWCUV1='" + G_EPF + "', AWCFV1='PASS',AWCDV1=" + fecha + ",AWCTV1=" + hora + " WHERE DECNV1='" + pkg + "'", ODBC_LKA_PTDB);
                ReadOdbc10.Connection.Open();
                OdbcDataAdapter sda = new OdbcDataAdapter(ReadOdbc10);
                ReadOdbc10.ExecuteNonQuery();
                ReadOdbc10.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "PassSaveToWINGSHistory");
            } // AWS
        }
        private void FailSaveToSQLHistory()
        {
            string DATE = System.DateTime.Now.Date.ToString("yyyyMMdd");

            string Time = System.DateTime.Now.ToString("HH:mm:ss");

            try
            {
                string SQLC = "INSERT INTO AWDATAH (PSNUMH,SYSWGH,ACTWGH,RESULH,REGDTA,REGTMA,EPFNMH ) values('" + G_PsNumber + "', '" + G_SysWeigh.ToString() + "', '" + G_ActWeigh.ToString() + "', '2','" + DATE + "','" + Time + "','" + G_EPF + "')";

                SQL_LKA_AWS.Open();
                SqlCommand Dread = new SqlCommand(SQLC, SQL_LKA_AWS);
                SqlDataReader Dread2;
                Dread2 = Dread.ExecuteReader();
                SQL_LKA_AWS.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        } // AWS

        private void FailSaveToWINGSHistory()
        {
            uint fecha = Convert.ToUInt32(System.DateTime.Now.Date.ToString("yyyyMMdd"));
            uint ATMP;
            if (String.IsNullOrWhiteSpace(G_ATMP))
            {
                ATMP = 1;
            }
            else
            {
                ATMP = Convert.ToUInt32(G_ATMP.Remove(0, 10)) + 1;
            }
            string F_ATMP = pkg  + ATMP.ToString().PadLeft(3, '0');
            uint hora = Convert.ToUInt32(System.DateTime.Now.ToString("HHmmss"));
            
            try
            {
                OdbcCommand ReadOdbc10 = new OdbcCommand("UPDATE WAVEDLIB.VCS87V1 SET AWCNV1='" + F_ATMP + "',AWCWV1=" + G_ActWeigh + ", AWCGV1=" + WD_G + ", AWCUV1='" + G_EPF + "', AWCFV1='FAIL',AWCDV1=" + fecha + ",AWCTV1=" + hora + " WHERE DECNV1='" + pkg + "'", ODBC_LKA_PTDB);
              
                ReadOdbc10.Connection.Open();
                OdbcDataAdapter sda = new OdbcDataAdapter(ReadOdbc10);
                ReadOdbc10.ExecuteNonQuery();
                ReadOdbc10.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "FailSaveToWINGSHistory");
            }
        } // AWS

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FB = new Form1();
            FB.ShowDialog();
            this.Close();

        }
        private void B_Exit_Click(object sender, EventArgs e) // AWS
        {
            this.Hide();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F_LD_EPFNUMBER.Text = "EPF: " + EPF.EPFNUMBER;
            pkgTxt.Show();
            validarBtn.Visible = false;
            valoresGv.Visible = false;

        }

        private void validarBtn_Click(object sender, EventArgs e)
        {
           try {
                
                string message = string.Empty;
                decimal suma = 0;
                paquetes = 1;

                foreach (DataGridViewRow row in valoresGv.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                    if (isSelected)
                    {
                        suma += Convert.ToDecimal(row.Cells["WEIGHT"].Value.ToString());
                        paquetes += 1;
                    }
                }
                if ( suma > 0)
                {
                    G_SUM_PKH = suma;
                    GetActWeight();
                } else
                {
                    MessageBox.Show("No has seleccionado ningún registro");
                    return;
                }
              
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString(), "Botón Validar");
            }
            finally
            {

            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FB = new Form1();
            FB.ShowDialog();
            this.Close();
        }
    }
}
