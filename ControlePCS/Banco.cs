using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlePCS.Models;
using Dapper;
using Microsoft.Data.Sqlite;

namespace ControlePCS
{
    class Banco
    {
        public static readonly string version = "1.0.0.0";
        //private SqliteConnection con = new(@"Data Source=C:\Users\Michel\Documents\database.db;Cache=Shared");
        readonly private SqliteConnection con = new(@$"Data Source=database.db;");

        public SqliteConnection GetConnection()
        {
            //using var cnn = this.con;
            return con;
        }
        public void CreateTableComputadores()
        {
            using var cnn = con;
            string sql = @"CREATE TABLE IF NOT EXISTS COMPUTADORES(
                            ID INTEGER       PRIMARY KEY AUTOINCREMENT
                            UNIQUE ON CONFLICT ROLLBACK,
                            PISO INT           NOT NULL,
                            LOCAL    VARCHAR(100) NOT NULL,
                            DONO     VARCHAR(200) NOT NULL,
                            HOSTNAME VARCHAR(10),
                            IP VARCHAR(15)  NOT NULL,
                            MAC      VARCHAR(20)  NOT NULL,
                            SO       VARCHAR(20)
                        );";
            cnn.Query(sql);
        }
        
        public List<ComputadoresModel> UpdateDatabase()
        {
            using(var cnn = this.con)
            {
               var cmd = cnn.Query<ComputadoresModel>("SELECT * FROM COMPUTADORES").ToList();
               return cmd;
            }
        }

        public void RemovePC(string remove)
        {
            try
            {
                using (var cnn = this.con)
                {
                    var cmd = cnn.QueryAsync($"DELETE FROM COMPUTADORES WHERE ID = '{Int32.Parse(remove)}';");
                MessageBox.Show($"Computador Removido!", "Sucesso");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Error: {e}", "Error");
            }
        }
        public void UpdateCurrentPC(string field, object val, string updatepc)
        {
            ComputadoresModel pc = new() { Id = Int32.Parse(updatepc) };
            try
            {
                using (var cnn = this.con)
                {
                    cnn.Query<ComputadoresModel>($@"UPDATE COMPUTADORES SET {field} = '{val}' WHERE ID = @Id; ", pc);
                    MessageBox.Show($"Computador Atualizado !", "Sucesso");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e}", "Error");
            }
        }
    }
}
