﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMProje
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _EkranTemizlenecekMi;
        private int _İlkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void HM_Load(object sender, EventArgs e)
        {

        }

        private void rakam1Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void rakam2Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void rakam3Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void rakam4Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void rakam5Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void rakam6Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void rakam7Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void rakam8Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void rakam9Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void rakam0Button_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                ekranLabel.Text = "";
                _EkranTemizlenecekMi = false;
            }
            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _EkranTemizlenecekMi = true;
            _İlkSayi = Convert.ToInt32(ekranLabel.Text);

        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            int İkinciSayi = Convert.ToInt32(ekranLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _İlkSayi + İkinciSayi;
                    break;
                case '-':
                    sonuc = _İlkSayi - İkinciSayi;
                    break;
                case '*':
                    sonuc = _İlkSayi * İkinciSayi;
                    break;
                case '/':
                    sonuc = _İlkSayi / İkinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = Convert.ToString(sonuc);

        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _EkranTemizlenecekMi = true;
            _İlkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _EkranTemizlenecekMi = true;
            _İlkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _EkranTemizlenecekMi = true;
            _İlkSayi = Convert.ToInt32(ekranLabel.Text);
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            ekranLabel.Text = "0";
        }
    }
}
