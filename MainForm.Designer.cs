
namespace DB_Management
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblDatabaseConnectStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.접속해제tsm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectName = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAdress = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_add = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Info_help = new System.Windows.Forms.ToolStripMenuItem();
            this.Info_info = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SelectAll = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_logout = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus,
            this.tsslblDatabaseConnectStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(636, 17);
            this.tsslblStatus.Spring = true;
            this.tsslblStatus.Text = "데이터베이스에 접속 되었습니다.";
            this.tsslblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslblDatabaseConnectStatus
            // 
            this.tsslblDatabaseConnectStatus.AutoSize = false;
            this.tsslblDatabaseConnectStatus.BackColor = System.Drawing.Color.Blue;
            this.tsslblDatabaseConnectStatus.ForeColor = System.Drawing.Color.White;
            this.tsslblDatabaseConnectStatus.LinkColor = System.Drawing.Color.Blue;
            this.tsslblDatabaseConnectStatus.Name = "tsslblDatabaseConnectStatus";
            this.tsslblDatabaseConnectStatus.Size = new System.Drawing.Size(100, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Logout,
            this.toolStripSeparator1,
            this.접속해제tsm});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem1.Text = "데이터베이스";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(122, 22);
            this.Logout.Text = "로그아웃";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // 접속해제tsm
            // 
            this.접속해제tsm.Name = "접속해제tsm";
            this.접속해제tsm.Size = new System.Drawing.Size(122, 22);
            this.접속해제tsm.Text = "종료";
            this.접속해제tsm.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectName,
            this.SelectAdress,
            this.SelectAll});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem2.Text = "조회";
            // 
            // SelectName
            // 
            this.SelectName.Name = "SelectName";
            this.SelectName.Size = new System.Drawing.Size(154, 22);
            this.SelectName.Text = "이름으로 검색";
            this.SelectName.Click += new System.EventHandler(this.SelectName_Click);
            // 
            // SelectAdress
            // 
            this.SelectAdress.Name = "SelectAdress";
            this.SelectAdress.Size = new System.Drawing.Size(154, 22);
            this.SelectAdress.Text = "주소로 검색";
            this.SelectAdress.Click += new System.EventHandler(this.SelectAdress_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(154, 22);
            this.SelectAll.Text = "전체 목록 보기";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_add,
            this.Edit_edit,
            this.Edit_delete});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem3.Text = "편집";
            // 
            // Edit_add
            // 
            this.Edit_add.Name = "Edit_add";
            this.Edit_add.Size = new System.Drawing.Size(98, 22);
            this.Edit_add.Text = "추가";
            this.Edit_add.Click += new System.EventHandler(this.추가_Click);
            // 
            // Edit_edit
            // 
            this.Edit_edit.Name = "Edit_edit";
            this.Edit_edit.Size = new System.Drawing.Size(98, 22);
            this.Edit_edit.Text = "수정";
            this.Edit_edit.Click += new System.EventHandler(this.수정_Click);
            // 
            // Edit_delete
            // 
            this.Edit_delete.Name = "Edit_delete";
            this.Edit_delete.Size = new System.Drawing.Size(98, 22);
            this.Edit_delete.Text = "삭제";
            this.Edit_delete.Click += new System.EventHandler(this.제거_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info_help,
            this.Info_info});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem4.Text = "프로그램정보";
            // 
            // Info_help
            // 
            this.Info_help.Name = "Info_help";
            this.Info_help.Size = new System.Drawing.Size(110, 22);
            this.Info_help.Text = "도움말";
            this.Info_help.Click += new System.EventHandler(this.Info_help_Click);
            // 
            // Info_info
            // 
            this.Info_info.Name = "Info_info";
            this.Info_info.Size = new System.Drawing.Size(110, 22);
            this.Info_info.Text = "정보";
            this.Info_info.Click += new System.EventHandler(this.Info_info_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(643, 315);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_SelectAll
            // 
            this.btn_SelectAll.Location = new System.Drawing.Point(661, 38);
            this.btn_SelectAll.Name = "btn_SelectAll";
            this.btn_SelectAll.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectAll.TabIndex = 5;
            this.btn_SelectAll.Text = "전체 조회";
            this.toolTip1.SetToolTip(this.btn_SelectAll, "서버에 등록된 회원의 정보를 모두 조회합니다.");
            this.btn_SelectAll.UseVisualStyleBackColor = true;
            this.btn_SelectAll.Click += new System.EventHandler(this.btn_SelectAll_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.White;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(685, 318);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(34, 35);
            this.btn_logout.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_logout, "프로그램을 종료합니다.");
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 404);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_SelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "회원관리";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmDb;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem SelectName;
        private System.Windows.Forms.ToolStripMenuItem SelectAdress;
        private System.Windows.Forms.ToolStripMenuItem SelectAll;
        private System.Windows.Forms.ToolStripMenuItem Edit_add;
        private System.Windows.Forms.ToolStripMenuItem Edit_edit;
        private System.Windows.Forms.ToolStripMenuItem Edit_delete;
        private System.Windows.Forms.ToolStripMenuItem Info_help;
        private System.Windows.Forms.ToolStripMenuItem Info_info;
        private System.Windows.Forms.Button btn_SelectAll;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ToolStripMenuItem Logout;
        public System.Windows.Forms.ToolStripMenuItem 접속해제tsm;
        public System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        public System.Windows.Forms.ToolStripStatusLabel tsslblDatabaseConnectStatus;
        public System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

