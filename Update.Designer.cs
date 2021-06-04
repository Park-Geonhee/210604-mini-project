
namespace DB_Management
{
    partial class Update
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InsertID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxSex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(33, 326);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(200, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InsertID
            // 
            this.InsertID.Location = new System.Drawing.Point(175, 72);
            this.InsertID.Name = "InsertID";
            this.InsertID.Size = new System.Drawing.Size(100, 23);
            this.InsertID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "수정할 정보의 아이디를 먼저 조회합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "회원 아이디";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(175, 110);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.ReadOnly = true;
            this.txtboxName.Size = new System.Drawing.Size(100, 23);
            this.txtboxName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(175, 151);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.ReadOnly = true;
            this.txtboxAge.Size = new System.Drawing.Size(100, 23);
            this.txtboxAge.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "나이";
            // 
            // txtboxSex
            // 
            this.txtboxSex.Location = new System.Drawing.Point(175, 186);
            this.txtboxSex.Name = "txtboxSex";
            this.txtboxSex.ReadOnly = true;
            this.txtboxSex.Size = new System.Drawing.Size(100, 23);
            this.txtboxSex.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(175, 225);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.ReadOnly = true;
            this.txtboxAddress.Size = new System.Drawing.Size(100, 23);
            this.txtboxAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "주소";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(175, 265);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.ReadOnly = true;
            this.txtboxPhone.Size = new System.Drawing.Size(100, 23);
            this.txtboxPhone.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "전화번호";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(305, 72);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "조회";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 373);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Update";
            this.Text = "정보 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox InsertID;
        public System.Windows.Forms.TextBox txtboxName;
        public System.Windows.Forms.TextBox txtboxSex;
        public System.Windows.Forms.TextBox txtboxAddress;
        public System.Windows.Forms.TextBox txtboxPhone;
        public System.Windows.Forms.TextBox txtboxAge;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSelect;
        public System.Windows.Forms.Label label1;
    }
}