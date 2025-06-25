namespace ComputerAccessoriesApp
{
    partial class DeviceForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDeviceType;
        private System.Windows.Forms.Label lblSelectType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.NumericUpDown numericValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxDeviceType = new System.Windows.Forms.ComboBox();
            this.lblSelectType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            this.SuspendLayout();

            // comboBoxDeviceType
            this.comboBoxDeviceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeviceType.Location = new System.Drawing.Point(170, 25);
            this.comboBoxDeviceType.Name = "comboBoxDeviceType";
            this.comboBoxDeviceType.Size = new System.Drawing.Size(200, 24);

            // lblSelectType
            this.lblSelectType.AutoSize = true;
            this.lblSelectType.Location = new System.Drawing.Point(30, 28);
            this.lblSelectType.Text = "Тип пристрою:";

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(30, 70);
            this.lblType.Text = "Тип моделі:";

            // txtType
            this.txtType.Location = new System.Drawing.Point(170, 67);
            this.txtType.Size = new System.Drawing.Size(200, 22);

            // lblManufacturer
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(30, 110);
            this.lblManufacturer.Text = "Виробник:";

            // txtManufacturer
            this.txtManufacturer.Location = new System.Drawing.Point(170, 107);
            this.txtManufacturer.Size = new System.Drawing.Size(200, 22);

            // lblValue
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(30, 150);
            this.lblValue.Text = "Параметр:";

            // numericValue
            this.numericValue.Location = new System.Drawing.Point(170, 147);
            this.numericValue.Maximum = 10000;
            this.numericValue.Minimum = 1;
            this.numericValue.Value = 1;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(170, 190);
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.Text = "Зберегти";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // DeviceForm
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.comboBoxDeviceType);
            this.Controls.Add(this.lblSelectType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.numericValue);
            this.Controls.Add(this.btnSave);
            this.Name = "DeviceForm";
            this.Text = "Додати пристрій";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
