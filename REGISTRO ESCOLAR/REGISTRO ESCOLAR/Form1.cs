using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace REGISTRO_ESCOLAR
{
    public partial class INICIO : Form
    {
        private List<INFO> contactos = new List<INFO>();
        private int indice = -1;

        REGISTRO LOGEO;
        public INICIO()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            if ((USUARIO.Text !="") &&(CONTRASEÑA.Text !="")) { 
            if ((USUARIO.Text == "admin") && (CONTRASEÑA.Text == "123")) {
                    LOGEO = new REGISTRO();
                    LOGEO.Show();
                    this.Hide();
                
                
                }
            else {
                    MessageBox.Show("Uauario o contraseña incorrecta");
                
                
                }


            }

        }
    }
}
