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
    public partial class AdminDashboard : Form
    {
        Aptek0215Entities db = new Aptek0215Entities();
        int marginX = 10;
        int marginY = 20;
        int LocX = 10;
        int LocY = 20;
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private int addFirms(string firmname)
        {
            Firm selectedFirm = db.Firms.FirstOrDefault(fr => fr.Name == firmname);
            if(selectedFirm != null)
            {
                return selectedFirm.ID;
            }
           
          
                Firm newFirm = db.Firms.Add(new Firm
                {
                    Name = firmname
                });
                db.SaveChanges();

                return newFirm.ID;
  
   
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string medicinename = txtmedicinename.Text;
            string firmName = cmbfirm.Text;
            string tagsName = cmbtags.Text;
            float price = (float)nmprice.Value;
            bool WithReceipt = ckWithReceipt.Checked;
            int? count = (int)nmcount.Value;
            string barcode = txtbarcode.Text;
            DateTime productiondate = dtproductiondate.Value;
            DateTime endlinedate = dtedlineddate.Value;
            string description = rccdescription.Text;
            bool allEmpty = Extensions.IsEmpty(new string[]
            {
                medicinename, firmName, tagsName, barcode, description
            }, string.Empty);
            if (allEmpty)
                if(count!=null && price!=null)
            {
                int firmID = addFirms(firmName);
                Medicine AddMedicine = db.Medicines.Add(new Medicine
                {
                    Name = medicinename,
                    Price = price,
                    Count = count,
                    PurchaseDate = productiondate,
                    ExperienceDate = endlinedate,
                    Barcode = barcode,
                    Description = description,
                    WithReceipt = Convert.ToBoolean(WithReceipt)

                });
                db.SaveChanges();
                db.Medicine_to_Firms.Add(new Medicine_to_Firm
                {
                    Firm_ID = firmID,
                    Medicine_ID = AddMedicine.ID
                });
                db.SaveChanges();
                MessageBox.Show("Dərman uğurla daxil edildi", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblError.Text = "Qiymət və sayı qeyd edin !";
                    lblError.Visible = true;
                }
            else
            {
                lblError.Text = "Zəhmət olmasa boşluqları doldurun !";
                lblError.Visible = true;
            }
        }

        private void FillComboFirms()
        {
            cmbfirm .Items.AddRange(db.Firms.Select(fr => fr.Name).ToArray());
        }

        private void FillComboTags()
        {
            cmbtags.Items.AddRange(db.Tags.Select(tg => tg.Name).ToArray());
        }
        #region Admin Load Event
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FillComboFirms();
            FillComboTags();
        }
        #endregion

        private void Cmbtags_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tagName = cmbtags.Text;
            AddTag(tagName);
        }
        public void AddTag(string tagname)
        {
            if(tagname != null)
            {
                Button btn = new Button();
                btn.Text = tagname;
                btn.BackColor = Color.DarkGreen;
                btn.ForeColor = Color.White;
                btn.Location = new Point(25, 45);
                btn.Width = 100;
                taggroup.Controls.Add(btn);
                if (LocX + btn.Width > taggroup.Width)
                {
                    LocX = marginX;
                    LocY = Height + marginY;
                }
                btn.Location = new Point(LocX, LocY);
                LocX += btn.Width;
                taggroup.Controls.Add(btn);
            }
        }
    }
}
