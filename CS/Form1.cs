using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i % 30), i, 3 - i % 40, DateTime.Now.AddDays(i % 10) });
            return tbl;
        }

        private object CreateCollectionDataSouce(int rowCount)
        {
            BindingList<Customer> bl = new BindingList<Customer>(); ;
            for (int i = 0; i < rowCount; i++)
                bl.Add(new Customer { FirstName = String.Format("FirstName{0}", i % 30), LastName = String.Format("FirstName{0}", i % 30), ID=i });
            return bl;
        }
        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(200);
            gridControl3.DataSource = CreateCollectionDataSouce(200);
        }


    }
}
