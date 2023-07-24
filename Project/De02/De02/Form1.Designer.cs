namespace De02
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.dtpk_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.txt_SearchSP = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_DontSave = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SearchSP = new System.Windows.Forms.Button();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.lsv_Show = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(724, 183);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(50, 16);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "Mã SP:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(724, 215);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 16);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Tên SP:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(698, 247);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(76, 16);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Ngày nhập:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(717, 282);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(57, 16);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Loại SP:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(797, 177);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(185, 22);
            this.txt_ID.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(797, 209);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(185, 22);
            this.txt_Name.TabIndex = 5;
            // 
            // dtpk_Date
            // 
            this.dtpk_Date.Location = new System.Drawing.Point(797, 241);
            this.dtpk_Date.Name = "dtpk_Date";
            this.dtpk_Date.Size = new System.Drawing.Size(185, 22);
            this.dtpk_Date.TabIndex = 8;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(343, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(333, 32);
            this.lbl_Title.TabIndex = 10;
            this.lbl_Title.Text = "DANH MỤC SẢN PHẨM";
            // 
            // txt_SearchSP
            // 
            this.txt_SearchSP.Location = new System.Drawing.Point(38, 59);
            this.txt_SearchSP.Multiline = true;
            this.txt_SearchSP.Name = "txt_SearchSP";
            this.txt_SearchSP.Size = new System.Drawing.Size(178, 29);
            this.txt_SearchSP.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(63, 393);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(179, 393);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 14;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(299, 393);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(418, 393);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_DontSave
            // 
            this.btn_DontSave.Enabled = false;
            this.btn_DontSave.Location = new System.Drawing.Point(524, 393);
            this.btn_DontSave.Name = "btn_DontSave";
            this.btn_DontSave.Size = new System.Drawing.Size(75, 23);
            this.btn_DontSave.TabIndex = 17;
            this.btn_DontSave.Text = "K.Lưu";
            this.btn_DontSave.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(643, 393);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 18;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // btn_SearchSP
            // 
            this.btn_SearchSP.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SearchSP.Location = new System.Drawing.Point(236, 59);
            this.btn_SearchSP.Name = "btn_SearchSP";
            this.btn_SearchSP.Size = new System.Drawing.Size(75, 30);
            this.btn_SearchSP.TabIndex = 19;
            this.btn_SearchSP.Text = "Tìm";
            this.btn_SearchSP.UseVisualStyleBackColor = false;
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(797, 274);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(185, 24);
            this.cb_Category.TabIndex = 20;
            // 
            // lsv_Show
            // 
            this.lsv_Show.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Name,
            this.col_Date,
            this.col_Category});
            this.lsv_Show.HideSelection = false;
            this.lsv_Show.Location = new System.Drawing.Point(38, 111);
            this.lsv_Show.Name = "lsv_Show";
            this.lsv_Show.Size = new System.Drawing.Size(638, 253);
            this.lsv_Show.TabIndex = 21;
            this.lsv_Show.UseCompatibleStateImageBehavior = false;
            this.lsv_Show.View = System.Windows.Forms.View.Details;
            // 
            // col_ID
            // 
            this.col_ID.Text = "Mã SP";
            this.col_ID.Width = 139;
            // 
            // col_Name
            // 
            this.col_Name.Text = "Tên Sản Phẩm";
            this.col_Name.Width = 196;
            // 
            // col_Date
            // 
            this.col_Date.Text = "Ngày Nhập";
            this.col_Date.Width = 164;
            // 
            // col_Category
            // 
            this.col_Category.Text = "Loại SP";
            this.col_Category.Width = 135;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 450);
            this.Controls.Add(this.lsv_Show);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.btn_SearchSP);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DontSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_SearchSP);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dtpk_Date);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_ID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtpk_Date;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox txt_SearchSP;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_DontSave;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SearchSP;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.ListView lsv_Show;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader col_Date;
        private System.Windows.Forms.ColumnHeader col_Category;
    }
}

