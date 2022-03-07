using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ARM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Control de 1 sola Instancia
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                //MessageBox.Show("Another instance is already running.");
                return;
            }
            #endregion


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                BonusSkins.Register();
                SkinManager.EnableFormSkins();
                UserLookAndFeel.Default.SetSkinStyle("Whiteprint");
                //UserLookAndFeel.Default.SetSkinStyle("Sharp");

                Application.Run(new frmLogin());

                //----------------------------------------------------------------------
                //Application.Run(new Mants.Mants_Bins());    //1 asigna la clasificacion o categoria del bin
                //Application.Run(new Mants.Mant_MP_xBin());    //2 asignacion de MP permitidas en el bin
                //Application.Run(new Production.OP_Production_Orders_Planner("1012"));//3=consola y gestion de formulas y ordenes de produccion
                //----------------------------------------------------------------------

                GC.KeepAlive(mutex);    //Parte del control de 1 sola instancia
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


    }
}
