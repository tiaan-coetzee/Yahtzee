namespace Yahtzee2._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblHighestScore = new Label();
            lblRollsRemaining = new Label();
            lblScore = new Label();
            displayFullHouse = new Button();
            label12 = new Label();
            label11 = new Label();
            displaySMStraight = new Button();
            displayLGStraight = new Button();
            label10 = new Label();
            display3ofaKind = new Button();
            label9 = new Label();
            display4ofaKind = new Button();
            label8 = new Label();
            displayYahtzee = new Button();
            label7 = new Label();
            BtnReset = new Button();
            display6s = new Button();
            display5s = new Button();
            display4s = new Button();
            display3s = new Button();
            display2s = new Button();
            display1s = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            keepDice5 = new CheckBox();
            keepDice4 = new CheckBox();
            keepDice3 = new CheckBox();
            keepDice2 = new CheckBox();
            keepDice1 = new CheckBox();
            lblDice5 = new Label();
            lblDice4 = new Label();
            lblDice3 = new Label();
            lblDice2 = new Label();
            lblDice1 = new Label();
            btnRoll = new Button();
            SuspendLayout();
            // 
            // lblHighestScore
            // 
            lblHighestScore.Location = new Point(134, 18);
            lblHighestScore.Margin = new Padding(4, 0, 4, 0);
            lblHighestScore.Name = "lblHighestScore";
            lblHighestScore.Size = new Size(93, 17);
            lblHighestScore.TabIndex = 78;
            lblHighestScore.Text = "Highscore: 0";
            lblHighestScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRollsRemaining
            // 
            lblRollsRemaining.Location = new Point(61, 333);
            lblRollsRemaining.Margin = new Padding(4, 0, 4, 0);
            lblRollsRemaining.Name = "lblRollsRemaining";
            lblRollsRemaining.Size = new Size(142, 16);
            lblRollsRemaining.TabIndex = 77;
            lblRollsRemaining.Text = "3/3 rolls remaining";
            lblRollsRemaining.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblScore
            // 
            lblScore.Location = new Point(39, 18);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(93, 17);
            lblScore.TabIndex = 76;
            lblScore.Text = "Score: 0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // displayFullHouse
            // 
            displayFullHouse.FlatStyle = FlatStyle.Flat;
            displayFullHouse.Location = new Point(204, 188);
            displayFullHouse.Margin = new Padding(4, 3, 4, 3);
            displayFullHouse.Name = "displayFullHouse";
            displayFullHouse.Size = new Size(37, 29);
            displayFullHouse.TabIndex = 75;
            displayFullHouse.TabStop = false;
            displayFullHouse.Text = "0";
            displayFullHouse.UseVisualStyleBackColor = true;
            displayFullHouse.Click += displayFullHouse_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(129, 195);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 74;
            label12.Text = "Full house";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(123, 122);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 73;
            label11.Text = "SM straight";
            // 
            // displaySMStraight
            // 
            displaySMStraight.FlatStyle = FlatStyle.Flat;
            displaySMStraight.Location = new Point(204, 115);
            displaySMStraight.Margin = new Padding(4, 3, 4, 3);
            displaySMStraight.Name = "displaySMStraight";
            displaySMStraight.Size = new Size(37, 29);
            displaySMStraight.TabIndex = 72;
            displaySMStraight.TabStop = false;
            displaySMStraight.Text = "0";
            displaySMStraight.UseVisualStyleBackColor = true;
            displaySMStraight.Click += displaySMStraight_Click;
            // 
            // displayLGStraight
            // 
            displayLGStraight.FlatStyle = FlatStyle.Flat;
            displayLGStraight.Location = new Point(204, 150);
            displayLGStraight.Margin = new Padding(4, 3, 4, 3);
            displayLGStraight.Name = "displayLGStraight";
            displayLGStraight.Size = new Size(37, 29);
            displayLGStraight.TabIndex = 71;
            displayLGStraight.TabStop = false;
            displayLGStraight.Text = "0";
            displayLGStraight.UseVisualStyleBackColor = true;
            displayLGStraight.Click += displayLGStraight_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(123, 157);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 70;
            label10.Text = "LG straight";
            // 
            // display3ofaKind
            // 
            display3ofaKind.FlatStyle = FlatStyle.Flat;
            display3ofaKind.Location = new Point(204, 43);
            display3ofaKind.Margin = new Padding(4, 3, 4, 3);
            display3ofaKind.Name = "display3ofaKind";
            display3ofaKind.Size = new Size(37, 29);
            display3ofaKind.TabIndex = 69;
            display3ofaKind.TabStop = false;
            display3ofaKind.Text = "0";
            display3ofaKind.UseVisualStyleBackColor = true;
            display3ofaKind.Click += display3ofaKind_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(101, 49);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 68;
            label9.Text = "Three of a kind";
            // 
            // display4ofaKind
            // 
            display4ofaKind.FlatStyle = FlatStyle.Flat;
            display4ofaKind.Location = new Point(204, 81);
            display4ofaKind.Margin = new Padding(4, 3, 4, 3);
            display4ofaKind.Name = "display4ofaKind";
            display4ofaKind.Size = new Size(37, 29);
            display4ofaKind.TabIndex = 67;
            display4ofaKind.TabStop = false;
            display4ofaKind.Text = "0";
            display4ofaKind.UseVisualStyleBackColor = true;
            display4ofaKind.Click += display4ofaKind_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(109, 88);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 66;
            label8.Text = "Four of a kind";
            // 
            // displayYahtzee
            // 
            displayYahtzee.FlatStyle = FlatStyle.Flat;
            displayYahtzee.Location = new Point(204, 224);
            displayYahtzee.Margin = new Padding(4, 3, 4, 3);
            displayYahtzee.Name = "displayYahtzee";
            displayYahtzee.Size = new Size(37, 29);
            displayYahtzee.TabIndex = 65;
            displayYahtzee.TabStop = false;
            displayYahtzee.Text = "0";
            displayYahtzee.UseVisualStyleBackColor = true;
            displayYahtzee.Click += displayYahtzee_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 231);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 64;
            label7.Text = "Yahtzee";
            // 
            // BtnReset
            // 
            BtnReset.FlatStyle = FlatStyle.Flat;
            BtnReset.Location = new Point(75, 353);
            BtnReset.Margin = new Padding(4, 3, 4, 3);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(115, 27);
            BtnReset.TabIndex = 63;
            BtnReset.TabStop = false;
            BtnReset.Text = "RESET";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // display6s
            // 
            display6s.FlatStyle = FlatStyle.Flat;
            display6s.Location = new Point(53, 224);
            display6s.Margin = new Padding(4, 3, 4, 3);
            display6s.Name = "display6s";
            display6s.Size = new Size(37, 29);
            display6s.TabIndex = 62;
            display6s.TabStop = false;
            display6s.Text = "0";
            display6s.UseVisualStyleBackColor = true;
            display6s.Click += display6s_Click;
            // 
            // display5s
            // 
            display5s.FlatStyle = FlatStyle.Flat;
            display5s.Location = new Point(53, 188);
            display5s.Margin = new Padding(4, 3, 4, 3);
            display5s.Name = "display5s";
            display5s.Size = new Size(37, 29);
            display5s.TabIndex = 61;
            display5s.TabStop = false;
            display5s.Text = "0";
            display5s.UseVisualStyleBackColor = true;
            display5s.Click += display5s_Click;
            // 
            // display4s
            // 
            display4s.FlatStyle = FlatStyle.Flat;
            display4s.Location = new Point(53, 150);
            display4s.Margin = new Padding(4, 3, 4, 3);
            display4s.Name = "display4s";
            display4s.Size = new Size(37, 29);
            display4s.TabIndex = 60;
            display4s.TabStop = false;
            display4s.Text = "0";
            display4s.UseVisualStyleBackColor = true;
            display4s.Click += display4s_Click;
            // 
            // display3s
            // 
            display3s.FlatStyle = FlatStyle.Flat;
            display3s.Location = new Point(53, 115);
            display3s.Margin = new Padding(4, 3, 4, 3);
            display3s.Name = "display3s";
            display3s.Size = new Size(37, 29);
            display3s.TabIndex = 59;
            display3s.TabStop = false;
            display3s.Text = "0";
            display3s.UseVisualStyleBackColor = true;
            display3s.Click += display3s_Click;
            // 
            // display2s
            // 
            display2s.FlatStyle = FlatStyle.Flat;
            display2s.Location = new Point(53, 81);
            display2s.Margin = new Padding(4, 3, 4, 3);
            display2s.Name = "display2s";
            display2s.Size = new Size(37, 29);
            display2s.TabIndex = 58;
            display2s.TabStop = false;
            display2s.Text = "0";
            display2s.UseVisualStyleBackColor = true;
            display2s.Click += display2s_Click;
            // 
            // display1s
            // 
            display1s.FlatStyle = FlatStyle.Flat;
            display1s.Location = new Point(53, 43);
            display1s.Margin = new Padding(4, 3, 4, 3);
            display1s.Name = "display1s";
            display1s.Size = new Size(37, 29);
            display1s.TabIndex = 57;
            display1s.TabStop = false;
            display1s.Text = "0";
            display1s.UseVisualStyleBackColor = true;
            display1s.Click += display1s_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 228);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 56;
            label6.Text = "6s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 55;
            label5.Text = "5s";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 122);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 54;
            label4.Text = "3s";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 53;
            label3.Text = "4s";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 52;
            label2.Text = "2s";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 51;
            label1.Text = "1s";
            // 
            // keepDice5
            // 
            keepDice5.AutoSize = true;
            keepDice5.FlatStyle = FlatStyle.Flat;
            keepDice5.Location = new Point(174, 280);
            keepDice5.Margin = new Padding(4, 3, 4, 3);
            keepDice5.Name = "keepDice5";
            keepDice5.Size = new Size(12, 11);
            keepDice5.TabIndex = 50;
            keepDice5.TabStop = false;
            keepDice5.UseVisualStyleBackColor = true;
            // 
            // keepDice4
            // 
            keepDice4.AutoSize = true;
            keepDice4.FlatStyle = FlatStyle.Flat;
            keepDice4.Location = new Point(150, 280);
            keepDice4.Margin = new Padding(4, 3, 4, 3);
            keepDice4.Name = "keepDice4";
            keepDice4.Size = new Size(12, 11);
            keepDice4.TabIndex = 49;
            keepDice4.TabStop = false;
            keepDice4.UseVisualStyleBackColor = true;
            // 
            // keepDice3
            // 
            keepDice3.AutoSize = true;
            keepDice3.FlatStyle = FlatStyle.Flat;
            keepDice3.Location = new Point(126, 280);
            keepDice3.Margin = new Padding(4, 3, 4, 3);
            keepDice3.Name = "keepDice3";
            keepDice3.Size = new Size(12, 11);
            keepDice3.TabIndex = 48;
            keepDice3.TabStop = false;
            keepDice3.UseVisualStyleBackColor = true;
            // 
            // keepDice2
            // 
            keepDice2.AutoSize = true;
            keepDice2.FlatStyle = FlatStyle.Flat;
            keepDice2.Location = new Point(101, 280);
            keepDice2.Margin = new Padding(4, 3, 4, 3);
            keepDice2.Name = "keepDice2";
            keepDice2.Size = new Size(12, 11);
            keepDice2.TabIndex = 47;
            keepDice2.TabStop = false;
            keepDice2.UseVisualStyleBackColor = true;
            // 
            // keepDice1
            // 
            keepDice1.AutoSize = true;
            keepDice1.FlatStyle = FlatStyle.Flat;
            keepDice1.Location = new Point(76, 280);
            keepDice1.Margin = new Padding(4, 3, 4, 3);
            keepDice1.Name = "keepDice1";
            keepDice1.Size = new Size(12, 11);
            keepDice1.TabIndex = 46;
            keepDice1.TabStop = false;
            keepDice1.UseVisualStyleBackColor = true;
            // 
            // lblDice5
            // 
            lblDice5.AutoSize = true;
            lblDice5.Location = new Point(174, 262);
            lblDice5.Margin = new Padding(4, 0, 4, 0);
            lblDice5.Name = "lblDice5";
            lblDice5.Size = new Size(12, 15);
            lblDice5.TabIndex = 45;
            lblDice5.Text = "?";
            // 
            // lblDice4
            // 
            lblDice4.AutoSize = true;
            lblDice4.Location = new Point(150, 262);
            lblDice4.Margin = new Padding(4, 0, 4, 0);
            lblDice4.Name = "lblDice4";
            lblDice4.Size = new Size(12, 15);
            lblDice4.TabIndex = 44;
            lblDice4.Text = "?";
            // 
            // lblDice3
            // 
            lblDice3.AutoSize = true;
            lblDice3.Location = new Point(126, 262);
            lblDice3.Margin = new Padding(4, 0, 4, 0);
            lblDice3.Name = "lblDice3";
            lblDice3.Size = new Size(12, 15);
            lblDice3.TabIndex = 43;
            lblDice3.Text = "?";
            // 
            // lblDice2
            // 
            lblDice2.AutoSize = true;
            lblDice2.Location = new Point(101, 262);
            lblDice2.Margin = new Padding(4, 0, 4, 0);
            lblDice2.Name = "lblDice2";
            lblDice2.Size = new Size(12, 15);
            lblDice2.TabIndex = 42;
            lblDice2.Text = "?";
            // 
            // lblDice1
            // 
            lblDice1.AutoSize = true;
            lblDice1.Location = new Point(76, 262);
            lblDice1.Margin = new Padding(4, 0, 4, 0);
            lblDice1.Name = "lblDice1";
            lblDice1.Size = new Size(12, 15);
            lblDice1.TabIndex = 41;
            lblDice1.Text = "?";
            // 
            // btnRoll
            // 
            btnRoll.FlatStyle = FlatStyle.Flat;
            btnRoll.Location = new Point(75, 303);
            btnRoll.Margin = new Padding(4, 3, 4, 3);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(114, 27);
            btnRoll.TabIndex = 40;
            btnRoll.TabStop = false;
            btnRoll.Text = "ROLL";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 398);
            Controls.Add(lblHighestScore);
            Controls.Add(lblRollsRemaining);
            Controls.Add(lblScore);
            Controls.Add(displayFullHouse);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(displaySMStraight);
            Controls.Add(displayLGStraight);
            Controls.Add(label10);
            Controls.Add(display3ofaKind);
            Controls.Add(label9);
            Controls.Add(display4ofaKind);
            Controls.Add(label8);
            Controls.Add(displayYahtzee);
            Controls.Add(label7);
            Controls.Add(BtnReset);
            Controls.Add(display6s);
            Controls.Add(display5s);
            Controls.Add(display4s);
            Controls.Add(display3s);
            Controls.Add(display2s);
            Controls.Add(display1s);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(keepDice5);
            Controls.Add(keepDice4);
            Controls.Add(keepDice3);
            Controls.Add(keepDice2);
            Controls.Add(keepDice1);
            Controls.Add(lblDice5);
            Controls.Add(lblDice4);
            Controls.Add(lblDice3);
            Controls.Add(lblDice2);
            Controls.Add(lblDice1);
            Controls.Add(btnRoll);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yahtzee";
            FormClosing += Form1_FormClosing;
            Load += Form2_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHighestScore;
        private Label lblRollsRemaining;
        private Label lblScore;
        private Button displayFullHouse;
        private Label label12;
        private Label label11;
        private Button displaySMStraight;
        private Button displayLGStraight;
        private Label label10;
        private Button display3ofaKind;
        private Label label9;
        private Button display4ofaKind;
        private Label label8;
        private Button displayYahtzee;
        private Label label7;
        private Button BtnReset;
        private Button display6s;
        private Button display5s;
        private Button display4s;
        private Button display3s;
        private Button display2s;
        private Button display1s;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox keepDice5;
        private CheckBox keepDice4;
        private CheckBox keepDice3;
        private CheckBox keepDice2;
        private CheckBox keepDice1;
        private Label lblDice5;
        private Label lblDice4;
        private Label lblDice3;
        private Label lblDice2;
        private Label lblDice1;
        private Button btnRoll;
    }
}