﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Regisztráció : Form
    {
        public Regisztráció()
        {
            InitializeComponent();
            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                List<string> hobbik = new List<string>();
                try
                {
                    string fileName = saveFileDialog1.FileName;
                    string nev = textBoxNev.Text;
                    string szulDatum = textBoxSzulDatum.Text;
                    string nem = "";
                    if (radioFerfi.Checked == true)
                    {
                        nem = radioFerfi.Text;
                    }
                    else if (radioNo.Checked == true)
                    {
                        nem = radioNo.Text;
                    }
                    int hobbi = listBoxHobbik.SelectedIndex;
                    if (hobbi == -1)
                    {
                        hobbi = 0;
                    }
                    foreach (var item in listBoxHobbik.Items)
                    {
                        hobbik.Add((string)item);
                    }
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(nev + ";" + szulDatum + ";" + nem + ";" + hobbi);
                        for (int i = 0; i < hobbik.Count; i++)
                        {
                            sw.WriteLine(hobbik[i]);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Valami hiba történt, kérem kezelje fel kereső orvosát gyógyszemészét");
                }
            };
            openFileDialog1.FileOk += (sender, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialog1.FileName);
                    string adatok = sorok[0];
                    string[] listBoxAdatok = new string[sorok.Length - 1];
                    for (int i = 1; i < sorok.Length; i++)
                    {
                        listBoxAdatok[i - 1] = sorok[i];
                    }
                    string[] adat = adatok.Split(';');
                    textBoxNev.Text = adat[0];
                    textBoxSzulDatum.Text = adat[1];
                    if (adat[2] == "Férfi")
                    {
                        radioFerfi.Checked = true;
                    }
                    if (adat[2] == "Nő")
                    {
                        radioNo.Checked = true;
                    }
                    int hobbi = Convert.ToInt32(adat[3]);
                    for (int i = 0; i < listBoxAdatok.Length; i++)
                    {
                        listBoxHobbik.Items.Add(listBoxAdatok[i]);
                    }
                    listBoxHobbik.SetSelected(hobbi, true);
                }
                catch (Exception)
                {
                    MessageBox.Show("nem sikerült megnyitni a filet help");
                }
            };
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void textBoxUjHobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(textBoxUjHobbi.Text == ""))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    listBoxHobbik.Items.Add(textBoxUjHobbi.Text);
                    listBoxHobbik.Text = "";
                    textBoxUjHobbi.Clear();

                }
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if (!(textBoxUjHobbi.Text == ""))
            {
                listBoxHobbik.Items.Add(textBoxUjHobbi.Text);
                listBoxHobbik.Text = "";
                textBoxUjHobbi.Clear();
            }
        }
    }
}
