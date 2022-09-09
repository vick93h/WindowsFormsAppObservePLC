using Sharp7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppObservePLC
{
    public partial class Form1 : Form
    {
        List<string> functionLettura = new List<string>();
        private S7Client client;
        private byte[] BufferLettura;
        //sposta la form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        //

        public Form1()
        {
            InitializeComponent();    
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxOn.Image = WindowsFormsAppObservePLC.Properties.Resources.buttons_on;
            pictureBoxOff.Image = WindowsFormsAppObservePLC.Properties.Resources.buttons_off;
            CheckLettura.Enabled = false;
            getButton.Enabled = false;
            ScriviButton.Enabled = false;
            label4.Text = "Non Connesso";
            //creo lista funzioni da scegliere
            functionLettura.Add("GetBitAt");
            functionLettura.Add("GetSIntAt");
            functionLettura.Add("GetIntAt");
            functionLettura.Add("GetDIntAt");
            functionLettura.Add("GetLIntAt");
            functionLettura.Add("GetUSIntAt");
            functionLettura.Add("GetUIntAt");
            functionLettura.Add("GetUDIntAt");
            functionLettura.Add("GetULIntAt");
            functionLettura.Add("GetByteAt");
            functionLettura.Add("GetWordAt");
            functionLettura.Add("GetDWordAt");
            functionLettura.Add("GetLWordAt");
            functionLettura.Add("GetRealAt");
            functionLettura.Add("GetLRealAt");
            functionLettura.Add("GetDateTimeAt");
            functionLettura.Add("GetDateAt");
            functionLettura.Add("GetTODAt");
            functionLettura.Add("GetLTODAt");
            functionLettura.Add("GetLDTAt");
            functionLettura.Add("GetDTLAt");
            functionLettura.Add("GetStringAt");
            functionLettura.Add("GetCharsAt");
        }

   
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = WindowsFormsAppObservePLC.Properties.Resources.close_red;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = WindowsFormsAppObservePLC.Properties.Resources.close_button;
        }

        private void buttonMinimize_MouseEnter(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = WindowsFormsAppObservePLC.Properties.Resources.minimize_btn_blue;
        }

        private void buttonMinimize_MouseLeave(object sender, EventArgs e)
        {
            buttonMinimize.BackgroundImage = WindowsFormsAppObservePLC.Properties.Resources.minimize_button;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Connetti_Click(object sender, EventArgs e)
        {
            client = new S7Client();
            string ip = textBoxIP.Text.ToString();
            int rank = ConverterInteger(textBoxRank.Text.ToString());
            int slot = ConverterInteger(textBoxSlot.Text.ToString());
            try
            {
                int result = client.ConnectTo(ip, rank, slot);
                if (result == 0)
                {
                    pictureBoxOn.Image=WindowsFormsAppObservePLC.Properties.Resources.on_unscreen;
                    pictureBoxOff.Image = WindowsFormsAppObservePLC.Properties.Resources.buttons_off;
                    CheckLettura.Enabled = true;
                    label4.Text = "Connesso";

                }
                else
                {
                    CheckLettura.Enabled = false;
                    label4.Text = "Non Connesso";
                    pictureBoxOn.Image = WindowsFormsAppObservePLC.Properties.Resources.buttons_on;
                    pictureBoxOff.Image = WindowsFormsAppObservePLC.Properties.Resources.off_unscreen;
                    MessageBox.Show(client.ErrorText(result));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }
        public int ConverterInteger(string s)
        {
            try
            {
                if (s != "" && s != " ")
                    return int.Parse(s);
                else
                    return 0;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

        }

        private void CheckLettura_Click(object sender, EventArgs e)
        {
            int NumDb = ConverterInteger(textBoxNDB.Text.ToString());
            int dim = ConverterInteger(textBoxSizeBuffer.Text.ToString());
            BufferLettura = new byte[dim];
            try
            {
                int i = client.DBRead(NumDb, 0, BufferLettura.Length, BufferLettura);
                if (i == 0)
                {
                    MessageBox.Show("Sono entrato nella DB!");
                    comboBoxFunGet.DataSource = functionLettura;
                    getButton.Enabled = true;
                    ScriviButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Attenzione Lettura DB fallita!,controllare i parametri!");
                    getButton.Enabled = false;
                    ScriviButton.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [Obsolete]
        private void getButton_Click(object sender, EventArgs e)
         {
            int size = 0;
            int  bit=0;
            string func = comboBoxFunGet.SelectedItem.ToString();
            if (func == "GetBitAt") {
                bit = ConverterInteger(textBox8.Text.ToString());
            }
            if (func == "GetCharsAt")
            {
               size = ConverterInteger(textBox1.Text.ToString());
            }
            int pos = ConverterInteger(textBox7.Text.ToString());
            switch(func)
            {
                case "GetBitAt":    
                    bool r = S7.GetBitAt(BufferLettura, pos, bit);
                    textBoxVisualizza.Text = r.ToString();
                    break;

                case "GetSIntAt":    
                    int r1 = S7.GetSIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r1.ToString();
                    break;
                case "GetIntAt":    
                    int r2 = S7.GetIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r2.ToString();
                    break;
                case "GetDIntAt":   
                    int r3 = S7.GetDIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r3.ToString();
                    break;
                case "GetLIntAt":
                    long r4 = S7.GetLIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r4.ToString();
                    break;
                case "GetUSIntAt":
                    byte r5 = S7.GetUSIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r5.ToString();
                    break;
                case "GetUIntAt":
                    ushort r6 = S7.GetUIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r6.ToString();
                    break;
                case "GetUDIntAt":
                    uint r7 = S7.GetUDIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r7.ToString();
                    break;
                case "GetULIntAt":
                    ulong r8 = S7.GetULIntAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r8.ToString();
                    break;
                case "GetByteAt":
                    byte r9 = S7.GetByteAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r9.ToString();
                    break;
                case "GetWordAt":
                    ushort r10 = S7.GetWordAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r10.ToString();
                    break;
                case "GetDWordAt":
                    uint r11 = S7.GetDWordAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r11.ToString();
                    break;
                case "GetLWordAt":
                    ulong r12 = S7.GetLWordAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r12.ToString();
                    break;
                case "GetRealAt":
                    float r13 = S7.GetRealAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r13.ToString();
                    break;
                case "GetLRealAt":
                    double r14 = S7.GetLRealAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r14.ToString();
                    break;
                case "GetDateTimeAt":
                   DateTime r15 = S7.GetDateTimeAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r15.ToString();
                    break;
                case "GetDateAt":
                    DateTime r16 = S7.GetDateAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r16.ToString();
                    break;
                case "GetTODAt":
                    DateTime r17 = S7.GetTODAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r17.ToString();
                    break;
                case "GetLTODAt":
                    DateTime r18 = S7.GetLTODAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r18.ToString();
                    break;
                case "GetLDTAt":
                    DateTime r19 = S7.GetLDTAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r19.ToString();
                    break;
                case "GetDTLAt":
                    DateTime r20 = S7.GetDTLAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r20.ToString();
                    break;
                case "GetStringAt":
                   string r21 = S7.GetStringAt(BufferLettura, pos);
                    textBoxVisualizza.Text = r21;
                    break;
                case "GetCharsAt":
                    string r22 = S7.GetCharsAt(BufferLettura, pos,size);
                    textBoxVisualizza.Text = r22;
                    break;
            }
        }

        private void comboBoxFunGet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string func = comboBoxFunGet.SelectedItem.ToString();
            if (func == "GetBitAt")
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
            }
            if(func== "GetCharsAt")
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled =false;

            }
        }

    
    }
}
/*functionLettura.Add("GetBitAt");
functionLettura.Add("GetSIntAt");
functionLettura.Add("GetIntAt");
functionLettura.Add("GetSIntAt");
functionLettura.Add("GetDIntAt");
functionLettura.Add("GetLIntAt");
functionLettura.Add("GetUSIntAt");
functionLettura.Add("GetUDIntAt");
functionLettura.Add("GetULIntAt");
functionLettura.Add("GetByteAt");
functionLettura.Add("GetWordAt");
functionLettura.Add("GetDWordAt");
functionLettura.Add("GetLWordAt");
functionLettura.Add("GetRealAt");
functionLettura.Add("GetLRealAt");
functionLettura.Add("GetDateTimeAt");
functionLettura.Add("GetTODAt");
functionLettura.Add("GetLTODAt");
functionLettura.Add("GetLDTAt");
functionLettura.Add("GetDTLAt");
functionLettura.Add("GetStringAt");
functionLettura.Add("GetCharsAt");
functionLettura.Add("GetCounter");
functionLettura.Add("GetCounterAt");
functionLettura.Add("ToCounter");*/