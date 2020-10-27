using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.ToString();
            listBox1.Items.Add(e.Node.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode ekle = new TreeNode("Dersler");
            treeView1.Nodes.Add(ekle);


            TreeNode cocuk1 = new TreeNode("Matematik");
            TreeNode cocuk2 = new TreeNode("Geometri");
            TreeNode cocuk3 = new TreeNode("Fizik");
            TreeNode cocuk4 = new TreeNode("Kimya");
            TreeNode cocuk5 = new TreeNode("Biyoloji");

            TreeNode[] array = new TreeNode[] { cocuk1, cocuk2, cocuk3, cocuk4, cocuk5 };

            ekle = new TreeNode("Sayısal Dersler", array);
            treeView1.Nodes.Add(ekle);


            TreeNode cocuk6 = new TreeNode("Türk Dili ve Edebiyatı");
            TreeNode cocuk7 = new TreeNode("Dil ve Anlatım");
            TreeNode cocuk8 = new TreeNode("Tarih");
            TreeNode cocuk9 = new TreeNode("Coğrafya");
            TreeNode cocuk10 = new TreeNode("Felsefe Grubu");

            TreeNode[] array2 = new TreeNode[] { cocuk6, cocuk7, cocuk8, cocuk9, cocuk10 };

            ekle = new TreeNode("Sözel Dersler", array2);
            treeView1.Nodes.Add(ekle);

            TreeNode cocuk11 = new TreeNode("İngilizce");
            TreeNode cocuk12 = new TreeNode("Almanca");
            TreeNode cocuk13 = new TreeNode("Fransızca");
            TreeNode cocuk14 = new TreeNode("İspanyolca");
            TreeNode cocuk15 = new TreeNode("İtalyanca");

            TreeNode[] array3 = new TreeNode[] { cocuk11, cocuk12, cocuk13, cocuk14, cocuk15 };

            ekle = new TreeNode("Dil Dersleri", array3);
            treeView1.Nodes.Add(ekle);


            TreeNode cocuk16 = new TreeNode("Beden Eğitimi ve Spor");
            TreeNode cocuk17 = new TreeNode("Görsel Sanatlar");
            TreeNode cocuk18 = new TreeNode("Müzik");
            TreeNode cocuk19 = new TreeNode("Drama");
            TreeNode cocuk20 = new TreeNode("El Sanatları");

            TreeNode[] array4 = new TreeNode[] { cocuk16, cocuk17, cocuk18, cocuk19, cocuk20 };

            ekle = new TreeNode("Hobi Dersleri", array4);
            treeView1.Nodes.Add(ekle);

            TreeNode cocuk21 = new TreeNode("Astronomi ve Uzay Bilimleri");
            TreeNode cocuk22 = new TreeNode("Bilgisayar ve Yazılım");
            TreeNode cocuk23 = new TreeNode("Sanat Tarihi");
            TreeNode cocuk24 = new TreeNode("Sağlık Bilgisi");
            TreeNode cocuk25 = new TreeNode("Yaratıcı Yazarlık");

            TreeNode[] array5 = new TreeNode[] { cocuk21, cocuk22, cocuk23, cocuk24, cocuk25 };

            ekle = new TreeNode("Genel Kültür Dersleri", array5);
            treeView1.Nodes.Add(ekle);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
