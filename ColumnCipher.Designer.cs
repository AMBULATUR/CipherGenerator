namespace CipherGenerator
{
    partial class ColumnCipher
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
            this.SourceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SecondDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CipherKeyBox = new System.Windows.Forms.TextBox();
            this.CipherBox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.FirstEncodeGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultEncryptBox = new System.Windows.Forms.TextBox();
            this.SecondEncodeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEncodeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEncodeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceBox
            // 
            this.SourceBox.Location = new System.Drawing.Point(32, 51);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(344, 20);
            this.SourceBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходный текст";
            // 
            // KeyBox
            // 
            this.KeyBox.Location = new System.Drawing.Point(32, 94);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(344, 20);
            this.KeyBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ключ";
            // 
            // FirstDataGrid
            // 
            this.FirstDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstDataGrid.Location = new System.Drawing.Point(32, 157);
            this.FirstDataGrid.Name = "FirstDataGrid";
            this.FirstDataGrid.Size = new System.Drawing.Size(344, 148);
            this.FirstDataGrid.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Текст из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Шифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecondDataGrid
            // 
            this.SecondDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondDataGrid.Location = new System.Drawing.Point(32, 321);
            this.SecondDataGrid.Name = "SecondDataGrid";
            this.SecondDataGrid.Size = new System.Drawing.Size(344, 148);
            this.SecondDataGrid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Шифротекст";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(29, 523);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(347, 20);
            this.ResultBox.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Шифротекст из файла";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шифротекст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ключ";
            // 
            // CipherKeyBox
            // 
            this.CipherKeyBox.Location = new System.Drawing.Point(463, 99);
            this.CipherKeyBox.Name = "CipherKeyBox";
            this.CipherKeyBox.Size = new System.Drawing.Size(344, 20);
            this.CipherKeyBox.TabIndex = 13;
            // 
            // CipherBox
            // 
            this.CipherBox.Location = new System.Drawing.Point(463, 56);
            this.CipherBox.Name = "CipherBox";
            this.CipherBox.Size = new System.Drawing.Size(344, 20);
            this.CipherBox.TabIndex = 12;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(588, 128);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(94, 23);
            this.EncodeButton.TabIndex = 16;
            this.EncodeButton.Text = "Дешифровать";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // FirstEncodeGrid
            // 
            this.FirstEncodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstEncodeGrid.Location = new System.Drawing.Point(472, 157);
            this.FirstEncodeGrid.Name = "FirstEncodeGrid";
            this.FirstEncodeGrid.Size = new System.Drawing.Size(344, 148);
            this.FirstEncodeGrid.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Расшифрованный текст";
            // 
            // ResultEncryptBox
            // 
            this.ResultEncryptBox.Location = new System.Drawing.Point(472, 523);
            this.ResultEncryptBox.Name = "ResultEncryptBox";
            this.ResultEncryptBox.Size = new System.Drawing.Size(347, 20);
            this.ResultEncryptBox.TabIndex = 18;
            // 
            // SecondEncodeGrid
            // 
            this.SecondEncodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondEncodeGrid.Location = new System.Drawing.Point(472, 321);
            this.SecondEncodeGrid.Name = "SecondEncodeGrid";
            this.SecondEncodeGrid.Size = new System.Drawing.Size(344, 148);
            this.SecondEncodeGrid.TabIndex = 17;
            // 
            // ColumnCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 555);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultEncryptBox);
            this.Controls.Add(this.SecondEncodeGrid);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.FirstEncodeGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CipherKeyBox);
            this.Controls.Add(this.CipherBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SecondDataGrid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceBox);
            this.Name = "ColumnCipher";
            this.Text = "ColumnCipher";
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEncodeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEncodeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView FirstDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView SecondDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CipherKeyBox;
        private System.Windows.Forms.TextBox CipherBox;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.DataGridView FirstEncodeGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultEncryptBox;
        private System.Windows.Forms.DataGridView SecondEncodeGrid;
    }
}