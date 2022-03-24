
/**************************************************************************
 *                                                                        *
 *  File:        CommandGraph.cs                                          *
 *  Copyright:   (c) 2021, Petrov Sergiu                                  *
 *  E-mail:     sergiu.petrov@tuiasi.ro                                   *
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
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Authentication
{
    public partial class FormBrowse : Form
    {
        /// <summary>
        ///Calea catre imagini.
        /// </summary>
        public string path;
        /// <summary>
        /// Constructorul clasei FormBrowse.
        /// </summary>
        public FormBrowse()
        {
            InitializeComponent();
            PopulateTreeView();
            path = "";

        }
        /// <summary>
        /// Crearea meniului de parcurgere catre calea imaginii.
        /// </summary>
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info, rootNode);
                GetFiles(info, rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        /// <summary>
        /// Metoda de creare a unei liste cu toate directoarele din folderul curent.
        /// </summary>
        /// <param name="dir">Numele folderului</param>
        /// <param name="nodeToAddTo">Lista cu directoare</param>
        private void GetDirectories(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            DirectoryInfo[] subDirs = dir.GetDirectories();
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subDir, aNode);
                    GetFiles(subDir, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        /// <summary>
        /// Metoda de adaugare in lista a fisierelor.
        /// </summary>
        /// <param name="dir">Numele folderului curent</param>
        /// <param name="nodeToAddTo">Lista cu directoare</param>
        private void GetFiles(DirectoryInfo dir, TreeNode nodeToAddTo)
        {
            FileInfo[] files = dir.GetFiles();
            TreeNode aNode;
            foreach (FileInfo file in files)
            {
                aNode = new TreeNode(file.Name, 0, 0);
                aNode.Tag = file;
                aNode.ImageKey = "file";
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        /// <summary>
        /// Iesirea din panoul FormBrowse
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            path = "";
            this.Close();
        }

        /// <summary>
        /// Importarea numelui imaginii in panoul FormTask.
        /// </summary>
        private void buttonImport_Click(object sender, EventArgs e)
        {
            string _path = treeView1.SelectedNode.Text;
            string[] sir = _path.Split('.');
            if (sir.Length == 1)
            {
                MessageBox.Show("Alege un fisier.");
            }
            else if (sir[1] == "jpg" || sir[1] == "gif" || sir[1] == "jpeg" || sir[1] == "png" || sir[1] == "pdf")
            {
                path = _path;
                this.Close();
            }
            else
                MessageBox.Show("Alege o imagine");
        }

    }
}
