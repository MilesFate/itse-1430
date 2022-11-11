using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuisalbertoCastaneda.CharacterCreator;

namespace LuisalbertoCastaneda.AdventureGame.WinHost
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent();
        }

        public Character character { get; set; }

        private void OnSave ( object sender, EventArgs e )
        {
            // validate children
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
                return;
            }

            //Build up a Movie
            var character = new Character() {
                Name = _txtName.Text,
                Profession = _cbProfession.Text,
                Race = _cbRace.Text,
                Biography = _txtBio.Text,
                Strength = GetInt32(_txtStrength),
                Intelligence = GetInt32(_txtIntel),
                Agility = GetInt32(_txtAgility),
                Constitution = GetInt32(_txtConstitution),
                Charisma = GetInt32(_txtCharisma),
            };
            //Validate
            var error = character.Validate();
            if (!String.IsNullOrEmpty(error))
            {
                DisplayError(error, "Error");
                DialogResult = DialogResult.None;
                return;
            };
            var Character = character;

            //Close the form
            //Close();
        }

        private int GetInt32 ( Control /*TextBox*/ control )
        {
            var text = control.Text;
            if (Int32.TryParse(text, out var result))
                return result;

            return -1;
        }

        private void DisplayError ( string message, string title )
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
