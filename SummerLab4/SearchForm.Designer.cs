namespace ComputerAccessoriesApp
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.lblType = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();

            // comboBoxSearchType
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.Location = new System.Drawing.Point(130, 20);
            this.comboBoxSearchType.Size = new System.Drawing.Size(200, 24);

            // lblType
            this.lblType.Location = new System.Drawing.Point(30, 23);
            this.lblType.Text = "Тип пристрою:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(130, 60);
            this.txtSearch.Size = new System.Drawing.Size(200, 22);

            // lblText
            this.lblText.Location = new System.Drawing.Point(30, 63);
            this.lblText.Text = "Пошук по назві або виробнику:";

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(130, 100);
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.Text = "Пошук";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dataGridViewResults
            this.dataGridViewResults.Location = new System.Drawing.Point(30, 150);
            this.dataGridViewResults.Size = new System.Drawing.Size(600, 250);

            // SearchForm
            this.ClientSize = new System.Drawing.Size(680, 430);
            this.Controls.Add(this.comboBoxSearchType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewResults);
            this.Text = "Пошук пристроїв";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
