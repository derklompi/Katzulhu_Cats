/*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Katzulhu_Cats.Classes;

namespace Katzulhu_Cats
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private readonly Character c = new Character();

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (cbStrength1.SelectedIndex != -1)
            {
                int strength;

                strength = c.Strength(Convert.ToInt32(cbStrength1.SelectedItem.ToString()));

                lblStrength100.Text = Convert.ToString(strength);
                lblStrength50.Text = Convert.ToString(strength / 2);
                lblStrength33.Text = Convert.ToString(strength / 3);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Stärke überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbConstitution1.SelectedIndex != -1 && cbConstitution2.SelectedIndex != -1)
            {
                int constitution1;
                int constitution2;
                int constitution;

                constitution1 = Convert.ToInt32(cbConstitution1.SelectedItem.ToString());
                constitution2 = Convert.ToInt32(cbConstitution2.SelectedItem.ToString());
                constitution = c.Constitution(constitution1, constitution2);

                lblConstitution100.Text = Convert.ToString(constitution);
                lblConstitution50.Text = Convert.ToString(constitution / 2);
                lblConstitution33.Text = Convert.ToString(constitution / 3);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Konstitution überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbIntelligence1.SelectedIndex != -1 && cbIntelligence2.SelectedIndex != -1)
            {
                int intelligence1;
                int intelligence2;
                int intelligence;

                intelligence1 = Convert.ToInt32(cbIntelligence1.SelectedItem.ToString());
                intelligence2 = Convert.ToInt32(cbIntelligence2.SelectedItem.ToString());
                intelligence = c.Intelligence(intelligence1, intelligence2);

                lblIntelligence.Text = Convert.ToString(intelligence);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Intelligenz überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbDexterity1.SelectedIndex != -1 && cbDexterity2.SelectedIndex != -1)
            {
                int dexterity1;
                int dexterity2;
                int dexterity;

                dexterity1 = Convert.ToInt32(cbDexterity1.SelectedItem.ToString());
                dexterity2 = Convert.ToInt32(cbDexterity1.SelectedItem.ToString());
                dexterity = c.Dexterity(dexterity1, dexterity2);

                lblDexterity.Text = Convert.ToString(dexterity);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Geschicklichkeit überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbEducation1.SelectedIndex != -1 && cbEducation2.SelectedIndex != -1 && cbEducation3.SelectedIndex != -1)
            {
                int education1;
                int education2;
                int education3;
                int education;

                education1 = Convert.ToInt32(cbEducation1.SelectedItem.ToString());
                education2 = Convert.ToInt32(cbEducation2.SelectedItem.ToString());
                education3 = Convert.ToInt32(cbEducation3.SelectedItem.ToString());
                education = c.Education(education1, education2, education3);

                lblEducation.Text = Convert.ToString(education);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Bildung überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbAppearance1.SelectedIndex != -1 && cbAppearance2.SelectedIndex != -1 && cbAppearance3.SelectedIndex != -1)
            {
                int appearance1;
                int appearance2;
                int appearance3;
                int appearance;

                appearance1 = Convert.ToInt32(cbAppearance1.SelectedItem.ToString());
                appearance2 = Convert.ToInt32(cbAppearance2.SelectedItem.ToString());
                appearance3 = Convert.ToInt32(cbAppearance3.SelectedItem.ToString());
                appearance = c.Appearance(appearance1, appearance2, appearance3);

                lblAppearance.Text = Convert.ToString(appearance);
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Erscheinung überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbMana1.SelectedIndex != -1 && cbMana2.SelectedIndex != -1)
            {
                lblMana.Text = Convert.ToString(c.Mana(Convert.ToInt32(cbMana1.SelectedItem.ToString()), Convert.ToInt32(cbMana2.SelectedItem.ToString())));
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Mana überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cbLuck1.SelectedIndex != -1 && cbLuck2.SelectedIndex != -1 && cbLuck3.SelectedIndex != -1)
            {
                lblLuck.Text = Convert.ToString(c.Luck(Convert.ToInt32(cbLuck1.SelectedItem.ToString()), Convert.ToInt32(cbLuck2.SelectedItem.ToString()), Convert.ToInt32(cbLuck3.SelectedItem.ToString())));
            }
            else
            {
                MessageBox.Show("Bitte Eingaben bei Glück überprüfen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
