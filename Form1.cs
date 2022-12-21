using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ModernForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        #region MenuDesing
        private void customizeDesing()
        {
            pnl_MediaSubMenu.Visible = false;
            pnl_PlaylistSubMenu.Visible = false;
            pnl_ToolsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnl_MediaSubMenu.Visible == true)
            {
                pnl_MediaSubMenu.Visible = false;
            }

            if (pnl_PlaylistSubMenu.Visible == true)
            {
                pnl_PlaylistSubMenu.Visible = false;
            }

            if (pnl_ToolsSubMenu.Visible == true)
            {
                pnl_ToolsSubMenu.Visible = false;
            }
        }  

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        private void btn_Media_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_MediaSubMenu);
        }

        #region MediaSubMenu
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }
        #endregion

        private void btn_Playlist_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_PlaylistSubMenu);
        }

        #region PlaylistSubMenu
        private void button6_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }
        #endregion
        
        private void btn_Equalizer_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
            hideSubMenu();
        }

        private void btn_Tools_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_ToolsSubMenu);
        }

        #region ToolsSubMenu
        private void button12_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }
        #endregion

        private void btn_Help_Click(object sender, EventArgs e)
        {
            //My Code
            hideSubMenu();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_ChildForm.Controls.Add(childForm);
            pnl_ChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Youtube Daha Sonra İzleye eklendi (graphical user interface modernist)
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Title  Bar Hareket Sağlama
        #region Title Bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
