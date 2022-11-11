// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;
using System.Linq;
using System.Windows.Forms;
using CharacterCreator.Player;

namespace CharacterCreator.WinHost
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm ()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers        

        private void HandleNewCharacter ( object sender, EventArgs e )
        {
            var form = new CharacterForm();

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;
            _character = form.SelectedCharacter;
            UpdateUI();
        }

        private void HandleCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            _character = null;
            UpdateUI();
        }

        private void HandleCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var form = new CharacterForm();
            form.SelectedCharacter = character;

            if (form.ShowDialog(this) == DialogResult.Cancel)
                return;

            _character = form.SelectedCharacter;
            UpdateUI();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm();
            form.ShowDialog(this);
        }        
        #endregion

        #region Private Members

        private Character GetSelectedCharacter ()
        {
            return _character;
        }

        private void UpdateUI()
        {
            _lstCharacters.Items.Clear();

            if (_character == null)
                return;

            var roster = new Character[1];
            roster[0] = _character;
            
            _lstCharacters.Items.AddRange(roster);
            _lstCharacters.DisplayMember = nameof(Character.Name);
        }

        private Character _character;
        #endregion

        #region Game Related
       

        private void HanldeExit ( object sender, EventArgs e )
        {
            if (!Confirm("Do you want to quit?", "Confirm"))
                return;

            Close();
        }

        private static bool Confirm ( string message, string title ) => MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        private void UpdateQuest ()
        {          
            var bindingsource = new BindingSource();           

            _lstArea.DataSource = bindingsource;
        }

        private void OnNewGame ( object sender, EventArgs e )
        {
            if (_character == null)
            {
                ErrorMessage("Error", "A character must be made before you can play the game.");
                DialogResult = DialogResult.None;
                return;
            };

            characterToolStripMenuItem.Enabled = false;
            _btnNorth.Enabled = true;
            _btnSouth.Enabled = true;
            _btnEast.Enabled = true;
            _btnWest.Enabled = true;

            UpdateQuest();
        }

        private void ErrorMessage ( string title, string message ) => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        

        private void OnMoveNorth ( object sender, EventArgs e )
        {
            var player = new RepresentPlayer();

            player.placeY += -1;
        }       

        #endregion
    }
}
