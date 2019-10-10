namespace CipherGenerator
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RotatingGrillButton = new System.Windows.Forms.Button();
            this.ColumnButton = new System.Windows.Forms.Button();
            this.substitution = new System.Windows.Forms.GroupBox();
            this.SubstitutionGroupBox = new System.Windows.Forms.GroupBox();
            this.VizhnerButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SubstitutionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotatingGrillButton);
            this.groupBox1.Controls.Add(this.ColumnButton);
            this.groupBox1.Location = new System.Drawing.Point(38, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ReShuffle[ENG Alphabet]";
            // 
            // RotatingGrillButton
            // 
            this.RotatingGrillButton.Location = new System.Drawing.Point(193, 19);
            this.RotatingGrillButton.Name = "RotatingGrillButton";
            this.RotatingGrillButton.Size = new System.Drawing.Size(155, 150);
            this.RotatingGrillButton.TabIndex = 1;
            this.RotatingGrillButton.Text = "Метод поворачивающейся решетки";
            this.RotatingGrillButton.UseVisualStyleBackColor = true;
            // 
            // ColumnButton
            // 
            this.ColumnButton.Location = new System.Drawing.Point(6, 19);
            this.ColumnButton.Name = "ColumnButton";
            this.ColumnButton.Size = new System.Drawing.Size(155, 150);
            this.ColumnButton.TabIndex = 0;
            this.ColumnButton.Text = "Столбцовый метод";
            this.ColumnButton.UseVisualStyleBackColor = true;
            this.ColumnButton.Click += new System.EventHandler(this.ColumnButton_Click);
            // 
            // substitution
            // 
            this.substitution.Location = new System.Drawing.Point(8, 8);
            this.substitution.Name = "substitution";
            this.substitution.Size = new System.Drawing.Size(354, 175);
            this.substitution.TabIndex = 1;
            this.substitution.TabStop = false;
            this.substitution.Text = "ReShuffle[ENG Alphabet]";
            // 
            // SubstitutionGroupBox
            // 
            this.SubstitutionGroupBox.Controls.Add(this.VizhnerButton);
            this.SubstitutionGroupBox.Location = new System.Drawing.Point(409, 136);
            this.SubstitutionGroupBox.Name = "SubstitutionGroupBox";
            this.SubstitutionGroupBox.Size = new System.Drawing.Size(354, 175);
            this.SubstitutionGroupBox.TabIndex = 1;
            this.SubstitutionGroupBox.TabStop = false;
            this.SubstitutionGroupBox.Text = "Substitution[RUS Alphabet]";
            // 
            // VizhnerButton
            // 
            this.VizhnerButton.Location = new System.Drawing.Point(97, 19);
            this.VizhnerButton.Name = "VizhnerButton";
            this.VizhnerButton.Size = new System.Drawing.Size(155, 150);
            this.VizhnerButton.TabIndex = 2;
            this.VizhnerButton.Text = "Метод вижнера";
            this.VizhnerButton.UseVisualStyleBackColor = true;
            this.VizhnerButton.Click += new System.EventHandler(this.VizhnerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubstitutionGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.SubstitutionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ColumnButton;
        private System.Windows.Forms.GroupBox substitution;
        private System.Windows.Forms.GroupBox SubstitutionGroupBox;
        private System.Windows.Forms.Button RotatingGrillButton;
        private System.Windows.Forms.Button VizhnerButton;
    }
}

