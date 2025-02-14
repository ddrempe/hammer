﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class frmDodajGradiliste : Form
    {
        private gradilista gradilisteIzmjena;
        public frmDodajGradiliste()
        {
            InitializeComponent();
        }
        public frmDodajGradiliste(gradilista gradiliste)
        {
            InitializeComponent();
            gradilisteIzmjena = gradiliste;

        }
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new Entities())
            {
                if (gradilisteIzmjena == null)
                {
                    gradilista gradiliste = new gradilista();
                    {

                        gradiliste.naziv = txtNaziv.Text;
                        gradiliste.aktivan_od = dateTimePicker1.Value.ToString();
                        gradiliste.aktivan_do = dateTimePicker2.Value.ToString();
                    };
                    db.gradilista.Add(gradiliste);
                    db.SaveChanges();
                }
                else
                {
                    db.gradilista.Attach(gradilisteIzmjena);
                    gradilisteIzmjena.naziv = txtNaziv.Text;
                    gradilisteIzmjena.aktivan_od = dateTimePicker1.Value.ToString();
                    gradilisteIzmjena.aktivan_do = dateTimePicker2.Value.ToString();
                    db.SaveChanges();
                }

            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajGradiliste_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (gradilisteIzmjena != null)
            {
                txtID.Text = gradilisteIzmjena.ID.ToString();
                txtNaziv.Text = gradilisteIzmjena.naziv;
                dateTimePicker1.Text = gradilisteIzmjena.aktivan_od;
                dateTimePicker1.Text = gradilisteIzmjena.aktivan_do;
            }
        }
    }
}
