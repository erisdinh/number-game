namespace Assignment1_NumberGame {
    partial class NumberGameForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumber1 = new System.Windows.Forms.Label();
            this.labelNumber2 = new System.Windows.Forms.Label();
            this.labelNumber3 = new System.Windows.Forms.Label();
            this.labelNumber4 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRoundScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            this.labelNumber0 = new System.Windows.Forms.Label();
            this.groupLabelNumber = new System.Windows.Forms.GroupBox();
            this.groupLabelNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMBER GAME";
            // 
            // labelNumber1
            // 
            this.labelNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNumber1.Location = new System.Drawing.Point(134, 20);
            this.labelNumber1.Name = "labelNumber1";
            this.labelNumber1.Size = new System.Drawing.Size(128, 136);
            this.labelNumber1.TabIndex = 1;
            this.labelNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber2
            // 
            this.labelNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNumber2.Location = new System.Drawing.Point(268, 20);
            this.labelNumber2.Name = "labelNumber2";
            this.labelNumber2.Size = new System.Drawing.Size(128, 136);
            this.labelNumber2.TabIndex = 2;
            this.labelNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber3
            // 
            this.labelNumber3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNumber3.Location = new System.Drawing.Point(402, 20);
            this.labelNumber3.Name = "labelNumber3";
            this.labelNumber3.Size = new System.Drawing.Size(128, 136);
            this.labelNumber3.TabIndex = 3;
            this.labelNumber3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumber4
            // 
            this.labelNumber4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNumber4.Location = new System.Drawing.Point(536, 20);
            this.labelNumber4.Name = "labelNumber4";
            this.labelNumber4.Size = new System.Drawing.Size(128, 136);
            this.labelNumber4.TabIndex = 4;
            this.labelNumber4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(280, 280);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(128, 35);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "New Game";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Round: ";
            // 
            // labelRound
            // 
            this.labelRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.Location = new System.Drawing.Point(625, 72);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(51, 23);
            this.labelRound.TabIndex = 7;
            this.labelRound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Round Score:";
            // 
            // labelRoundScore
            // 
            this.labelRoundScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundScore.Location = new System.Drawing.Point(159, 351);
            this.labelRoundScore.Name = "labelRoundScore";
            this.labelRoundScore.Size = new System.Drawing.Size(66, 22);
            this.labelRoundScore.TabIndex = 9;
            this.labelRoundScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(409, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Score:";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalScore.ForeColor = System.Drawing.Color.Red;
            this.labelTotalScore.Location = new System.Drawing.Point(576, 345);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(100, 28);
            this.labelTotalScore.TabIndex = 11;
            this.labelTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNumber0
            // 
            this.labelNumber0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelNumber0.Location = new System.Drawing.Point(0, 20);
            this.labelNumber0.Name = "labelNumber0";
            this.labelNumber0.Size = new System.Drawing.Size(128, 136);
            this.labelNumber0.TabIndex = 0;
            this.labelNumber0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupLabelNumber
            // 
            this.groupLabelNumber.Controls.Add(this.labelNumber0);
            this.groupLabelNumber.Controls.Add(this.labelNumber1);
            this.groupLabelNumber.Controls.Add(this.labelNumber2);
            this.groupLabelNumber.Controls.Add(this.labelNumber3);
            this.groupLabelNumber.Controls.Add(this.labelNumber4);
            this.groupLabelNumber.Location = new System.Drawing.Point(12, 98);
            this.groupLabelNumber.Name = "groupLabelNumber";
            this.groupLabelNumber.Size = new System.Drawing.Size(664, 176);
            this.groupLabelNumber.TabIndex = 13;
            this.groupLabelNumber.TabStop = false;
            // 
            // NumberGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 403);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRoundScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupLabelNumber);
            this.Name = "NumberGameForm";
            this.Text = "Number Game";
            this.groupLabelNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelNumber3;
        private System.Windows.Forms.Label labelNumber4;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRoundScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalScore;
        private System.Windows.Forms.Label labelNumber0;
        private System.Windows.Forms.GroupBox groupLabelNumber;
    }
}

