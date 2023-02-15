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
            this.groupBox1.Location = new System.Drawing.Point(1030, 509);
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
            this.button3.Location = new System.Drawing.Point(1125, 676);
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
            this.label2.Location = new System.Drawing.Point(1040, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Move";
            // 
            // labelMove
            // 
            this.labelMove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMove.Location = new System.Drawing.Point(1125, 652);
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
            // playForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoTyPhu.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1350, 729);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}