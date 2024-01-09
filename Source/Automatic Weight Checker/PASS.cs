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
using System.Data.SqlClient;


using System.Data.Odbc; //my


namespace Automatic_Weight_Checker
{
    public partial class PASS : Form
    {
        public PASS()
        {
            InitializeComponent();
            GP_EPF = EPF.EPFNUMBER;
            A = Form1.A;
            ActWeigh = Form1.G_ActWeigh;
            P_PSNUMBER_LONG = Form1.G_PsNumber;
            P_PSNUMBER = Form1.A;
           // P_PSSUB = Form1.B;
            P_DateTime = Form1.G_DateTime;

            P_WD = Form1.G_WD;
            P_WDDEC = System.Convert.ToDecimal(P_WD);
            label3.Text = "DIF PESO: "+ P_WDDEC + " Kg";

            //P_PSNUMBER_LONG = P_PSNUMBER + P_PSSUB;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            APLMS();

            //PsssSignalTrue();
        }

        decimal ActWeigh = 0;
        string P_PSNUMBER = string.Empty;
        //string P_PSSUB = string.Empty;
        string P_PSNUMBER_LONG = string.Empty;
        string P_LOCATION = string.Empty;
        string P_BOXSIZE = string.Empty;
        string G_BoxType = string.Empty;
        //public static String G_EPF = string.Empty;
        string GP_EPF = string.Empty;
        public static string A = string.Empty;
        string CUST = string.Empty;
        string CusGroup = string.Empty;

        string P_DateTime = string.Empty;

        string P_WD = string.Empty;
        decimal P_WDDEC = 0;

        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 FB = new Form1();
            FB.ShowDialog();
            this.Close();
        }

        private void APLMS()
        {
            DateTime TodayDate3 = Convert.ToDateTime(DateTime.Now);

            try
            {
                PrintFuntion();
 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Hide();
                Form1 FB = new Form1();
                FB.ShowDialog();
                this.Close();


            }



        }
        private void PrintFuntion()
        {
            string myf1 = @"C:\APLTS\TAG1.xlsx";
            var exelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = exelApp.Workbooks.Open(myf1);

           Microsoft.Office.Interop.Excel.Range rang = exelApp.Cells[2, "A"];
            rang.Value2 = A;// P_PSNUMBER;

            //Microsoft.Office.Interop.Excel.Range rang2 = exelApp.Cells[3, "A"];
            //rang2.Value2 = P_PSSUB;

            //Microsoft.Office.Interop.Excel.Range rang3 = exelApp.Cells[7, "A"];
            //rang3.Value2 = P_LOCATION.Substring(0, 3);

            //Microsoft.Office.Interop.Excel.Range rang7 = exelApp.Cells[12, "B"];
            Microsoft.Office.Interop.Excel.Range rang7 = exelApp.Cells[7, "A"];
            rang7.Value2 = "AGW : " + (ActWeigh).ToString() + " Kg";

            //Microsoft.Office.Interop.Excel.Range rang9 = exelApp.Cells[12, "A"];
            Microsoft.Office.Interop.Excel.Range rang9 = exelApp.Cells[6, "A"];
            rang9.Value2 = "EPF: " + GP_EPF;

            //Microsoft.Office.Interop.Excel.Range rang11 = exelApp.Cells[11, "A"];
            Microsoft.Office.Interop.Excel.Range rang11 = exelApp.Cells[5, "A"];
            //rang11.Value2 = "PACKING DATE: " + P_DateTime;
            rang11.Value2 = P_DateTime;

            //System.DateTime.Now.Date.ToString("yyyy-MM-dd")

            //DateTime TodayDate3 = Convert.ToDateTime(DateTime.Now);

            ////********************************* 

            var printers = System.Drawing.Printing.PrinterSettings.InstalledPrinters;

            int printerIndex = 0;

            foreach (String s in printers)
            {
                //if (s.Equals("ZDesigner GT800 (EPL)"))
                if (s.Equals("ZDesigner ZD420-203dpi ZPL")) //Producción
                {
                    break;
                }
                printerIndex++;
            }

            workbook.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing, printers[printerIndex], Type.Missing, Type.Missing, Type.Missing);
            workbook.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing, printers[printerIndex], Type.Missing, Type.Missing, Type.Missing);

            //******************************


            Microsoft.Office.Interop.Excel.Range rang4 = exelApp.Cells[2, "A"];
           rang4.Value2 = null;


            Microsoft.Office.Interop.Excel.Range rang5 = exelApp.Cells[3, "A"];
            rang5.Value2 = null;

            Microsoft.Office.Interop.Excel.Range rang6 = exelApp.Cells[7, "A"];
            rang6.Value2 = null;

            //Microsoft.Office.Interop.Excel.Range rang8 = exelApp.Cells[12, "B"];
            //rang8.Value2 = null;

            //Microsoft.Office.Interop.Excel.Range rang10 = exelApp.Cells[12, "A"];
            Microsoft.Office.Interop.Excel.Range rang10 = exelApp.Cells[6, "A"];
            rang10.Value2 = null;

            //Microsoft.Office.Interop.Excel.Range rang12 = exelApp.Cells[11, "A"];
            Microsoft.Office.Interop.Excel.Range rang12 = exelApp.Cells[5, "A"];
            rang12.Value2 = null;

            workbook.Save();
            workbook.Close();

            //this.Hide();
            //this.Close();
        }

    }
}
