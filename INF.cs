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
    public static class INF
    {
        public static class Energia
        {
            public static int EnergiaAtual { get; set; }

            public static int EnergiaTotal
            {
                get
                {
                    return 100;
                }
            }
        }

        public static class Fase
        {
            public static SoundPlayer Música { get; set; }

            public static Bitmap Cenário { get; set; }

            public static int PontuaçãoParaPróximoNível { get; set; }
            public static int VelocidadeDosAsteroides { get; set; }
            public static byte Número { get; set; }
        }

        public static class Regras
        {
            public class Asteroides
            {
                public int AlturaAst1 { get; set; }
                public int LarguraAst1 { get; set; }

                public int AlturaAst2 { get; set; }
                public int LarguraAst2 { get; set; }

                public int AlturaAst3 { get; set; }
                public int LarguraAst3 { get; set; }

                public int AlturaAst4 { get; set; }
                public int LarguraAst4 { get; set; }

                public int AlturaMínima
                {
                    get
                    {
                        return 0;
                    }
                }

                public int AlturaMáxima
                {
                    get
                    {
                        return 200;
                    }
                }

                public int LarguraMínima
                {
                    get
                    {
                        return 0;
                    }
                }

                public int LarguraMáxima
                {
                    get
                    {
                        return 200;
                    }
                }

                public int PosiçãoX { get; set;}
                public int PosiçãoY { get; set; }

                public int PosiçãoHorizontalMínima
                {
                    get
                    {
                        return 23;
                    }
                }

                public int PosiçãoHorizontalMáxima
                {
                    get
                    {
                        return 367;
                    }
                }

                public int PosiçãoVerticalMínima
                {
                    get
                    {
                        return 23;
                    }
                }

                public int PosiçãoVerticalMáxima
                {
                    get
                    {
                        return 170;
                    }
                }

                public Bitmap[] Figuras = 
            {
                        Properties.Resources.asteroide_1,
                        Properties.Resources.asteroide_2,
                        Properties.Resources.asteroide_3,
                        Properties.Resources.asteroide_4
            };
            }

            public static bool EstáPausado { get; set; }
            public static bool TemSom { get; set; }

            public static bool TemJogoSalvo()
            {
                SettingReader.Configurações set = new SettingReader.Configurações();
            
                // Se houver algum jogo salvo,
                if (set.LerConfigurações("options.scfg", "save", "name") != "namevalue")
                {
                    // Retorna Sim
                    return true;
                }
                    // Se não houver algum jogo salvo,
                else
                {
                    // Retorna Não
                    return false;
                }
            }

            public static int Nível { get; set; }

            public static class Pontuação
            {
                public static int Pontos { get; set; }
                public static int PontosPorAsteroide
                {
                    get
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
