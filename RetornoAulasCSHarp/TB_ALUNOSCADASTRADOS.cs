using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetornoAulasCSHarp;

namespace RetornoAulasCSHarp
{
    public partial class TB_ALUNOSCADASTRADOS : Form
    {
        private int alunoSelecionadoId = 0;
        private AlunoDAO _alunoDAO = new AlunoDAO();

        public TB_ALUNOSCADASTRADOS()
        {
            InitializeComponent();

            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void TB_ALUNOSCADASTRADOS_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CarregarAlunos();
            ConfigurarLink();
        }

        private void ConfigurarGrid()
        {
            DGV_ALUNOS.ReadOnly = true;
            DGV_ALUNOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_ALUNOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_ALUNOS.MultiSelect = false;

            DGV_ALUNOS.CellClick += DGV_ALUNOS_CellClick;
        }

        private void ConfigurarLink()
        {
            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
        }

        private void CarregarAlunos()
        {
            DGV_ALUNOS.DataSource = _alunoDAO.LIST();

            if (DGV_ALUNOS.Columns.Contains("Imagem"))
            {
                DGV_ALUNOS.Columns["Imagem"].Visible = false;
            }
        }

        private void DGV_ALUNOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = DGV_ALUNOS.Rows[e.RowIndex];

            alunoSelecionadoId = Convert.ToInt32(row.Cells["Id"].Value);

            if (DGV_ALUNOS.Columns.Contains("Imagem") && row.Cells["Imagem"].Value != DBNull.Value)
            {
                byte[] fotoFatura = (byte[])row.Cells["Imagem"].Value;
                PB_IMAGEM.Image = ByteArrayToImage(fotoFatura);
            }
            else
            {
                PB_IMAGEM.Image = null;
            }
        }

        private void DataGridVisu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_ALUNOS_CellClick(sender, e);
        }

        private void BTN_ATUALIZAR_Click(object sender, EventArgs e)
        {
            CarregarAlunos();
        }
    }
}