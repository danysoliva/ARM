using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARM.Classes;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ARM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Contraseña")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.LightGray;
                txtpassword.Properties.UseSystemPasswordChar = true;
                txtpassword.Properties.PasswordChar = '·';
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Properties.UseSystemPasswordChar = false;
                txtpassword.Text = "Contraseña";
                txtpassword.ForeColor = Color.Silver;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user;
            string pass;
            string domain;
            if (txtuser.Text != "")
            {
                user = txtuser.Text;
            }
            else
            {
                CajaDialogo.Error("No puede dejar el usuario vacio!");
                return;
            }

            if (txtpassword.Text != "")
            {
                pass = txtpassword.Text;
            }
            else
            {
                CajaDialogo.Error("No puede dejar la contraseña vacia!");
                return;
            }

            Security sc = new Security();
            domain = "AQUAFEEDHN";
            if (sc.Validate_Account(domain, user, pass))
            {
                UserLogin Log1 = new UserLogin();
                if (Log1.RecuperarRegistroFromUser(user))
                {
                    Log1.Pass = txtpassword.Text;
                    Log1.GrupoUsuario.GrupoUsuarioActivo = (GrupoUser.GrupoUsuario)Log1.IdGrupo;

                    if (Log1.IdGrupo == 0) //ClasificacionBines
                    {
                        Mants.Mants_Bins frm = new Mants.Mants_Bins();
                        frm.Show();
                    }
                    if (Log1.IdGrupo == 1) //AsignacionMP
                    {
                        Mants.Mant_MP_xBin frm = new Mants.Mant_MP_xBin();
                        frm.Show();
                    }
                    if (Log1.IdGrupo == 2) //GestionFormulasyOrdenes
                    {
                        Production.OP_Production_Orders_Planner frm = new Production.OP_Production_Orders_Planner("1012");
                        frm.Show();
                    }
                    if (Log1.IdGrupo == 3) //NINNGUNA
                    {
                        CajaDialogo.Error("No tiene asignado un grupo para usar esta aplicacion! Contacte al Adminsitrador de Sistemas!");
                        return;
                    }

                }
                else
                {
                    CajaDialogo.Error("Usuario No encontrado en AQFSVR003");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
