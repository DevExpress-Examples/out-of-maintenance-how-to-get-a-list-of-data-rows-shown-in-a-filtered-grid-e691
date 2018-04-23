namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridViewDataTable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.filteredDataSource_DataTable = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewFilteredDataView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filteredDataSourceHelper_DataTable = new WindowsApplication1.FilteredDataSourceHelperComponent();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridViewBindingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridViewFilteredBindingList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filteredDataSourceHelper_BindingList = new WindowsApplication1.FilteredDataSourceHelperComponent();
            this.filteredDataSource_BindingList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredDataSource_DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilteredDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilteredBindingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredDataSource_BindingList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(394, 547);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "DataSet";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 21);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(390, 524);
            this.splitContainerControl1.SplitterPosition = 231;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridViewDataTable;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(390, 231);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDataTable,
            this.gridView2});
            // 
            // gridViewDataTable
            // 
            this.gridViewDataTable.GridControl = this.gridControl1;
            this.gridViewDataTable.Name = "gridViewDataTable";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(390, 288);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "GridControl bound to a filtered datasource";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.filteredDataSource_DataTable;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 21);
            this.gridControl2.MainView = this.gridViewFilteredDataView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(386, 265);
            this.gridControl2.TabIndex = 9;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFilteredDataView,
            this.gridView4});
            // 
            // gridViewFilteredDataView
            // 
            this.gridViewFilteredDataView.GridControl = this.gridControl2;
            this.gridViewFilteredDataView.Name = "gridViewFilteredDataView";
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            // 
            // filteredDataSourceHelper_DataTable
            // 
            this.filteredDataSourceHelper_DataTable.FilteredDataSource = this.filteredDataSource_DataTable;
            this.filteredDataSourceHelper_DataTable.View = this.gridViewDataTable;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.splitContainerControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(394, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(457, 547);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "BindingList";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(2, 21);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl3);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl4);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(453, 524);
            this.splitContainerControl2.SplitterPosition = 231;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridViewBindingList;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(453, 231);
            this.gridControl3.TabIndex = 7;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBindingList,
            this.gridView6});
            // 
            // gridViewBindingList
            // 
            this.gridViewBindingList.GridControl = this.gridControl3;
            this.gridViewBindingList.Name = "gridViewBindingList";
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl3;
            this.gridView6.Name = "gridView6";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControl4);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(453, 288);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "GridControl bound to a filtered datasource";
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.filteredDataSource_BindingList;
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(2, 21);
            this.gridControl4.MainView = this.gridViewFilteredBindingList;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(449, 265);
            this.gridControl4.TabIndex = 9;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFilteredBindingList,
            this.gridView8});
            // 
            // gridViewFilteredBindingList
            // 
            this.gridViewFilteredBindingList.GridControl = this.gridControl4;
            this.gridViewFilteredBindingList.Name = "gridViewFilteredBindingList";
            // 
            // gridView8
            // 
            this.gridView8.GridControl = this.gridControl4;
            this.gridView8.Name = "gridView8";
            // 
            // filteredDataSourceHelper_BindingList
            // 
            this.filteredDataSourceHelper_BindingList.FilteredDataSource = this.filteredDataSource_BindingList;
            this.filteredDataSourceHelper_BindingList.View = this.gridViewBindingList;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 547);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredDataSource_DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilteredDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBindingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFilteredBindingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteredDataSource_BindingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDataTable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private FilteredDataSourceHelperComponent filteredDataSourceHelper_DataTable;
        private System.Windows.Forms.BindingSource filteredDataSource_DataTable;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFilteredDataView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBindingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFilteredBindingList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private FilteredDataSourceHelperComponent filteredDataSourceHelper_BindingList;
        private System.Windows.Forms.BindingSource filteredDataSource_BindingList;

    }
}

