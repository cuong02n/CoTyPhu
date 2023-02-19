namespace CoTyPhu.view
{
    partial class playForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dice2 = new System.Windows.Forms.Label();
            this.dice1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMove = new System.Windows.Forms.Label();
            this.character = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbNameP1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMoneyP1 = new System.Windows.Forms.Label();
            this.lbMoneyP4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNameP4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMoneyP3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNameP3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbMoneyP2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbNameP2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRoomId = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(639, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_auto);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dice2);
            this.groupBox1.Controls.Add(this.dice1);
            this.groupBox1.Location = new System.Drawing.Point(602, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dice2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice2.Location = new System.Drawing.Point(95, 19);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(60, 88);
            this.dice2.TabIndex = 1;
            this.dice2.Text = "1";
            this.dice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dice1
            // 
            this.dice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dice1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dice1.Location = new System.Drawing.Point(15, 19);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(60, 88);
            this.dice1.TabIndex = 0;
            this.dice1.Text = "1";
            this.dice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Roll";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Move";
            // 
            // labelMove
            // 
            this.labelMove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMove.Location = new System.Drawing.Point(697, 431);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(74, 15);
            this.labelMove.TabIndex = 6;
            this.labelMove.Text = "0";
            this.labelMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // character
            // 
            this.character.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.character.Location = new System.Drawing.Point(668, 582);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(39, 50);
            this.character.TabIndex = 7;
            this.character.Text = "character";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 617);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player Name";
            // 
            // lbNameP1
            // 
            this.lbNameP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameP1.Location = new System.Drawing.Point(126, 616);
            this.lbNameP1.Name = "lbNameP1";
            this.lbNameP1.Size = new System.Drawing.Size(100, 23);
            this.lbNameP1.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Money";
            // 
            // lbMoneyP1
            // 
            this.lbMoneyP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoneyP1.Location = new System.Drawing.Point(126, 665);
            this.lbMoneyP1.Name = "lbMoneyP1";
            this.lbMoneyP1.Size = new System.Drawing.Size(100, 23);
            this.lbMoneyP1.TabIndex = 13;
            // 
            // lbMoneyP4
            // 
            this.lbMoneyP4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoneyP4.Location = new System.Drawing.Point(1197, 664);
            this.lbMoneyP4.Name = "lbMoneyP4";
            this.lbMoneyP4.Size = new System.Drawing.Size(100, 23);
            this.lbMoneyP4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1112, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Money";
            // 
            // lbNameP4
            // 
            this.lbNameP4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameP4.Location = new System.Drawing.Point(1197, 615);
            this.lbNameP4.Name = "lbNameP4";
            this.lbNameP4.Size = new System.Drawing.Size(100, 23);
            this.lbNameP4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1108, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Player Name";
            // 
            // lbMoneyP3
            // 
            this.lbMoneyP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoneyP3.Location = new System.Drawing.Point(1215, 115);
            this.lbMoneyP3.Name = "lbMoneyP3";
            this.lbMoneyP3.Size = new System.Drawing.Size(100, 23);
            this.lbMoneyP3.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1130, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Money";
            // 
            // lbNameP3
            // 
            this.lbNameP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameP3.Location = new System.Drawing.Point(1215, 66);
            this.lbNameP3.Name = "lbNameP3";
            this.lbNameP3.Size = new System.Drawing.Size(100, 23);
            this.lbNameP3.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1126, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Player Name";
            // 
            // lbMoneyP2
            // 
            this.lbMoneyP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoneyP2.Location = new System.Drawing.Point(215, 143);
            this.lbMoneyP2.Name = "lbMoneyP2";
            this.lbMoneyP2.Size = new System.Drawing.Size(100, 23);
            this.lbMoneyP2.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(130, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "Money";
            // 
            // lbNameP2
            // 
            this.lbNameP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNameP2.Location = new System.Drawing.Point(215, 94);
            this.lbNameP2.Name = "lbNameP2";
            this.lbNameP2.Size = new System.Drawing.Size(100, 23);
            this.lbNameP2.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(126, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "Player Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "ID room";
            // 
            // lbRoomId
            // 
            this.lbRoomId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbRoomId.Location = new System.Drawing.Point(126, 567);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(100, 23);
            this.lbRoomId.TabIndex = 27;
            // 
            // playForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoTyPhu.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lbRoomId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMoneyP2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbNameP2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbMoneyP3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbNameP3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbMoneyP4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNameP4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbMoneyP1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbNameP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.character);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "playForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "playForm";
            this.Load += new System.EventHandler(this.playForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label dice2;
        private Label dice1;
        private Button button3;
        private Label label2;
        private Label labelMove;
        private Label character;
        private System.Windows.Forms.Timer timer2;
        private Label label3;
        private Label lbNameP1;
        private Label label7;
        private Label lbMoneyP1;
        private Label lbMoneyP4;
        private Label label5;
        private Label lbNameP4;
        private Label label8;
        private Label lbMoneyP3;
        private Label label10;
        private Label lbNameP3;
        private Label label12;
        private Label lbMoneyP2;
        private Label label14;
        private Label lbNameP2;
        private Label label16;
        private Label label4;
        private Label lbRoomId;
    }
}