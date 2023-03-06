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

       
        private void MainForm_Load(object sender, EventArgs e)
        {
          

            genislik = Screen.PrimaryScreen.Bounds.Width;

            yukseklik = Screen.PrimaryScreen.Bounds.Height;


            label3.Text = (genislik + "x" +yukseklik);


            



            var scope = new ManagementScope();
            var query = new ObjectQuery("SELECT * FROM CIM_VideoControllerResolution");
            List<Resoulution> resolutions = new List<Resoulution>();
            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var results = searcher.Get();
                foreach (var item in results)
                {
                    var matches = Regex.Matches(item["Caption"].ToString(), "([0-9]+)");
                    int.TryParse(matches[0].Value, out int width);
                    int.TryParse(matches[1].Value, out int height);
                    resolutions.Add(new Resoulution
                    {
                        Width = width,
                        Height = height
                    });
                }
            }
            for (int i = 0; i < resolutions.Count; i++)
            {
               comboBox1.Items.Add(resolutions[i].Width + " x " + resolutions[i].Height);
            }


           



        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            label2.Visible = true;
            label2.Text = "";
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenboyut = comboBox1.SelectedItem;
            label2.Text = (string)secilenboyut;
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
