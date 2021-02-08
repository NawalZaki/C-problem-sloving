using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Day11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folders = new FolderBrowserDialog();
            if (folders.ShowDialog() == DialogResult.OK)
            {
                fillTree(folders.SelectedPath);
            }
        }
        public async void fillTree(string path)
        {
            TreeNode treeNode = await loadTree(path);
            treeView1.Nodes.Add(treeNode);
        }
        private Task<TreeNode>loadTree(string path)
        {
            return Task.Run(() =>
          {
              DirectoryInfo directoryInfo = new DirectoryInfo(path);
              TreeNode treeNode = new TreeNode(directoryInfo.Name);
              foreach(var item in directoryInfo.GetDirectories())
              {
                  treeNode.Nodes.Add(loadTree(item.FullName).Result);
              }
              foreach (var item in directoryInfo.GetFiles())
              {
                  treeNode.Nodes.Add(item.Name);
              }
              return treeNode;
          });
        }
    }
}
