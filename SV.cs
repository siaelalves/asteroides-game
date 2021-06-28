using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MATH
{
    public partial class SV : Form
    {
        public SV()
        {
            InitializeComponent();
        }

        SettingReader.Configurações set = new SettingReader.Configurações();

        private void cmdOK_Click(object sender, EventArgs e)
        {
            GM game = new GM();
            // Salva o jogo
            set.ModificarConfiguração("options.scfg", "save", "name", txtNm.Text);
            set.ModificarConfiguração("options.scfg", "save", "stage", INF.Fase.Número.ToString());
            set.ModificarConfiguração("options.scfg", "save", "score", INF.Regras.Pontuação.Pontos.ToString());
            set.ModificarConfiguração("options.scfg", "save", "level", INF.Regras.Nível.ToString());
            set.ModificarConfiguração("options.scfg", "save", "energy", INF.Energia.EnergiaAtual.ToString());
        }

        private void cmdCnc_Click(object sender, EventArgs e)
        {
            // Fecha janela
            this.Close();
        }

        private void SV_Load(object sender, EventArgs e)
        {
            // Focaliza a caixa de texto de nome
            txtNm.Focus();
            // Seleciona todo o texto da caixa de texto
            txtNm.SelectAll();
            // Exibe a pontuação e a fase que serão salvos
            lblRs.Text = "PONTOS: " + INF.Regras.Pontuação.Pontos.ToString() + 
                "\rFASE: " + INF.Fase.Número.ToString();
        }
    }
}
