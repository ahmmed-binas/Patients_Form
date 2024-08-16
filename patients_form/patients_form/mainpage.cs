using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace patients_form
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();

        }

        private void mainpagecs_Load(object sender, EventArgs e)
        {


            // first making the tab conrol same size as the screen.
            int screenwidth = Screen.PrimaryScreen.Bounds.Width;
            int screenheight = Screen.PrimaryScreen.Bounds.Height;
            mainform_tabcontrol.Width = screenwidth;  
            mainform_tabcontrol.Height = screenheight; 


            
            



        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            settingsform settings = new settingsform();
            settings.Show();
        }
    }
}

    


