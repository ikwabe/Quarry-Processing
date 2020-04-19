using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;



namespace Peter
{
    public partial class Home : Form
    {
        public Home()
        {
           
            InitializeComponent();
        }

        phaseOne p1 = new phaseOne();
        phaseTwo p2 = new phaseTwo();
        private void Form1_Load(object sender, EventArgs e)
        {
            p1.Dock = DockStyle.Fill;
            p1.Visible = true;
            panel3.Controls.Add(p1);
            ph1 = true;
            phaseOne.timerSwitch = true;

            PhaseLabel.Text = "PHASE ONE (INITIAL DESIGN)";
            p2.Dock = DockStyle.Fill;
            p2.Visible = false;
            panel3.Controls.Add(p2);


        }


        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               System.Windows.Forms. Application.Exit();
            }
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    
                }

            }
        }


        private void mimimizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }


        // function to reset the whole program
        private void refreshBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if(ph1 == true)
                    phaseOne.refreshPage = true;
                if (ph2 == true)
                    phaseTwo.refreshPage = true;
            }
        }

      
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            if(ph1 == true)
                phaseOne.saveData = true;
            if (ph2 == true)
                phaseTwo.saveData = true;

        }

       
        //function for Dark Theme

            private void DarkTheme()
        {
            //for buttons
            closeBtn.Visible = false;
            mimimizeBtn.Visible = false;
            miniMizeBtn1.Visible = true;
            closeBtn1.Visible = true;

            //for pannels
           

            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            foreach (Control crl in panel1.Controls)
            {
                crl.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            }

           
        }

        //function for white theme
        private void WhiteTheme()
        {
            //for buttons
            closeBtn.Visible = true;
            mimimizeBtn.Visible = true;
            miniMizeBtn1.Visible = false;
            closeBtn1.Visible = false;
            //for pannels
            panel1.BackColor = System.Drawing.Color.White;

            foreach (Control crl in panel1.Controls)
            {
                crl.BackColor = System.Drawing.Color.White;
            }

          

        }

        private void changeTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(changeTheme.Text == "Dark Theme")
            {
                DarkTheme();
                phaseOne.changeThemeToDark = true;
                phaseTwo.changeThemeToDark = true;
                
            }

            if (changeTheme.Text == "White Theme")
            {
                WhiteTheme();
                phaseOne.changeThemeToWhite = true;
                phaseTwo.changeThemeToWhite = true;
                
            }
                
        }

        private void closeBtn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Close();
            }
        }

        private void miniMizeBtn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        bool ph1 = false, ph2 = false;
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var link = sender as LinkLabel;

                if(link.Name == "linkLabel2")
                {
                    linkLabel2.Visible = false;
                    phaseTwo.timerSwitch = false;
                    phaseOne.timerSwitch = true;
                    ph2 = false;
                    p2.Visible = false;
                    linkLabel1.Visible = true;
                    ph1 = true;
                    p1.Visible = true;
                    PhaseLabel.Text = "PHASE ONE (INITIAL DESIGN)";

                }

                if (link.Name == "linkLabel1")
                {
                    linkLabel1.Visible = false;
                    phaseOne.timerSwitch = false;
                    phaseTwo.timerSwitch = true;
                    ph1 = false;
                    p1.Visible = false;
                    linkLabel2.Visible = true;
                    ph2 = true;
                    p2.Visible = true;
                    PhaseLabel.Text = "PHASE TWO (CURRENT  DESIGN)";
                }
            }
        }

      
    }
}
