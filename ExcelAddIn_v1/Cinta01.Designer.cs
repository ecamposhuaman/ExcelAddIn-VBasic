namespace ExcelAddIn_v1
{
    partial class Cinta01 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Cinta01()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnGuardarED = this.Factory.CreateRibbonButton();
            this.btnPrecioMC = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "Sync To SQL";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnGuardarED);
            this.group1.Items.Add(this.btnPrecioMC);
            this.group1.Label = "Envío de Datos";
            this.group1.Name = "group1";
            // 
            // btnGuardarED
            // 
            this.btnGuardarED.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnGuardarED.Image = global::ExcelAddIn_v1.Properties.Resources.iconov1;
            this.btnGuardarED.Label = "Enviar Balance";
            this.btnGuardarED.Name = "btnGuardarED";
            this.btnGuardarED.ScreenTip = "Enviar datos de un Formato Balance de Energia te dipo *.xlsx";
            this.btnGuardarED.ShowImage = true;
            this.btnGuardarED.SuperTip = "Permite Seleccionar un Formato de Balance de Energia y enviar datos a SQL Server";
            this.btnGuardarED.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGuardarED_Click);
            // 
            // btnPrecioMC
            // 
            this.btnPrecioMC.Image = global::ExcelAddIn_v1.Properties.Resources.soles6;
            this.btnPrecioMC.Label = "Enviar PMC";
            this.btnPrecioMC.Name = "btnPrecioMC";
            this.btnPrecioMC.ScreenTip = "Envio de Precios Medios de Compra";
            this.btnPrecioMC.ShowImage = true;
            this.btnPrecioMC.SuperTip = "Permite el envío de Precios Medios de Compra a la Base de Datos SQL";
            this.btnPrecioMC.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPrecioMC_Click);
            // 
            // Cinta01
            // 
            this.Name = "Cinta01";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Cinta01_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGuardarED;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPrecioMC;
    }

    partial class ThisRibbonCollection
    {
        internal Cinta01 Cinta01
        {
            get { return this.GetRibbon<Cinta01>(); }
        }
    }
}
