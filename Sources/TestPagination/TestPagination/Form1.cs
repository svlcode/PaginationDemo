using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TestPagination.Helpers;

namespace TestPagination
{
    public partial class Form1 : Form
    {
        PagingManager _pagingManager;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pagingManager = new PagingManager(gridControl1, lblDisplayPageNo, cmbPageSize, new RandomDataSourceGenerator());
        }
       

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            //RefreshData();
        }

        private void spinEditNumberOfRows_EditValueChanged(object sender, EventArgs e)
        {
            //RefreshData();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            _pagingManager.FirstPage();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            _pagingManager.LastPage();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            _pagingManager.PreviousPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _pagingManager.NextPage();
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            _pagingManager.Init();
            _pagingManager.LoadPage();
        }

        //public void RefreshData()
        //{
        //    int numberOfRows = (int)spinEditNumberOfRows.Value;
        //    var dt = _randomDataSourceGenerator.Generate(numberOfRows);
        //    gridControl1.DataSource = dt;
        //}
    }
}
