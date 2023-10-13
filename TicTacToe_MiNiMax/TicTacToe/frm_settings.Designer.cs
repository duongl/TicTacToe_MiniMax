namespace TicTacToe
{
    partial class frm_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pieceX = new System.Windows.Forms.RadioButton();
            this.pieceO = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mode2 = new System.Windows.Forms.RadioButton();
            this.mode3 = new System.Windows.Forms.RadioButton();
            this.mode1 = new System.Windows.Forms.RadioButton();
            this.picRetour = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.labelPlayer2);
            this.groupBox1.Controls.Add(this.txtPlayer2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPlayer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(334, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TÊN";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(27, 84);
            this.labelPlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(108, 18);
            this.labelPlayer2.TabIndex = 3;
            this.labelPlayer2.Text = "PLAYER 2 :";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(142, 81);
            this.txtPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(157, 26);
            this.txtPlayer2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYER 1 :";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(142, 35);
            this.txtPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(157, 26);
            this.txtPlayer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.pieceX);
            this.groupBox2.Controls.Add(this.pieceO);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(334, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Hình";
            // 
            // pieceX
            // 
            this.pieceX.AutoSize = true;
            this.pieceX.Checked = true;
            this.pieceX.Location = new System.Drawing.Point(150, 41);
            this.pieceX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pieceX.Name = "pieceX";
            this.pieceX.Size = new System.Drawing.Size(36, 22);
            this.pieceX.TabIndex = 4;
            this.pieceX.TabStop = true;
            this.pieceX.Tag = "X";
            this.pieceX.Text = "X";
            this.pieceX.UseVisualStyleBackColor = true;
            this.pieceX.CheckedChanged += new System.EventHandler(this.pieceChecked);
            // 
            // pieceO
            // 
            this.pieceO.AutoSize = true;
            this.pieceO.Location = new System.Drawing.Point(215, 41);
            this.pieceO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pieceO.Name = "pieceO";
            this.pieceO.Size = new System.Drawing.Size(36, 22);
            this.pieceO.TabIndex = 3;
            this.pieceO.Tag = "O";
            this.pieceO.Text = "O";
            this.pieceO.UseVisualStyleBackColor = true;
            this.pieceO.CheckedChanged += new System.EventHandler(this.pieceChecked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLAYER 1 :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.mode2);
            this.groupBox3.Controls.Add(this.mode3);
            this.groupBox3.Controls.Add(this.mode1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 336);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(334, 76);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ĐỘ KHÓ";
            // 
            // mode2
            // 
            this.mode2.AutoSize = true;
            this.mode2.Location = new System.Drawing.Point(124, 34);
            this.mode2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(56, 22);
            this.mode2.TabIndex = 7;
            this.mode2.Tag = "moyen";
            this.mode2.Text = "Khó";
            this.mode2.UseVisualStyleBackColor = true;
            this.mode2.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // mode3
            // 
            this.mode3.AutoSize = true;
            this.mode3.BackColor = System.Drawing.Color.Gainsboro;
            this.mode3.Enabled = false;
            this.mode3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode3.Location = new System.Drawing.Point(215, 34);
            this.mode3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mode3.Name = "mode3";
            this.mode3.Size = new System.Drawing.Size(90, 21);
            this.mode3.TabIndex = 6;
            this.mode3.Tag = "hard";
            this.mode3.Text = "Siêu Khó";
            this.mode3.UseVisualStyleBackColor = false;
            this.mode3.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // mode1
            // 
            this.mode1.AutoSize = true;
            this.mode1.Checked = true;
            this.mode1.Location = new System.Drawing.Point(28, 34);
            this.mode1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(46, 22);
            this.mode1.TabIndex = 5;
            this.mode1.TabStop = true;
            this.mode1.Tag = "easy";
            this.mode1.Text = "Dễ";
            this.mode1.UseVisualStyleBackColor = true;
            this.mode1.CheckedChanged += new System.EventHandler(this.modeChecked);
            // 
            // picRetour
            // 
            this.picRetour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRetour.BackgroundImage")));
            this.picRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRetour.Location = new System.Drawing.Point(274, 437);
            this.picRetour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picRetour.Name = "picRetour";
            this.picRetour.Size = new System.Drawing.Size(61, 62);
            this.picRetour.TabIndex = 3;
            this.picRetour.TabStop = false;
            this.picRetour.Click += new System.EventHandler(this.picRetour_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 451);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.saveClick);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DimGray;
            this.lblError.Location = new System.Drawing.Point(34, 7);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(290, 54);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "Chào mừng bạn trong cài đặt!";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(352, 509);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picRetour);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRetour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.RadioButton pieceX;
        private System.Windows.Forms.RadioButton pieceO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRetour;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.RadioButton mode3;
        private System.Windows.Forms.RadioButton mode1;
        private System.Windows.Forms.RadioButton mode2;
    }
}