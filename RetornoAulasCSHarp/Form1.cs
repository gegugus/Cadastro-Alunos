using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetornoAulasCSHarp;

namespace RetornoAulasCSHarp
{
    public partial class SCREEN : Form
    {
        private AlunoDAO _alunoDAO = new AlunoDAO();
        private int alunoSelecionadoId = 0;

        public SCREEN()
        {
            InitializeComponent();

            LblLink.Links.Clear();
            LblLink.Links.Add(0, LblLink.Text.Length, "https://github.com/gegugus");
            LblLink.LinkClicked += LblLink_LinkClicked;
        }

        private void LblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = e.Link.LinkData.ToString(),
                UseShellExecute = true
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void BTN_ALUNOS_STRIP_Click(object sender, EventArgs e)
        {
            TB_ALUNOSCADASTRADOS tela = new TB_ALUNOSCADASTRADOS();
            tela.Show();
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            if (bytes == null) return null;
            using (var ms = new System.IO.MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void LimparCampos()
        {
            TXT_NOME.Clear();
            TXT_EMAIL.Clear();
            TXT_TELEFONE.Clear();

            if (PB_IMAGEM.Image != null)
            {
                PB_IMAGEM.Image.Dispose();
                PB_IMAGEM.Image = null;
            }

            alunoSelecionadoId = 0; 
            TXT_NOME.Focus();
        }

        private void BTN_ADICIONAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXT_NOME.Text))
            {
                MessageBox.Show("Informe o nome do aluno!");
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_EMAIL.Text))
            {
                MessageBox.Show("Informe o e-mail do aluno");
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_TELEFONE.Text))
            {
                MessageBox.Show("Informe o telefone do aluno");
                return;
            }

            Aluno aluno = new Aluno
            {
                NOME = TXT_NOME.Text,
                EMAIL = TXT_EMAIL.Text,
                TELEFONE = TXT_TELEFONE.Text,
                IMAGEM = ImageToByteArray(PB_IMAGEM.Image) 
            };

            _alunoDAO.INSERT(aluno);

            MessageBox.Show("Aluno cadastrado com sucesso!");
            LimparCampos();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            string nomeParaBusca = TXT_NOME.Text.Trim();

            if (string.IsNullOrEmpty(nomeParaBusca))
            {
                MessageBox.Show("Digite um nome para buscar.");
                return;
            }

            DataTable dt = _alunoDAO.LIST();
            DataRow[] encontrados = dt.Select($"Nome LIKE '%{nomeParaBusca}%'");

            if (encontrados.Length > 0)
            {
                DataRow row = encontrados[0];
                alunoSelecionadoId = Convert.ToInt32(row["Id"]);

                TXT_NOME.Text = row["Nome"].ToString();
                TXT_EMAIL.Text = row["Email"].ToString();
                TXT_TELEFONE.Text = row["Telefone"].ToString();

                if (row["Imagem"] != DBNull.Value)
                    PB_IMAGEM.Image = ByteArrayToImage((byte[])row["Imagem"]);
                else
                    PB_IMAGEM.Image = null;
            }
            else
            {
                MessageBox.Show("Aluno não encontrado.");
                LimparCampos();
            }
        }

        private void BTN_DELETAR_Click(object sender, EventArgs e)
        {
            if (alunoSelecionadoId == 0)
            {
                MessageBox.Show("Busque um aluno para deletar.");
                return;
            }

            _alunoDAO.DELETE(alunoSelecionadoId);
            MessageBox.Show("Aluno deletado com sucesso!");
            LimparCampos();
        }

        private void BTN_ATUALIZAR_Click(object sender, EventArgs e)
        {
            if (alunoSelecionadoId == 0)
            {
                MessageBox.Show("Busque o aluno antes de atualizar.");
                return;
            }

            Aluno aluno = new Aluno
            {
                ID = alunoSelecionadoId,
                NOME = TXT_NOME.Text,
                EMAIL = TXT_EMAIL.Text,
                TELEFONE = TXT_TELEFONE.Text,
                IMAGEM = PB_IMAGEM.Image != null ? ImageToByteArray(PB_IMAGEM.Image) : null
            };

            _alunoDAO.UPDATE(aluno);
            MessageBox.Show($"Dados de {TXT_NOME.Text} atualizados com sucesso!");
            LimparCampos();
        }

        private void BTN_IMG_ADICIONAR_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (var temp = Image.FromFile(ofd.FileName))
                    {
                        PB_IMAGEM.Image = new Bitmap(temp);
                    }
                }
            }
        }

        private void BTN_IMG_ALTERAR_Click(object sender, EventArgs e)
        {
            BTN_IMG_ADICIONAR_Click(sender, e);
        }

        private void BTN_IMG_EXCLUIR_Click(object sender, EventArgs e)
        {
            if (PB_IMAGEM.Image != null)
            {
                PB_IMAGEM.Image.Dispose();
                PB_IMAGEM.Image = null;
            }
        }

        private void BTN_SAIR_STRIP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LBL_EMAIL_Click(object sender, EventArgs e)
        {
        }

        private void TXT_EMAIL_TextChanged(object sender, EventArgs e)
        {
        }
    }
}