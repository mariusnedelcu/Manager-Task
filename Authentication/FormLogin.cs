
/**************************************************************************
 *                                                                        *
 *  File:        CommandGraph.cs                                          *
 *  Copyright:   (c) 2021, Triboi Maria Emanuela                          *
 *  E-mail:     maria-emanuela.triboi@tuiasi.ro                           *
 *  Website:     https://github.com/petrov-sergiu/Proiect_IP              *
 *  Description:  A graph full of commands ready to be used.              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proxy;

namespace Authentication
{
    /// <summary>
    /// Panoul de autentificare.
    /// </summary>
    public partial class FormAuth : Form
    {
        private ProxyAuthManager _proxyAuthManager;
        /// <summary>
        /// Constructorul panoului Autentificare.
        /// </summary>
        public FormAuth()
        {
            InitializeComponent();
            //instantierea clasei ProxyAuthManager
            _proxyAuthManager = new ProxyAuthManager();
            this.CenterToScreen();
        }

        /// <summary>
        /// Verificarea datelor de autentificare prin intermediul clasei ProxyAuthManager
        /// </summary>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // TODO: open json file
            if (username != string.Empty || password != string.Empty)
            {
                if (_proxyAuthManager.Login(username, password))
                {
                    this.Hide();
                    MainForm home = new MainForm(username);

                    
                    home.labelAut.Text = "Autentificat: " + username;
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, Please try again", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                    textBoxUsername.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter values in every field", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }
        /// <summary>
        /// Link spre pagina de inregistrare.
        /// </summary>
        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: register user and add data to json file

            // redirect to register form 
            new FormReg().Show();
            this.Hide();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Help.chm");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
