namespace ControlePCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Banco db = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqliteConnection connection = new(@".\Data\database.db");
            db.CreateTableComputadores();
            UpdateDtPrincipal();
            lb_version.Text = Banco.version;
        }
        public void UpdateDtPrincipal()
        {
            var count = 0;
            int win = 0, lin = 0;
            if (dtPrincipal.Rows.Count > 0)
            {
                dtPrincipal.Rows.Clear();
            }
            var cmd = db.UpdateDatabase();
            cmd.ForEach(pc =>
            {
                dtPrincipal.Rows.Add(pc.Id,pc.Piso, pc.Local, pc.Dono, pc.Hostname, pc.IP, pc.Mac, pc.SO);
                count++;
                if (pc.SO!.ToLower().Contains("windows")) { win++; }
                if (pc.SO.ToLower().Contains("linux")){ lin++; }
            });
            lb_total.Text = count.ToString();
            lb_linux.Text = lin.ToString();
            lb_windows.Text = win.ToString();
        }

        private void tsm_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPc add = new();
            add.ShowDialog();
            UpdateDtPrincipal();
        }

        private void addComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_add_Click(sender, e);
        }

        private void btn_rm_Click(object sender, EventArgs e)
        {
            var a = dtPrincipal.CurrentRow;
            //MessageBox.Show(a["dlHostname"].Value.ToString());
            db.RemovePC(a.Cells["ID"].Value.ToString()!);
            UpdateDtPrincipal();
        }

        private void deletarSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_rm_Click(sender, e);
        }



        private void dtPrincipal_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var cel = dtPrincipal.CurrentRow;
            var a = dtPrincipal.CurrentCell;

            //var indice = cel.Cells["Hostname"].Value.ToString()!;
            //ComputadoresModel comp = new()
            //{
            //    Piso = Int32.Parse(cel.Cells["PISO"].Value.ToString()!),
            //    Local = cel.Cells[1].Value.ToString(),
            //    Dono = cel.Cells[2].Value.ToString(),
            //    Hostname = cel.Cells[3].Value.ToString(),
            //    IP = cel.Cells[4].Value.ToString(),
            //    Mac = cel.Cells[5].Value.ToString(),
            //    SO = cel.Cells[6].Value.ToString(),
            //};
            //MessageBox.Show(a);
            db.UpdateCurrentPC(a.OwningColumn.Name, a.Value.ToString()!, cel.Cells["ID"].Value.ToString()!);
            UpdateDtPrincipal();
        }

        
    }
}