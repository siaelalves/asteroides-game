using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MATH
{
    public partial class GM : Form
    {
        public GM()
        {
            InitializeComponent();
        }
        //public Random rnd = new Random();
        //public INF.Regras.Asteroides a = new INF.Regras.Asteroides();
        //public INF.Regras.Pontuação p = new INF.Regras.Pontuação();
        //public INF.Regras r = new INF.Regras();

        //public INF.Fase f = new INF.Fase();

        //public SettingReadeINF.Regras.Configurações set = new SettingReadeINF.Regras.Configurações();

        //public INF.Energia en = new INF.Energia();

        //public SoundPlayer snd = new SoundPlayer();

        //public class Energia
        //{
        //    public int EnergiaAtual {get;set;}

        //    public int EnergiaTotal
        //    {
        //        get
        //        {
        //            return 100;
        //        }
        //    }

        //}

        //public class Fase
        //{
        //    public SoundPlayer Música { get; set; }

        //    public Bitmap Cenário { get; set; }

        //    public int PontuaçãoParaPróximoNível { get; set; }
        //    public int VelocidadeDosAsteroides { get; set; }
        //    public byte Número { get; set; }
        //}

        //public class Regras
        //{
        //    public class Asteroides
        //    {
        //        public int AlturaAst1 { get; set; }                
        //        public int LarguraAst1 { get; set; }

        //        public int AlturaAst2 { get; set; }
        //        public int LarguraAst2 { get; set; }

        //        public int AlturaAst3 { get; set; }
        //        public int LarguraAst3 { get; set; }

        //        public int AlturaAst4 { get; set; }
        //        public int LarguraAst4 { get; set; }

        //        public int AlturaMínima
        //        {
        //            get
        //            {
        //                return 0;
        //            }
        //        }

        //        public int AlturaMáxima
        //        {
        //            get
        //            {
        //                return 200;
        //            }
        //        }

        //        public int LarguraMínima
        //        {
        //            get
        //            {
        //                return 0;
        //            }
        //        }

        //        public int LarguraMáxima
        //        {
        //            get
        //            {
        //                return 200;
        //            }
        //        }

        //        public int PosiçãoX { get; set; }
        //        public int PosiçãoY { get; set; }

        //        public int PosiçãoHorizontalMínima
        //        { 
        //            get
        //            {
        //                return 23;
        //            }
        //        }

        //        public int PosiçãoHorizontalMáxima
        //        {
        //            get
        //            {
        //                return 367;
        //            }
        //        }

        //        public int PosiçãoVerticalMínima
        //        {
        //            get
        //            {
        //                return 23;
        //            }
        //        }

        //        public int PosiçãoVerticalMáxima
        //        {
        //            get
        //            {
        //                return 170;
        //            }
        //        }

        //        public Bitmap[] Figuras = 
        //    {
        //                Properties.Resources.asteroide_1,
        //                Properties.Resources.asteroide_2,
        //                Properties.Resources.asteroide_3,
        //                Properties.Resources.asteroide_4
        //    };
        ////    }

        //    public bool EstáPausado { get; set; }
        //    public bool TemSom { get; set; }
        //    public int Nível { get; set; }

        //    public class Pontuação
        //    {
        //        public int Pontos { get; set; }
        //        public int PontosPorAsteroide
        //        {
        //            get
        //            {                        
        //                return 5;
        //            }
        //        }
        //    }
        //}

        INF.Regras.Asteroides a = new INF.Regras.Asteroides();

        SettingReader.Configurações set = new SettingReader.Configurações();
        SoundPlayer snd = new SoundPlayer();
        Random rnd = new Random();

        public void PassarFase(
               int FaseAtual)
        {
            // Se a fase for 1
            if (FaseAtual == 1)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "two")))
                {
                    // Aumenta 1 fase                    
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_two;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stagetwo");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado,
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            else if (FaseAtual == 2)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "three")))
                {
                    // Aumenta 1 fase
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_three;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stagethree");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado,            
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            else if (FaseAtual == 3)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "four")))
                {
                    // Aumenta 1 fase                    
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_four;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stagefour");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado, 
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            else if (FaseAtual == 4)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "five")))
                {
                    // Aumenta 1 fase
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_five;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stagefive");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado,            
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            else if (FaseAtual == 5)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "six")))
                {
                    // Aumenta 1 fase
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_six;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stagesix");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado,            
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            else if (FaseAtual == 6)
            {
                // Se o número de pontos for suficiente para passar de fase,
                if (INF.Regras.Pontuação.Pontos >= Convert.ToInt16(set.LerConfigurações("options.scfg", "stage", "seven")))
                {
                    // Aumenta 1 fase
                    INF.Fase.Número += 1;
                    // Define o cenário da fase
                    INF.Fase.Cenário = Properties.Resources.stage_seven;
                    // Aplica o cenário da fase
                    this.BackgroundImage = INF.Fase.Cenário;
                    // Define a música da fase
                    snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stageseven");
                    // Para de tocar a música anterior
                    snd.Stop();
                    // Se o som estiver ativado,            
                    if (INF.Regras.TemSom == true)
                    {
                        // Toca a música indefinidademente
                        snd.PlayLooping();
                    }
                    // Por outro lado, se o som estiver desativado,
                    else
                    {
                        // Para de tocar a música
                        snd.Stop();
                    }
                }
            }
            // Aplica a fase atual à tela
            lblFs.Text = "FASE\r" + INF.Fase.Número;
        }

        private void GM_Load(object sender, EventArgs e)
        {
            // Ativa cronômetro
            tmR.Enabled = true;
            // Define intervalo de tempo
            tmR.Interval = 10;

            // Cria asteroide 1
            // Determina nova posição aleatória            
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica a nova posição à figura
            picAst1.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst1.Image = a.Figuras[rnd.Next(0, 3)];

            // Cria asteroide 2
            // Determina nova posição aleatória
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica a nova posição à figura
            picAst2.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst2.Image = a.Figuras[rnd.Next(0, 3)];

            // Cria asteroide 3
            // Determina nova posição aleatória
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica a nova posição à figura
            picAst3.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst3.Image = a.Figuras[rnd.Next(0, 3)];

            // Cria asteroide 4
            // Determina nova posição aleatória
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica a nova posição à figura
            picAst4.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst4.Image = a.Figuras[rnd.Next(0, 3)];

            // Se tiver jogo salvo,
            if (INF.Regras.TemJogoSalvo() == true)
            {
                // Define fase inicial
                INF.Fase.Número = Convert.ToByte(set.LerConfigurações("options.scfg", "save", "stage"));
                // Define a pontuação inicial
                INF.Regras.Pontuação.Pontos = Convert.ToInt16(set.LerConfigurações("options.scfg", "save", "score"));
                // Define energia inicial
                INF.Energia.EnergiaAtual = Convert.ToInt16(set.LerConfigurações("options.scfg", "save", "energy"));
            }
            // Caso não tenha jogo salvo
            else if (INF.Regras.TemJogoSalvo() == false)
            {
                // Define fase inicial
                INF.Fase.Número = 1;
                // Define a pontuação inicial
                INF.Regras.Pontuação.Pontos = 0;
                // Define energia inicial
                INF.Energia.EnergiaAtual = Convert.ToInt16(set.LerConfigurações("options.scfg", "save", "energy"));
            }

            // Define música inicial
            snd.SoundLocation = @set.LerConfigurações("options.scfg", "music", "stageone");
            // Define se há som ou não
            INF.Regras.TemSom = Convert.ToBoolean(set.LerConfigurações("options.scfg", "game", "sound"));
            // Se o som estiver ativado,
            if (INF.Regras.TemSom == true)
            {
                // Para de tocar a música
                snd.Stop();
                // Toca a música indefinidamente
                snd.PlayLooping();
            }
            // Por outro lado, se o som estiver desativado,
            else
            {
                // Para de tocar a música
                snd.Stop();
            }
            // Define nível do jogo;
            // Se ao ler as configurações, encontrar o nível "Fácil",
            if (set.LerConfigurações("options.scfg", "game", "level") == "Fácil")
            {
                // Define nível 1
                INF.Regras.Nível = 1;
            }
            // Se ao ler as configurações, encontrar o nível "Médio",
            else if (set.LerConfigurações("options.scfg", "game", "level") == "Médio")
            {
                // Define nível 2
                INF.Regras.Nível = 2;
            }
            // Se ao ler as configurações, encontrar o nível "Difícil",
            else if (set.LerConfigurações("options.scfg", "game", "level") == "Difícil")
            {
                // Define nível 3
                INF.Regras.Nível = 3;
            }
            
            // Se o Nível for 1 (Fácil),
            if (INF.Regras.Nível == 1)
            {
                // Cronômetro roda com base 15 milissegundos
                tmR.Interval = 15;
            }
            // Se o Nível for 2 (Médio),
            else if (INF.Regras.Nível == 2)
            {
                // Cronômetro roda com base 10 milissegundos
                tmR.Interval = 10;
            }
            // Se o Nível for 3 (Difícil),
            else if (INF.Regras.Nível == 3)
            {
                // Cronômetro roda com base 5 milissegundos
                tmR.Interval = 5;
            }

            // Aplica os pontos à tela do jogo
            lblPn.Text = "PONTOS\r"+
                INF.Regras.Pontuação.Pontos.ToString();

            // Aplica a energia à tela do jogo
            lblEn.Text = "ENERGIA\r" +
                INF.Energia.EnergiaAtual.ToString();

            // Aplica a fase à tela do jogo
            lblFs.Text = "FASE\r" +
                INF.Fase.Número.ToString();

            // Aplica o nível à tela do jogo
            lblNv.Text = "NÍVEL\r" + 
            set.LerConfigurações("options.scfg", "game", "level").ToUpper();

            // Ativa cronômetro
            tmR.Enabled = true;
            // Inicia cronômetro
            tmR.Start();
        }

        private void tmR_Tick(object sender, EventArgs e)
        {
            // Se o jogo não estiver parado,
            if (INF.Regras.EstáPausado == false)
            {
                if (a.AlturaAst1 == a.AlturaMáxima)
                {
                    // Reduz 10 pontos de energia
                    INF.Energia.EnergiaAtual -= 10;
                    // Aplica energia à barra de progresso
                    lblEn.Text = "ENERGIA\r" + INF.Energia.EnergiaAtual.ToString();
                    // Se energia acabar,
                    if (INF.Energia.EnergiaAtual <= 0)
                    {
                        // Cronômetro para
                        tmR.Stop();
                        // Mesagem de fim de jogo.
                        MessageBox.Show("FIM DE JOGO!", "MATH", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        // Janela é fechada.
                        this.Close();
                    }
                    // Se ainda tiver energia,
                    // Apaga asteroide
                    a.AlturaAst1 = 0;
                    a.LarguraAst1 = 0;
                    // Cria asteroide
                    // Determina nova posição aleatória
                    a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
                    a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
                    // Aplica a nova posição à figura
                    picAst1.Location = new Point(a.PosiçãoX, a.PosiçãoY);
                    // Insere a imagem de um asteroide aleatório
                    picAst1.Image = a.Figuras[rnd.Next(0, 2)];
                }
                // Cresce asteroide
                a.AlturaAst1 += 1;
                a.LarguraAst1 += 1;
                // Novo tamanho é aplicado a cada 10 milissegundos.
                picAst1.Size = new Size(a.LarguraAst1, a.AlturaAst1);

            if (a.AlturaAst2 == a.AlturaMáxima)
            {
                    // Reduz 10 pontos de energia
                    INF.Energia.EnergiaAtual -= 10;
                    // Aplica energia à barra de progresso
                    lblEn.Text = "ENERGIA\r" + INF.Energia.EnergiaAtual.ToString();
                    // Se energia acabar,
                    if (INF.Energia.EnergiaAtual == 0)
                    {
                        // Cronômetro para
                        tmR.Stop();
                        // Mesagem de fim de jogo.
                        MessageBox.Show("FIM DE JOGO!", "MATH", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        // Janela é fechada.
                        this.Close();
                    }
                    // Se ainda tiver energia,
                    // Apaga asteroide
                    a.AlturaAst2 = 0;
                    a.LarguraAst2 = 0;
                    // Cria asteroide
                    // Determina nova posição aleatória
                    a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
                    a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
                    // Aplica a nova posição à figura
                    picAst2.Location = new Point(a.PosiçãoX, a.PosiçãoY);
                    // Insere a imagem de um asteroide aleatório
                    picAst2.Image = a.Figuras[rnd.Next(0, 2)];
                }
            // Cresce asteroide
            a.AlturaAst2 += 1;
            a.LarguraAst2 += 1;
            // Novo tamanho é aplicado a cada 10 milissegundos.
            picAst2.Size = new Size(a.LarguraAst2, a.AlturaAst2);

            if (a.AlturaAst3 == a.AlturaMáxima)
            {
                    // Reduz 10 pontos de energia
                    INF.Energia.EnergiaAtual -= 10;
                    // Aplica energia à barra de progresso
                    lblEn.Text = "ENERGIA\r" + INF.Energia.EnergiaAtual.ToString();
                    // Se energia acabar,
                    if (INF.Energia.EnergiaAtual <= 0)
                    {
                        // Cronômetro para
                        tmR.Stop();
                        // Exibe mensagem de fim de jogo.
                        MessageBox.Show("FIM DE JOGO!", "MATH", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        // Janela é fechada.
                        this.Close();
                    }
                    // Se ainda tiver energia,
                    // Apaga asteroide
                    a.AlturaAst3 = 0;
                    a.LarguraAst3 = 0;
                    // Cria asteroide
                    // Determina nova posição aleatória
                    a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
                    a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
                    // Aplica a nova posição à figura
                    picAst3.Location = new Point(a.PosiçãoX, a.PosiçãoY);
                    // Insere a imagem de um asteroide aleatório
                    picAst3.Image = a.Figuras[rnd.Next(0, 2)];
            }
            // Cresce asteroide
            a.AlturaAst3 += 1;
            a.LarguraAst3 += 1;
            // Novo tamanho é aplicado a cada 10 milissegundos.
            picAst3.Size = new Size(a.LarguraAst3, a.AlturaAst3);

            if (a.AlturaAst4 == a.AlturaMáxima)
            {
                // Reduz 10 pontos de energia
                INF.Energia.EnergiaAtual -= 10;
                // Aplica energia à barra de progresso
                lblEn.Text = "ENERGIA\r" + INF.Energia.EnergiaAtual.ToString();
                // Se energia acabar,
                if (INF.Energia.EnergiaAtual <= 0)
                {
                    // Cronômetro para
                    tmR.Stop();
                    // Mesagem de fim de jogo.
                    MessageBox.Show("FIM DE JOGO!", "MATH", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    // Janela é fechada.
                    this.Close();
                }
                // Se ainda tiver energia,
                // Apaga asteroide
                a.AlturaAst4 = 0;
                a.LarguraAst4 = 0;
                // Cria asteroide
                // Determina nova posição aleatória
                a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
                a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
                // Aplica a nova posição à figura
                picAst4.Location = new Point(a.PosiçãoX, a.PosiçãoY);
                // Insere a imagem de um asteroide aleatório
                picAst4.Image = a.Figuras[rnd.Next(0, 2)];
            }
            // Cresce asteroide
            a.AlturaAst4 += 1;
            a.LarguraAst4 += 1;
            // Novo tamanho é aplicado a cada 10 milissegundos.
            picAst4.Size = new Size(a.LarguraAst4, a.AlturaAst4);

            // Define pontuação e fase atual
            
            }
        }  

        private void picAst1_Click(object sender, EventArgs e)
        {
            // Apaga asteroide
            a.AlturaAst1 = 0;
            a.LarguraAst1 = 0;
            // Reposiciona novo asteroide
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica tamanho à figura
            picAst1.Size = new Size(a.LarguraAst1, a.AlturaAst1);
            // Aplica nova posição aleatória à figura
            picAst1.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst1.Image = a.Figuras[rnd.Next(0, 3)];
            // Coloca o asteroide à frente dos outros
            //picAst1.BringToFront();            
            // Marca pontuação
            INF.Regras.Pontuação.Pontos += INF.Regras.Pontuação.PontosPorAsteroide;
            // Aplica a pontuação à tela
            lblPn.Text = "PONTOS\r" + INF.Regras.Pontuação.Pontos.ToString();
            // Determina se passou de fase
            PassarFase(INF.Fase.Número);
        }

        private void picAst2_Click(object sender, EventArgs e)
        {
            // Apaga asteroide
            a.AlturaAst2 = 0;
            a.LarguraAst2 = 0;
            // Reposiciona novo asteroide
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica tamanho à figura
            picAst2.Size = new Size(a.LarguraAst2, a.AlturaAst2);
            // Aplica nova posição aleatória à figura
            picAst2.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst2.Image = a.Figuras[rnd.Next(0, 2)];
            // Coloca o asteroide à frente dos outros
            picAst2.BringToFront();
            // Marca pontuação
            INF.Regras.Pontuação.Pontos += INF.Regras.Pontuação.PontosPorAsteroide;
            // Aplica a pontuação à tela
            lblPn.Text = "PONTOS\r" + INF.Regras.Pontuação.Pontos.ToString();
            // Determina se passou de fase
            PassarFase(INF.Fase.Número);
        }

        private void picAst3_Click(object sender, EventArgs e)
        {
            // Apaga asteroide
            a.AlturaAst3 = 0;
            a.LarguraAst3 = 0;
            // Reposiciona novo asteroide
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica tamanho à figura
            picAst3.Size = new Size(a.LarguraAst3, a.AlturaAst3);
            // Aplica nova posição aleatória à figura
            picAst3.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst3.Image = a.Figuras[rnd.Next(0, 2)];
            // Coloca o asteroide à frente dos outros
            //picAst3.BringToFront();
            // Marca pontuação
            INF.Regras.Pontuação.Pontos += INF.Regras.Pontuação.PontosPorAsteroide;
            // Aplica a pontuação à tela
            lblPn.Text = "PONTOS\r" + INF.Regras.Pontuação.Pontos.ToString();
            // Determina se passou de fase
            PassarFase(INF.Fase.Número);
        }

        private void picAst4_Click(object sender, EventArgs e)
        {
            // Apaga asteroide
            a.AlturaAst4 = 0;
            a.LarguraAst4 = 0;
            // Reposiciona novo asteroide
            a.PosiçãoX = rnd.Next(a.PosiçãoHorizontalMínima, a.PosiçãoHorizontalMáxima);
            a.PosiçãoY = rnd.Next(a.PosiçãoVerticalMínima, a.PosiçãoVerticalMáxima);
            // Aplica tamanho à figura
            picAst4.Size = new Size(a.LarguraAst4, a.AlturaAst4);
            // Aplica nova posição aleatória à figura
            picAst4.Location = new Point(a.PosiçãoX, a.PosiçãoY);
            // Insere a imagem de um asteroide aleatório
            picAst4.Image = a.Figuras[rnd.Next(0, 2)];
            // Coloca o asteroide à frente dos outros
            //picAst4.BringToFront();
            // Marca pontuação
            INF.Regras.Pontuação.Pontos += INF.Regras.Pontuação.PontosPorAsteroide;
            // Aplica a pontuação à tela
            lblPn.Text = "PONTOS\r" + INF.Regras.Pontuação.Pontos.ToString();
            // Determina se passou de fase
            PassarFase(INF.Fase.Número);
        }

        private void GM_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Para cronômetro
            tmR.Stop();
            // Se pressionar a tecla {ESC}
            if (e.KeyData == Keys.Escape)
            {
                // Se responder Sim à pergunta,
                if (MessageBox.Show("Você realmente deseja sair?",
                "Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    // Para cronômetro,
                    tmR.Stop();
                    // Desativa asteroides 1,
                    picAst1.Enabled = false;
                    // Desativa asteroide 2,
                    picAst2.Enabled = false;
                    // Desativa asteroide 3,
                    picAst3.Enabled = false;
                    // Determina que o jogo está parado
                    INF.Regras.EstáPausado = true;
                    // Cria objeto da janela de salvamento
                    SV save = new SV();
                    // Exibe janela de salvamento
                    save.ShowDialog();
                    // Fecha a janela.
                    GM.ActiveForm.Close();
                }
            }
            // Se pressionar tecla {PAUSE}
            else if (e.KeyData == Keys.Pause)
            {
                // Se o jogo já estiver parado,
                if (INF.Regras.EstáPausado == true)
                {
                    // Continua cronômetro
                    tmR.Start();
                    // Ativa asteroides 1,
                    picAst1.Enabled = true;
                    // Ativa asteroide 2,
                    picAst2.Enabled = true;
                    // Ativa asteroide 3,
                    picAst3.Enabled = true;
                    // Ativa asteroide 4,
                    picAst4.Enabled = true;
                    // Determina que o jogo não está mais parado
                    INF.Regras.EstáPausado = false;
                }
                // Por outro lado, se o jogo não estiver parado
                else
                {
                    // Para cronômetro,
                    tmR.Stop();
                    // Desativa asteroides 1,
                    picAst1.Enabled = false;
                    // Desativa asteroide 2,
                    picAst2.Enabled = false;
                    // Desativa asteroide 3,
                    picAst3.Enabled = false;
                    // Ativa asteroide 4,
                    picAst4.Enabled = true;
                    // Determina que o jogo está parado
                    INF.Regras.EstáPausado = true;
                }
                // Finaliza método
                return;
            }
            // Continua cronômetro
            tmR.Start();
        }
    }
}
