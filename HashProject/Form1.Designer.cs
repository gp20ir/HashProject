
namespace HashProject
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
            this.BtnHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCampare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHashLength = new System.Windows.Forms.Label();
            this.BtnLength = new System.Windows.Forms.Button();
            this.BtnCampare = new System.Windows.Forms.Button();
            this.lblResultCampare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHash
            // 
            this.BtnHash.Location = new System.Drawing.Point(202, 118);
            this.BtnHash.Name = "BtnHash";
            this.BtnHash.Size = new System.Drawing.Size(341, 45);
            this.BtnHash.TabIndex = 0;
            this.BtnHash.Text = "Hash Now";
            this.BtnHash.UseVisualStyleBackColor = true;
            this.BtnHash.Click += new System.EventHandler(this.BtnHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orginal Text";
            // 
            // txtOrg
            // 
            this.txtOrg.Location = new System.Drawing.Point(95, 17);
            this.txtOrg.Name = "txtOrg";
            this.txtOrg.Size = new System.Drawing.Size(569, 21);
            this.txtOrg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hash Text";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(95, 55);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(569, 21);
            this.txtHash.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Campare Hash Text";
            // 
            // txtCampare
            // 
            this.txtCampare.Location = new System.Drawing.Point(127, 338);
            this.txtCampare.Name = "txtCampare";
            this.txtCampare.Size = new System.Drawing.Size(544, 21);
            this.txtCampare.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hash Length";
            // 
            // lblHashLength
            // 
            this.lblHashLength.AutoSize = true;
            this.lblHashLength.Location = new System.Drawing.Point(94, 226);
            this.lblHashLength.Name = "lblHashLength";
            this.lblHashLength.Size = new System.Drawing.Size(35, 13);
            this.lblHashLength.TabIndex = 1;
            this.lblHashLength.Text = ".......";
            // 
            // BtnLength
            // 
            this.BtnLength.Location = new System.Drawing.Point(202, 210);
            this.BtnLength.Name = "BtnLength";
            this.BtnLength.Size = new System.Drawing.Size(341, 45);
            this.BtnLength.TabIndex = 0;
            this.BtnLength.Text = "Get Length Hash";
            this.BtnLength.UseVisualStyleBackColor = true;
            this.BtnLength.Click += new System.EventHandler(this.BtnLength_Click);
            // 
            // BtnCampare
            // 
            this.BtnCampare.Location = new System.Drawing.Point(202, 385);
            this.BtnCampare.Name = "BtnCampare";
            this.BtnCampare.Size = new System.Drawing.Size(341, 45);
            this.BtnCampare.TabIndex = 0;
            this.BtnCampare.Text = "Campare";
            this.BtnCampare.UseVisualStyleBackColor = true;
            this.BtnCampare.Click += new System.EventHandler(this.BtnCampare_Click);
            // 
            // lblResultCampare
            // 
            this.lblResultCampare.AutoSize = true;
            this.lblResultCampare.Location = new System.Drawing.Point(576, 401);
            this.lblResultCampare.Name = "lblResultCampare";
            this.lblResultCampare.Size = new System.Drawing.Size(75, 13);
            this.lblResultCampare.TabIndex = 1;
            this.lblResultCampare.Text = ".................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 441);
            this.Controls.Add(this.txtCampare);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtOrg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultCampare);
            this.Controls.Add(this.lblHashLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLength);
            this.Controls.Add(this.BtnCampare);
            this.Controls.Add(this.BtnHash);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCampare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHashLength;
        private System.Windows.Forms.Button BtnLength;
        private System.Windows.Forms.Button BtnCampare;
        private System.Windows.Forms.Label lblResultCampare;
    }
}

