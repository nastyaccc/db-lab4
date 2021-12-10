using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iut_dbm_lw4
{
    public partial class Form1 : Form
    {
        private MySqlConnection Connection;

        public Form1(MySqlConnection connection)
        {
            Connection = connection;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateAll();
        }

        public void UpdateAll()
        {
            Hotel.SetConnection(Connection);
            Carrier.SetConnection(Connection);
            Route.SetConnection(Connection);
            Hotel.CacheUpdate();
            Carrier.CacheUpdate();
            Route.CacheUpdate();

            if (hotelsDataGridView.Columns.Count == 0 
                || carriersDataGridView.Columns.Count == 0 
                || routesDataGridView.Columns.Count == 0)
            {
                return;
            }

            hotelsDataGridView.Rows.Clear();
            List<string[]> hotelsData = Hotel.GetCachedLikeString();
            foreach (string[] hotel in hotelsData)
            {
                hotelsDataGridView.Rows.Add(hotel);
            }

            carriersDataGridView.Rows.Clear();
            List<string[]> carriersData = Carrier.GetCachedLikeString();
            foreach (string[] carrier in carriersData)
            {
                carriersDataGridView.Rows.Add(carrier);
            }

            routesDataGridView.Rows.Clear();
            List<string[]> routesData = Carrier.GetCachedLikeString();
            foreach (string[] route in routesData)
            {
                routesDataGridView.Rows.Add(route);
            }
        }

        private void hotelsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Hotel.Cache.Count)
            {
                int Id = Convert.ToInt32(hotelsDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Name = hotelsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Hotel hotel = Hotel.Cache.ContainsKey(Id) ? Hotel.Cache[Id] : null;
                if (hotel != null)
                {
                    if (hotel.Title != Name)
                    {
                        hotel.Title = Name;
                        hotel.Update();
                    }
                }
            } else if (e.RowIndex == Hotel.Cache.Count)
            {
                string Name = hotelsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Name != "")
                {
                    Hotel.Create(Name);
                }
            }
            UpdateAll();
        }

        private void hotelsDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }

        private void hotelsDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                hotelsDataGridView.Rows[e.RowIndex].Selected = true;
                hotelsDataGridView.CurrentCell = hotelsDataGridView.Rows[e.RowIndex].Cells[1];
                hotelsDataGridViewContextMenuStrip.Show(this.hotelsDataGridView, e.Location);
                hotelsDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(hotelsDataGridView.CurrentRow.Cells[0].Value);
            Hotel.Delete(Id);
            UpdateAll();
        }

        private void carriersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < Carrier.Cache.Count)
            {
                int Id = Convert.ToInt32(carriersDataGridView.Rows[e.RowIndex].Cells[0].Value);
                string Name = carriersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                Carrier carrier = Carrier.Cache.ContainsKey(Id) ? Carrier.Cache[Id] : null;
                if (carrier != null)
                {
                    if (carrier.Title != Name)
                    {
                        carrier.Title = Name;
                        carrier.Update();
                    }
                }
            }
            else if (e.RowIndex == Carrier.Cache.Count)
            {
                string Name = carriersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Name != "")
                {
                    Carrier.Create(Name);
                }
            }
            UpdateAll();
        }

        private void carriersDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                carriersDataGridView.Rows[e.RowIndex].Selected = true;
                carriersDataGridView.CurrentCell = carriersDataGridView.Rows[e.RowIndex].Cells[1];
                carriersDataGridViewContextMenuStrip.Show(this.carriersDataGridView, e.Location);
                carriersDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void carriersDataGridViewContextMenuStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(carriersDataGridView.CurrentRow.Cells[0].Value);
            Carrier.Delete(Id);
            UpdateAll();
        }

        private void routesDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Id = Convert.ToInt32(routesDataGridView.Rows[e.RowIndex].Cells[0].Value);
            (new Form2(Route.GetById<Route>(Id), this)).Show();
            this.Hide();
        }

        private void routesDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                routesDataGridView.Rows[e.RowIndex].Selected = true;
                routesDataGridView.CurrentCell = routesDataGridView.Rows[e.RowIndex].Cells[1];
                routesDataGridViewContextMenuStrip.Show(this.routesDataGridView, e.Location);
                routesDataGridViewContextMenuStrip.Show(Cursor.Position);
            }
        }

        private void routesDataGridViewContextMenuStrip_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(routesDataGridView.CurrentRow.Cells[0].Value);
            Route.Delete(Id);
            UpdateAll();
        }

        private void routesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void routesLabel_Click(object sender, EventArgs e)
        {

        }

        private void carriersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
