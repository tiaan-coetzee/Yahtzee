using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yahtzee2._0.Properties;

namespace Yahtzee2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            savedHighscore = savedHighscore = Properties.Settings.Default.Highscore;
            lblHighestScore.Text = "Highscore: " + savedHighscore.ToString();
        }

        int rerollChances = 3;
        Random random = new Random();
        List<bool> keepDiceStatus = new List<bool>();
        List<Label> labels = new List<Label>();
        string diceRolls = "";
        int OnesRolled, TwosRolled, ThreesRolled, FoursRolled, FivesRolled, SixesRolled, Score, savedHighscore;
        bool OnesLocked, TwosLocked, ThreesLocked, FoursLocked, FivesLocked, SixesLocked, FullHouseLocked, YahtzeeLocked, FourOfAKindLocked, ThreeOfAKindLocked, SMStraightLocked, LGStraightLocked;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateHighScore();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                string output =
                    $"Dice Rolls: {diceRolls}\n\n" +
                    $"Counts:\n" +
                    $"  Ones Rolled: {OnesRolled}\n" +
                    $"  Twos Rolled: {TwosRolled}\n" +
                    $"  Threes Rolled: {ThreesRolled}\n" +
                    $"  Fours Rolled: {FoursRolled}\n" +
                    $"  Fives Rolled: {FivesRolled}\n" +
                    $"  Sixes Rolled: {SixesRolled}\n\n" +
                    $"Scores:\n" +
                    $"  Score: {Score}\n" +
                    $"  Saved Highscore: {savedHighscore}\n\n" +
                    $"Locks:\n" +
                    $"  Ones Locked: {OnesLocked}\n" +
                    $"  Twos Locked: {TwosLocked}\n" +
                    $"  Threes Locked: {ThreesLocked}\n" +
                    $"  Fours Locked: {FoursLocked}\n" +
                    $"  Fives Locked: {FivesLocked}\n" +
                    $"  Sixes Locked: {SixesLocked}\n" +
                    $"  Full House Locked: {FullHouseLocked}\n" +
                    $"  Yahtzee Locked: {YahtzeeLocked}\n" +
                    $"  Four of a Kind Locked: {FourOfAKindLocked}\n" +
                    $"  Three of a Kind Locked: {ThreeOfAKindLocked}\n" +
                    $"  Small Straight Locked: {SMStraightLocked}\n" +
                    $"  Large Straight Locked: {LGStraightLocked}";

                MessageBox.Show(output, "Game State");
            }
        }

        // Mechanics to lock selection
        private void display1s_Click(object sender, EventArgs e)
        {
            OnesLocked = true;
            Score += int.Parse(display1s.Text);
            display1s.BackColor = Color.Gray;
            softReset();
            display1s.Enabled = false;
        }

        private void display2s_Click(object sender, EventArgs e)
        {
            TwosLocked = true;
            Score += int.Parse(display2s.Text);
            display2s.BackColor = Color.Gray;
            softReset();
            display2s.Enabled = false;
        }

        private void display3s_Click(object sender, EventArgs e)
        {
            ThreesLocked = true;
            Score += int.Parse(display3s.Text);
            display3s.BackColor = Color.Gray;
            softReset();
            display3s.Enabled = false;
        }

        private void display4s_Click(object sender, EventArgs e)
        {
            FoursLocked = true;
            Score += int.Parse(display4s.Text);
            display4s.BackColor = Color.Gray;
            softReset();
            display4s.Enabled = false;
        }

        private void display5s_Click(object sender, EventArgs e)
        {
            FivesLocked = true;
            Score += int.Parse(display5s.Text);
            display5s.BackColor = Color.Gray;
            softReset();
            display5s.Enabled = false;
        }

        private void display6s_Click(object sender, EventArgs e)
        {
            SixesLocked = true;
            Score += int.Parse(display6s.Text);
            display6s.BackColor = Color.Gray;
            softReset();
            display6s.Enabled = false;
        }

        private void displayYahtzee_Click(object sender, EventArgs e)
        {
            YahtzeeLocked = true;
            Score += int.Parse(displayYahtzee.Text);
            displayYahtzee.BackColor = Color.Gray;
            softReset();
            displayYahtzee.Enabled = false;
        }

        private void displayFullHouse_Click(object sender, EventArgs e)
        {
            FullHouseLocked = true;
            Score += int.Parse(displayFullHouse.Text);
            displayFullHouse.BackColor = Color.Gray;
            softReset();
            displayFullHouse.Enabled = false;
        }

        private void displayLGStraight_Click(object sender, EventArgs e)
        {
            LGStraightLocked = true;
            Score += int.Parse(displayLGStraight.Text);
            displayLGStraight.BackColor = Color.Gray;
            softReset();
            displayLGStraight.Enabled = false;
        }

        private void displaySMStraight_Click(object sender, EventArgs e)
        {
            SMStraightLocked = true;
            Score += int.Parse(displaySMStraight.Text);
            displaySMStraight.BackColor = Color.Gray;
            softReset();
            displaySMStraight.Enabled = false;
        }

        private void display4ofaKind_Click(object sender, EventArgs e)
        {
            FourOfAKindLocked = true;
            Score += int.Parse(display4ofaKind.Text);
            display4ofaKind.BackColor = Color.Gray;
            softReset();
            display4ofaKind.Enabled = false;
        }

        private void display3ofaKind_Click(object sender, EventArgs e)
        {
            ThreeOfAKindLocked = true;
            Score += int.Parse(display3ofaKind.Text);
            display3ofaKind.BackColor = Color.Gray;
            softReset();
            display3ofaKind.Enabled = false;
        }
        //

        private void btnRoll_Click(object sender, EventArgs e)
        {
            diceRolls = "";
            keepDiceStatus = new List<bool> { keepDice1.Checked, keepDice2.Checked, keepDice3.Checked, keepDice4.Checked, keepDice5.Checked };
            labels = new List<Label> { lblDice1, lblDice2, lblDice3, lblDice4, lblDice5 };

            if (rerollChances > 0)
            {
                lblRollsRemaining.ForeColor = SystemColors.ControlText;
                for (int i = 0; i < labels.Count; i++)
                {
                    if (keepDiceStatus[i] == false)
                    {
                        labels[i].Text = random.Next(1, 7).ToString();
                        diceRolls += labels[i].Text;
                    }
                    else
                    {
                        diceRolls += labels[i].Text;
                    }

                    if (i == labels.Count - 1)
                    {
                        calculateDisplayPoints();
                    }
                }
                rerollChances--;
            }

            else
            {
                lblRollsRemaining.ForeColor = Color.Red;
            }
        }

        private void calculateDisplayPoints()
        {

            if (rerollChances != 0)
            {
                OnesRolled = diceRolls.Split('1').Length - 1;
                TwosRolled = diceRolls.Split('2').Length - 1;
                ThreesRolled = diceRolls.Split('3').Length - 1;
                FoursRolled = diceRolls.Split('4').Length - 1;
                FivesRolled = diceRolls.Split('5').Length - 1;
                SixesRolled = diceRolls.Split('6').Length - 1;

                //Check whether a number was already selected
                if (OnesLocked == false)
                {
                    display1s.Text = "0";
                    display1s.Text = OnesRolled.ToString();
                }

                if (TwosLocked == false)
                {
                    display2s.Text = "0";
                    int temp2 = TwosRolled * 2;
                    display2s.Text = temp2.ToString();
                }

                if (ThreesLocked == false)
                {
                    display3s.Text = "0";
                    int temp3 = ThreesRolled * 3;
                    display3s.Text = temp3.ToString();
                }

                if (FoursLocked == false)
                {
                    display4s.Text = "0";
                    int temp4 = FoursRolled * 4;
                    display4s.Text = temp4.ToString();
                }

                if (FivesLocked == false)
                {
                    display5s.Text = "0";
                    int temp5 = FivesRolled * 5;
                    display5s.Text = temp5.ToString();
                }

                if (SixesLocked == false)
                {
                    display6s.Text = "0";
                    int temp6 = SixesRolled * 6;
                    display6s.Text = temp6.ToString();
                }

                if (ThreeOfAKindLocked == false)
                {
                    display3ofaKind.Text = "0";
                    if (OnesRolled >= 3 || TwosRolled >= 3 || ThreesRolled >= 3 || FoursRolled >= 3 || FivesRolled >= 3 || SixesRolled >= 3)
                    {
                        int threeofakind = OnesRolled + TwosRolled * 2 + ThreesRolled * 3 + FoursRolled * 4 + FivesRolled * 5 + SixesRolled * 6;
                        display3ofaKind.Text = threeofakind.ToString();
                    }
                }

                if (FourOfAKindLocked == false)
                {
                    display4ofaKind.Text = "0";
                    if (OnesRolled >= 4 || TwosRolled >= 4 || ThreesRolled >= 4 || FoursRolled >= 4 || FivesRolled >= 4 || SixesRolled >= 4)
                    {
                        int fourofakind = OnesRolled + TwosRolled * 2 + ThreesRolled * 3 + FoursRolled * 4 + FivesRolled * 5 + SixesRolled * 6;
                        display4ofaKind.Text = fourofakind.ToString();
                    }
                }

                if (SMStraightLocked == false)
                {
                    displaySMStraight.Text = "0";
                    if ((OnesRolled >= 1 && TwosRolled >= 1 && ThreesRolled >= 1 && FoursRolled >= 1) || (ThreesRolled >= 1 && FoursRolled >= 1 && FivesRolled >= 1 && SixesRolled >= 1) || (TwosRolled >= 1 && ThreesRolled >= 1 && FoursRolled >= 1 && FivesRolled >= 1))
                    {
                        displaySMStraight.Text = "30";
                    }
                }

                if (LGStraightLocked == false)
                {
                    displayLGStraight.Text = "0";
                    if ((TwosRolled == 1 && ThreesRolled == 1 && FoursRolled == 1 && FivesRolled == 1 && SixesRolled == 1) || (OnesRolled == 1 && TwosRolled == 1 && ThreesRolled == 1 && FoursRolled == 1 && FivesRolled == 1))
                    {
                        displayLGStraight.Text = "40";
                    }
                }

                if (FullHouseLocked == false)
                {
                    displayFullHouse.Text = "0";
                    if ((OnesRolled == 3 || TwosRolled == 3 || ThreesRolled == 3 || FoursRolled == 3 || FivesRolled == 3 || SixesRolled == 3) && (OnesRolled == 2 || TwosRolled == 2 || ThreesRolled == 2 || FoursRolled == 2 || FivesRolled == 2 || SixesRolled == 2))
                    {
                        displayFullHouse.Text = "25";
                    }
                }

                if (YahtzeeLocked == false)
                {
                    displayYahtzee.Text = "0";
                    if (OnesRolled == 5 || TwosRolled == 5 || ThreesRolled == 5 || FoursRolled == 5 || FivesRolled == 5 || SixesRolled == 5)
                    {
                        MessageBox.Show("Yahtzee");
                        displayYahtzee.Text = "50";
                    }
                }

                updateRemaingRolls();
            }
            //
        }

        private void softReset()
        {
            labels = new List<Label> { lblDice1, lblDice2, lblDice3, lblDice4, lblDice5 };
            List<CheckBox> checkBoxes = new List<CheckBox> { keepDice1, keepDice2, keepDice3, keepDice4, keepDice5 };
            List<bool> keepNumber = new List<bool> { OnesLocked, TwosLocked, ThreesLocked, FoursLocked, FivesLocked, SixesLocked, ThreeOfAKindLocked, FourOfAKindLocked, SMStraightLocked, LGStraightLocked, FullHouseLocked, YahtzeeLocked };
            List<Button> buttons = new List<Button> { display1s, display2s, display3s, display4s, display5s, display6s, display3ofaKind, display4ofaKind, displaySMStraight, displayLGStraight, displayFullHouse, displayYahtzee };

            rerollChances = 3;
            lblRollsRemaining.Text = rerollChances.ToString() + "/3 rolls remaining";
            lblRollsRemaining.ForeColor = SystemColors.ControlText;

            for (int i = 0; i < checkBoxes.Count; i++)
            {
                checkBoxes[i].Checked = false;
                labels[i].Text = "?";
            }

            for (int i = 0; i < buttons.Count; i++)
            {
                if (keepNumber[i] != true)
                {
                    buttons[i].Text = "0";
                }
            }

            lblScore.Text = "Score: " + Score.ToString();
            OnesRolled = 0;
            TwosRolled = 0;
            ThreesRolled = 0;
            FoursRolled = 0;
            FivesRolled = 0;
            SixesRolled = 0;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button> { display1s, display2s, display3s, display4s, display5s, display5s, display6s, display3ofaKind, display4ofaKind, displayYahtzee, displaySMStraight, displayLGStraight, displayFullHouse };
            updateHighScore();
            Score = 0;

            foreach (Button button in buttons)
            {
                button.BackColor = Color.Transparent;
                button.Text = "0";
                button.Enabled = true;
            }

            softReset();

        }

        private void updateRemaingRolls()
        {
            int tempReroll = rerollChances - 1;
            lblRollsRemaining.Text = tempReroll.ToString() + "/3 rolls remaining";
        }

        private void updateHighScore()
        {
            if (Score > savedHighscore)
            {
                Properties.Settings.Default.Highscore = Score;
                Properties.Settings.Default.Save();
                lblHighestScore.Text = "Highscore: " + Score.ToString();
            }

        }
    }
}

