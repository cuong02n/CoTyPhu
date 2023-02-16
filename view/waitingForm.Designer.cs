namespace CoTyPhu.view
{
    partial class waitingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameView = new System.Windows.Forms.Label();
            this.idView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "your ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "your name";
            // 
            // nameView
            // 
            this.nameView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nameView.Location = new System.Drawing.Point(231, 98);
            this.nameView.Name = "nameView";
            this.nameView.Size = new System.Drawing.Size(79, 31);
            this.nameView.TabIndex = 3;
            // 
            // idView
            // 
            this.idView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.idView.Location = new System.Drawing.Point(231, 44);
            this.idView.Name = "idView";
            this.idView.Size = new System.Drawing.Size(79, 29);
            this.idView.TabIndex = 4;
            // 
            // waitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idView);
            this.Controls.Add(this.nameView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "waitingForm";
            this.Text = "waitingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label nameView;
        private Label idView;
    }
}