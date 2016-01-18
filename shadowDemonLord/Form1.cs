using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shadowDemonLord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SaveFileDialog textDialog;
        public int spellCount = 0;
        public int yLocation = 3;

        private void saveButton_Click(object sender, EventArgs e)
        {
            textDialog = new SaveFileDialog();
            textDialog.Filter = "Xml files (*.xml)|*xml";
            textDialog.DefaultExt = "xml";

            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                //===============================================
                //save character
                //===============================================
                character Character = new character();
                Character.Level = levelTextBox.Text;
                Character.CharName = nameTextBox.Text;
                Character.Age = ageTextBox.Text;
                Character.Gender = genderTextBox.Text;
                Character.Ancestry = ancestryTextBox.Text;
                Character.Size = sizeTextBox.Text;
                Character.Speed = speedTextBox.Text;
                Character.Build = buildTextBox.Text;
                Character.Appearance = appearanceTextBox.Text;
                Character.Religion = religionTextBox.Text;
                Character.Languages = languageTextBox.Text;
                Character.Personality = personalityTextBox.Text;
                Character.Quirk = quirkTextBox.Text;
                Character.Profession = profTextBox.Text;
                Character.Wealth = wealthTextBox.Text;
                Character.Background = backgroundTextBox.Text;
                Character.Armor = armorTextBox.Text;
                Character.ArmorProp = armorPropTextBox.Text;
                Character.ArmorDef = defTextBox.Text;
                Character.Wep1 = wep1Label.Text;
                Character.Wep1Prop = wep1PropTextBox.Text;
                Character.Wep1Hand = wep1HandTextBox.Text;
                Character.Wep1Dmg = wep1DmgTextBox.Text;
                Character.Wep2 = wep2TextBox.Text;
                Character.Wep2Prop = wep2PropTextBox.Text;
                Character.Wep2Hand = wep2HandTextBox.Text;
                Character.Wep2Dmg = wep2DmgTextBox.Text;
                Character.Shield = shieldTextBox.Text;
                Character.ShieldProp = shieldPropTextBox.Text;
                Character.ShieldDmg = shieldDmgTextBox.Text;
                Character.ShieldHand = shieldHandTextBox.Text;
                Character.Inventory = inventoryTextBox.Text;
                Character.NovicePath = novicePathTextBox.Text;
                Character.NoviceTraining = noviceTrainingTextBox.Text;
                Character.NoviceTalents = noviceTalentsTextBox.Text;
                Character.ExpertPath = expertPathTextBox.Text;
                Character.ExpertCharObj = expertCharObjTextBox.Text;
                Character.ExpertStoryDev = expertStoryDevTextBox.Text;
                Character.ExpertTalents = expertTalentsTextBox.Text;
                Character.MasterPath = masterPathTextBox.Text;
                Character.MasterQuest = masterQuestTextBox.Text;
                Character.MasterStoryDev = masterStoryDevTextBox.Text;
                Character.MasterTalents = masterTalentsTextBox.Text;
                Character.Strength = strengthNumeric.Value.ToString();
                Character.Will = willNumeric.Value.ToString();
                Character.Intelect = IntelectNumeric.Value.ToString();
                Character.Agility = agilityNumeric.Value.ToString();
                Character.Health = healthNumber.Value.ToString();
                Character.Dmg = damageNumber.Value.ToString();
                Character.HealingRate = healingNumber.Value.ToString();
                Character.Insanity = insanityNumber.Value.ToString();
                Character.Corruption = corruptionNumber.Value.ToString();
                Character.Power = powerNumber.Value.ToString();
                Character.Def = defenseNumber.Value.ToString();
                Character.Perception = perceptionNumber.Value.ToString();
                //============================================================
                //save spell
                //============================================================
                for (int i = 1; i <= spellCount; i++)
                {

                    spell Spell = new spell();
                    TextBox spellNameTxtBx = ((TextBox)this.Controls.Find("spellName" + i + "TxtBox", true)[0]);
                    Spell.SpellName = spellNameTxtBx.Text;

                    TextBox castsPerDayTxtBx = ((TextBox)this.Controls.Find("castsPerDay" + i + "TxtBox", true)[0]);
                    Spell.CastsPerDay = castsPerDayTxtBx.Text;

                    TextBox castsTxtBx = ((TextBox)this.Controls.Find("casts" + spellCount + "TxtBox", true)[0]);
                    Spell.Casts = castsTxtBx.Text;

                    TextBox rankTxtBx = ((TextBox)this.Controls.Find("rank" + spellCount + "TxtBox", true)[0]);
                    Spell.Rank = rankTxtBx.Text;

                    TextBox statVStatTxtBx = ((TextBox)this.Controls.Find("statVStat" + spellCount + "TxtBox", true)[0]);
                    Spell.StatVStat = statVStatTxtBx.Text;

                    TextBox descriptionTxtBx = ((TextBox)this.Controls.Find("description" + spellCount + "TxtBox", true)[0]);
                    Spell.Description = descriptionTxtBx.Text;

                    Character.Spells.Add(Spell);

                }

                XmlData.saveData(Character, textDialog.FileName);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                character Character = new character();
                XmlLoad<character> loadCharacter = new XmlLoad<character>();

                Character = loadCharacter.loadData(openFileDialog1.FileName);

                levelTextBox.Text = Character.Level;
                nameTextBox.Text = Character.CharName;
                ageTextBox.Text = Character.Age;
                genderTextBox.Text = Character.Gender;
                ancestryTextBox.Text = Character.Ancestry;
                sizeTextBox.Text = Character.Size;
                speedTextBox.Text = Character.Speed;
                buildTextBox.Text = Character.Build;
                appearanceTextBox.Text = Character.Appearance;
                religionTextBox.Text = Character.Religion;
                languageTextBox.Text = Character.Languages;
                personalityTextBox.Text = Character.Personality;
                quirkTextBox.Text = Character.Quirk;
                profTextBox.Text = Character.Profession;
                wealthTextBox.Text = Character.Wealth;
                backgroundTextBox.Text = Character.Background;
                armorTextBox.Text = Character.Armor;
                armorPropTextBox.Text = Character.ArmorProp;
                defTextBox.Text = Character.ArmorDef;
                wep1Label.Text = Character.Wep1;
                wep1PropTextBox.Text = Character.Wep1Prop;
                wep1HandTextBox.Text = Character.Wep1Hand;
                wep1DmgTextBox.Text = Character.Wep1Dmg;
                wep2TextBox.Text = Character.Wep2;
                wep2PropTextBox.Text = Character.Wep2Prop;
                wep2HandTextBox.Text = Character.Wep2Hand;
                wep2DmgTextBox.Text = Character.Wep2Dmg;
                shieldTextBox.Text = Character.Shield;
                shieldPropTextBox.Text = Character.ShieldProp;
                shieldDmgTextBox.Text = Character.ShieldDmg;
                shieldHandTextBox.Text = Character.ShieldHand;
                inventoryTextBox.Text = Character.Inventory;
                novicePathTextBox.Text = Character.NovicePath;
                noviceTrainingTextBox.Text = Character.NoviceTraining;
                noviceTalentsTextBox.Text = Character.NoviceTalents;
                expertPathTextBox.Text = Character.ExpertPath;
                expertCharObjTextBox.Text = Character.ExpertCharObj;
                expertStoryDevTextBox.Text = Character.ExpertStoryDev;
                expertTalentsTextBox.Text = Character.ExpertTalents;
                masterPathTextBox.Text = Character.MasterPath;
                masterQuestTextBox.Text = Character.MasterQuest;
                masterStoryDevTextBox.Text = Character.MasterStoryDev;
                masterTalentsTextBox.Text = Character.MasterTalents;
                strengthNumeric.Value = Convert.ToDecimal(Character.Strength);
                willNumeric.Value = Convert.ToDecimal(Character.Will);
                IntelectNumeric.Value = Convert.ToDecimal(Character.Intelect);
                agilityNumeric.Value = Convert.ToDecimal(Character.Agility);
                healthNumber.Value = Convert.ToDecimal(Character.Health);
                damageNumber.Value = Convert.ToDecimal(Character.Dmg);
                healingNumber.Value = Convert.ToDecimal(Character.HealingRate);
                insanityNumber.Value = Convert.ToDecimal(Character.Insanity);
                corruptionNumber.Value = Convert.ToDecimal(Character.Corruption);
                powerNumber.Value = Convert.ToDecimal(Character.Power);
                defenseNumber.Value = Convert.ToDecimal(Character.Def);
                perceptionNumber.Value = Convert.ToDecimal(Character.Perception);
                //=================================================================
                //load spells
                //=================================================================
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            diceList.Items.Clear();
            Roll myRoll = new Roll(Convert.ToInt16(diceNumber.Value), Convert.ToInt16(diceTypeNumber.Value), Convert.ToInt16(diceModifierNumber.Value));
            resultLabelToChange.Text = Convert.ToString(myRoll.rollDice());
            for (int i = 0; i < myRoll.dieRes.Length; i++)
            {
                diceList.Items.Add("dice number " + (i + 1) + " = " + myRoll.dieRes[i]);
            }  
        }

        private void addSpellBtn_Click(object sender, EventArgs e)
        {
            

        }

    }
}
