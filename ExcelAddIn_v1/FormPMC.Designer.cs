namespace ExcelAddIn_v1
{
    partial class FormPMC
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
            this.btnImportPMC = new System.Windows.Forms.Button();
            this.btnEnviarData = new System.Windows.Forms.Button();
            this.dgvPMC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcantregs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPMC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportPMC
            // 
            this.btnImportPMC.Location = new System.Drawing.Point(12, 58);
            this.btnImportPMC.Name = "btnImportPMC";
            this.btnImportPMC.Size = new System.Drawing.Size(103, 27);
            this.btnImportPMC.TabIndex = 0;
            this.btnImportPMC.Text = "Importar";
            this.btnImportPMC.UseVisualStyleBackColor = true;
            this.btnImportPMC.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnEnviarData
            // 
            this.btnEnviarData.Location = new System.Drawing.Point(12, 321);
            this.btnEnviarData.Name = "btnEnviarData";
            this.btnEnviarData.Size = new System.Drawing.Size(103, 27);
            this.btnEnviarData.TabIndex = 1;
            this.btnEnviarData.Text = "Enviar a BD";
            this.btnEnviarData.UseVisualStyleBackColor = true;
            this.btnEnviarData.Click += new System.EventHandler(this.btnEnviarData_Click);
            // 
            // dgvPMC
            // 
            this.dgvPMC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPMC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPMC.Location = new System.Drawing.Point(125, 46);
            this.dgvPMC.Name = "dgvPMC";
            this.dgvPMC.Size = new System.Drawing.Size(703, 318);
            this.dgvPMC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Datos que se Guardarán en la Base de Datos SQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registros:";
            // 
            // lblcantregs
            // 
            this.lblcantregs.AutoSize = true;
            this.lblcantregs.Location = new System.Drawing.Point(802, 19);
            this.lblcantregs.Name = "lblcantregs";
            this.lblcantregs.Size = new System.Drawing.Size(13, 13);
            this.lblcantregs.TabIndex = 5;
            this.lblcantregs.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExcelAddIn_v1.Properties.Resources.excelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExcelAddIn_v1.Properties.Resources.bdsql;
            this.pictureBox2.Location = new System.Drawing.Point(27, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FormPMC
            // 
            this.ClientSize = new System.Drawing.Size(840, 376);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblcantregs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPMC);
            this.Controls.Add(this.btnEnviarData);
            this.Controls.Add(this.btnImportPMC);
            this.Name = "FormPMC";
            this.Text = "Precio Medio de Compra";
            this.Load += new System.EventHandler(this.FormPMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPMC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImportPMC;
        private System.Windows.Forms.Button btnEnviarData;
        private System.Windows.Forms.DataGridView dgvPMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcantregs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}