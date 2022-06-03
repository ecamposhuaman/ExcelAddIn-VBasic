namespace ExcelAddIn_v1
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnGuardarBD = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2A = new System.Windows.Forms.Label();
            this.lbl3A = new System.Windows.Forms.Label();
            this.lbl1A = new System.Windows.Forms.Label();
            this.lbl4A = new System.Windows.Forms.Label();
            this.lbl2B = new System.Windows.Forms.Label();
            this.lbl3B = new System.Windows.Forms.Label();
            this.lbl1B = new System.Windows.Forms.Label();
            this.lbl4B = new System.Windows.Forms.Label();
            this.lbl5A = new System.Windows.Forms.Label();
            this.lbl6A = new System.Windows.Forms.Label();
            this.lbl5B = new System.Windows.Forms.Label();
            this.lbl6B = new System.Windows.Forms.Label();
            this.lblregistros = new System.Windows.Forms.Label();
            this.lblCalVac = new System.Windows.Forms.Label();
            this.lblcantregs = new System.Windows.Forms.Label();
            this.lblcantcelvac = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(31, 483);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(123, 29);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnGuardarBD
            // 
            this.btnGuardarBD.Location = new System.Drawing.Point(632, 483);
            this.btnGuardarBD.Name = "btnGuardarBD";
            this.btnGuardarBD.Size = new System.Drawing.Size(123, 29);
            this.btnGuardarBD.TabIndex = 1;
            this.btnGuardarBD.Text = "Guardar en BD";
            this.btnGuardarBD.UseVisualStyleBackColor = true;
            this.btnGuardarBD.Click += new System.EventHandler(this.btnGuardarBD_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 41);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(763, 345);
            this.dgv.TabIndex = 2;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Datos que se Guardarán en la Base de Datos SQL Server";
            // 
            // lbl2A
            // 
            this.lbl2A.AutoSize = true;
            this.lbl2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2A.Location = new System.Drawing.Point(380, 419);
            this.lbl2A.Name = "lbl2A";
            this.lbl2A.Size = new System.Drawing.Size(121, 13);
            this.lbl2A.TabIndex = 5;
            this.lbl2A.Text = "1     Energía Distribuida:";
            // 
            // lbl3A
            // 
            this.lbl3A.AutoSize = true;
            this.lbl3A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3A.Location = new System.Drawing.Point(380, 439);
            this.lbl3A.Name = "lbl3A";
            this.lbl3A.Size = new System.Drawing.Size(126, 13);
            this.lbl3A.TabIndex = 6;
            this.lbl3A.Text = "2     Venta Energía + AP:";
            // 
            // lbl1A
            // 
            this.lbl1A.AutoSize = true;
            this.lbl1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1A.Location = new System.Drawing.Point(380, 399);
            this.lbl1A.Name = "lbl1A";
            this.lbl1A.Size = new System.Drawing.Size(148, 13);
            this.lbl1A.TabIndex = 7;
            this.lbl1A.Text = "12   Energía Total Entregada:";
            // 
            // lbl4A
            // 
            this.lbl4A.AutoSize = true;
            this.lbl4A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4A.Location = new System.Drawing.Point(380, 459);
            this.lbl4A.Name = "lbl4A";
            this.lbl4A.Size = new System.Drawing.Size(138, 13);
            this.lbl4A.TabIndex = 8;
            this.lbl4A.Text = "13   Energía Total Vendida:";
            // 
            // lbl2B
            // 
            this.lbl2B.AutoSize = true;
            this.lbl2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2B.Location = new System.Drawing.Point(531, 417);
            this.lbl2B.Name = "lbl2B";
            this.lbl2B.Size = new System.Drawing.Size(40, 15);
            this.lbl2B.TabIndex = 9;
            this.lbl2B.Text = "lbl2B";
            // 
            // lbl3B
            // 
            this.lbl3B.AutoSize = true;
            this.lbl3B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3B.Location = new System.Drawing.Point(531, 437);
            this.lbl3B.Name = "lbl3B";
            this.lbl3B.Size = new System.Drawing.Size(40, 15);
            this.lbl3B.TabIndex = 10;
            this.lbl3B.Text = "lbl3B";
            // 
            // lbl1B
            // 
            this.lbl1B.AutoSize = true;
            this.lbl1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1B.Location = new System.Drawing.Point(531, 397);
            this.lbl1B.Name = "lbl1B";
            this.lbl1B.Size = new System.Drawing.Size(40, 15);
            this.lbl1B.TabIndex = 11;
            this.lbl1B.Text = "lbl1B";
            // 
            // lbl4B
            // 
            this.lbl4B.AutoSize = true;
            this.lbl4B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4B.Location = new System.Drawing.Point(531, 457);
            this.lbl4B.Name = "lbl4B";
            this.lbl4B.Size = new System.Drawing.Size(40, 15);
            this.lbl4B.TabIndex = 12;
            this.lbl4B.Text = "lbl4B";
            // 
            // lbl5A
            // 
            this.lbl5A.AutoSize = true;
            this.lbl5A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5A.Location = new System.Drawing.Point(380, 479);
            this.lbl5A.Name = "lbl5A";
            this.lbl5A.Size = new System.Drawing.Size(142, 13);
            this.lbl5A.TabIndex = 14;
            this.lbl5A.Text = "16   Energia Entregada CLT:";
            // 
            // lbl6A
            // 
            this.lbl6A.AutoSize = true;
            this.lbl6A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6A.Location = new System.Drawing.Point(380, 499);
            this.lbl6A.Name = "lbl6A";
            this.lbl6A.Size = new System.Drawing.Size(121, 13);
            this.lbl6A.TabIndex = 15;
            this.lbl6A.Text = "17   Venta Energia CLT:";
            // 
            // lbl5B
            // 
            this.lbl5B.AutoSize = true;
            this.lbl5B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5B.Location = new System.Drawing.Point(531, 477);
            this.lbl5B.Name = "lbl5B";
            this.lbl5B.Size = new System.Drawing.Size(40, 15);
            this.lbl5B.TabIndex = 16;
            this.lbl5B.Text = "lbl5B";
            // 
            // lbl6B
            // 
            this.lbl6B.AutoSize = true;
            this.lbl6B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6B.Location = new System.Drawing.Point(531, 497);
            this.lbl6B.Name = "lbl6B";
            this.lbl6B.Size = new System.Drawing.Size(40, 15);
            this.lbl6B.TabIndex = 17;
            this.lbl6B.Text = "lbl6B";
            // 
            // lblregistros
            // 
            this.lblregistros.AutoSize = true;
            this.lblregistros.Location = new System.Drawing.Point(650, 5);
            this.lblregistros.Name = "lblregistros";
            this.lblregistros.Size = new System.Drawing.Size(57, 13);
            this.lblregistros.TabIndex = 18;
            this.lblregistros.Text = "Registros: ";
            // 
            // lblCalVac
            // 
            this.lblCalVac.AutoSize = true;
            this.lblCalVac.Location = new System.Drawing.Point(650, 22);
            this.lblCalVac.Name = "lblCalVac";
            this.lblCalVac.Size = new System.Drawing.Size(79, 13);
            this.lblCalVac.TabIndex = 19;
            this.lblCalVac.Text = "Celdas Vacías:";
            // 
            // lblcantregs
            // 
            this.lblcantregs.AutoSize = true;
            this.lblcantregs.Location = new System.Drawing.Point(743, 4);
            this.lblcantregs.Name = "lblcantregs";
            this.lblcantregs.Size = new System.Drawing.Size(13, 13);
            this.lblcantregs.TabIndex = 20;
            this.lblcantregs.Text = "0";
            // 
            // lblcantcelvac
            // 
            this.lblcantcelvac.AutoSize = true;
            this.lblcantcelvac.Location = new System.Drawing.Point(743, 22);
            this.lblcantcelvac.Name = "lblcantcelvac";
            this.lblcantcelvac.Size = new System.Drawing.Size(13, 13);
            this.lblcantcelvac.TabIndex = 21;
            this.lblcantcelvac.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExcelAddIn_v1.Properties.Resources.excelLogo;
            this.pictureBox2.Location = new System.Drawing.Point(48, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExcelAddIn_v1.Properties.Resources.bdsql;
            this.pictureBox1.Location = new System.Drawing.Point(646, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(787, 523);
            this.Controls.Add(this.lblcantcelvac);
            this.Controls.Add(this.lblcantregs);
            this.Controls.Add(this.lblCalVac);
            this.Controls.Add(this.lblregistros);
            this.Controls.Add(this.lbl6B);
            this.Controls.Add(this.lbl5B);
            this.Controls.Add(this.lbl6A);
            this.Controls.Add(this.lbl5A);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl4B);
            this.Controls.Add(this.lbl1B);
            this.Controls.Add(this.lbl3B);
            this.Controls.Add(this.lbl2B);
            this.Controls.Add(this.lbl4A);
            this.Controls.Add(this.lbl1A);
            this.Controls.Add(this.lbl3A);
            this.Controls.Add(this.lbl2A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnGuardarBD);
            this.Controls.Add(this.btnImportar);
            this.Name = "Form1";
            this.Text = "Visualicación de los datos a Enviar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnGuardarBD;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2A;
        private System.Windows.Forms.Label lbl3A;
        private System.Windows.Forms.Label lbl1A;
        private System.Windows.Forms.Label lbl4A;
        private System.Windows.Forms.Label lbl2B;
        private System.Windows.Forms.Label lbl3B;
        private System.Windows.Forms.Label lbl1B;
        private System.Windows.Forms.Label lbl4B;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl5A;
        private System.Windows.Forms.Label lbl6A;
        private System.Windows.Forms.Label lbl5B;
        private System.Windows.Forms.Label lbl6B;
        private System.Windows.Forms.Label lblregistros;
        private System.Windows.Forms.Label lblCalVac;
        private System.Windows.Forms.Label lblcantregs;
        private System.Windows.Forms.Label lblcantcelvac;
    }
}