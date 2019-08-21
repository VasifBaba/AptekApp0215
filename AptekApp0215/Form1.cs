using AptekApp0215.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AptekApp0215
{
    public partial class Form1 : Form
    {
        Aptek0215Entities db = new Aptek0215Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                lblWelcome.Text = "Öz aptekinizə xoş gəlmisiz !";
                Settng selectedSetting = db.Settngs.First();
                this.Icon = new Icon("../../Uploads/" + selectedSetting.Logo);
                this.Text = selectedSetting.Name;
                lblWelcome.Text = selectedSetting.Header;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            if (email != null && password != null)
            {
                AdminEmail selectAdmin = db.AdminEmails.FirstOrDefault(ad => ad.AdminEmail1 == email);
                if (selectAdmin != null)
                {
                    if (selectAdmin.AdminPassword == password)
                    {
                        AdminDashboard Adm = new AdminDashboard();
                        Adm.ShowDialog();
                    }

                }
                else
                {
                    Worker selectWorker = db.Workers.FirstOrDefault(wr => wr.Username == email);
                    if (selectWorker != null)
                    {
                        if (selectWorker.Password != password)
                        {
                            WorkersDashboard wd = new WorkersDashboard();
                            wd.ShowDialog();
                        }
                        else
                        {
                            lblError.Text = "Şifrə yanlışdır !";
                            lblError.Visible = true;
                            lblError0.Text = "Şifrə yanlışdır !";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Email yanlışdır !";
                        lblError.Visible = true;
                        lblError0.Text = "Email yanlışdır !";
                        lblError.Visible = true;
                    }
                }
            }
            else
            {
                lblError.Text = "Zəhmət olmasa boşluqları doldurun !";
                lblError.Visible = true;
                lblError0.Text = "Zəhmət olmasa boşluqları doldurun !";
                lblError.Visible = true;
            }
        }
    }
}
