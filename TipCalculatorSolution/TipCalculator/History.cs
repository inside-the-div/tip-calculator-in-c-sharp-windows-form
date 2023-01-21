﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class History : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source=.; Initial Catalog = tip_calculator_db; TrustServerCertificate=True; Integrated Security=True ");
        public History()
        {
            InitializeComponent();
        }

        public void DisplayHistory()
        {
            string HistoryShow = "SELECT bill_id AS ID, " +
                "bill_time AS 'Date', " +
                "bill AS 'Bill', " +
                "tip_persentage AS 'Tips %', " +
                "total_tip AS 'Total Tip',  " +
                "total_person AS Persons, " +
                "tip_per_person AS 'Every Person Tip', " +
                "total_bill AS 'Total Bill' " +
                "FROM tip_calculator_history";
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter(HistoryShow, DBconnection);
            DataTable HistoryDataTable = new DataTable();
            SQLselectQuery.Fill(HistoryDataTable);
            DatagridviewHistory.DataSource = HistoryDataTable;
            this.DatagridviewHistory.Columns["ID"].Visible = false;
        }

        private void History_Load(object sender, EventArgs e)
        {
            DisplayHistory();
            DatagridviewHistory.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            TipCalculator tipCalculator = new TipCalculator();
            tipCalculator.Show();
        }

        private void dateTimePickerSearch_ValueChanged(object sender, EventArgs e)
        {
            string SearchDate = dateTimePickerSearch.Value.ToShortDateString().ToLower();
            foreach (DataGridViewRow row in DatagridviewHistory.Rows)
            {
                string GridViewDateTime = row.Cells[1].Value.ToString().ToLower();
                string[] SplitGridViewDateTime = GridViewDateTime.Split(' ');
                string GridViewDate = SplitGridViewDateTime[0].ToString().ToLower();
                if (!GridViewDate.Contains(SearchDate))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewHistory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[DatagridviewHistory.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
            DatagridviewHistory.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Ids = string.Empty;
            foreach (DataGridViewRow row in DatagridviewHistory.SelectedRows)
            {
                int id = (int)row.Cells[0].Value;
                Ids += id.ToString() + ",";
            }
            Ids = Ids.TrimEnd(',');
            if (Ids == "")
            {
                MessageBox.Show("Select a History frist.");
            }
            else
            {
                string DeleteQuerry = "DELETE FROM tip_calculator_history WHERE  bill_id IN (" + Ids + ")";
                DBconnection.Open();
                SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection);
                if (deleteCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Selected History deleted successfully.");
                    DatagridviewHistory.ClearSelection();
                }
                DBconnection.Close();
                DisplayHistory();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            string DeleteQuerry = "DELETE FROM tip_calculator_history";
            DBconnection.Open();
            SqlCommand deleteCommand = new SqlCommand(DeleteQuerry, DBconnection);
            if (deleteCommand.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("All History deleted successfully.");
                DatagridviewHistory.ClearSelection();
            }
            DBconnection.Close();
            DisplayHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayHistory();
            DatagridviewHistory.ClearSelection();
        }
    }
}
