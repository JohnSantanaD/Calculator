namespace Calculator
{
    partial class FrmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculator));
            this.PanelControlWindows = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PtxIcon = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnMaximize = new FontAwesome.Sharp.IconButton();
            this.BtnClose = new FontAwesome.Sharp.IconButton();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnExponent = new FontAwesome.Sharp.IconButton();
            this.BtnRoot = new FontAwesome.Sharp.IconButton();
            this.BtnPercentage = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn9 = new FontAwesome.Sharp.IconButton();
            this.Btn8 = new FontAwesome.Sharp.IconButton();
            this.Btn7 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn6 = new FontAwesome.Sharp.IconButton();
            this.Btn5 = new FontAwesome.Sharp.IconButton();
            this.Btn4 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn3 = new FontAwesome.Sharp.IconButton();
            this.Btn2 = new FontAwesome.Sharp.IconButton();
            this.Btn1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDot = new FontAwesome.Sharp.IconButton();
            this.Btn0 = new FontAwesome.Sharp.IconButton();
            this.BtnClear = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBackSpace = new FontAwesome.Sharp.IconButton();
            this.BtnSplit = new FontAwesome.Sharp.IconButton();
            this.BtnMultiply = new FontAwesome.Sharp.IconButton();
            this.BtnMinus = new FontAwesome.Sharp.IconButton();
            this.BtnPlus = new FontAwesome.Sharp.IconButton();
            this.BtnEqual = new FontAwesome.Sharp.IconButton();
            this.PanelDisplay = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.LblSing = new System.Windows.Forms.Label();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.PanelControlWindows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtxIcon)).BeginInit();
            this.PanelButtons.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelDisplay.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControlWindows
            // 
            this.PanelControlWindows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.PanelControlWindows.Controls.Add(this.LblTitle);
            this.PanelControlWindows.Controls.Add(this.PtxIcon);
            this.PanelControlWindows.Controls.Add(this.BtnMinimize);
            this.PanelControlWindows.Controls.Add(this.BtnMaximize);
            this.PanelControlWindows.Controls.Add(this.BtnClose);
            this.PanelControlWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControlWindows.Location = new System.Drawing.Point(0, 0);
            this.PanelControlWindows.Name = "PanelControlWindows";
            this.PanelControlWindows.Size = new System.Drawing.Size(263, 28);
            this.PanelControlWindows.TabIndex = 0;
            this.PanelControlWindows.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControlWindows_MouseMove);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.LblTitle.Location = new System.Drawing.Point(29, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(70, 17);
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "Calculator";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblTitle_MouseMove);
            // 
            // PtxIcon
            // 
            this.PtxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.PtxIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PtxIcon.BackgroundImage")));
            this.PtxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PtxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtxIcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PtxIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.PtxIcon.IconColor = System.Drawing.SystemColors.ControlText;
            this.PtxIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PtxIcon.IconSize = 26;
            this.PtxIcon.Location = new System.Drawing.Point(0, 0);
            this.PtxIcon.Name = "PtxIcon";
            this.PtxIcon.Size = new System.Drawing.Size(26, 28);
            this.PtxIcon.TabIndex = 3;
            this.PtxIcon.TabStop = false;
            this.PtxIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PtxIcon_MouseMove);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinimize.IconSize = 32;
            this.BtnMinimize.Location = new System.Drawing.Point(173, 0);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(30, 28);
            this.BtnMinimize.TabIndex = 2;
            this.BtnMinimize.Text = " ";
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximize.FlatAppearance.BorderSize = 0;
            this.BtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximize.IconColor = System.Drawing.Color.DarkGray;
            this.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.BtnMaximize.IconSize = 32;
            this.BtnMaximize.Location = new System.Drawing.Point(203, 0);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(30, 28);
            this.BtnMaximize.TabIndex = 1;
            this.BtnMaximize.Text = " ";
            this.BtnMaximize.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.BtnClose.IconColor = System.Drawing.Color.DarkGray;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.BtnClose.IconSize = 32;
            this.BtnClose.Location = new System.Drawing.Point(233, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 28);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = " ";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PanelButtons
            // 
            this.PanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.PanelButtons.Controls.Add(this.panel6);
            this.PanelButtons.Controls.Add(this.panel5);
            this.PanelButtons.Controls.Add(this.panel4);
            this.PanelButtons.Controls.Add(this.panel3);
            this.PanelButtons.Controls.Add(this.panel2);
            this.PanelButtons.Controls.Add(this.panel1);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButtons.Location = new System.Drawing.Point(0, 109);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(263, 290);
            this.PanelButtons.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnExponent);
            this.panel6.Controls.Add(this.BtnRoot);
            this.panel6.Controls.Add(this.BtnPercentage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 58);
            this.panel6.TabIndex = 5;
            // 
            // BtnExponent
            // 
            this.BtnExponent.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExponent.FlatAppearance.BorderSize = 0;
            this.BtnExponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExponent.IconChar = FontAwesome.Sharp.IconChar.Superscript;
            this.BtnExponent.IconColor = System.Drawing.Color.DarkGray;
            this.BtnExponent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExponent.IconSize = 32;
            this.BtnExponent.Location = new System.Drawing.Point(128, 0);
            this.BtnExponent.Name = "BtnExponent";
            this.BtnExponent.Size = new System.Drawing.Size(64, 58);
            this.BtnExponent.TabIndex = 10;
            this.BtnExponent.Text = " ";
            this.BtnExponent.UseVisualStyleBackColor = true;
            this.BtnExponent.Click += new System.EventHandler(this.BtnExponent_Click);
            // 
            // BtnRoot
            // 
            this.BtnRoot.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRoot.FlatAppearance.BorderSize = 0;
            this.BtnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoot.IconChar = FontAwesome.Sharp.IconChar.SquareRootVariable;
            this.BtnRoot.IconColor = System.Drawing.Color.DarkGray;
            this.BtnRoot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRoot.IconSize = 32;
            this.BtnRoot.Location = new System.Drawing.Point(64, 0);
            this.BtnRoot.Name = "BtnRoot";
            this.BtnRoot.Size = new System.Drawing.Size(64, 58);
            this.BtnRoot.TabIndex = 9;
            this.BtnRoot.Text = " ";
            this.BtnRoot.UseVisualStyleBackColor = true;
            this.BtnRoot.Click += new System.EventHandler(this.BtnRoot_Click);
            // 
            // BtnPercentage
            // 
            this.BtnPercentage.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPercentage.FlatAppearance.BorderSize = 0;
            this.BtnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercentage.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            this.BtnPercentage.IconColor = System.Drawing.Color.DarkGray;
            this.BtnPercentage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnPercentage.IconSize = 32;
            this.BtnPercentage.Location = new System.Drawing.Point(0, 0);
            this.BtnPercentage.Name = "BtnPercentage";
            this.BtnPercentage.Size = new System.Drawing.Size(64, 58);
            this.BtnPercentage.TabIndex = 8;
            this.BtnPercentage.Text = " ";
            this.BtnPercentage.UseVisualStyleBackColor = true;
            this.BtnPercentage.Click += new System.EventHandler(this.BtnPercentage_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Btn9);
            this.panel5.Controls.Add(this.Btn8);
            this.panel5.Controls.Add(this.Btn7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(195, 58);
            this.panel5.TabIndex = 4;
            // 
            // Btn9
            // 
            this.Btn9.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.IconChar = FontAwesome.Sharp.IconChar._9;
            this.Btn9.IconColor = System.Drawing.Color.DarkGray;
            this.Btn9.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn9.IconSize = 32;
            this.Btn9.Location = new System.Drawing.Point(128, 0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(64, 58);
            this.Btn9.TabIndex = 9;
            this.Btn9.Text = " ";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn8
            // 
            this.Btn8.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.IconChar = FontAwesome.Sharp.IconChar._8;
            this.Btn8.IconColor = System.Drawing.Color.DarkGray;
            this.Btn8.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn8.IconSize = 32;
            this.Btn8.Location = new System.Drawing.Point(64, 0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(64, 58);
            this.Btn8.TabIndex = 8;
            this.Btn8.Text = " ";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn7
            // 
            this.Btn7.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.IconChar = FontAwesome.Sharp.IconChar._7;
            this.Btn7.IconColor = System.Drawing.Color.DarkGray;
            this.Btn7.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn7.IconSize = 32;
            this.Btn7.Location = new System.Drawing.Point(0, 0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(64, 58);
            this.Btn7.TabIndex = 7;
            this.Btn7.Text = " ";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btn6);
            this.panel4.Controls.Add(this.Btn5);
            this.panel4.Controls.Add(this.Btn4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 58);
            this.panel4.TabIndex = 3;
            // 
            // Btn6
            // 
            this.Btn6.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.IconChar = FontAwesome.Sharp.IconChar._6;
            this.Btn6.IconColor = System.Drawing.Color.DarkGray;
            this.Btn6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn6.IconSize = 32;
            this.Btn6.Location = new System.Drawing.Point(128, 0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(64, 58);
            this.Btn6.TabIndex = 9;
            this.Btn6.Text = " ";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn5
            // 
            this.Btn5.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.IconChar = FontAwesome.Sharp.IconChar._5;
            this.Btn5.IconColor = System.Drawing.Color.DarkGray;
            this.Btn5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn5.IconSize = 32;
            this.Btn5.Location = new System.Drawing.Point(64, 0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(64, 58);
            this.Btn5.TabIndex = 8;
            this.Btn5.Text = " ";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn4
            // 
            this.Btn4.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.IconChar = FontAwesome.Sharp.IconChar._4;
            this.Btn4.IconColor = System.Drawing.Color.DarkGray;
            this.Btn4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn4.IconSize = 32;
            this.Btn4.Location = new System.Drawing.Point(0, 0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(64, 58);
            this.Btn4.TabIndex = 7;
            this.Btn4.Text = " ";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn3);
            this.panel3.Controls.Add(this.Btn2);
            this.panel3.Controls.Add(this.Btn1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 58);
            this.panel3.TabIndex = 2;
            // 
            // Btn3
            // 
            this.Btn3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.IconChar = FontAwesome.Sharp.IconChar._3;
            this.Btn3.IconColor = System.Drawing.Color.DarkGray;
            this.Btn3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn3.IconSize = 32;
            this.Btn3.Location = new System.Drawing.Point(128, 0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(64, 58);
            this.Btn3.TabIndex = 6;
            this.Btn3.Text = " ";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.IconChar = FontAwesome.Sharp.IconChar._2;
            this.Btn2.IconColor = System.Drawing.Color.DarkGray;
            this.Btn2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn2.IconSize = 32;
            this.Btn2.Location = new System.Drawing.Point(64, 0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(64, 58);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = " ";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.IconChar = FontAwesome.Sharp.IconChar._1;
            this.Btn1.IconColor = System.Drawing.Color.DarkGray;
            this.Btn1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn1.IconSize = 32;
            this.Btn1.Location = new System.Drawing.Point(0, 0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(64, 58);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = " ";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnDot);
            this.panel2.Controls.Add(this.Btn0);
            this.panel2.Controls.Add(this.BtnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 52);
            this.panel2.TabIndex = 1;
            // 
            // BtnDot
            // 
            this.BtnDot.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnDot.IconChar = FontAwesome.Sharp.IconChar._9;
            this.BtnDot.IconColor = System.Drawing.Color.DarkGray;
            this.BtnDot.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnDot.IconSize = 1;
            this.BtnDot.Location = new System.Drawing.Point(128, 0);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(64, 52);
            this.BtnDot.TabIndex = 12;
            this.BtnDot.Text = " .";
            this.BtnDot.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.Click += new System.EventHandler(this.BtnDot_Click);
            // 
            // Btn0
            // 
            this.Btn0.Dock = System.Windows.Forms.DockStyle.Left;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.IconChar = FontAwesome.Sharp.IconChar._0;
            this.Btn0.IconColor = System.Drawing.Color.DarkGray;
            this.Btn0.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn0.IconSize = 32;
            this.Btn0.Location = new System.Drawing.Point(64, 0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(64, 52);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = " ";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.DarkGray;
            this.BtnClear.IconChar = FontAwesome.Sharp.IconChar._0;
            this.BtnClear.IconColor = System.Drawing.Color.DarkGray;
            this.BtnClear.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnClear.IconSize = 1;
            this.BtnClear.Location = new System.Drawing.Point(0, 0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(64, 52);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = " C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBackSpace);
            this.panel1.Controls.Add(this.BtnSplit);
            this.panel1.Controls.Add(this.BtnMultiply);
            this.panel1.Controls.Add(this.BtnMinus);
            this.panel1.Controls.Add(this.BtnPlus);
            this.panel1.Controls.Add(this.BtnEqual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(195, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 290);
            this.panel1.TabIndex = 0;
            // 
            // BtnBackSpace
            // 
            this.BtnBackSpace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnBackSpace.FlatAppearance.BorderSize = 0;
            this.BtnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackSpace.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.BtnBackSpace.IconColor = System.Drawing.Color.DarkGray;
            this.BtnBackSpace.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnBackSpace.IconSize = 32;
            this.BtnBackSpace.Location = new System.Drawing.Point(0, 2);
            this.BtnBackSpace.Name = "BtnBackSpace";
            this.BtnBackSpace.Size = new System.Drawing.Size(68, 48);
            this.BtnBackSpace.TabIndex = 7;
            this.BtnBackSpace.Text = " ";
            this.BtnBackSpace.UseVisualStyleBackColor = true;
            this.BtnBackSpace.Click += new System.EventHandler(this.BtnBackSpace_Click);
            // 
            // BtnSplit
            // 
            this.BtnSplit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSplit.FlatAppearance.BorderSize = 0;
            this.BtnSplit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSplit.IconChar = FontAwesome.Sharp.IconChar.Divide;
            this.BtnSplit.IconColor = System.Drawing.Color.DarkGray;
            this.BtnSplit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnSplit.IconSize = 32;
            this.BtnSplit.Location = new System.Drawing.Point(0, 50);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(68, 48);
            this.BtnSplit.TabIndex = 6;
            this.BtnSplit.Text = " ";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnMultiply.FlatAppearance.BorderSize = 0;
            this.BtnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiply.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.BtnMultiply.IconColor = System.Drawing.Color.DarkGray;
            this.BtnMultiply.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMultiply.IconSize = 32;
            this.BtnMultiply.Location = new System.Drawing.Point(0, 98);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(68, 48);
            this.BtnMultiply.TabIndex = 5;
            this.BtnMultiply.Text = " ";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnMinus.FlatAppearance.BorderSize = 0;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.IconChar = FontAwesome.Sharp.IconChar.Subtract;
            this.BtnMinus.IconColor = System.Drawing.Color.DarkGray;
            this.BtnMinus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnMinus.IconSize = 32;
            this.BtnMinus.Location = new System.Drawing.Point(0, 146);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(68, 48);
            this.BtnMinus.TabIndex = 4;
            this.BtnMinus.Text = " ";
            this.BtnMinus.UseVisualStyleBackColor = true;
            this.BtnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnPlus.IconColor = System.Drawing.Color.DarkGray;
            this.BtnPlus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnPlus.IconSize = 32;
            this.BtnPlus.Location = new System.Drawing.Point(0, 194);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(68, 48);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = " ";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEqual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEqual.FlatAppearance.BorderSize = 0;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.IconChar = FontAwesome.Sharp.IconChar.Equals;
            this.BtnEqual.IconColor = System.Drawing.Color.DimGray;
            this.BtnEqual.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnEqual.IconSize = 32;
            this.BtnEqual.Location = new System.Drawing.Point(0, 242);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(68, 48);
            this.BtnEqual.TabIndex = 2;
            this.BtnEqual.Text = " ";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.PanelDisplay.Controls.Add(this.panel7);
            this.PanelDisplay.Controls.Add(this.TxtDisplay);
            this.PanelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDisplay.Location = new System.Drawing.Point(0, 28);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.Size = new System.Drawing.Size(263, 76);
            this.PanelDisplay.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LblDisplay);
            this.panel7.Controls.Add(this.LblSing);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 29);
            this.panel7.TabIndex = 2;
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblDisplay.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDisplay.ForeColor = System.Drawing.Color.DimGray;
            this.LblDisplay.Location = new System.Drawing.Point(263, 0);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(0, 23);
            this.LblDisplay.TabIndex = 2;
            // 
            // LblSing
            // 
            this.LblSing.AutoSize = true;
            this.LblSing.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblSing.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSing.ForeColor = System.Drawing.Color.DimGray;
            this.LblSing.Location = new System.Drawing.Point(263, 0);
            this.LblSing.Name = "LblSing";
            this.LblSing.Size = new System.Drawing.Size(0, 23);
            this.LblSing.TabIndex = 1;
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.TxtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtDisplay.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay.Location = new System.Drawing.Point(0, 36);
            this.TxtDisplay.MaxLength = 14;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(263, 40);
            this.TxtDisplay.TabIndex = 0;
            this.TxtDisplay.Tag = "0";
            this.TxtDisplay.Text = "0";
            this.TxtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDisplay_KeyPress);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(263, 399);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.PanelButtons);
            this.Controls.Add(this.PanelControlWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.PanelControlWindows.ResumeLayout(false);
            this.PanelControlWindows.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtxIcon)).EndInit();
            this.PanelButtons.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelDisplay.ResumeLayout(false);
            this.PanelDisplay.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelControlWindows;
        private System.Windows.Forms.Label LblTitle;
        private FontAwesome.Sharp.IconPictureBox PtxIcon;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Btn9;
        private FontAwesome.Sharp.IconButton Btn8;
        private FontAwesome.Sharp.IconButton Btn7;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton Btn6;
        private FontAwesome.Sharp.IconButton Btn5;
        private FontAwesome.Sharp.IconButton Btn4;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Btn3;
        private FontAwesome.Sharp.IconButton Btn2;
        private FontAwesome.Sharp.IconButton Btn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton BtnSplit;
        private FontAwesome.Sharp.IconButton BtnMultiply;
        private FontAwesome.Sharp.IconButton BtnMinus;
        private FontAwesome.Sharp.IconButton BtnPlus;
        private FontAwesome.Sharp.IconButton BtnEqual;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton BtnRoot;
        private FontAwesome.Sharp.IconButton BtnPercentage;
        private FontAwesome.Sharp.IconButton BtnBackSpace;
        private System.Windows.Forms.Panel PanelDisplay;
        private System.Windows.Forms.TextBox TxtDisplay;
        private FontAwesome.Sharp.IconButton BtnExponent;
        private FontAwesome.Sharp.IconButton BtnDot;
        private FontAwesome.Sharp.IconButton Btn0;
        private FontAwesome.Sharp.IconButton BtnClear;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LblSing;
        private System.Windows.Forms.Label LblDisplay;
    }
}