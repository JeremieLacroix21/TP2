﻿namespace TP2_Base_de_données
{
    partial class AjouterQuestion
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
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBX_D_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_C_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_B_Reponse = new System.Windows.Forms.RichTextBox();
            this.RTBX_A_Reponse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RBTN_B_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_C_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_D_Reponse = new System.Windows.Forms.RadioButton();
            this.RBTN_A_Reponse = new System.Windows.Forms.RadioButton();
            this.RTBX_Question = new System.Windows.Forms.RichTextBox();
            this.BTN_Ajouterautre = new System.Windows.Forms.Button();
            this.CBB_catégo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouter.Location = new System.Drawing.Point(12, 335);
            this.BTN_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(145, 53);
            this.BTN_Ajouter.TabIndex = 29;
            this.BTN_Ajouter.Text = "Ajouter la question";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Réponses";
            // 
            // RTBX_D_Reponse
            // 
            this.RTBX_D_Reponse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBX_D_Reponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBX_D_Reponse.Location = new System.Drawing.Point(53, 271);
            this.RTBX_D_Reponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBX_D_Reponse.Name = "RTBX_D_Reponse";
            this.RTBX_D_Reponse.Size = new System.Drawing.Size(237, 29);
            this.RTBX_D_Reponse.TabIndex = 27;
            this.RTBX_D_Reponse.Text = "";
            this.RTBX_D_Reponse.TextChanged += new System.EventHandler(this.RTBX_D_Reponse_TextChanged);
            // 
            // RTBX_C_Reponse
            // 
            this.RTBX_C_Reponse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBX_C_Reponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBX_C_Reponse.Location = new System.Drawing.Point(53, 237);
            this.RTBX_C_Reponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBX_C_Reponse.Name = "RTBX_C_Reponse";
            this.RTBX_C_Reponse.Size = new System.Drawing.Size(237, 29);
            this.RTBX_C_Reponse.TabIndex = 26;
            this.RTBX_C_Reponse.Text = "";
            this.RTBX_C_Reponse.TextChanged += new System.EventHandler(this.RTBX_C_Reponse_TextChanged);
            // 
            // RTBX_B_Reponse
            // 
            this.RTBX_B_Reponse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBX_B_Reponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBX_B_Reponse.Location = new System.Drawing.Point(53, 204);
            this.RTBX_B_Reponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBX_B_Reponse.Name = "RTBX_B_Reponse";
            this.RTBX_B_Reponse.Size = new System.Drawing.Size(237, 29);
            this.RTBX_B_Reponse.TabIndex = 25;
            this.RTBX_B_Reponse.Text = "";
            this.RTBX_B_Reponse.TextChanged += new System.EventHandler(this.RTBX_B_Reponse_TextChanged);
            // 
            // RTBX_A_Reponse
            // 
            this.RTBX_A_Reponse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBX_A_Reponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBX_A_Reponse.Location = new System.Drawing.Point(53, 171);
            this.RTBX_A_Reponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBX_A_Reponse.Name = "RTBX_A_Reponse";
            this.RTBX_A_Reponse.Size = new System.Drawing.Size(237, 29);
            this.RTBX_A_Reponse.TabIndex = 24;
            this.RTBX_A_Reponse.Text = "";
            this.RTBX_A_Reponse.TextChanged += new System.EventHandler(this.RTBX_A_Reponse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Question";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RBTN_B_Reponse
            // 
            this.RBTN_B_Reponse.AutoSize = true;
            this.RBTN_B_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_B_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_B_Reponse.Location = new System.Drawing.Point(10, 204);
            this.RBTN_B_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_B_Reponse.Name = "RBTN_B_Reponse";
            this.RBTN_B_Reponse.Size = new System.Drawing.Size(37, 22);
            this.RBTN_B_Reponse.TabIndex = 22;
            this.RBTN_B_Reponse.TabStop = true;
            this.RBTN_B_Reponse.Text = "B";
            this.RBTN_B_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_B_Reponse.UseVisualStyleBackColor = true;
            // 
            // RBTN_C_Reponse
            // 
            this.RBTN_C_Reponse.AutoSize = true;
            this.RBTN_C_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_C_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_C_Reponse.Location = new System.Drawing.Point(9, 237);
            this.RBTN_C_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_C_Reponse.Name = "RBTN_C_Reponse";
            this.RBTN_C_Reponse.Size = new System.Drawing.Size(38, 22);
            this.RBTN_C_Reponse.TabIndex = 21;
            this.RBTN_C_Reponse.TabStop = true;
            this.RBTN_C_Reponse.Text = "C";
            this.RBTN_C_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_C_Reponse.UseVisualStyleBackColor = true;
            // 
            // RBTN_D_Reponse
            // 
            this.RBTN_D_Reponse.AutoSize = true;
            this.RBTN_D_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_D_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_D_Reponse.Location = new System.Drawing.Point(9, 271);
            this.RBTN_D_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_D_Reponse.Name = "RBTN_D_Reponse";
            this.RBTN_D_Reponse.Size = new System.Drawing.Size(38, 22);
            this.RBTN_D_Reponse.TabIndex = 20;
            this.RBTN_D_Reponse.TabStop = true;
            this.RBTN_D_Reponse.Text = "D";
            this.RBTN_D_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_D_Reponse.UseVisualStyleBackColor = true;
            // 
            // RBTN_A_Reponse
            // 
            this.RBTN_A_Reponse.AutoSize = true;
            this.RBTN_A_Reponse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RBTN_A_Reponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTN_A_Reponse.Location = new System.Drawing.Point(8, 176);
            this.RBTN_A_Reponse.Margin = new System.Windows.Forms.Padding(2);
            this.RBTN_A_Reponse.Name = "RBTN_A_Reponse";
            this.RBTN_A_Reponse.Size = new System.Drawing.Size(36, 22);
            this.RBTN_A_Reponse.TabIndex = 19;
            this.RBTN_A_Reponse.TabStop = true;
            this.RBTN_A_Reponse.Text = "A";
            this.RBTN_A_Reponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBTN_A_Reponse.UseVisualStyleBackColor = true;
            // 
            // RTBX_Question
            // 
            this.RTBX_Question.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBX_Question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RTBX_Question.Location = new System.Drawing.Point(9, 21);
            this.RTBX_Question.Margin = new System.Windows.Forms.Padding(2);
            this.RTBX_Question.Name = "RTBX_Question";
            this.RTBX_Question.Size = new System.Drawing.Size(282, 119);
            this.RTBX_Question.TabIndex = 18;
            this.RTBX_Question.Text = "";
            this.RTBX_Question.TextChanged += new System.EventHandler(this.RTBX_Question_TextChanged);
            // 
            // BTN_Ajouterautre
            // 
            this.BTN_Ajouterautre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ajouterautre.BackColor = System.Drawing.SystemColors.Control;
            this.BTN_Ajouterautre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Ajouterautre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ajouterautre.Location = new System.Drawing.Point(161, 335);
            this.BTN_Ajouterautre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Ajouterautre.Name = "BTN_Ajouterautre";
            this.BTN_Ajouterautre.Size = new System.Drawing.Size(156, 53);
            this.BTN_Ajouterautre.TabIndex = 30;
            this.BTN_Ajouterautre.Text = "Ajouter une autre";
            this.BTN_Ajouterautre.UseVisualStyleBackColor = false;
            this.BTN_Ajouterautre.Click += new System.EventHandler(this.BTN_Ajouterautre_Click);
            // 
            // CBB_catégo
            // 
            this.CBB_catégo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBB_catégo.FormattingEnabled = true;
            this.CBB_catégo.Location = new System.Drawing.Point(173, 305);
            this.CBB_catégo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBB_catégo.Name = "CBB_catégo";
            this.CBB_catégo.Size = new System.Drawing.Size(129, 21);
            this.CBB_catégo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Choisir la catégorie:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AjouterQuestion
            // 
            this.AcceptButton = this.BTN_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBB_catégo);
            this.Controls.Add(this.BTN_Ajouterautre);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RTBX_D_Reponse);
            this.Controls.Add(this.RTBX_C_Reponse);
            this.Controls.Add(this.RTBX_B_Reponse);
            this.Controls.Add(this.RTBX_A_Reponse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBTN_B_Reponse);
            this.Controls.Add(this.RBTN_C_Reponse);
            this.Controls.Add(this.RBTN_D_Reponse);
            this.Controls.Add(this.RBTN_A_Reponse);
            this.Controls.Add(this.RTBX_Question);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjouterQuestion";
            this.Text = "AjouterQuestion";
            this.Load += new System.EventHandler(this.AjouterQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBX_D_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_C_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_B_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_A_Reponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBTN_B_Reponse;
        private System.Windows.Forms.RadioButton RBTN_C_Reponse;
        private System.Windows.Forms.RadioButton RBTN_D_Reponse;
        private System.Windows.Forms.RadioButton RBTN_A_Reponse;
        private System.Windows.Forms.RichTextBox RTBX_Question;
        private System.Windows.Forms.Button BTN_Ajouterautre;
        private System.Windows.Forms.ComboBox CBB_catégo;
        private System.Windows.Forms.Label label3;
    }
}