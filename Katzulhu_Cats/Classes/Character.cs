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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katzulhu_Cats.Classes
{
    class Character
    {
        public int Strength(int strength)
        {
            int strengthValue;

            strengthValue = strength * 5;

            return strengthValue;
        }

        public int Constitution(int constitution1, int constitution2)
        {
            int constitutionValue;

            constitutionValue = (constitution1 + constitution2) * 5;

            return constitutionValue;
        }

        public int Intelligence(int intelligence1, int intelligence2)
        {
            int intelligenceValue;

            intelligenceValue = (intelligence1 + intelligence2 + 6 ) * 5;

            return intelligenceValue;
        }

        public int Dexterity(int dexterity1, int dexterity2)
        {
            int dexterityValue;

            dexterityValue = (dexterity1 + dexterity2 + 14) * 5;

            return dexterityValue;
        }

        public int Education(int education1, int education2, int education3)
        {
            int educationValue;

            educationValue = (education1 + education2 + education3 + 3) * 5;

            return educationValue;
        }

        public int Appearance(int appearance1, int appearance2, int appearance3)
        {
            int appearanceValue;

            appearanceValue = (appearance1 + appearance2 + appearance3) * 5;

            return appearanceValue;
        }

        public int Mana(int mana1, int mana2)
        {
            int manaValue;

            manaValue = (mana1 + mana2 + 6) * 5;

            return manaValue;
        }

        public int Luck(int luck1, int luck2, int luck3)
        {
            int luckValue;

            luckValue = (luck1 + luck2 + luck3) * 5;

            return luckValue;
        }

        public int HealthPoints(int constitution, int size)
        {
            int healthPointsValue;

            healthPointsValue = (constitution + size) / 10;

            return healthPointsValue;
        }

        public int Animalism(int mana)
        {
            int animalismValue;

            animalismValue = mana;

            return animalismValue;
        }

        public int MagicPoints(int mana)
        {
            int magicPointsValue;

            magicPointsValue = mana / 5;

            return magicPointsValue;
        }

        public int AbilityPoints(int education, int intelligence)
        {
            int abilityPointsValue;

            abilityPointsValue = education + intelligence;

            return abilityPointsValue;
        }
    }
}
