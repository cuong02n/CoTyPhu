namespace CoTyPhu.view
{
    partial class userForm
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(200, 107);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(261, 23);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            this.tbUserName.DataContextChanged += new System.EventHandler(this.tbUserName_DataContextChanged);
            this.tbUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUserName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(119, 107);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(238, 271);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.Location = new System.Drawing.Point(119, 171);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(53, 15);
            this.labelRoomId.TabIndex = 4;
            this.labelRoomId.Text = "Room ID";
            this.labelRoomId.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbRoomId
            // 
            this.tbRoomId.Location = new System.Drawing.Point(200, 171);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(261, 23);
            this.tbRoomId.TabIndex = 3;
            this.tbRoomId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(451, 264);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.labelRoomId);
            this.Controls.Add(this.tbRoomId);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbUserName);
            this.Name = "userForm";
            this.Text = "userForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tbUserName;
        private Label labelName;
        private Button playButton;
        private Label labelRoomId;
        public TextBox tbRoomId;
        private Button createButton;
    }
}