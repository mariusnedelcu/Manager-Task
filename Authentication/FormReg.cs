
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
using System.Text;
using System.Windows.Forms;
using Proxy;

namespace Authentication
{
    /// <summary>
    /// Panoul pentru inregistrare.
    /// </summary>
    public partial class FormReg : Form
    {
        private ProxyAuthManager _proxyAuthManager;
        /// <summary>
        /// Constructorul clasei de inregistrare ce va apela constructorul clasei ProxyAuthManager
        /// </summary>
        public FormReg()
        {
            InitializeComponent();
            _proxyAuthManager = new ProxyAuthManager();
            this.CenterToScreen();
        }

        /// <summary>
        /// Link de redirectionare catre pagina de logare.
        /// </summary>
        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormAuth().Show();
            this.Hide();
        }

        /// <summary>
        /// Butonul de inregistrare si salvare a unui utilizator.
        /// </summary>
        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string passConfirm = textBoxConfPassw.Text;
            if (username != string.Empty || password != string.Empty || passConfirm != string.Empty)
            {
                if (password == passConfirm)
                {
                    //search username in list
                    if (_proxyAuthManager.UserExists(username))
                    {
                        MessageBox.Show("Username already exists, please try another", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsername.Text = "";
                        textBoxConfPassw.Text = "";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        // TODO: add to file a new user
                        _proxyAuthManager.AddUser(username, password);
                        textBoxUsername.Text = "";
                        textBoxConfPassw.Text = "";
                        textBoxPassword.Text = "";

                        MessageBox.Show("Your account has been succesfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match, please re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Text = "";
                    textBoxConfPassw.Text = "";
                    textBoxPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter values in every field", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void textBoxConfPassw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
