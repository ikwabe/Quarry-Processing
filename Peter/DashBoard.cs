using System;
using System.IO;
using System.Windows.Forms;

namespace Peter
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
                
            }
        }

        //creating a directory for storing informations
        static void createDirectory()
        {
            string rootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Querry Processing";
            try
            {
                if (!Directory.Exists(rootDirectory)) { Directory.CreateDirectory(rootDirectory); }
                if (!Directory.Exists(rootDirectory + "\\Saved Data")) { Directory.CreateDirectory(rootDirectory + "\\Saved Data"); }
            }
            catch
            {

            }


        }

       

        private void DashBoard_Load(object sender, EventArgs e)
        {
            //create a directory if not exist
            createDirectory();
        }

        private void PhaseOne_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Home home = new Home();
                home.ShowDialog();
            }
           
        }

        private void PhaseTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               
            }
           
        }
    }
}
