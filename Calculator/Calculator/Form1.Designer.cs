namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnClearHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnSubtraction = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnBackSpace = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnPM = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.BtnDesimal = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSub);
            this.panel1.Controls.Add(this.BtnMax);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 40);
            this.panel1.TabIndex = 0;
            // 
            // BtnSub
            // 
            this.BtnSub.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSub.FlatAppearance.BorderSize = 0;
            this.BtnSub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSub.Image = ((System.Drawing.Image)(resources.GetObject("BtnSub.Image")));
            this.BtnSub.Location = new System.Drawing.Point(223, 0);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(51, 40);
            this.BtnSub.TabIndex = 4;
            this.BtnSub.UseVisualStyleBackColor = true;
            // 
            // BtnMax
            // 
            this.BtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.Location = new System.Drawing.Point(274, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(51, 40);
            this.BtnMax.TabIndex = 3;
            this.BtnMax.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(325, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(51, 40);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.richTextBox1);
            this.PnlHistory.Controls.Add(this.BtnClearHistory);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 572);
            this.PnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(376, 5);
            this.PnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(376, 0);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // BtnClearHistory
            // 
            this.BtnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnClearHistory.FlatAppearance.BorderSize = 0;
            this.BtnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearHistory.Image")));
            this.BtnClearHistory.Location = new System.Drawing.Point(0, -35);
            this.BtnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClearHistory.Name = "BtnClearHistory";
            this.BtnClearHistory.Size = new System.Drawing.Size(376, 40);
            this.BtnClearHistory.TabIndex = 5;
            this.BtnClearHistory.UseVisualStyleBackColor = true;
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 97);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(376, 41);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay2.TextChanged += new System.EventHandler(this.TxtDisplay2_TextChanged);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 138);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(376, 69);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn1
            // 
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.Location = new System.Drawing.Point(12, 453);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(85, 55);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.Location = new System.Drawing.Point(103, 453);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(85, 55);
            this.Btn2.TabIndex = 6;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.Location = new System.Drawing.Point(194, 453);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(85, 55);
            this.Btn3.TabIndex = 7;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAdd.Location = new System.Drawing.Point(285, 453);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 55);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Btn4
            // 
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.Location = new System.Drawing.Point(12, 392);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(85, 55);
            this.Btn4.TabIndex = 9;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn5
            // 
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.Location = new System.Drawing.Point(103, 392);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(85, 55);
            this.Btn5.TabIndex = 10;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.Location = new System.Drawing.Point(194, 392);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(85, 55);
            this.Btn6.TabIndex = 11;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // BtnSubtraction
            // 
            this.BtnSubtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSubtraction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnSubtraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubtraction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSubtraction.Location = new System.Drawing.Point(285, 392);
            this.BtnSubtraction.Name = "BtnSubtraction";
            this.BtnSubtraction.Size = new System.Drawing.Size(85, 55);
            this.BtnSubtraction.TabIndex = 12;
            this.BtnSubtraction.Text = "-";
            this.BtnSubtraction.UseVisualStyleBackColor = false;
            this.BtnSubtraction.Click += new System.EventHandler(this.BtnSubtraction_Click);
            // 
            // Btn7
            // 
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.Location = new System.Drawing.Point(12, 331);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(85, 55);
            this.Btn7.TabIndex = 13;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // Btn8
            // 
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.Location = new System.Drawing.Point(103, 331);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(85, 55);
            this.Btn8.TabIndex = 14;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn9
            // 
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Btn9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.Location = new System.Drawing.Point(194, 331);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(85, 55);
            this.Btn9.TabIndex = 15;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiply.Location = new System.Drawing.Point(285, 331);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(85, 55);
            this.BtnMultiply.TabIndex = 16;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnCE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.Location = new System.Drawing.Point(103, 270);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(85, 55);
            this.BtnCE.TabIndex = 18;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            this.BtnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnC.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.Location = new System.Drawing.Point(194, 270);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(85, 55);
            this.BtnC.TabIndex = 19;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnBackSpace.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnBackSpace.Image = ((System.Drawing.Image)(resources.GetObject("BtnBackSpace.Image")));
            this.BtnBackSpace.Location = new System.Drawing.Point(285, 210);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(85, 55);
            this.BtnBackSpace.TabIndex = 20;
            this.BtnBackSpace.Text = "1";
            this.BtnBackSpace.UseVisualStyleBackColor = false;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPercent.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPercent.Location = new System.Drawing.Point(12, 270);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(85, 55);
            this.BtnPercent.TabIndex = 21;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            // 
            // BtnPM
            // 
            this.BtnPM.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPM.Location = new System.Drawing.Point(12, 515);
            this.BtnPM.Name = "BtnPM";
            this.BtnPM.Size = new System.Drawing.Size(85, 55);
            this.BtnPM.TabIndex = 22;
            this.BtnPM.Text = "+/-";
            this.BtnPM.UseVisualStyleBackColor = true;
            this.BtnPM.Click += new System.EventHandler(this.BtnPM_Click);
            // 
            // button18
            // 
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button18.Location = new System.Drawing.Point(103, 515);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(85, 55);
            this.button18.TabIndex = 23;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // BtnDesimal
            // 
            this.BtnDesimal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDesimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDesimal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDesimal.Location = new System.Drawing.Point(194, 515);
            this.BtnDesimal.Name = "BtnDesimal";
            this.BtnDesimal.Size = new System.Drawing.Size(85, 55);
            this.BtnDesimal.TabIndex = 24;
            this.BtnDesimal.Text = ".";
            this.BtnDesimal.UseVisualStyleBackColor = true;
            this.BtnDesimal.Click += new System.EventHandler(this.BtnDesimal_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Blue;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button20.Location = new System.Drawing.Point(285, 515);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(85, 55);
            this.button20.TabIndex = 25;
            this.button20.Text = "=";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDivision.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivision.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivision.Location = new System.Drawing.Point(285, 270);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(85, 55);
            this.BtnDivision.TabIndex = 26;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(376, 577);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.BtnDesimal);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.BtnPM);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnBackSpace);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnSubtraction);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.PnlHistory);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculator";
            this.panel1.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.Button BtnClearHistory;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnSubtraction;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnBackSpace;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnPM;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button BtnDesimal;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button BtnDivision;
    }
}

