namespace dbconnexample
{
    partial class UpdateForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLable = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.ageLable = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLable = new System.Windows.Forms.Label();
            this.msgLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(317, 184);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(153, 36);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(93, 115);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(148, 20);
            this.emailBox.TabIndex = 20;
            // 
            // emailLable
            // 
            this.emailLable.AutoSize = true;
            this.emailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLable.Location = new System.Drawing.Point(32, 115);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(52, 20);
            this.emailLable.TabIndex = 19;
            this.emailLable.Text = "Email:";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(93, 160);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(148, 20);
            this.ageBox.TabIndex = 18;
            // 
            // ageLable
            // 
            this.ageLable.AutoSize = true;
            this.ageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLable.Location = new System.Drawing.Point(32, 160);
            this.ageLable.Name = "ageLable";
            this.ageLable.Size = new System.Drawing.Size(42, 20);
            this.ageLable.TabIndex = 17;
            this.ageLable.Text = "Age:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(93, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(148, 20);
            this.nameBox.TabIndex = 16;
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(32, 71);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(55, 20);
            this.nameLable.TabIndex = 15;
            this.nameLable.Text = "Name:";
            // 
            // msgLable
            // 
            this.msgLable.AutoSize = true;
            this.msgLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLable.Location = new System.Drawing.Point(90, 277);
            this.msgLable.Name = "msgLable";
            this.msgLable.Size = new System.Drawing.Size(0, 20);
            this.msgLable.TabIndex = 22;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 386);
            this.Controls.Add(this.msgLable);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLable);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.ageLable);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLable);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label ageLable;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label msgLable;
    }
}