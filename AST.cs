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
    public partial class AST : Form
    {
        public AST()
        {
            InitializeComponent();
        }

        System.Media.SoundPlayer snd = new System.Media.SoundPlayer();
        SettingReader.Configurações set = new SettingReader.Configurações();

        private void lblCnt_Click(object sender, EventArgs e)
        {
            GM game = new GM();
            INF.Fase.Número = Convert.ToByte(
                set.LerConfigurações("options.scfg", "save", "stage"));
            INF.Regras.Pontuação.Pontos = Convert.ToInt16(
                set.LerConfigurações("options.scfg", "save", "score"));
            INF.Regras.Nível = Convert.ToInt16(
                set.LerConfigurações("options.scfg", "save", "level"));
            INF.Energia.EnergiaAtual = Convert.ToInt16(
                set.LerConfigurações("options.scfg", "save", "energy"));
            INF.Regras.EstáPausado = false;
            game.PassarFase(INF.Fase.Número);
            game.Show();
        }

        private void MATH_Load(object sender, EventArgs e)
        {
            // Inicializa um novo formulário GM
            GM game = new GM();
            // Se houver algum jogo salvo,
            if (INF.Regras.TemJogoSalvo() == true)
            {
                // Exibe botão Continuar
                lblCnt.Visible = true;
            }
            // Se não houver jogo salvo,
            else
            {
                // Oculta o botão Continuar
                lblCnt.Visible = false;
            }
            // Define a música de abertura
            snd.SoundLocation = set.LerConfigurações("options.scfg", "music", "opening");
            // Define se vai tocar a música de abertura
            INF.Regras.TemSom = Convert.ToBoolean(set.LerConfigurações("options.scfg", "game", "sound"));
            // Se o som estiver ativado,
            if (INF.Regras.TemSom == true)
            {
                // Toca a música da abertura
                snd.PlayLooping();
            }
        }

        private void lblIn_MouseHover(object sender, EventArgs e)
        {
            lblIn.ForeColor = Color.Red;
        }

        private void lblIn_MouseLeave(object sender, EventArgs e)
        {
            lblIn.ForeColor = Color.Yellow;
        }

        private void lblOp_MouseHover(object sender, EventArgs e)
        {
            lblOp.ForeColor = Color.Red;
        }

        private void lblOp_MouseLeave(object sender, EventArgs e)
        {
            lblOp.ForeColor = Color.Yellow;
        }

        private void lblSr_MouseHover(object sender, EventArgs e)
        {
            lblSr.ForeColor = Color.Red;
        }

        private void lblSr_MouseLeave(object sender, EventArgs e)
        {
            lblSr.ForeColor = Color.Yellow;
        }

        private void lblCnt_MouseLeave(object sender, EventArgs e)
        {
            lblCnt.ForeColor = Color.Yellow;
        }

        private void lblCnt_MouseHover(object sender, EventArgs e)
        {
            lblCnt.ForeColor = Color.Red;
        }

        private void lblIn_Click(object sender, EventArgs e)
        {
            //set.ModificarConfiguração(
            //    "options.scfg", "save", "name", "namevalue");
            //set.ModificarConfiguração(
            //    "options.scfg", "save", "stage", "value");
            //set.ModificarConfiguração(
            //    "options.scfg", "save", "score", "value");
            //set.ModificarConfiguração(
            //    "options.scfg", "save", "energy", "value");
            GM jogo = new GM();
            jogo.Show();
        }

        private void lblOp_Click(object sender, EventArgs e)
        {            
            OPT opções = new OPT();
            GM game = new GM();
            if (opções.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        private void lblSr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?",
                "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
            {
                snd.Stop();
                // Finaliza aplicação.
                Application.Exit();
            }
        }
    }
}
