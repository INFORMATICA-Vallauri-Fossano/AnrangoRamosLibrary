using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnrangoRamosLibrary
{
    /// <summary>
    /// ASSUNTI:
    /// <list type="bullet">
    ///     <item>
    ///         <description>Server utilizzato: Visual studio 2022 MSSQL local</description>
    ///     </item>
    ///     <item>
    ///         <description>FileDatabase in Bin/Debug</description>
    ///     </item>
    /// </list>
    /// </summary>

    internal class SqlFillControls
    {
        private string dbName;
        private static string connectionString;
        public string DbName { get => dbName; set {
                dbName = value;
                connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" +
                                Application.StartupPath + "\\" + dbName +
                                ";Integrated Security=True;Connect Timeout=30";
            } }

        public static void FillComboBox(System.Windows.Forms.ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            System.Data.DataTable table = new System.Data.DataTable();
                            table.Load(reader);
                            comboBox.DataSource = table;
                            comboBox.DisplayMember = displayMember;
                            comboBox.ValueMember = valueMember;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static void FillDataGridView(System.Windows.Forms.DataGridView dataGridView, string query)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            System.Data.DataTable table = new System.Data.DataTable();
                            table.Load(reader);
                            dataGridView.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        public static void FillDataGridView(System.Windows.Forms.DataGridView dataGridView, string query, string[] columns)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    connection.Open();
                    using (System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection))
                    {
                        using (System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader())
                        {
                            System.Data.DataTable table = new System.Data.DataTable();
                            table.Load(reader);
                            dataGridView.DataSource = table;
                            for (int i = 0; i < columns.Length; i++)
                            {
                                dataGridView.Columns[i].HeaderText = columns[i];
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    } }
