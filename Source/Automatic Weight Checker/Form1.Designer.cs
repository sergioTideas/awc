namespace Automatic_Weight_Checker
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
            this.F_LD_EPFNUMBER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pkgTxt = new System.Windows.Forms.TextBox();
            this.pkgLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.B_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.validarBtn = new System.Windows.Forms.Button();
            this.valoresGv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LENGTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UOQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WEIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresGv)).BeginInit();
            this.SuspendLayout();
            // 
            // F_LD_EPFNUMBER
            // 
            this.F_LD_EPFNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_LD_EPFNUMBER.ForeColor = System.Drawing.Color.LimeGreen;
            this.F_LD_EPFNUMBER.Location = new System.Drawing.Point(3, 130);
            this.F_LD_EPFNUMBER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.F_LD_EPFNUMBER.Name = "F_LD_EPFNUMBER";
            this.F_LD_EPFNUMBER.Size = new System.Drawing.Size(1031, 59);
            this.F_LD_EPFNUMBER.TabIndex = 0;
            this.F_LD_EPFNUMBER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(347, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 1;
            // 
            // pkgTxt
            // 
            this.pkgTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pkgTxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.pkgTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pkgTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgTxt.Location = new System.Drawing.Point(288, 279);
            this.pkgTxt.Margin = new System.Windows.Forms.Padding(4);
            this.pkgTxt.MaxLength = 10;
            this.pkgTxt.Name = "pkgTxt";
            this.pkgTxt.Size = new System.Drawing.Size(864, 83);
            this.pkgTxt.TabIndex = 2;
            this.pkgTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pkgTxt_KeyDown);
            // 
            // pkgLbl
            // 
            this.pkgLbl.AutoSize = true;
            this.pkgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgLbl.ForeColor = System.Drawing.Color.Green;
            this.pkgLbl.Location = new System.Drawing.Point(298, 217);
            this.pkgLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pkgLbl.Name = "pkgLbl";
            this.pkgLbl.Size = new System.Drawing.Size(0, 31);
            this.pkgLbl.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(17, 485);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 530);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 31);
            this.label5.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(301, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 131);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1444, 107);
            this.label6.TabIndex = 0;
            this.label6.Text = "CHECADOR DE PESO AUTOMÁTICO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.B_Exit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1444, 209);
            this.panel2.TabIndex = 11;
            // 
            // B_Exit
            // 
            this.B_Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.B_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Image = ((System.Drawing.Image)(resources.GetObject("B_Exit.Image")));
            this.B_Exit.Location = new System.Drawing.Point(0, 0);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(89, 209);
            this.B_Exit.TabIndex = 3;
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Automatic_Weight_Checker.Properties.Resources.refresh2;
            this.button1.Location = new System.Drawing.Point(1077, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 209);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1269, 131);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 451);
            this.panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Automatic_Weight_Checker.Properties.Resources.scan2;
            this.pictureBox1.Location = new System.Drawing.Point(353, 380);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // validarBtn
            // 
            this.validarBtn.Location = new System.Drawing.Point(1041, 152);
            this.validarBtn.Name = "validarBtn";
            this.validarBtn.Size = new System.Drawing.Size(221, 40);
            this.validarBtn.TabIndex = 15;
            this.validarBtn.Text = "Revisar Peso";
            this.validarBtn.UseVisualStyleBackColor = true;
            this.validarBtn.Click += new System.EventHandler(this.validarBtn_Click);
            // 
            // valoresGv
            // 
            this.valoresGv.AllowUserToAddRows = false;
            this.valoresGv.AllowUserToDeleteRows = false;
            this.valoresGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.valoresGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ITEM,
            this.LENGTH,
            this.UOL,
            this.COLOR,
            this.QTY,
            this.UOQ,
            this.WEIGHT});
            this.valoresGv.Location = new System.Drawing.Point(288, 380);
            this.valoresGv.Name = "valoresGv";
            this.valoresGv.RowHeadersWidth = 51;
            this.valoresGv.RowTemplate.Height = 24;
            this.valoresGv.Size = new System.Drawing.Size(864, 186);
            this.valoresGv.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "SUBNUMBER";
            this.Column1.HeaderText = "SUBNo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 83;
            // 
            // ITEM
            // 
            this.ITEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ITEM.DataPropertyName = "ITEM";
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.MinimumWidth = 6;
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Width = 69;
            // 
            // LENGTH
            // 
            this.LENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LENGTH.DataPropertyName = "LENGTH";
            this.LENGTH.HeaderText = "LENGTH";
            this.LENGTH.MinimumWidth = 6;
            this.LENGTH.Name = "LENGTH";
            this.LENGTH.ReadOnly = true;
            this.LENGTH.Width = 94;
            // 
            // UOL
            // 
            this.UOL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UOL.DataPropertyName = "UOL";
            this.UOL.HeaderText = "UOL";
            this.UOL.MinimumWidth = 6;
            this.UOL.Name = "UOL";
            this.UOL.ReadOnly = true;
            this.UOL.Width = 66;
            // 
            // COLOR
            // 
            this.COLOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.COLOR.DataPropertyName = "COLOR";
            this.COLOR.HeaderText = "COLOR";
            this.COLOR.MinimumWidth = 6;
            this.COLOR.Name = "COLOR";
            this.COLOR.ReadOnly = true;
            this.COLOR.Width = 86;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.QTY.DataPropertyName = "QTY";
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 66;
            // 
            // UOQ
            // 
            this.UOQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UOQ.DataPropertyName = "UOQ";
            this.UOQ.HeaderText = "UOQ";
            this.UOQ.MinimumWidth = 6;
            this.UOQ.Name = "UOQ";
            this.UOQ.ReadOnly = true;
            this.UOQ.Width = 69;
            // 
            // WEIGHT
            // 
            this.WEIGHT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WEIGHT.DataPropertyName = "WEIGHT";
            this.WEIGHT.HeaderText = "WEIGHT";
            this.WEIGHT.MinimumWidth = 6;
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.ReadOnly = true;
            this.WEIGHT.Width = 92;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(1041, 208);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(221, 40);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Nuevo Pesaje";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 791);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.valoresGv);
            this.Controls.Add(this.validarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pkgLbl);
            this.Controls.Add(this.pkgTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_LD_EPFNUMBER);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valoresGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label F_LD_EPFNUMBER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pkgTxt;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pkgLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button validarBtn;
        private System.Windows.Forms.DataGridView valoresGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn LENGTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn UOQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn WEIGHT;
        private System.Windows.Forms.Button cancelBtn;
    }
}