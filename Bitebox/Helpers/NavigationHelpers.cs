using Bitebox.Views;
using System;
using System.Windows.Forms;

namespace Bitebox.Helpers
{
    public static class NavigationHelper
    {
        public static void KeluarKeLogin(Form currentForm)
        {
            
            DialogResult result = MessageBox.Show("Yakin mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();

                currentForm.Close();
            }
        }
    }
}