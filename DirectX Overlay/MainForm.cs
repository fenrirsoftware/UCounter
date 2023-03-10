using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DirectX_Overlay
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int genislik, yukseklik;
        string yer;
        Boolean labelorgraph;

        Boolean cpvar, ravar;

       
        private void MainForm_Load(object sender, EventArgs e)
        {
          

            genislik = Screen.PrimaryScreen.Bounds.Width;

            yukseklik = Screen.PrimaryScreen.Bounds.Height;


            label3.Text = (genislik + "x" +yukseklik);


            



           


        }

   

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            yer = (string)comboBox2.SelectedItem;

           

            fr.yer = yer;
        }


        Boolean frmack = true;
        
        private void button3_Click(object sender, EventArgs e)
        {
            fr.Close();
            frmack = false;
          
 

        }
        TransparentBorderlessForm fr = new TransparentBorderlessForm();

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox3.Checked = false;
                labelorgraph = true; //true grafik var demek olsun
                fr.graphorlabel = labelorgraph;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Checked = false;
                labelorgraph = false; //true grafik var demek olsun
                fr.graphorlabel = labelorgraph;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Counter";
                notifyIcon1.BalloonTipTitle = "Program Çalışıyor";
                notifyIcon1.BalloonTipText = "Program sağ alt köşede konumlandı.";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(30000);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;


        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

       
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cpvar = true;
                fr.cpuvar = cpvar;
            }

           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                ravar = true;
                fr.ramvar = ravar;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr.genislik = (genislik);
            fr.yükseklik = (yukseklik);


            if (yer == null)
            {
                MessageBox.Show("Gösterim yeri seçmelisiniz!");


            }

            if ((checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Gösterim şekli seçmelisiniz!");
            }

            else
            {

                if (frmack == true)
                {
                    fr.Show();
                }

                else if (frmack == false)
                {
                    Application.Restart();
                }
            }


          
         
           










        }
    }
}

public class Resoulution
{
    public int Width { get; set; }
    public int Height { get; set; }
}
