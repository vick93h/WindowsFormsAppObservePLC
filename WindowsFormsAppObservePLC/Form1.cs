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
        List<string> functionScrittura = new List<string>();
        private S7Client client;
        private byte[] BufferLettura;
        private byte[] BufferScrittura;
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
            //
            functionScrittura.Add("SetBitAt");
            functionScrittura.Add("SetSIntAt");
            functionScrittura.Add("SetIntAt");
            functionScrittura.Add("SetDIntAt");
            functionScrittura.Add("SetLIntAt");
            functionScrittura.Add("SetUSIntAt");
            functionScrittura.Add("SetUIntAt");
            functionScrittura.Add("SetUDIntAt");
            functionScrittura.Add("SetULIntAt");
            functionScrittura.Add("SetByteAt");
            functionScrittura.Add("SetWordAt");
            functionScrittura.Add("SetDWordAt");
            functionScrittura.Add("SetLWordAt");
            functionScrittura.Add("SetRealAt");
            functionScrittura.Add("SetLRealAt");
            functionScrittura.Add("SetDateTimeAt");
            functionScrittura.Add("SetDateAt");
            functionScrittura.Add("SetTODAt");
            functionScrittura.Add("SetLTODAt");
            functionScrittura.Add("SetLDTAt");
            functionScrittura.Add("SetDTLAt");
            functionScrittura.Add("SetStringAt");
            functionScrittura.Add("SetCharsAt");
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
            int start = ConverterInteger(textBox5.Text.ToString());
            BufferLettura = new byte[dim];
            try
            {
                int i = client.DBRead(NumDb,start, BufferLettura.Length, BufferLettura);
                if (i == 0)
                {
                    MessageBox.Show("Sono entrato nella DB!");
                    comboBoxFunGet.DataSource = functionLettura;
                    comboBoxfuncSet.DataSource = functionScrittura;
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
            int NumDb = ConverterInteger(textBoxNDB.Text.ToString());
            int size = 0;
            int  bit=0;
            int start = ConverterInteger(textBox5.Text.ToString());
            string func = comboBoxFunGet.SelectedItem.ToString();
            if (func == "GetBitAt") {
                bit = ConverterInteger(textBox8.Text.ToString());
            }
            if (func == "GetCharsAt")
            {
               size = ConverterInteger(textBox1.Text.ToString());
            }
            int pos = ConverterInteger(textBox7.Text.ToString());
            int j = client.DBRead(NumDb, start, BufferLettura.Length, BufferLettura);
            switch (func)
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
            int i= client.DBRead(NumDb, start, BufferLettura.Length, BufferLettura);
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

        private void ScriviButton_Click(object sender, EventArgs e)
        {
            int NumDb = ConverterInteger(textBoxNDB.Text.ToString());
            string sizeBuffer = textBox10.Text.ToString();
            int dim = ConverterInteger(sizeBuffer);
            BufferScrittura = new byte[dim];
            int pos = ConverterInteger(textBox12.Text.ToString());
            int bit = 0;
            int max_lenght = 0;
            string func = comboBoxfuncSet.SelectedItem.ToString();
            if (func == "SetBitAt")
            {
                bit = ConverterInteger(textBox14.Text.ToString());
               
            }
            if (func == "SetStringAt")
            {
                max_lenght = ConverterInteger(textBox13.Text.ToString());
            }
            switch (func)
            {
                case "SetBitAt":
                    string valore = textBox11.Text.ToString();
                    if (valore != "true" && valore != "false")
                    {
                        MessageBox.Show("valori ammessi:true o false!");
                        return;
                    }
                    else
                    {

                        bool value = bool.Parse(valore);
                        S7.SetBitAt(BufferScrittura, pos, bit, value);
                    }
                    break;

                case "SetSIntAt":
                    string valore1 = textBox11.Text.ToString();
                    int value1 = ConverterInteger(valore1);
                    S7.SetSIntAt(BufferScrittura, pos, value1);
                    break;
                case "SetIntAt":
                    string valore2 = textBox11.Text.ToString();
                    Int16 value2 = Int16.Parse(valore2);
                    S7.SetIntAt(BufferScrittura, pos, value2);
                    break;
                case "SetDIntAt":
                    string valore3 = textBox11.Text.ToString();
                    int value3 = ConverterInteger(valore3);
                    S7.SetDIntAt(BufferScrittura, pos, value3);
                    break;
                case "SetLIntAt":
                    string valore4 = textBox11.Text.ToString();
                    Int64 value4 = Int64.Parse(valore4);
                    S7.SetLIntAt(BufferScrittura, pos, value4);
                    break;
                case "SetUSIntAt":
                    string valore5 = textBox11.Text.ToString();
                    byte value5 = byte.Parse(valore5);
                    S7.SetUSIntAt(BufferScrittura, pos, value5);
                    break;
                case "SetUIntAt":
                    string valore6 = textBox11.Text.ToString();
                    UInt16 value6 = UInt16.Parse(valore6);
                    S7.SetUIntAt(BufferScrittura, pos, value6);
                    break;
                case "SetUDIntAt":
                    string valore7 = textBox11.Text.ToString();
                    UInt32 value7 = UInt32.Parse(valore7);
                    S7.SetUDIntAt(BufferScrittura, pos, value7);
                    break;
                case "SetULintAt":
                    string valore8 = textBox11.Text.ToString();
                    UInt64 value8 = UInt64.Parse(valore8);
                    S7.SetULintAt(BufferScrittura, pos, value8);
                    break;
                case "SetByteAt":
                    string valore9 = textBox11.Text.ToString();
                    byte value9 = byte.Parse(valore9);
                    S7.SetByteAt(BufferScrittura, pos, value9);
                    break;
                case "SetWordAt":
                    string valore10 = textBox11.Text.ToString();
                    UInt16 value10 = UInt16.Parse(valore10);
                    S7.SetWordAt(BufferScrittura, pos, value10);
                    break;
                case "SetDWordAt":
                    string valore11 = textBox11.Text.ToString();
                    UInt32 value11 = UInt32.Parse(valore11);
                    S7.SetDWordAt(BufferScrittura, pos, value11);
                    break;
                case "SetLWordAt":
                    string valore12 = textBox11.Text.ToString();
                    UInt64 value12 = UInt64.Parse(valore12);
                    S7.SetLWordAt(BufferScrittura, pos, value12);
                    break;
                case "SetRealAt":
                    string valore13 = textBox11.Text.ToString();
                    Single value13 = Single.Parse(valore13);
                    S7.SetRealAt(BufferScrittura, pos, value13);
                    break;
                case "SetLRealAt":
                    string valore14 = textBox11.Text.ToString();
                    Double value14 = Double.Parse(valore14);
                    S7.SetLRealAt(BufferScrittura, pos, value14);
                    break;
                case "SetDateTimeAt":
                    string valore15 = textBox11.Text.ToString();
                    DateTime value15 = DateTime.Parse(valore15);
                    S7.SetDateTimeAt(BufferScrittura, pos, value15);
                    break;
                case "SetDateAt":
                    string valore16 = textBox11.Text.ToString();
                    DateTime value16 = DateTime.Parse(valore16);
                    S7.SetDateAt(BufferScrittura, pos, value16);
                    break;
                case "SetTODAt":
                    string valore17 = textBox11.Text.ToString();
                    DateTime value17 = DateTime.Parse(valore17);
                    S7.SetTODAt(BufferScrittura, pos, value17);
                    break;
                case "SetLTODAt":
                    string valore18 = textBox11.Text.ToString();
                    DateTime value18 = DateTime.Parse(valore18);
                    S7.SetLTODAt(BufferScrittura, pos, value18);
                    break;
                case "SetLDTAt":
                    string valore19 = textBox11.Text.ToString();
                    DateTime value19 = DateTime.Parse(valore19);
                    S7.SetLDTAt(BufferScrittura, pos, value19);
                    break;
                case "SetDTLAt":
                    string valore20 = textBox11.Text.ToString();
                    DateTime value20 = DateTime.Parse(valore20);
                    S7.SetDTLAt(BufferScrittura, pos, value20);
                    break;
                case "SetStringAt":

                    string valore21 = textBox11.Text.ToString();
                    S7.SetStringAt(BufferScrittura, pos, max_lenght, valore21);
                    break;
                case "SetCharsAt":
                    string valore22 = textBox11.Text.ToString();
                    S7.SetCharsAt(BufferScrittura, pos, valore22);
                    break;

            }
            int i=client.DBWrite(NumDb,pos, BufferScrittura.Length, BufferScrittura);
            if(i==0)
            {
                MessageBox.Show("Scrittura Effettuata!");
            }
            else
            {
                MessageBox.Show("Scrittura non Effettuata!");
            }
        }

  

        private void comboBoxfuncSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string func = comboBoxfuncSet.SelectedItem.ToString();
            if (func == "SetBitAt")
            {
                textBox14.Enabled = true;
            }
            else
            {
                textBox14.Enabled = false;
            }
            if (func == "SetStringAt")
            {
                textBox13.Enabled = true;
            }
            else
            {
                textBox13.Enabled = false;

            }
        }
    }
}
/*          functionScrittura.Add("SetBitAt");
            functionScrittura.Add("SetSIntAt");
            functionScrittura.Add("SetIntAt");
            functionScrittura.Add("SetDIntAt");
            functionScrittura.Add("SetLIntAt");
            functionScrittura.Add("SetUSIntAt");
            functionScrittura.Add("SetUIntAt");
            functionScrittura.Add("SetUDIntAt");
            functionScrittura.Add("SetULIntAt");
            functionScrittura.Add("SetByteAt");
            functionScrittura.Add("SetWordAt");
            functionScrittura.Add("SetDWordAt");
            functionScrittura.Add("SetLWordAt");
            functionScrittura.Add("SetRealAt");
            functionScrittura.Add("SetLRealAt");
            functionScrittura.Add("SetDateTimeAt");
            functionScrittura.Add("SetDateAt");
            functionScrittura.Add("SetTODAt");
            functionScrittura.Add("SetLTODAt");
            functionScrittura.Add("SetLDTAt");
            functionScrittura.Add("SetDTLAt");
            functionScrittura.Add("SetStringAt");
            functionScrittura.Add("SetCharsAt");*/