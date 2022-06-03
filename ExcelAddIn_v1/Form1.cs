using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ExcelAddIn_v1
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter MyDataAdapterVal, MyDataAdapterInfo;
        DataTable dt, dtVal, dtInfo;

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            this.btnGuardarBD.Enabled = false;

            this.lbl1A.Visible = false; this.lbl1B.Visible = false;
            this.lbl2A.Visible = false; this.lbl2B.Visible = false;
            this.lbl3A.Visible = false; this.lbl3B.Visible = false;
            this.lbl4A.Visible = false; this.lbl4B.Visible = false;
            this.lbl5A.Visible = false; this.lbl5B.Visible = false;
            this.lbl6A.Visible = false; this.lbl6B.Visible = false;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;toolTip1.InitialDelay = 100;toolTip1.ReshowDelay = 500; toolTip1.IsBalloon = false;
            toolTip1.SetToolTip(this.btnImportar, "Buscar archivo con formato '.xlsx' y asegurarse de que el nombre de la hoja a importar sea 'BalanceEjecutado'. \nAdemás la celda 'P7' de esta debe contener el periodo en formato de Fecha");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String NomTabla = "IndicadoresDatos";       //Registramos el nombre de la Tabla destino
        private void btnImportar_Click(object sender, EventArgs e)
        {
            string nomHoja = "BalanceEjecutado";        //Hoja (Default) de donde se extraen los datos
            string ruta = "";
            try
            {
                OpenFileDialog openfile1 = new OpenFileDialog();
                openfile1.Filter = "Excel Files |*.xlsx";
                openfile1.Title = "Seleccione el archivo de Excel";
                if (openfile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openfile1.FileName.Equals("") == false)
                    {
                        ruta = openfile1.FileName;
                    }
                }


                //Variables de Apoyo a la lectura del archivo excel
                int NumIndicadores = 6; //Cantidad de indicadores en la Hoja Excel
                string ColINI = "B"; string ColFIN = "N";         //Rango de columnas con valores en el Archivo Excel (de B hasta N)
                int deleteColumn = 7;       //contado a partir de 1... para eliminar la columna "TOTAL - Hyo" del archivo excel
                string[] FilasIndic = { "37", "38", "10", "47", "46" };         //Filas de los 4 INDICADORES + CLTerceros(46)

                //DATOS CONSTANTES NECESARIOS
                double FactPerd = 1.013;
                int[] idtipodato = { 1, 2, 12, 13, 17, 16 };                    //IdTipoDato de las Filas (Fila 37 = idtipodato 1, Fila 10 = idtipodato 12... etc y de las filas de CLT)
                //iduunn: Aya, Hyo, Hych, Chp, Conc, Jau, Hvca, Tar, Selv, Hnco, Pasco, TinM
                int[] iduunn = { 76, 77, 77, 83, 83, 83, 78, 79, 80, 82, 81, 84 };
                int[] idssee = { 1, 1, 2, 3, 1, 2, 1, 1, 1, 1, 1, 1 };      //idssee ordenados segun uunn presentes en el archivo Excel
                int idtipo = 2;                                             //Ejecutado
                string usuario = Environment.UserName;
                string maquina = Environment.MachineName;
                DateTime fecha = Convert.ToDateTime((String.Format("{0:G}", DateTime.Now)));//DateTime.Today;

                //Microsoft Jet para versiones anteriores de Office
                dtInfo = new DataTable("Informacion");
                conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'"); //Horientation=Horizontal;
                conn.Open();
                MyDataAdapterInfo = new OleDbDataAdapter
                    ("(Select * from [" + nomHoja + "$P7:P7])", conn);  //Celda con dato necesario para asignar el PERIODO
                MyDataAdapterInfo.Fill(dtInfo);
                conn.Close();
                string fech = dtInfo.Rows[0]["F1"].ToString();
                string per1 = fech.Substring(6, 4) + fech.Substring(3, 2);
                int periodInt = Int32.Parse(per1);                     //Periodo Creado

                dtVal = new DataTable("Valores");       //Se resume las 13 columnas del Excel (uunn) y 4 filas (Indicadores) del Libro Excel
                conn.Open();
                MyDataAdapterVal = new OleDbDataAdapter(
                                                        "(Select * from [" + nomHoja + "$" + ColINI + FilasIndic[0] + ":" + ColFIN + FilasIndic[0] + "])" // 1  Energia Distribuida
                                      + " union all " + "(Select * from [" + nomHoja + "$" + ColINI + FilasIndic[1] + ":" + ColFIN + FilasIndic[1] + "])" // 2  Venta de Energia + AP
                                      + " union all " + "(Select * from [" + nomHoja + "$" + ColINI + FilasIndic[2] + ":" + ColFIN + FilasIndic[2] + "])" // 12 Energia Total Entregada
                                      + " union all " + "(Select * from [" + nomHoja + "$" + ColINI + FilasIndic[3] + ":" + ColFIN + FilasIndic[3] + "])" // 13 Energia Total Vendida
                                      + " union all " + "(Select * from [" + nomHoja + "$" + ColINI + FilasIndic[4] + ":" + ColFIN + FilasIndic[4] + "])" // 17 Venta de Energía Clientes Libres Terceros
                                      , conn);
                MyDataAdapterVal.Fill(dtVal);
                conn.Close();

                string delCol = "F" + deleteColumn;
                dtVal.Columns.Remove(delCol);   //eliminando la columna "Total" (col 7) ...Los DataTable identifican a sus columnas con F1, F2, F3, etc...
                int nColumnas = dtVal.Columns.Count; //Conteo de Columnas
                //Renombrando y ordenando asi las columnas del DataTable
                int colum = deleteColumn + 1;
                for (int i = colum; i <= nColumnas + 1; i++)
                {
                    int ns = i - 1;
                    dtVal.Columns["F" + i].ColumnName = "F" + ns;
                }
                //Añadiendo el Indicador 16 producto de: indicador 17 x Factor de Perdida (1.013) EN DATA TABLE dtVal
                DataRow NewRowVal;
                NewRowVal = dtVal.NewRow();
                for (int nv = 1; nv <= nColumnas; nv++)
                {
                    if (dtVal.Rows[4]["F" + nv].ToString() != "")
                    {
                        NewRowVal["F" + nv] = Convert.ToDecimal(Convert.ToDouble(dtVal.Rows[4]["F" + nv].ToString()) * FactPerd);
                    }
                    else
                    {
                        /////
                    }
                }
                dtVal.Rows.Add(NewRowVal);

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

                int acum = 0;
                for (int i = 0; i < NumIndicadores; i++)             //Para el rellenado de 6 filas de Indicadores 
                {
                    for (int j = 0; j < nColumnas; j++)        //12 valores de un Indicador por Periodo
                    {
                        DataRow row1;
                        row1 = dt.NewRow();
                        row1["idtipodato"] = idtipodato[i];
                        row1["periodo"] = periodInt;
                        dt.Rows.Add(row1);
                    }

                    // La columna "valor" se obtiene a partir de un Enlace de datos OLEDB y el resto de las columnas a partir de Constantes
                    // Esta forma diferente de asignar Datos es para mantener las relaciones en la informacion que sera guardada en la Base de Datos
                    for (int j = 0; j < nColumnas; j++)        //12 valores de un Indicador por Periodo
                    {
                        int a = j + 1;
                        DataRow row2;
                        row2 = dt.NewRow();
                        if (dtVal.Rows[i]["F" + a].ToString() != "")
                        {
                            row2 = dt.Rows[acum]; row2["valor"] = dtVal.Rows[i]["F" + a].ToString();
                        }
                        row2 = dt.Rows[acum]; row2["iduunn"] = iduunn[j];
                        row2 = dt.Rows[acum]; row2["idssee"] = idssee[j];
                        row2 = dt.Rows[acum]; row2["idtipo"] = idtipo;
                        row2 = dt.Rows[acum]; row2["osuser"] = usuario;
                        row2 = dt.Rows[acum]; row2["osmaquina"] = maquina;
                        row2 = dt.Rows[acum]; row2["osdate"] = fecha;
                        acum++;
                    }
                }

                //---------------------
                int localiz = 5;
                int acumrem = 0;
                for (int i = 0; i < 2; i++)     //Para modificar datos de los primeros 2 indicadores
                {
                    for (int j = 0; j < nColumnas; j++)
                    {
                        DataRow row1;
                        row1 = dt.NewRow();
                        row1["idtipodato"] = idtipodato[i];
                        row1["periodo"] = periodInt;
                        dt.Rows.Add(row1);
                    }

                    for (int j = 0; j < nColumnas; j++)
                    {
                        int a = j + 1;
                        DataRow row2;
                        row2 = dt.NewRow();
                        if (dtVal.Rows[localiz]["F" + a].ToString() != "")
                        {
                            row2 = dt.Rows[acumrem]; row2["valor"] = Convert.ToDecimal(dtVal.Rows[i]["F" + a].ToString()) - Convert.ToDecimal(dtVal.Rows[localiz]["F" + a].ToString());
                            row2 = dt.Rows[acumrem]; row2["iduunn"] = iduunn[j];
                            row2 = dt.Rows[acumrem]; row2["idssee"] = idssee[j];
                            row2 = dt.Rows[acumrem]; row2["idtipo"] = idtipo;
                            row2 = dt.Rows[acumrem]; row2["osuser"] = usuario;
                            row2 = dt.Rows[acumrem]; row2["osmaquina"] = maquina;
                            row2 = dt.Rows[acumrem]; row2["osdate"] = fecha;
                        }
                        acumrem++;
                    }
                    localiz--;
                }
                //---------------------

                //////////////////////
                int dtcount = dt.Rows.Count;
                for (int i = 0; i < dtcount; i++)
                {
                    if (dt.Rows[i]["valor"].ToString() == null || string.IsNullOrEmpty(dt.Rows[i]["valor"].ToString()))
                    {
                        //Eliminar Fila en DataTable
                        DataRow RowDelete = dt.NewRow();
                        RowDelete = dt.Rows[i];
                        dt.Rows.Remove(RowDelete);
                        i--;
                        dtcount--;
                    }
                }
                //////////////////////
                
                dgv.DataSource = dt;
                //Convirtiendo valores de 'KILO' a 'MEGA'
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells["valor"].Value = Convert.ToDecimal(row.Cells["valor"].Value)/1000;
                }

                dgv.AllowUserToAddRows = false; //Eliminando la Ultima Fila (La  fila vacia por defecto)

                /*//Eliminar Fila en DataGridView
                DataGridViewRow dgvRowDelete;
                dgvRowDelete = dgv.Rows[70];
                dgv.Rows.Remove(dgvRowDelete);
                */
                //////////////////////////////////////////////////
                int count16 = 0;
                int cnt = 0;
                if (dgv.RowCount > 0)
                {
                    foreach (DataGridViewRow dr in dgv.Rows)
                    {
                        foreach (DataGridViewCell dc in dr.Cells)
                        {
                            string cad = Convert.ToString(dc.Value);
                            if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
                            {
                                cnt++;
                            }
                            else {  if (cad == "16")
                                    {
                                        count16++;
                                    }
                            }
                        }
                    }
                }
                /////////////////////////////////////////////////

                /*  //Añadiendo sumatoria referencial de TODA LA COLUMNA
                    Decimal sumatoria = 0;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {sumatoria += Convert.ToDecimal(row.Cells[2].Value);    //Sumar solo la columna valor
                    }
                    label2.Text = Convert.ToString(sumatoria);    //aqui se graba el total
                    this.label2.Visible = true;
                    this.label3.Visible = true;
                */

                int ac = 0;
                Decimal[] sum = new Decimal[6]; //Obtendremos 6 sumas
                for (int i = 0; i < NumIndicadores; i++)             //Sumar cada uno de los 6 Indicadores
                {
                    if (i < 4)
                    {
                        for (int x = 0; x < nColumnas; x++)        //Sumar de 12 en 12 los 4 Indicadores previos (Propios ELC)
                        {
                            sum[i] = sum[i] + Decimal.Parse(dgv[2, ac].Value.ToString()); //Sumar solo la columna valor (2)
                            ac = ac + 1;
                        }
                    }
                    else
                    {
                        for (int x = 0; x < count16; x++)        //Sumar de n en n solo los indicadores de Clientes Libres Externos
                        {
                            sum[i] = sum[i] + Decimal.Parse(dgv[2, ac].Value.ToString()); //Sumar solo la columna valor (2)
                            ac = ac + 1;
                        }
                    }
                }

                lbl1B.Text = Convert.ToString(sum[2]);
                lbl2B.Text = Convert.ToString(sum[0]);
                lbl3B.Text = Convert.ToString(sum[1]);
                lbl4B.Text = Convert.ToString(sum[3]);
                lbl5B.Text = Convert.ToString(sum[5]);
                lbl6B.Text = Convert.ToString(sum[4]);
                lblcantregs.Text = Convert.ToString(dgv.RowCount);
                lblcantcelvac.Text = Convert.ToString(cnt);
                this.lbl1A.Visible = true; this.lbl1B.Visible = true;
                this.lbl2A.Visible = true; this.lbl2B.Visible = true;
                this.lbl3A.Visible = true; this.lbl3B.Visible = true;
                this.lbl4A.Visible = true; this.lbl4B.Visible = true;
                this.lbl5A.Visible = true; this.lbl5B.Visible = true;
                this.lbl6A.Visible = true; this.lbl6B.Visible = true;

                dgv.ColumnHeadersVisible = true;
                dgv.AutoResizeColumns();
                
                //dgv.Columns[2].HeaderText = "valor";          ...Para modificar el encabezado de una columnna
                //dgv.Columns["columnaX"].Visible = false;      ...Para Ordenar Columnas solo a nivel DataGridView
                //dgv.Columns["columnaY"].DisplayIndex = 0;
                //dgv.Columns["columnaZ"].DisplayIndex = 1;
                if (dgv.Rows.Count == 0)
                {
                    btnGuardarBD.Enabled = false;
                }
                else
                {
                    btnGuardarBD.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!   No se seleccionó ningún archivo Excel.");
            }

        }

        private void btnGuardarBD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta usted seguro de Enviar los datos visualizados anteriormente a la Base de Datos?", "Confirmación", MessageBoxButtons.OKCancel , MessageBoxIcon.Question)
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