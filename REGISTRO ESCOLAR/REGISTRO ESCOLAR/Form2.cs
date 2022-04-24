using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;


namespace REGISTRO_ESCOLAR
{
    public partial class REGISTRO : Form
    {
        private string idcategoria;
        private List<INFO> datosp = new List<INFO>();
        private int indice = -1;

        public REGISTRO()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            INFO.conectar();
            string insertar = "INSERT INTO EMPLEADOS(NOMBRE,APELLIDO,TELEFONO,CORREO,SALARIO,PUESTO)VALUES(@NOMBRE,@APELLIDO,@TELEFONO,@CORREO,@SALARIO,@PUESTO)";
            SqlCommand cmd1 = new SqlCommand(insertar, INFO.conectar());
           cmd1.Parameters.AddWithValue("@NOMBRE",txtnombre.Text);
            cmd1.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
            cmd1.Parameters.AddWithValue("@TELEFONO", txttelefono.Text);
            cmd1.Parameters.AddWithValue("@CORREO", txtcorreo.Text);
            cmd1.Parameters.AddWithValue("@SALARIO", txtsalario.Text);
            cmd1.Parameters.AddWithValue("@PUESTO", txtpuesto.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("se guardo correctamente");

            DATOS.DataSource = llenar_grid();



        }
        private void actualizarVista()
        {
            DATOS.DataSource = null;
            DATOS.DataSource = datosp;
            DATOS.ClearSelection();
        }

        private void DATOS_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                idcategoria = DATOS.CurrentRow.Cells[1].Value.ToString();
                txtnombre.Text = DATOS.CurrentRow.Cells[2].Value.ToString();
                txtapellido.Text = DATOS.CurrentRow.Cells[3].Value.ToString();
                txttelefono.Text = DATOS.CurrentRow.Cells[4].Value.ToString();
                txtcorreo.Text = DATOS.CurrentRow.Cells[5].Value.ToString();
                txtsalario.Text = DATOS.CurrentRow.Cells[6].Value.ToString();
                txtpuesto.Text = DATOS.CurrentRow.Cells[7].Value.ToString();
              
            }
            
            catch
            {

            }
        }
        private void LimpiaCampos()
        {
            
            txtnombre.Text = null;
            txtapellido.Text = null;
            txttelefono.Text = null;
            txtcorreo.Text = null;
            txtsalario.Text = null;
            txtpuesto.Text = null;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            INFO.conectar();
            string eliminar = "DELETE FROM EMPLEADOS WHERE  TELEFONO=@TELEFONO";
            SqlCommand cmd3 = new SqlCommand(eliminar, INFO.conectar());
            cmd3.Parameters.AddWithValue("@TELEFONO", txttelefono.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Se Elimino correctamente");
            DATOS.DataSource = llenar_grid();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            INFO.conectar();
            string actualizar = "UPDATE EMPLEADOS SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, TELEFONO=@TELEFONO, CORREO=@CORREO, SALARIO=@SALARIO,PUESTO=@PUESTO WHERE  TELEFONO=@TELEFONO";
            SqlCommand cmd2 = new SqlCommand(actualizar, INFO.conectar());

            
            cmd2.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
            cmd2.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
            cmd2.Parameters.AddWithValue("@TELEFONO", txttelefono.Text);
            cmd2.Parameters.AddWithValue("@CORREO", txtcorreo.Text);
            cmd2.Parameters.AddWithValue("@SALARIO", txtsalario.Text);
            cmd2.Parameters.AddWithValue("@PUESTO", txtpuesto.Text);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Se actualizo correctamente");
            DATOS.DataSource = llenar_grid();



        }

        private void REGISTRO_Load(object sender, EventArgs e)
        {
            INFO.conectar();
            MessageBox.Show("conexion exitosa");
            DATOS.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            INFO.conectar();
            DataTable dt = new DataTable();
            string consulte = "SELECT* FROM EMPLEADOS";

            SqlCommand cmd = new SqlCommand(consulte, INFO.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;


        }




















        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form3 calculadora = new Form3();
            calculadora.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abririmagen = new OpenFileDialog();
            if (abririmagen.ShowDialog() == DialogResult.OK){
                pictureBox1.ImageLocation= abririmagen.FileName;
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtsalario.Clear();
            txtpuesto.Clear();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            txtsalario.Clear();
            txtpuesto.Clear();

        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}


