﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInScreen.Forms
{
    public partial class FormBooks : Form
    {
        public FormBooks()
        {
            InitializeComponent();
        }
        private void FormBooks_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Themes.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Themes.SecondaryColor;

                }
            }
            //label14.ForeColor = Themes.SecondaryColor;
            //label15.ForeColor = Themes.PrimaryColor;
        }
    }
}
