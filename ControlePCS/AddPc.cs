using ControlePCS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Data.Sqlite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePCS
{
    public partial class AddPc : Form
    {
        public AddPc()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                Banco db = new();
                ComputadoresModel et = new()
                {
                    Piso = Int32.Parse((string)cb_Piso.SelectedItem),
                    Local = tb_local.Text,
                    Dono = tb_dono.Text,
                    Hostname = tb_hostname.Text,
                    IP = tb_ip.Text,
                    Mac = tb_mac.Text,
                    SO = tb_so.Text
                };

                string sql = @"INSERT INTO COMPUTADORES(PISO,LOCAL,DONO,HOSTNAME,IP,MAC,SO) VALUES (@Piso,@Local,@Dono,@Hostname,@IP,@Mac,@SO);";
                using (SqliteConnection connection = db.GetConnection())
                {
                    connection.Query<ComputadoresModel>(sql, et);
                }
                MessageBox.Show("Adicionado com Sucesso!", "Sucesso!");
                db.UpdateDatabase();
                this.Close();
            }catch { MessageBox.Show("Valores não podem ser Nulo!", "Error"); }
        }

        private void AddPc_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
