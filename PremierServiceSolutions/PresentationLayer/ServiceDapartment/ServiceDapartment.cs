﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace PremierServiceSolutions.PresentationLayer.ServiceDapartment
{
    public partial class ServiceDapartment : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public ServiceDapartment()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            try
            {
                if (senderBtn != null)
                {
                    DisableButton();
                    // Button

                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    // Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    // Current Child Form Icon
                    ipbChildForm.IconChar = currentBtn.IconChar;
                    ipbChildForm.IconColor = color;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        public void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;

            ipbChildForm.IconChar = IconChar.Home;
            ipbChildForm.IconColor = Color.DarkCyan;

            lblTitleChildForm.Text = "Home";
        }

        private void ibtnTechnicians_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Technicians());
        }

        private void ibtnSchedule_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Schedule());
        }

        private void ibtnLogOout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Form1());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        //
        //
        //

        private void ServiceDapartment_Load(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            timer1.Start();


            lblTime.Text = DateTime.Now.ToLongTimeString();

            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
