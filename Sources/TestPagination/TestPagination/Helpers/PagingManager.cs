using System;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace TestPagination.Helpers
{
    public class PagingManager
    {
        private readonly GridControl _gridControl;
        private readonly LabelControl _displayPageNumber;
        private readonly ComboBoxEdit _cmbPageSize;
        private readonly RandomDataSourceGenerator _randomDataSourceGenerator;
        public int PageSize { get; set; }
        private readonly DataTable _dataTable;

        public int MaxRec { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public int RecNo { get; set; }

        public PagingManager(GridControl gridControl, LabelControl displayPageNumber, ComboBoxEdit cmbPageSize, RandomDataSourceGenerator randomDataSourceGenerator)
        {
            _gridControl = gridControl;
            _displayPageNumber = displayPageNumber;
            _cmbPageSize = cmbPageSize;
            _randomDataSourceGenerator = randomDataSourceGenerator;
            _dataTable = _randomDataSourceGenerator.Generate(300);
            Init();
            LoadPage();
        }

        public void Init()
        {
            PageSize = Convert.ToInt32(_cmbPageSize.Text);
            MaxRec = _dataTable.Rows.Count;
            PageCount = MaxRec / PageSize;
            if (MaxRec % PageSize == 0)
            {
                PageCount--;
            }
            CurrentPage = 1;
            RecNo = 0;
        }

        public void LoadPage()
        {
            int startRec = RecNo;
            int endRec;
            DataTable dtTemp = _dataTable.Clone();
            if(CurrentPage == PageCount)
            {
               endRec = MaxRec; 
            }
            else
            {
                endRec = PageSize * CurrentPage;
            }
            for (int i = startRec; i < endRec; i++)
            {
                if(i < _dataTable.Rows.Count)
                {
                    dtTemp.ImportRow(_dataTable.Rows[i]);
                    RecNo++;
                }
            }
            _gridControl.DataSource = dtTemp;
            DisplayPageInfo();
        }

        private void DisplayPageInfo()
        {
            _displayPageNumber.Text = string.Format("Page {0}/ {1}", CurrentPage, PageCount);
        }

        public void FirstPage()
        {
            if (CurrentPage != 1)
            {
                CurrentPage = 1;
                RecNo = 0;
                LoadPage();
            }
        }

        public void LastPage()
        {
            if (CurrentPage == PageCount)
            {
                return;
            }
            CurrentPage = PageCount;
            RecNo = PageSize * (CurrentPage - 1);
            LoadPage();
        }

        public void PreviousPage()
        {
            if(CurrentPage == 1)
            {
                return;
            }

            CurrentPage = CurrentPage - 1;
            if (CurrentPage < 1)
                CurrentPage = 1;
            else
                RecNo = PageSize * (CurrentPage - 1);

            LoadPage();
        }

        public void NextPage()
        {
            if (CurrentPage == PageCount)
            {
                return;
            }
            CurrentPage = CurrentPage + 1;
            if (CurrentPage > PageCount)
            {
                CurrentPage = PageCount;
            }
            LoadPage();
        }
    }
}