namespace Boxes
{
    partial class Form1
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
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFigure = new System.Windows.Forms.ComboBox();
            this.cmbAmount = new System.Windows.Forms.ComboBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.gbxSuits = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlPlayer3 = new System.Windows.Forms.Panel();
            this.pnlPlayer4 = new System.Windows.Forms.Panel();
            this.pnlDeck = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.gbxSuits.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.Location = new System.Drawing.Point(191, 131);
            this.pnlPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(242, 151);
            this.pnlPlayer1.TabIndex = 0;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlPlayer2.Location = new System.Drawing.Point(581, 131);
            this.pnlPlayer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(235, 151);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(975, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFigure
            // 
            this.cmbFigure.FormattingEnabled = true;
            this.cmbFigure.Location = new System.Drawing.Point(975, 162);
            this.cmbFigure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFigure.Name = "cmbFigure";
            this.cmbFigure.Size = new System.Drawing.Size(121, 24);
            this.cmbFigure.TabIndex = 3;
            this.cmbFigure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbFigure.TextChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbAmount
            // 
            this.cmbAmount.FormattingEnabled = true;
            this.cmbAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbAmount.Location = new System.Drawing.Point(975, 219);
            this.cmbAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAmount.Name = "cmbAmount";
            this.cmbAmount.Size = new System.Drawing.Size(121, 24);
            this.cmbAmount.TabIndex = 4;
            this.cmbAmount.Visible = false;
            this.cmbAmount.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cmbAmount.TextChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btncheck
            // 
            this.btncheck.Enabled = false;
            this.btncheck.Location = new System.Drawing.Point(1113, 154);
            this.btncheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(107, 39);
            this.btncheck.TabIndex = 8;
            this.btncheck.Text = "Check";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 32);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Diamond";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 60);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 21);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Club";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 117);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 21);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Spade";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 89);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(65, 21);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Heart";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // gbxSuits
            // 
            this.gbxSuits.Controls.Add(this.checkBox1);
            this.gbxSuits.Controls.Add(this.checkBox4);
            this.gbxSuits.Controls.Add(this.checkBox2);
            this.gbxSuits.Controls.Add(this.checkBox3);
            this.gbxSuits.Location = new System.Drawing.Point(975, 277);
            this.gbxSuits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSuits.Name = "gbxSuits";
            this.gbxSuits.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSuits.Size = new System.Drawing.Size(121, 164);
            this.gbxSuits.TabIndex = 13;
            this.gbxSuits.TabStop = false;
            this.gbxSuits.Text = "Suits";
            this.gbxSuits.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(449, 310);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 14;
            // 
            // pnlPlayer3
            // 
            this.pnlPlayer3.Location = new System.Drawing.Point(183, 342);
            this.pnlPlayer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer3.Name = "pnlPlayer3";
            this.pnlPlayer3.Size = new System.Drawing.Size(250, 166);
            this.pnlPlayer3.TabIndex = 15;
            // 
            // pnlPlayer4
            // 
            this.pnlPlayer4.Location = new System.Drawing.Point(571, 342);
            this.pnlPlayer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlayer4.Name = "pnlPlayer4";
            this.pnlPlayer4.Size = new System.Drawing.Size(245, 169);
            this.pnlPlayer4.TabIndex = 16;
            // 
            // pnlDeck
            // 
            this.pnlDeck.Location = new System.Drawing.Point(845, 293);
            this.pnlDeck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDeck.Name = "pnlDeck";
            this.pnlDeck.Size = new System.Drawing.Size(13, 164);
            this.pnlDeck.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 41);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 17);
            this.lbl1.TabIndex = 17;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(449, 41);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 17);
            this.lbl2.TabIndex = 18;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(33, 342);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 17);
            this.lbl3.TabIndex = 19;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(449, 342);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(0, 17);
            this.lbl4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::Boxes.Properties.Resources.field1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 692);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pnlPlayer4);
            this.Controls.Add(this.pnlDeck);
            this.Controls.Add(this.pnlPlayer3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.gbxSuits);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.cmbAmount);
            this.Controls.Add(this.cmbFigure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSuits.ResumeLayout(false);
            this.gbxSuits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbFigure;
        private System.Windows.Forms.ComboBox cmbAmount;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox gbxSuits;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlPlayer3;
        private System.Windows.Forms.Panel pnlPlayer4;
        private System.Windows.Forms.Panel pnlDeck;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}

