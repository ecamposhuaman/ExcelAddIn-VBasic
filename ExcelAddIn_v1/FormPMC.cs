using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn_v1
{
    public partial class FormPMC : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapterPer, MyDataAdapterInfo;
        DataTable dt, dtInfo, dtPer;
        public FormPMC()
        {
            InitializeComponent();
            this.btnEnviarData.Enabled = false;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000; toolTip1.InitialDelay = 100; toolTip1.ReshowDelay = 500; toolTip1.IsBalloon = false;
            toolTip1.SetToolTip(this.btnImportPMC, "Buscar archivo con el formato '.xls' (VERSION ANTERIOR) y asegurarse de que el nombre de la hoja a importar sea 'Precios Medios'. \nAdemás en la Fila '2' del archivo deberia mostrarse la fecha, necesaria para obtener el periodo de los datos a enviar");

        }

        String NomTabla = "IndicadoresDatos";

        private void FormPMC_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string nomHoja = "Precios Medios";        //Hoja (Default) de donde se extraen los datos
            string ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xls";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }
                //--------------------------------------------------------------------------------------
                //iduunn: Aya, Hyo, Hych, Jau, Conc, Chup, Hvca, Hnco, TinM, Tar, Pasco, SelC, ELC      ...ORDEN DE LAS UUNN
                int[] iduunn = { 76, 77, 77, 83, 83, 83, 78, 82, 84, 79, 81, 80, 0 };
                int[] idssee = { 1,  1,  2,  2,  1,  3,  1,  1,  1,  1,  1,  1,  0 };      //idssee ordenados segun uunn presentes en el archivo Excel
                //int[] FactExpanc = { 1, 1, 2, 2, 1, 3, 1, 1, 1, 1, 1, 1, 0 };
                int idtipo = 2;                                             //Ejecutado
                string usuario = Environment.UserName;
                string maquina = Environment.MachineName;
                DateTime fecha = Convert.ToDateTime((String.Format("{0:G}", DateTime.Now)));//DateTime.Today;
                
                //--------------------------------------------------------------------------------------
                dtInfo = new DataTable("Informacion");
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + "; Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1;';"); //Horientation=Horizontal;
                conn.Open();
                MyDataAdapterInfo = new OleDbDataAdapter
                    ("(Select * from [" + nomHoja + "$A27:IV40])", conn);
                MyDataAdapterInfo.Fill(dtInfo);
                conn.Close();
                
                int column = 0;
                for (int i = 1; i < 1000; i++)
                {
                    if (dtInfo.Rows[0]["F" + i].ToString() == null || string.IsNullOrEmpty(dtInfo.Rows[0]["F" + i].ToString()))
                    {
                        // MessageBox.Show("celda vacia encontrda: F" + i, "ExcelAddIn", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        column = i - 1;
                        { break; }
                    }
                }

                dtPer = new DataTable("periodoConsulta");
                conn.Open();
                MyDataAdapterPer = new OleDbDataAdapter
                    ("(Select * from [" + nomHoja + "$A2:IV2])", conn);  //Celda con dato necesario para asignar el PERIODO
                MyDataAdapterPer.Fill(dtPer);
                conn.Close();


                string fech = dtPer.Rows[0]["F" + column].ToString();
                //MessageBox.Show("celda vacia encontrda: F" + fech, "ExcelAddIn", MessageBoxButtons.OK, MessageBoxIcon.Question);
                string per1 = fech.Substring(6, 4) + fech.Substring(3, 2);
                int periodInt = Int32.Parse(per1);
                


                // CREACION DE LA ESTRUCTURA DE LA TABLA (DataTable --> DataGridView)
                dt = new DataTable("Balance");

                DataColumn Colidtipodato = new DataColumn();
                Colidtipodato.DataType = System.Type.GetType("System.Int32");
                Colidtipodato.Caption = "idtipodato"; Colidtipodato.ColumnName = "idtipodato";
                dt.Columns.Add(Colidtipodato);

                DataColumn ColPeriodo = new DataColumn();
                ColPeriodo.DataType = System.Type.GetType("System.Int32");
                ColPeriodo.Caption = "periodo"; ColPeriodo.ColumnName = "periodo";
                dt.Columns.Add(ColPeriodo);

                DataColumn ColValores = new DataColumn();
                ColValores.DataType = System.Type.GetType("System.Decimal");
                ColValores.Caption = "valor"; ColValores.ColumnName = "valor";
                dt.Columns.Add(ColValores);

                DataColumn Coliduunn = new DataColumn();
                Coliduunn.DataType = System.Type.GetType("System.Int32");
                Coliduunn.Caption = "iduunn"; Coliduunn.ColumnName = "iduunn";
                dt.Columns.Add(Coliduunn);

                DataColumn Colidssee = new DataColumn();
                Colidssee.DataType = System.Type.GetType("System.Int32");
                Colidssee.Caption = "idssee"; Colidssee.ColumnName = "idssee";
                dt.Columns.Add(Colidssee);

                DataColumn Colidtipo = new DataColumn();
                Colidtipo.DataType = System.Type.GetType("System.Int32");
                Colidtipo.Caption = "idtipo"; Colidtipo.ColumnName = "idtipo";
                dt.Columns.Add(Colidtipo);

                DataColumn Colosuser = new DataColumn();
                Colosuser.DataType = System.Type.GetType("System.String");
                Colosuser.Caption = "osuser"; Colosuser.ColumnName = "osuser";
                dt.Columns.Add(Colosuser);

                DataColumn Colosmaquina = new DataColumn();
                Colosmaquina.DataType = System.Type.GetType("System.String");
                Colosmaquina.Caption = "osmaquina"; Colosmaquina.ColumnName = "osmaquina";
                dt.Columns.Add(Colosmaquina);

                DataColumn Colosdate = new DataColumn();
                Colosdate.DataType = System.Type.GetType("System.String");
                Colosdate.Caption = "osdate"; Colosdate.ColumnName = "osdate";
                dt.Columns.Add(Colosdate);

                int nFilas = dtInfo.Rows.Count;
                int acum = 0;
                
                    for (int j = 0; j < nFilas-1; j++)        //12 valores de un Indicador por Periodo
                    {
                        DataRow row1;
                        row1 = dt.NewRow();
                        row1["idtipodato"] = 14;
                        row1["periodo"] = periodInt;
                        dt.Rows.Add(row1);
                    }

                    // La columna "valor" se obtiene a partir de un Enlace de datos OLEDB y el resto de las columnas a partir de Constantes
                    // Esta forma diferente de asignar Datos es para mantener las relaciones en la informacion que sera guardada en la Base de Datos
                    //int ssss = column - 1;
                    for (int j = 0; j < nFilas-1; j++)        //12 valores de un Indicador por Periodo
                    {
                        int a = j + 1;
                        DataRow row2;
                        row2 = dt.NewRow();
                        
                            row2 = dt.Rows[j]; row2["valor"] = dtInfo.Rows[a]["F" + column].ToString();

                        row2 = dt.Rows[j]; row2["iduunn"] = iduunn[j];
                        row2 = dt.Rows[j]; row2["idssee"] = idssee[j];
                        row2 = dt.Rows[j]; row2["idtipo"] = idtipo;
                        row2 = dt.Rows[j]; row2["osuser"] = usuario;
                        row2 = dt.Rows[j]; row2["osmaquina"] = maquina;
                        row2 = dt.Rows[j]; row2["osdate"] = fecha;
                        acum++;
                    }

                conn.Close();
                dgvPMC.DataSource = dt;

                dgvPMC.AllowUserToAddRows = false; //Eliminando la Ultima Fila (La  fila vacia por defecto)
                dgvPMC.ColumnHeadersVisible = true;
                dgvPMC.AutoResizeColumns();

                lblcantregs.Text = Convert.ToString(dgvPMC.RowCount);
                if (dgvPMC.Rows.Count == 0)
                {
                    btnEnviarData.Enabled = false;
                }
                else
                {
                    btnEnviarData.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!   No se seleccionó ningún archivo Excel.");
            }
        }

        private void btnEnviarData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta usted seguro de Enviar los datos visualizados anteriormente a la Base de Datos SQL?", "Confirmación de Envio de Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                SqlConnection conexion_destino = new SqlConnection();
                conexion_destino.ConnectionString = "Persist Security Info=False;Data Source=sdb40007;Initial Catalog=Spider_Comercial;User ID = userweb;Password = userweb69"; //Integrated Security = True
                conexion_destino.Open();
                SqlBulkCopy importar = default(SqlBulkCopy);
                importar = new SqlBulkCopy(conexion_destino);
                importar.DestinationTableName = NomTabla;
                importar.WriteToServer(dt);
                conexion_destino.Close();
                
                if (MessageBox.Show("Los datos fueron enviados y registrados correctamente en la Base de Datos", "ExcelAddIn", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
