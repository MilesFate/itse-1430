using System;
using System.ComponentModel;
using System.Windows.Forms;
using LuisalbertoCastaneda.CharacterCreator;

namespace LuisalbertoCastaneda.AdventureGame.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private static bool Confirm ( string message, string title )
        {
            return MessageBox.Show(message, title,MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            //Confirm exit?
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;

            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var dlg = new AboutBox();
            //Blocks until child form is closed
            dlg.ShowDialog();
        }

        private void OnAddCharacter ( object sender, EventArgs e )
        {
            var dlg = new CharacterForm();
            dlg.StartPosition = FormStartPosition.CenterParent;
            //ShowDialog -> DialogResult
            if (dlg.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO: Save movie            
            //_movie = dlg.Movie;
            //UpdateUI();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            var dlg = new CharacterForm();
            dlg.character = _character;

            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;            
        }

        private Character _character;

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            if (_character == null)
                return;

            var dlg = new CharacterForm();
            dlg.character = _character;

            //ShowDialog -> DialogResult
            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            _character = null;
            
        }
    }
}
