namespace CipherGenerator
{
    partial class RotateCipher
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
            this.EncryptFromFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.TextBox();
            this.FirstDataGrid = new System.Windows.Forms.DataGridView();
            this.SecondDataGrid = new System.Windows.Forms.DataGridView();
            this.FourthDataGrid = new System.Windows.Forms.DataGridView();
            this.ThirdDataGrid = new System.Windows.Forms.DataGridView();
            this.EnCryptButton = new System.Windows.Forms.Button();
            this.EnCryptResultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeCryptResultBox = new System.Windows.Forms.TextBox();
            this.DeCryptButton = new System.Windows.Forms.Button();
            this.ThirdCryptDataGrid = new System.Windows.Forms.DataGridView();
            this.FourthCryptDataGrid = new System.Windows.Forms.DataGridView();
            this.SecondCryptDataGrid = new System.Windows.Forms.DataGridView();
            this.FirstCryptDataGrid = new System.Windows.Forms.DataGridView();
            this.DecryptFromFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CipherSourceBox = new System.Windows.Forms.TextBox();
            this.KeyDataGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.RotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCryptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCryptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCryptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCryptDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptFromFile
            // 
            this.EncryptFromFile.Location = new System.Drawing.Point(12, 26);
            this.EncryptFromFile.Name = "EncryptFromFile";
            this.EncryptFromFile.Size = new System.Drawing.Size(351, 23);
            this.EncryptFromFile.TabIndex = 8;
            this.EncryptFromFile.Text = "Текст из файла";
            this.EncryptFromFile.UseVisualStyleBackColor = true;
            this.EncryptFromFile.Click += new System.EventHandler(this.EncryptFromFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Исходный текст";
            // 
            // SourceBox
            // 
            this.SourceBox.Enabled = false;
            this.SourceBox.Location = new System.Drawing.Point(12, 55);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(351, 20);
            this.SourceBox.TabIndex = 6;
            // 
            // FirstDataGrid
            // 
            this.FirstDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstDataGrid.ColumnHeadersVisible = false;
            this.FirstDataGrid.Location = new System.Drawing.Point(12, 134);
            this.FirstDataGrid.Name = "FirstDataGrid";
            this.FirstDataGrid.RowHeadersVisible = false;
            this.FirstDataGrid.Size = new System.Drawing.Size(150, 150);
            this.FirstDataGrid.TabIndex = 9;
            // 
            // SecondDataGrid
            // 
            this.SecondDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondDataGrid.ColumnHeadersVisible = false;
            this.SecondDataGrid.Location = new System.Drawing.Point(213, 134);
            this.SecondDataGrid.Name = "SecondDataGrid";
            this.SecondDataGrid.RowHeadersVisible = false;
            this.SecondDataGrid.Size = new System.Drawing.Size(150, 150);
            this.SecondDataGrid.TabIndex = 10;
            // 
            // FourthDataGrid
            // 
            this.FourthDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FourthDataGrid.ColumnHeadersVisible = false;
            this.FourthDataGrid.Location = new System.Drawing.Point(213, 290);
            this.FourthDataGrid.Name = "FourthDataGrid";
            this.FourthDataGrid.RowHeadersVisible = false;
            this.FourthDataGrid.Size = new System.Drawing.Size(150, 150);
            this.FourthDataGrid.TabIndex = 11;
            // 
            // ThirdDataGrid
            // 
            this.ThirdDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThirdDataGrid.ColumnHeadersVisible = false;
            this.ThirdDataGrid.Location = new System.Drawing.Point(12, 290);
            this.ThirdDataGrid.Name = "ThirdDataGrid";
            this.ThirdDataGrid.RowHeadersVisible = false;
            this.ThirdDataGrid.Size = new System.Drawing.Size(150, 150);
            this.ThirdDataGrid.TabIndex = 12;
            // 
            // EnCryptButton
            // 
            this.EnCryptButton.Location = new System.Drawing.Point(12, 81);
            this.EnCryptButton.Name = "EnCryptButton";
            this.EnCryptButton.Size = new System.Drawing.Size(351, 23);
            this.EnCryptButton.TabIndex = 13;
            this.EnCryptButton.Text = "Шифровать";
            this.EnCryptButton.UseVisualStyleBackColor = true;
            this.EnCryptButton.Click += new System.EventHandler(this.EnCryptButton_Click);
            // 
            // EnCryptResultBox
            // 
            this.EnCryptResultBox.Location = new System.Drawing.Point(12, 474);
            this.EnCryptResultBox.Name = "EnCryptResultBox";
            this.EnCryptResultBox.Size = new System.Drawing.Size(351, 20);
            this.EnCryptResultBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "90°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "180°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "270°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(968, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "270°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(758, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "180°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(968, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "90°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(758, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "0°";
            // 
            // DeCryptResultBox
            // 
            this.DeCryptResultBox.Location = new System.Drawing.Point(701, 474);
            this.DeCryptResultBox.Name = "DeCryptResultBox";
            this.DeCryptResultBox.Size = new System.Drawing.Size(351, 20);
            this.DeCryptResultBox.TabIndex = 27;
            // 
            // DeCryptButton
            // 
            this.DeCryptButton.Location = new System.Drawing.Point(701, 81);
            this.DeCryptButton.Name = "DeCryptButton";
            this.DeCryptButton.Size = new System.Drawing.Size(351, 23);
            this.DeCryptButton.TabIndex = 26;
            this.DeCryptButton.Text = "Расшифровать";
            this.DeCryptButton.UseVisualStyleBackColor = true;
            this.DeCryptButton.Click += new System.EventHandler(this.DeCryptButton_Click);
            // 
            // ThirdCryptDataGrid
            // 
            this.ThirdCryptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThirdCryptDataGrid.ColumnHeadersVisible = false;
            this.ThirdCryptDataGrid.Location = new System.Drawing.Point(701, 290);
            this.ThirdCryptDataGrid.Name = "ThirdCryptDataGrid";
            this.ThirdCryptDataGrid.RowHeadersVisible = false;
            this.ThirdCryptDataGrid.Size = new System.Drawing.Size(150, 150);
            this.ThirdCryptDataGrid.TabIndex = 25;
            // 
            // FourthCryptDataGrid
            // 
            this.FourthCryptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FourthCryptDataGrid.ColumnHeadersVisible = false;
            this.FourthCryptDataGrid.Location = new System.Drawing.Point(902, 290);
            this.FourthCryptDataGrid.Name = "FourthCryptDataGrid";
            this.FourthCryptDataGrid.RowHeadersVisible = false;
            this.FourthCryptDataGrid.Size = new System.Drawing.Size(150, 150);
            this.FourthCryptDataGrid.TabIndex = 24;
            // 
            // SecondCryptDataGrid
            // 
            this.SecondCryptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondCryptDataGrid.ColumnHeadersVisible = false;
            this.SecondCryptDataGrid.Location = new System.Drawing.Point(902, 134);
            this.SecondCryptDataGrid.Name = "SecondCryptDataGrid";
            this.SecondCryptDataGrid.RowHeadersVisible = false;
            this.SecondCryptDataGrid.Size = new System.Drawing.Size(150, 150);
            this.SecondCryptDataGrid.TabIndex = 23;
            // 
            // FirstCryptDataGrid
            // 
            this.FirstCryptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstCryptDataGrid.ColumnHeadersVisible = false;
            this.FirstCryptDataGrid.Location = new System.Drawing.Point(701, 134);
            this.FirstCryptDataGrid.Name = "FirstCryptDataGrid";
            this.FirstCryptDataGrid.RowHeadersVisible = false;
            this.FirstCryptDataGrid.Size = new System.Drawing.Size(150, 150);
            this.FirstCryptDataGrid.TabIndex = 22;
            // 
            // DecryptFromFile
            // 
            this.DecryptFromFile.Location = new System.Drawing.Point(701, 26);
            this.DecryptFromFile.Name = "DecryptFromFile";
            this.DecryptFromFile.Size = new System.Drawing.Size(351, 23);
            this.DecryptFromFile.TabIndex = 21;
            this.DecryptFromFile.Text = "Текст из файла";
            this.DecryptFromFile.UseVisualStyleBackColor = true;
            this.DecryptFromFile.Click += new System.EventHandler(this.DecryptFromFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(701, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Шифротекст";
            // 
            // CipherSourceBox
            // 
            this.CipherSourceBox.Enabled = false;
            this.CipherSourceBox.Location = new System.Drawing.Point(701, 55);
            this.CipherSourceBox.Name = "CipherSourceBox";
            this.CipherSourceBox.Size = new System.Drawing.Size(351, 20);
            this.CipherSourceBox.TabIndex = 19;
            // 
            // KeyDataGrid
            // 
            this.KeyDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KeyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeyDataGrid.ColumnHeadersVisible = false;
            this.KeyDataGrid.Location = new System.Drawing.Point(447, 186);
            this.KeyDataGrid.Name = "KeyDataGrid";
            this.KeyDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KeyDataGrid.RowHeadersVisible = false;
            this.KeyDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.KeyDataGrid.Size = new System.Drawing.Size(150, 150);
            this.KeyDataGrid.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(502, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ключ";
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(447, 342);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(150, 23);
            this.RotateButton.TabIndex = 34;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // RotateCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 506);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.KeyDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DeCryptResultBox);
            this.Controls.Add(this.DeCryptButton);
            this.Controls.Add(this.ThirdCryptDataGrid);
            this.Controls.Add(this.FourthCryptDataGrid);
            this.Controls.Add(this.SecondCryptDataGrid);
            this.Controls.Add(this.FirstCryptDataGrid);
            this.Controls.Add(this.DecryptFromFile);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CipherSourceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnCryptResultBox);
            this.Controls.Add(this.EnCryptButton);
            this.Controls.Add(this.ThirdDataGrid);
            this.Controls.Add(this.FourthDataGrid);
            this.Controls.Add(this.SecondDataGrid);
            this.Controls.Add(this.FirstDataGrid);
            this.Controls.Add(this.EncryptFromFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceBox);
            this.Name = "RotateCipher";
            this.Text = "RotateCipher";
            this.Load += new System.EventHandler(this.RotateCipher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FirstDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdCryptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthCryptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondCryptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstCryptDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KeyDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptFromFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SourceBox;
        private System.Windows.Forms.DataGridView FirstDataGrid;
        private System.Windows.Forms.DataGridView SecondDataGrid;
        private System.Windows.Forms.DataGridView FourthDataGrid;
        private System.Windows.Forms.DataGridView ThirdDataGrid;
        private System.Windows.Forms.Button EnCryptButton;
        private System.Windows.Forms.TextBox EnCryptResultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DeCryptResultBox;
        private System.Windows.Forms.Button DeCryptButton;
        private System.Windows.Forms.DataGridView ThirdCryptDataGrid;
        private System.Windows.Forms.DataGridView FourthCryptDataGrid;
        private System.Windows.Forms.DataGridView SecondCryptDataGrid;
        private System.Windows.Forms.DataGridView FirstCryptDataGrid;
        private System.Windows.Forms.Button DecryptFromFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CipherSourceBox;
        private System.Windows.Forms.DataGridView KeyDataGrid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button RotateButton;
    }
}