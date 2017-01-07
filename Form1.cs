using Project_Altis_pLauncher.TextParser;
using Project_Altis_pLauncher.Enums;
using Project_Altis_pLauncher.Custom_Controls;
using Project_Altis_pLauncher.ChildControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Project_Altis_pLauncher.ProcessInfo;
using System.Threading;
using Project_Altis_pLauncher.ExternalTTPA;
using System.Runtime.InteropServices;
using System.Reflection;



namespace Project_Altis_pLauncher
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public const string ProcessName = "Project Altis Launcher";

       
       
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
           
            changelogTextBox.Text = TextParser.GetChangeLog.ChangeLog();
           
            versionLabel.Text = GetCurrentVersion.CurrentVersion();
            this.Opacity = 0;
        }

      
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        

        private void playButtonPanel_MouseUp(object sender, MouseEventArgs e)
        {

            if (usernameTextBox1.Text == "username" || usernameTextBox1.Text == "" || passwordTextBox1.Text == "password" || passwordTextBox1.Text == "")
            {
                MessageBox.Show(this,"Please fill out both username and password fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            new Task(() => { 
            if (ProcessInformation.IsOpen("Project Altis Launcher"))
            {
           
                HandleIDs.SendMessage(
                    HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.UsernameText],
                    (int)WindowMessages.WM_SETTEXT, 0, usernameTextBox1.Text
                    );

                HandleIDs.SendMessage(
                    HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.PasswordText],
                    (int)WindowMessages.WM_SETTEXT, 0, passwordTextBox1.Text
                    );

                HandleIDs.SendMessage(
                    HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.PlayButton],
                    (int)WindowMessages.BM_CLICK, 0, null
                    );


                    
            }
            }).Start();

            loadingLabel.Visible = true;
            loadingProgress.Visible = true;
            loadingProgress.MarqueeAnimationSpeed = 30;
                
            
        }

        


        private void usernameTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                
                e.SuppressKeyPress = true;
                e.Handled = true;
              
            }  
        }

        private void passwordTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                e.SuppressKeyPress = true;
                e.Handled = true;

            } 
        }

       

        private void sanityChecks_Tick(object sender, EventArgs e)
        {
            if (ProcessInformation.IsOpen("Altis"))
            {
                this.Close();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            HideWindow.HideTTPA(this.Width, this.Height);
            
           
           
            this.Opacity = 1;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left)
             {
                 ReleaseCapture();
                 HandleIDs.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, null);
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button gotta fix event name
             if (ProcessInformation.IsOpen(ProcessName))
            {
                Process pName = Process.GetProcessesByName(ProcessName)[0];
                pName.Kill();
            }
             this.Close();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox1.Text == "username" || usernameTextBox1.Text == "" || passwordTextBox1.Text == "password" || passwordTextBox1.Text == "")
            {
                MessageBox.Show(this, "Please fill out both username and password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new Task(() =>
            {
                if (ProcessInformation.IsOpen("Project Altis Launcher"))
                {

                    HandleIDs.SendMessage(
                        HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.UsernameText],
                        (int)WindowMessages.WM_SETTEXT, 0, usernameTextBox1.Text
                        );

                    HandleIDs.SendMessage(
                        HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.PasswordText],
                        (int)WindowMessages.WM_SETTEXT, 0, passwordTextBox1.Text
                        );

                    HandleIDs.SendMessage(
                        HandleIDs.GetChildWindows(ProcessInformation.WindowHandle("Project Altis Launcher"))[(int)ControlLocation.PlayButton],
                        (int)WindowMessages.BM_CLICK, 0, null
                        );



                }
            }).Start();

            loadingLabel.Visible = true;
            loadingProgress.Visible = true;
            loadingProgress.MarqueeAnimationSpeed = 30;
        }
        
        

        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        ReleaseCapture();
        //        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        //    }
        //}
    }
}
