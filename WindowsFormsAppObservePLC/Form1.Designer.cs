
namespace WindowsFormsAppObservePLC
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisconnectButton = new RoundedButtonStyle.RoundedButton();
            this.Connetti = new RoundedButtonStyle.RoundedButton();
            this.textBoxSlot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBoxOff = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBoxOn = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxVisualizza = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.getButton = new RoundedButtonStyle.RoundedButton();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxFunGet = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CheckLettura = new RoundedButtonStyle.RoundedButton();
            this.textBoxNDB = new System.Windows.Forms.TextBox();
            this.textBoxSizeBuffer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBoxfuncSet = new System.Windows.Forms.ComboBox();
            this.ScriviButton = new RoundedButtonStyle.RoundedButton();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.82262F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.17738F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.19142F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.80858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisconnectButton);
            this.groupBox1.Controls.Add(this.Connetti);
            this.groupBox1.Controls.Add(this.textBoxSlot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxRank);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connessione";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BorderColor = System.Drawing.Color.Silver;
            this.DisconnectButton.ButtonColor = System.Drawing.Color.Teal;
            this.DisconnectButton.FlatAppearance.BorderSize = 0;
            this.DisconnectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DisconnectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.Location = new System.Drawing.Point(84, 237);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.DisconnectButton.OnHoverButtonColor = System.Drawing.Color.LawnGreen;
            this.DisconnectButton.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.DisconnectButton.Size = new System.Drawing.Size(99, 33);
            this.DisconnectButton.TabIndex = 7;
            this.DisconnectButton.Text = "Disconnetti";
            this.DisconnectButton.TextColor = System.Drawing.Color.White;
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Connetti
            // 
            this.Connetti.BorderColor = System.Drawing.Color.Silver;
            this.Connetti.ButtonColor = System.Drawing.Color.Teal;
            this.Connetti.FlatAppearance.BorderSize = 0;
            this.Connetti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Connetti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Connetti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connetti.Location = new System.Drawing.Point(84, 181);
            this.Connetti.Name = "Connetti";
            this.Connetti.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.Connetti.OnHoverButtonColor = System.Drawing.Color.LawnGreen;
            this.Connetti.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.Connetti.Size = new System.Drawing.Size(99, 33);
            this.Connetti.TabIndex = 6;
            this.Connetti.Text = "Connetti";
            this.Connetti.TextColor = System.Drawing.Color.White;
            this.Connetti.UseVisualStyleBackColor = true;
            this.Connetti.Click += new System.EventHandler(this.Connetti_Click);
            // 
            // textBoxSlot
            // 
            this.textBoxSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSlot.Location = new System.Drawing.Point(49, 144);
            this.textBoxSlot.Name = "textBoxSlot";
            this.textBoxSlot.Size = new System.Drawing.Size(198, 24);
            this.textBoxSlot.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Slot";
            // 
            // textBoxRank
            // 
            this.textBoxRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRank.Location = new System.Drawing.Point(49, 88);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(198, 24);
            this.textBoxRank.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rank";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIP.Location = new System.Drawing.Point(50, 37);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(199, 24);
            this.textBoxIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.pictureBoxOff);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.pictureBoxOn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(3, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 31);
            this.panel2.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label18.Location = new System.Drawing.Point(189, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "OFF";
            // 
            // pictureBoxOff
            // 
            this.pictureBoxOff.Image = global::WindowsFormsAppObservePLC.Properties.Resources.buttons_off;
            this.pictureBoxOff.Location = new System.Drawing.Point(218, -2);
            this.pictureBoxOff.Name = "pictureBoxOff";
            this.pictureBoxOff.Size = new System.Drawing.Size(43, 35);
            this.pictureBoxOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOff.TabIndex = 3;
            this.pictureBoxOff.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label17.Location = new System.Drawing.Point(118, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "ON";
            // 
            // pictureBoxOn
            // 
            this.pictureBoxOn.Image = global::WindowsFormsAppObservePLC.Properties.Resources.buttons_on;
            this.pictureBoxOn.Location = new System.Drawing.Point(140, -1);
            this.pictureBoxOn.Name = "pictureBoxOn";
            this.pictureBoxOn.Size = new System.Drawing.Size(43, 31);
            this.pictureBoxOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOn.TabIndex = 1;
            this.pictureBoxOn.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connesso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.panelTop, 2);
            this.panelTop.Controls.Add(this.tableLayoutPanel2);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(896, 40);
            this.panelTop.TabIndex = 2;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonClose, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonMinimize, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(794, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(102, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::WindowsFormsAppObservePLC.Properties.Resources.close_button;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(54, 3);
            this.buttonClose.Name = "buttonClose";
            this.tableLayoutPanel2.SetRowSpan(this.buttonClose, 2);
            this.buttonClose.Size = new System.Drawing.Size(45, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::WindowsFormsAppObservePLC.Properties.Resources.minimize_icon;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(3, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.tableLayoutPanel2.SetRowSpan(this.buttonMinimize, 2);
            this.buttonMinimize.Size = new System.Drawing.Size(45, 34);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonMinimize_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.buttonMinimize_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Visual Sharp7";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(272, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LetturaDB";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxVisualizza);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 139);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 127);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Visualizzatore";
            // 
            // textBoxVisualizza
            // 
            this.textBoxVisualizza.Location = new System.Drawing.Point(6, 23);
            this.textBoxVisualizza.Multiline = true;
            this.textBoxVisualizza.Name = "textBoxVisualizza";
            this.textBoxVisualizza.Size = new System.Drawing.Size(238, 75);
            this.textBoxVisualizza.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.getButton);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.comboBoxFunGet);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(352, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 147);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Prelievo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 15;
            this.label19.Text = "Size";
            // 
            // getButton
            // 
            this.getButton.BorderColor = System.Drawing.Color.Silver;
            this.getButton.ButtonColor = System.Drawing.Color.Teal;
            this.getButton.FlatAppearance.BorderSize = 0;
            this.getButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.getButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.getButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getButton.Location = new System.Drawing.Point(176, 104);
            this.getButton.Name = "getButton";
            this.getButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.getButton.OnHoverButtonColor = System.Drawing.Color.LawnGreen;
            this.getButton.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.getButton.Size = new System.Drawing.Size(73, 33);
            this.getButton.TabIndex = 8;
            this.getButton.Text = "Get";
            this.getButton.TextColor = System.Drawing.Color.White;
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "funzione";
            // 
            // comboBoxFunGet
            // 
            this.comboBoxFunGet.FormattingEnabled = true;
            this.comboBoxFunGet.Location = new System.Drawing.Point(77, 33);
            this.comboBoxFunGet.Name = "comboBoxFunGet";
            this.comboBoxFunGet.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFunGet.TabIndex = 13;
            this.comboBoxFunGet.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunGet_SelectedIndexChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(115, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(38, 22);
            this.textBox8.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "bit";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(43, 80);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(37, 22);
            this.textBox7.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Pos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CheckLettura);
            this.groupBox3.Controls.Add(this.textBoxNDB);
            this.groupBox3.Controls.Add(this.textBoxSizeBuffer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 114);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check";
            // 
            // CheckLettura
            // 
            this.CheckLettura.BorderColor = System.Drawing.Color.Silver;
            this.CheckLettura.ButtonColor = System.Drawing.Color.Teal;
            this.CheckLettura.FlatAppearance.BorderSize = 0;
            this.CheckLettura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckLettura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckLettura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckLettura.Location = new System.Drawing.Point(199, 75);
            this.CheckLettura.Name = "CheckLettura";
            this.CheckLettura.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.CheckLettura.OnHoverButtonColor = System.Drawing.Color.LawnGreen;
            this.CheckLettura.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.CheckLettura.Size = new System.Drawing.Size(138, 33);
            this.CheckLettura.TabIndex = 7;
            this.CheckLettura.Text = "Check Lettura";
            this.CheckLettura.TextColor = System.Drawing.Color.White;
            this.CheckLettura.UseVisualStyleBackColor = true;
            this.CheckLettura.Click += new System.EventHandler(this.CheckLettura_Click);
            // 
            // textBoxNDB
            // 
            this.textBoxNDB.Location = new System.Drawing.Point(52, 33);
            this.textBoxNDB.Name = "textBoxNDB";
            this.textBoxNDB.Size = new System.Drawing.Size(100, 22);
            this.textBoxNDB.TabIndex = 1;
            // 
            // textBoxSizeBuffer
            // 
            this.textBoxSizeBuffer.Location = new System.Drawing.Point(237, 33);
            this.textBoxSizeBuffer.Name = "textBoxSizeBuffer";
            this.textBoxSizeBuffer.Size = new System.Drawing.Size(100, 22);
            this.textBoxSizeBuffer.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "N.DB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(158, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "SizeBuffer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Start";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(52, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.comboBoxfuncSet);
            this.groupBox6.Controls.Add(this.ScriviButton);
            this.groupBox6.Controls.Add(this.textBox14);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.textBox13);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.textBox12);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox11);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBox10);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(272, 333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(627, 114);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ScritturaDB";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 18;
            this.label20.Text = "funzione";
            // 
            // comboBoxfuncSet
            // 
            this.comboBoxfuncSet.FormattingEnabled = true;
            this.comboBoxfuncSet.Location = new System.Drawing.Point(97, 34);
            this.comboBoxfuncSet.Name = "comboBoxfuncSet";
            this.comboBoxfuncSet.Size = new System.Drawing.Size(121, 28);
            this.comboBoxfuncSet.TabIndex = 17;
            this.comboBoxfuncSet.SelectedIndexChanged += new System.EventHandler(this.comboBoxfuncSet_SelectedIndexChanged);
            // 
            // ScriviButton
            // 
            this.ScriviButton.BorderColor = System.Drawing.Color.Silver;
            this.ScriviButton.ButtonColor = System.Drawing.Color.Teal;
            this.ScriviButton.FlatAppearance.BorderSize = 0;
            this.ScriviButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ScriviButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ScriviButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriviButton.Location = new System.Drawing.Point(480, 78);
            this.ScriviButton.Name = "ScriviButton";
            this.ScriviButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.ScriviButton.OnHoverButtonColor = System.Drawing.Color.LawnGreen;
            this.ScriviButton.OnHoverTextColor = System.Drawing.SystemColors.Window;
            this.ScriviButton.Size = new System.Drawing.Size(138, 33);
            this.ScriviButton.TabIndex = 8;
            this.ScriviButton.Text = "Scrivi";
            this.ScriviButton.TextColor = System.Drawing.Color.White;
            this.ScriviButton.UseVisualStyleBackColor = true;
            this.ScriviButton.Click += new System.EventHandler(this.ScriviButton_Click);
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(548, 34);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(53, 26);
            this.textBox14.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(519, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 15);
            this.label16.TabIndex = 14;
            this.label16.Text = "bit";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(116, 78);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 26);
            this.textBox13.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "MaxLunghezza";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(450, 34);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(53, 26);
            this.textBox12.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(412, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Pos";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(306, 34);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(235, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Valore";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(306, 78);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 26);
            this.textBox10.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(227, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "SizeBuffer";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 114);
            this.panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WindowsFormsAppObservePLC.Properties.Resources.Imsharp7;
            this.pictureBox1.Location = new System.Drawing.Point(867, 452);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(902, 487);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOn)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSlot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private RoundedButtonStyle.RoundedButton Connetti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxOn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private RoundedButtonStyle.RoundedButton CheckLettura;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxFunGet;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private RoundedButtonStyle.RoundedButton getButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxVisualizza;
        private System.Windows.Forms.TextBox textBoxSizeBuffer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
        private RoundedButtonStyle.RoundedButton ScriviButton;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBoxOff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboBoxfuncSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedButtonStyle.RoundedButton DisconnectButton;
    }
}

