﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Sedicesimi : Form
    {
        int idTorneo = 0;
        int idDisciplina = 0;

        List<AtletaEliminatorie> campo1;
        List<AtletaEliminatorie> campo2;
        List<AtletaEliminatorie> campo3;
        List<AtletaEliminatorie> campo4;


        public Sedicesimi(List<AtletaEliminatorie> campo1,
                            List<AtletaEliminatorie> campo2,
                            List<AtletaEliminatorie> campo3,
                            List<AtletaEliminatorie> campo4,
                            int idTorneo,
                            int idDisciplina)
        {
            this.campo1 = campo1;
            this.campo2 = campo2;
            this.campo3 = campo3;
            this.campo4 = campo4;


            this.idTorneo = idTorneo;
            this.idDisciplina = idDisciplina;

            InitializeComponent();

            caricaCampo1(campo1);
            caricaCampo2(campo2);
            caricaCampo3(campo3);
            caricaCampo4(campo4);

            //PdfManager pdf = new PdfManager();
            //pdf.StampaBracketSedicesimi(campo1, campo2, campo3, campo4);
        }

        private void caricaCampo1(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
                {
                    IdRosso = campo[0].IdAtleta,
                    CognomeRosso = campo[0].Cognome,
                    NomeRosso = campo[0].Nome,
                    PuntiRosso = 0,
                    IdBlu = campo[1].IdAtleta,
                    CognomeBlu = campo[1].Cognome,
                    NomeBlu = campo[1].Nome,
                    PuntiBlu = 0,
                }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[2].IdAtleta,
                CognomeRosso = campo[2].Cognome,
                NomeRosso = campo[2].Nome,
                PuntiRosso = 0,
                IdBlu = campo[3].IdAtleta,
                CognomeBlu = campo[3].Cognome,
                NomeBlu = campo[3].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[4].IdAtleta,
                CognomeRosso = campo[4].Cognome,
                NomeRosso = campo[4].Nome,
                PuntiRosso = 0,
                IdBlu = campo[5].IdAtleta,
                CognomeBlu = campo[5].Cognome,
                NomeBlu = campo[5].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[6].IdAtleta,
                CognomeRosso = campo[6].Cognome,
                NomeRosso = campo[6].Nome,
                PuntiRosso = 0,
                IdBlu = campo[7].IdAtleta,
                CognomeBlu = campo[7].Cognome,
                NomeBlu = campo[7].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo1.DataSource = list.ToArray();
            dataGridViewCampo1.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo1_DataBindingComplete);
        }

        private void dataGridViewCampo1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void caricaCampo2(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
            {
                IdRosso = campo[0].IdAtleta,
                CognomeRosso = campo[0].Cognome,
                NomeRosso = campo[0].Nome,
                PuntiRosso = 0,
                IdBlu = campo[1].IdAtleta,
                CognomeBlu = campo[1].Cognome,
                NomeBlu = campo[1].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[2].IdAtleta,
                CognomeRosso = campo[2].Cognome,
                NomeRosso = campo[2].Nome,
                PuntiRosso = 0,
                IdBlu = campo[3].IdAtleta,
                CognomeBlu = campo[3].Cognome,
                NomeBlu = campo[3].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[4].IdAtleta,
                CognomeRosso = campo[4].Cognome,
                NomeRosso = campo[4].Nome,
                PuntiRosso = 0,
                IdBlu = campo[5].IdAtleta,
                CognomeBlu = campo[5].Cognome,
                NomeBlu = campo[5].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[6].IdAtleta,
                CognomeRosso = campo[6].Cognome,
                NomeRosso = campo[6].Nome,
                PuntiRosso = 0,
                IdBlu = campo[7].IdAtleta,
                CognomeBlu = campo[7].Cognome,
                NomeBlu = campo[7].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo2.DataSource = list.ToArray();
            dataGridViewCampo2.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo2_DataBindingComplete);
        }

        private void dataGridViewCampo2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void caricaCampo3(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
            {
                IdRosso = campo[0].IdAtleta,
                CognomeRosso = campo[0].Cognome,
                NomeRosso = campo[0].Nome,
                PuntiRosso = 0,
                IdBlu = campo[1].IdAtleta,
                CognomeBlu = campo[1].Cognome,
                NomeBlu = campo[1].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[2].IdAtleta,
                CognomeRosso = campo[2].Cognome,
                NomeRosso = campo[2].Nome,
                PuntiRosso = 0,
                IdBlu = campo[3].IdAtleta,
                CognomeBlu = campo[3].Cognome,
                NomeBlu = campo[3].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[4].IdAtleta,
                CognomeRosso = campo[4].Cognome,
                NomeRosso = campo[4].Nome,
                PuntiRosso = 0,
                IdBlu = campo[5].IdAtleta,
                CognomeBlu = campo[5].Cognome,
                NomeBlu = campo[5].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[6].IdAtleta,
                CognomeRosso = campo[6].Cognome,
                NomeRosso = campo[6].Nome,
                PuntiRosso = 0,
                IdBlu = campo[7].IdAtleta,
                CognomeBlu = campo[7].Cognome,
                NomeBlu = campo[7].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo3.DataSource = list.ToArray();
            dataGridViewCampo3.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo3_DataBindingComplete);
        }

        private void dataGridViewCampo3_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }

        private void caricaCampo4(List<AtletaEliminatorie> campo)
        {

            List<Incontro> list = new List<Incontro>();

            list.Add(new Incontro()
            {
                IdRosso = campo[0].IdAtleta,
                CognomeRosso = campo[0].Cognome,
                NomeRosso = campo[0].Nome,
                PuntiRosso = 0,
                IdBlu = campo[1].IdAtleta,
                CognomeBlu = campo[1].Cognome,
                NomeBlu = campo[1].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[2].IdAtleta,
                CognomeRosso = campo[2].Cognome,
                NomeRosso = campo[2].Nome,
                PuntiRosso = 0,
                IdBlu = campo[3].IdAtleta,
                CognomeBlu = campo[3].Cognome,
                NomeBlu = campo[3].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[4].IdAtleta,
                CognomeRosso = campo[4].Cognome,
                NomeRosso = campo[4].Nome,
                PuntiRosso = 0,
                IdBlu = campo[5].IdAtleta,
                CognomeBlu = campo[5].Cognome,
                NomeBlu = campo[5].Nome,
                PuntiBlu = 0,
            }
            );

            list.Add(new Incontro()
            {
                IdRosso = campo[6].IdAtleta,
                CognomeRosso = campo[6].Cognome,
                NomeRosso = campo[6].Nome,
                PuntiRosso = 0,
                IdBlu = campo[7].IdAtleta,
                CognomeBlu = campo[7].Cognome,
                NomeBlu = campo[7].Nome,
                PuntiBlu = 0,
            }
            );

            dataGridViewCampo4.DataSource = list.ToArray();
            dataGridViewCampo4.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridViewCampo4_DataBindingComplete);
        }

        private void dataGridViewCampo4_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView d = (DataGridView)sender;

            d.Columns["IdBlu"].Visible = false;
            d.Columns["IdRosso"].Visible = false;
            d.Columns["SatrapiaRosso"].Visible = false;
            d.Columns["Satrapiablu"].Visible = false;
            //d.Columns["PrimoSangue"].Visible = false;
        }


        /** dtgrid index columns
             * [0] IdA
             * [1] AsdA
             * [2] CognomeA
             * [3] NomeA
             * [4] PuntiA
             * [5] IdB
             * [6] AdB
             * [7] CognomeB
             * [8] NomeB
             * [9] PuntiB
             * [10] Primosangue
             * */

        private void buttonSalvaCampo1_Click(object sender, EventArgs e)
        {
            Helper.EliminaSedicesimiByCampo(1, idTorneo, idDisciplina);

            int posizione = 1;

            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo1.Rows)
            {
                AtletaEliminatorie a = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                    a.IdAtleta = (int)r.Cells[0].Value;
                else
                    a.IdAtleta = (int)r.Cells[5].Value;

                Helper.UpdateQualificati32(idTorneo, idDisciplina, 1, posizione, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateQualificati32(idTorneo, idDisciplina, 1, posizione, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

                a.IdTorneo = idTorneo;
                a.idDisciplina = idDisciplina;
                a.Posizione = posizione;
                a.Campo = 1;
                a.PuntiFatti = 0;
                a.PuntiSubiti = 0;

                listAtleti.Add(a);

                posizione++;
            }
            Helper.InsertOttavi(listAtleti);

            MessageBox.Show("Campo 1 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonSalvaCampo2_Click(object sender, EventArgs e)
        {
            Helper.EliminaSedicesimiByCampo(2, idTorneo, idDisciplina);

            int posizione = 1;

            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo2.Rows)
            {
                AtletaEliminatorie a = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                    a.IdAtleta = (int)r.Cells[0].Value;
                else
                    a.IdAtleta = (int)r.Cells[5].Value;

                Helper.UpdateQualificati32(idTorneo, idDisciplina, 2, posizione, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateQualificati32(idTorneo, idDisciplina, 2, posizione, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

                a.IdTorneo = idTorneo;
                a.idDisciplina = idDisciplina;
                a.Posizione = posizione;
                a.Campo = 2;
                a.PuntiFatti = 0;
                a.PuntiSubiti = 0;

                listAtleti.Add(a);

                posizione++;
            }
            Helper.InsertOttavi(listAtleti);
            MessageBox.Show("Campo 2 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSalvaCampo3_Click(object sender, EventArgs e)
        {
            Helper.EliminaSedicesimiByCampo(3, idTorneo, idDisciplina);

            int posizione = 1;

            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo3.Rows)
            {
                AtletaEliminatorie a = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                    a.IdAtleta = (int)r.Cells[0].Value;
                else
                    a.IdAtleta = (int)r.Cells[5].Value;

                Helper.UpdateQualificati32(idTorneo, idDisciplina, 3, posizione, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateQualificati32(idTorneo, idDisciplina, 3, posizione, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

                a.IdTorneo = idTorneo;
                a.idDisciplina = idDisciplina;
                a.Posizione = posizione;
                a.Campo = 3;
                a.PuntiFatti = 0;
                a.PuntiSubiti = 0;

                listAtleti.Add(a);

                posizione++;
            }
            Helper.InsertOttavi(listAtleti);

            MessageBox.Show("Campo 3 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSalvaCampo4_Click(object sender, EventArgs e)
        {
            Helper.EliminaSedicesimiByCampo(4, idTorneo, idDisciplina);

            int posizione = 1;

            List<AtletaEliminatorie> listAtleti = new List<AtletaEliminatorie>();

            foreach (DataGridViewRow r in dataGridViewCampo4.Rows)
            {
                AtletaEliminatorie a = new AtletaEliminatorie();

                if ((int)r.Cells[4].Value > (int)r.Cells[9].Value)
                    a.IdAtleta = (int)r.Cells[0].Value;
                else
                    a.IdAtleta = (int)r.Cells[5].Value;

                Helper.UpdateQualificati32(idTorneo, idDisciplina, 4, posizione, (int)r.Cells[0].Value, (int)r.Cells[4].Value, (int)r.Cells[9].Value);
                Helper.UpdateQualificati32(idTorneo, idDisciplina, 4, posizione, (int)r.Cells[5].Value, (int)r.Cells[9].Value, (int)r.Cells[4].Value);

                a.IdTorneo = idTorneo;
                a.idDisciplina = idDisciplina;
                a.Posizione = posizione;
                a.Campo = 4;
                a.PuntiFatti = 0;
                a.PuntiSubiti = 0;

                listAtleti.Add(a);

                posizione++;
            }
            Helper.InsertOttavi(listAtleti);

            MessageBox.Show("Campo 4 Salvato correttamente", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            List<AtletaEliminatorie> campo1 = new List<AtletaEliminatorie>();
            List<AtletaEliminatorie> campo2 = new List<AtletaEliminatorie>();
            List<AtletaEliminatorie> campo3 = new List<AtletaEliminatorie>();
            List<AtletaEliminatorie> campo4 = new List<AtletaEliminatorie>();

            campo1 = Helper.GetOttavi(idTorneo, idDisciplina, 1);
            campo2 = Helper.GetOttavi(idTorneo, idDisciplina, 2);
            campo3 = Helper.GetOttavi(idTorneo, idDisciplina, 3);
            campo4 = Helper.GetOttavi(idTorneo, idDisciplina, 4);

            Form ottavi = new Ottavi(campo1, campo2, campo3, campo4, idTorneo, idDisciplina);

            ottavi.StartPosition = FormStartPosition.CenterScreen;

            ottavi.Show();

            this.Close();

        }

        private void buttonStampa_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();
            pdf.StampaSedicesimi(campo1, campo2, campo3, campo4);
        }

        private void btnBracket_Click(object sender, EventArgs e)
        {
            PdfManager pdf = new PdfManager();
            pdf.StampaBracketSedicesimi(campo1, campo2, campo3, campo4);
        }
    }
}
