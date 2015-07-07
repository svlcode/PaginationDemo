namespace TestPagination
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditNumberOfRows = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPageSize = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblDisplayPageNo = new DevExpress.XtraEditors.LabelControl();
            this.btnNextPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviousPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnLastPage = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirstPage = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNumberOfRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPageSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(15, 38);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(663, 501);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(603, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // spinEditNumberOfRows
            // 
            this.spinEditNumberOfRows.EditValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.spinEditNumberOfRows.Location = new System.Drawing.Point(102, 12);
            this.spinEditNumberOfRows.Name = "spinEditNumberOfRows";
            this.spinEditNumberOfRows.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditNumberOfRows.Properties.Mask.EditMask = "n0";
            this.spinEditNumberOfRows.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spinEditNumberOfRows.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditNumberOfRows.Size = new System.Drawing.Size(100, 20);
            this.spinEditNumberOfRows.TabIndex = 2;
            this.spinEditNumberOfRows.EditValueChanged += new System.EventHandler(this.spinEditNumberOfRows_EditValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of rows:";
            // 
            // cmbPageSize
            // 
            this.cmbPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPageSize.EditValue = "5";
            this.cmbPageSize.Location = new System.Drawing.Point(320, 548);
            this.cmbPageSize.Name = "cmbPageSize";
            this.cmbPageSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPageSize.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "50",
            "100"});
            this.cmbPageSize.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPageSize.Size = new System.Drawing.Size(48, 20);
            this.cmbPageSize.TabIndex = 10;
            this.cmbPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbPageSize_SelectedIndexChanged);
            // 
            // LabelControl2
            // 
            this.LabelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl2.Location = new System.Drawing.Point(266, 550);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(50, 13);
            this.LabelControl2.TabIndex = 8;
            this.LabelControl2.Text = "Page Size:";
            // 
            // lblDisplayPageNo
            // 
            this.lblDisplayPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplayPageNo.Location = new System.Drawing.Point(505, 550);
            this.lblDisplayPageNo.Name = "lblDisplayPageNo";
            this.lblDisplayPageNo.Size = new System.Drawing.Size(29, 13);
            this.lblDisplayPageNo.TabIndex = 9;
            this.lblDisplayPageNo.Text = "Pages";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextPage.Location = new System.Drawing.Point(572, 545);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(59, 23);
            this.btnNextPage.TabIndex = 4;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviousPage.Location = new System.Drawing.Point(421, 545);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(59, 23);
            this.btnPreviousPage.TabIndex = 5;
            this.btnPreviousPage.Text = "Previous";
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLastPage.Location = new System.Drawing.Point(637, 545);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(41, 23);
            this.btnLastPage.TabIndex = 6;
            this.btnLastPage.Text = "Last";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstPage.Location = new System.Drawing.Point(374, 545);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(41, 23);
            this.btnFirstPage.TabIndex = 7;
            this.btnFirstPage.Text = "First";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 580);
            this.Controls.Add(this.cmbPageSize);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.lblDisplayPageNo);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spinEditNumberOfRows);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Test Pagination";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditNumberOfRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPageSize.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SpinEdit spinEditNumberOfRows;
        private System.Windows.Forms.Label label1;
        internal DevExpress.XtraEditors.ComboBoxEdit cmbPageSize;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl lblDisplayPageNo;
        internal DevExpress.XtraEditors.SimpleButton btnNextPage;
        internal DevExpress.XtraEditors.SimpleButton btnPreviousPage;
        internal DevExpress.XtraEditors.SimpleButton btnLastPage;
        internal DevExpress.XtraEditors.SimpleButton btnFirstPage;
    }
}

