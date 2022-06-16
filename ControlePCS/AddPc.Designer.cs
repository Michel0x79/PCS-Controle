namespace ControlePCS
{
    partial class AddPc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPc));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Piso = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_hostname = new System.Windows.Forms.TextBox();
            this.tb_so = new System.Windows.Forms.TextBox();
            this.tb_dono = new System.Windows.Forms.TextBox();
            this.tb_local = new System.Windows.Forms.TextBox();
            this.tb_mac = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Novo PC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.cb_Piso);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_ok);
            this.panel1.Controls.Add(this.tb_hostname);
            this.panel1.Controls.Add(this.tb_so);
            this.panel1.Controls.Add(this.tb_dono);
            this.panel1.Controls.Add(this.tb_local);
            this.panel1.Controls.Add(this.tb_mac);
            this.panel1.Controls.Add(this.tb_ip);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 486);
            this.panel1.TabIndex = 1;
            // 
            // cb_Piso
            // 
            this.cb_Piso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_Piso.FormattingEnabled = true;
            this.cb_Piso.Items.AddRange(new object[] {
            "2",
            "1",
            "01",
            "02",
            "03",
            "04"});
            this.cb_Piso.Location = new System.Drawing.Point(174, 75);
            this.cb_Piso.Name = "cb_Piso";
            this.cb_Piso.Size = new System.Drawing.Size(151, 32);
            this.cb_Piso.TabIndex = 9;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BackgroundImage = global::ControlePCS.Properties.Resources.botao_cancelar_md;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.Location = new System.Drawing.Point(285, 397);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(130, 57);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BackgroundImage = global::ControlePCS.Properties.Resources.botao_confirmar_hi;
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ok.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ok.Location = new System.Drawing.Point(96, 397);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(130, 57);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_hostname
            // 
            this.tb_hostname.AcceptsTab = true;
            this.tb_hostname.Location = new System.Drawing.Point(174, 199);
            this.tb_hostname.Name = "tb_hostname";
            this.tb_hostname.Size = new System.Drawing.Size(125, 32);
            this.tb_hostname.TabIndex = 4;
            // 
            // tb_so
            // 
            this.tb_so.AcceptsTab = true;
            this.tb_so.Location = new System.Drawing.Point(174, 322);
            this.tb_so.Name = "tb_so";
            this.tb_so.Size = new System.Drawing.Size(199, 32);
            this.tb_so.TabIndex = 7;
            // 
            // tb_dono
            // 
            this.tb_dono.AcceptsTab = true;
            this.tb_dono.Location = new System.Drawing.Point(174, 157);
            this.tb_dono.Name = "tb_dono";
            this.tb_dono.Size = new System.Drawing.Size(287, 32);
            this.tb_dono.TabIndex = 3;
            // 
            // tb_local
            // 
            this.tb_local.AcceptsTab = true;
            this.tb_local.Location = new System.Drawing.Point(174, 117);
            this.tb_local.Name = "tb_local";
            this.tb_local.Size = new System.Drawing.Size(144, 32);
            this.tb_local.TabIndex = 2;
            // 
            // tb_mac
            // 
            this.tb_mac.AcceptsTab = true;
            this.tb_mac.Location = new System.Drawing.Point(174, 280);
            this.tb_mac.Name = "tb_mac";
            this.tb_mac.Size = new System.Drawing.Size(174, 32);
            this.tb_mac.TabIndex = 6;
            // 
            // tb_ip
            // 
            this.tb_ip.AcceptsTab = true;
            this.tb_ip.Location = new System.Drawing.Point(174, 240);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(174, 32);
            this.tb_ip.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 320);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label8.Size = new System.Drawing.Size(80, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sistema:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 202);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label5.Size = new System.Drawing.Size(100, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hostname:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "IP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 278);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label6.Size = new System.Drawing.Size(55, 34);
            this.label6.TabIndex = 0;
            this.label6.Text = "MAC:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label3.Size = new System.Drawing.Size(147, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Compartimento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label4.Size = new System.Drawing.Size(116, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Proprietário:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 73);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label2.Size = new System.Drawing.Size(49, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Piso:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddPc
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(549, 486);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPc_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btn_cancelar;
        private Button btn_ok;
        private TextBox tb_hostname;
        private TextBox tb_so;
        private TextBox tb_dono;
        private TextBox tb_local;
        private TextBox tb_mac;
        private TextBox tb_ip;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private ComboBox cb_Piso;
    }
}