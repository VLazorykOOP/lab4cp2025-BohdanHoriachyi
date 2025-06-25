namespace ComputerAccessoriesApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графічніАдаптериToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDПристроїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вінчестериToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизаціяToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графічніАдаптериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDПристроїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вінчестериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графічніАдаптериToolStripMenuItem,
            this.cDПристроїToolStripMenuItem,
            this.вінчестериToolStripMenuItem,
            this.авторизаціяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // графічніАдаптериToolStripMenuItem
            this.графічніАдаптериToolStripMenuItem.Name = "графічніАдаптериToolStripMenuItem";
            this.графічніАдаптериToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.графічніАдаптериToolStripMenuItem.Text = "Графічні адаптери";
            this.графічніАдаптериToolStripMenuItem.Click += new System.EventHandler(this.графічніАдаптериToolStripMenuItem_Click);

            // cDПристроїToolStripMenuItem
            this.cDПристроїToolStripMenuItem.Name = "cDПристроїToolStripMenuItem";
            this.cDПристроїToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.cDПристроїToolStripMenuItem.Text = "CD пристрої";
            this.cDПристроїToolStripMenuItem.Click += new System.EventHandler(this.cDПристроїToolStripMenuItem_Click);

            // вінчестериToolStripMenuItem
            this.вінчестериToolStripMenuItem.Name = "вінчестериToolStripMenuItem";
            this.вінчестериToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.вінчестериToolStripMenuItem.Text = "Вінчестери";
            this.вінчестериToolStripMenuItem.Click += new System.EventHandler(this.вінчестериToolStripMenuItem_Click);

            // авторизаціяToolStripMenuItem
            this.авторизаціяToolStripMenuItem.Name = "авторизаціяToolStripMenuItem";
            this.авторизаціяToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.авторизаціяToolStripMenuItem.Text = "Авторизація";
            this.авторизаціяToolStripMenuItem.Click += new System.EventHandler(this.авторизаціяToolStripMenuItem_Click);

            // dataGridView1
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                              | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 360);
            this.dataGridView1.TabIndex = 1;

            // btnRefresh
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(340, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Оновити";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Облік комп’ютерних аксесуарів";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
