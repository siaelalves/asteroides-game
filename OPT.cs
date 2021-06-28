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
    public partial class OPT : Form
    {
        public OPT()
        {
            InitializeComponent();
        }
        
        SettingReader.Configurações set = new SettingReader.Configurações();

        private void OPT_Load(object sender, EventArgs e)
        {            
            txtNv.Text = set.LerConfigurações("options.scfg", "game", "level");
            
            if (set.LerConfigurações("options.scfg", "game", "sound") == "true")
            { chkSm.Checked = true; } else { chkSm.Checked = false; }
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            GM game = new GM();
            INF.Regras.Nível = txtNv.SelectedIndex + 1;
            INF.Regras.TemSom = chkSm.Checked;
            set.ModificarConfiguração(@"options.scfg", "game",
                "level", txtNv.Text.ToLower());
            set.ModificarConfiguração(@"options.scfg", "game",
                "sound", chkSm.Checked.ToString().ToLower());
            this.Close();
        }

        private void cmdCnc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
