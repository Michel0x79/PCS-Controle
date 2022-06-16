namespace ControlePCS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComputadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarSelecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtPrincipal = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_rm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_windows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_linux = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // programaToolStripMenuItem
            // 
            this.programaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sair});
            this.programaToolStripMenuItem.Name = "programaToolStripMenuItem";
            resources.ApplyResources(this.programaToolStripMenuItem, "programaToolStripMenuItem");
            // 
            // tsm_sair
            // 
            this.tsm_sair.Name = "tsm_sair";
            resources.ApplyResources(this.tsm_sair, "tsm_sair");
            this.tsm_sair.Click += new System.EventHandler(this.tsm_sair_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComputadorToolStripMenuItem,
            this.deletarSelecionadoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            resources.ApplyResources(this.editarToolStripMenuItem, "editarToolStripMenuItem");
            // 
            // addComputadorToolStripMenuItem
            // 
            this.addComputadorToolStripMenuItem.Name = "addComputadorToolStripMenuItem";
            resources.ApplyResources(this.addComputadorToolStripMenuItem, "addComputadorToolStripMenuItem");
            this.addComputadorToolStripMenuItem.Click += new System.EventHandler(this.addComputadorToolStripMenuItem_Click);
            // 
            // deletarSelecionadoToolStripMenuItem
            // 
            this.deletarSelecionadoToolStripMenuItem.Name = "deletarSelecionadoToolStripMenuItem";
            resources.ApplyResources(this.deletarSelecionadoToolStripMenuItem, "deletarSelecionadoToolStripMenuItem");
            this.deletarSelecionadoToolStripMenuItem.Click += new System.EventHandler(this.deletarSelecionadoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            // 
            // dtPrincipal
            // 
            this.dtPrincipal.AllowUserToAddRows = false;
            this.dtPrincipal.AllowUserToDeleteRows = false;
            this.dtPrincipal.AllowUserToResizeRows = false;
            this.dtPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtPrincipal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.dtPrincipal, "dtPrincipal");
            this.dtPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PISO,
            this.LOCAL,
            this.DONO,
            this.HOSTNAME,
            this.IP,
            this.MAC,
            this.SO});
            this.dtPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtPrincipal.MultiSelect = false;
            this.dtPrincipal.Name = "dtPrincipal";
            this.dtPrincipal.RowHeadersVisible = false;
            this.dtPrincipal.RowTemplate.Height = 29;
            this.dtPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtPrincipal.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPrincipal_CellEndEdit);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            resources.ApplyResources(this.ID, "ID");
            this.ID.MaxInputLength = 50;
            this.ID.Name = "ID";
            // 
            // PISO
            // 
            this.PISO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PISO.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.PISO, "PISO");
            this.PISO.MaxInputLength = 60;
            this.PISO.Name = "PISO";
            // 
            // LOCAL
            // 
            this.LOCAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.LOCAL.FillWeight = 9.229106F;
            resources.ApplyResources(this.LOCAL, "LOCAL");
            this.LOCAL.Name = "LOCAL";
            // 
            // DONO
            // 
            this.DONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.DONO.FillWeight = 218.7493F;
            resources.ApplyResources(this.DONO, "DONO");
            this.DONO.Name = "DONO";
            // 
            // HOSTNAME
            // 
            this.HOSTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOSTNAME.FillWeight = 9.229106F;
            resources.ApplyResources(this.HOSTNAME, "HOSTNAME");
            this.HOSTNAME.Name = "HOSTNAME";
            // 
            // IP
            // 
            this.IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IP.FillWeight = 9.229106F;
            resources.ApplyResources(this.IP, "IP");
            this.IP.Name = "IP";
            // 
            // MAC
            // 
            this.MAC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAC.FillWeight = 9.229106F;
            resources.ApplyResources(this.MAC, "MAC");
            this.MAC.Name = "MAC";
            // 
            // SO
            // 
            this.SO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SO.FillWeight = 9.229106F;
            resources.ApplyResources(this.SO, "SO");
            this.SO.Name = "SO";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = global::ControlePCS.Properties.Resources.addimg;
            resources.ApplyResources(this.btn_add, "btn_add");
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_add.Name = "btn_add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_rm
            // 
            this.btn_rm.BackColor = System.Drawing.Color.Transparent;
            this.btn_rm.BackgroundImage = global::ControlePCS.Properties.Resources.removeimg;
            resources.ApplyResources(this.btn_rm, "btn_rm");
            this.btn_rm.FlatAppearance.BorderSize = 0;
            this.btn_rm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_rm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.UseVisualStyleBackColor = false;
            this.btn_rm.Click += new System.EventHandler(this.btn_rm_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Name = "label1";
            // 
            // lb_total
            // 
            resources.ApplyResources(this.lb_total, "lb_total");
            this.lb_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_total.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_total.Name = "lb_total";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Name = "label2";
            // 
            // lb_windows
            // 
            resources.ApplyResources(this.lb_windows, "lb_windows");
            this.lb_windows.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_windows.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_windows.Name = "lb_windows";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Name = "label4";
            // 
            // lb_linux
            // 
            resources.ApplyResources(this.lb_linux, "lb_linux");
            this.lb_linux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_linux.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb_linux.Name = "lb_linux";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lb_version
            // 
            resources.ApplyResources(this.lb_version, "lb_version");
            this.lb_version.Name = "lb_version";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_linux);
            this.Controls.Add(this.lb_windows);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_rm);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programaToolStripMenuItem;
        private ToolStripMenuItem tsm_sair;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private DataGridView dtPrincipal;
        private Button btn_add;
        private Button btn_rm;
        private ToolStripMenuItem addComputadorToolStripMenuItem;
        private ToolStripMenuItem deletarSelecionadoToolStripMenuItem;
        private Label label1;
        private Label lb_total;
        private Label label2;
        private Label lb_windows;
        private Label label4;
        private Label lb_linux;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PISO;
        private DataGridViewTextBoxColumn LOCAL;
        private DataGridViewTextBoxColumn DONO;
        private DataGridViewTextBoxColumn HOSTNAME;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn MAC;
        private DataGridViewTextBoxColumn SO;
        private Label label3;
        private Label lb_version;
    }
}