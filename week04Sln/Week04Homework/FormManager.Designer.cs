namespace Week04Homework
{
    partial class FomrManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbxArray = new System.Windows.Forms.ListBox();
            this.tbxBirtYear = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.tbxAdvisor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.cmbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.lbxDictionary = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(160, 39);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(136, 28);
            this.tbxNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(23, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 18);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "학번";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(487, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(173, 28);
            this.tbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(391, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 18;
            this.lbxArray.Location = new System.Drawing.Point(685, 39);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(242, 166);
            this.lbxArray.TabIndex = 2;
            // 
            // tbxBirtYear
            // 
            this.tbxBirtYear.Location = new System.Drawing.Point(160, 97);
            this.tbxBirtYear.Name = "tbxBirtYear";
            this.tbxBirtYear.Size = new System.Drawing.Size(136, 28);
            this.tbxBirtYear.TabIndex = 0;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(23, 100);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(80, 18);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "생년월일";
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(394, 97);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(73, 28);
            this.tbxBirthMonth.TabIndex = 0;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(317, 103);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(26, 18);
            this.lblBirthYear.TabIndex = 1;
            this.lblBirthYear.Text = "년";
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.AutoSize = true;
            this.lblBirthMonth.Location = new System.Drawing.Point(484, 103);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(26, 18);
            this.lblBirthMonth.TabIndex = 1;
            this.lblBirthMonth.Text = "월";
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(534, 100);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(73, 28);
            this.tbxBirthDay.TabIndex = 0;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(623, 103);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(26, 18);
            this.lblBirthDay.TabIndex = 1;
            this.lblBirthDay.Text = "일";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(23, 158);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 18);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "소속학과";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(160, 158);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(500, 26);
            this.cmbDepartment.TabIndex = 3;
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Location = new System.Drawing.Point(23, 216);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(80, 18);
            this.lblAdvisor.TabIndex = 1;
            this.lblAdvisor.Text = "지도교수";
            // 
            // tbxAdvisor
            // 
            this.tbxAdvisor.Location = new System.Drawing.Point(160, 213);
            this.tbxAdvisor.Name = "tbxAdvisor";
            this.tbxAdvisor.Size = new System.Drawing.Size(500, 28);
            this.tbxAdvisor.TabIndex = 0;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(23, 275);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "학년";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(160, 272);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(136, 26);
            this.cmbYear.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(387, 275);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 18);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "분반";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(496, 272);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(164, 26);
            this.cmbClass.TabIndex = 3;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Location = new System.Drawing.Point(23, 333);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(80, 18);
            this.lblRegStatus.TabIndex = 1;
            this.lblRegStatus.Text = "재적상태";
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(160, 330);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(136, 26);
            this.cmbRegStatus.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(23, 387);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 18);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "주소";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(160, 384);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(500, 28);
            this.tbxAddress.TabIndex = 0;
            // 
            // tbxContact
            // 
            this.tbxContact.Location = new System.Drawing.Point(160, 441);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(500, 28);
            this.tbxContact.TabIndex = 0;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(23, 444);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 18);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "연락처";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 18;
            this.lbxList.Location = new System.Drawing.Point(685, 231);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(242, 148);
            this.lbxList.TabIndex = 2;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 18;
            this.lbxDictionary.Location = new System.Drawing.Point(685, 421);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(242, 166);
            this.lbxDictionary.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(26, 507);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(118, 80);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(160, 507);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(500, 80);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // FomrManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 613);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbRegStatus);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lbxDictionary);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lbxArray);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBirthDay);
            this.Controls.Add(this.lblBirthMonth);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblRegStatus);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblAdvisor);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxBirthDay);
            this.Controls.Add(this.tbxContact);
            this.Controls.Add(this.tbxBirthMonth);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxAdvisor);
            this.Controls.Add(this.tbxBirtYear);
            this.Controls.Add(this.tbxNumber);
            this.Name = "FomrManager";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.TextBox tbxBirtYear;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.TextBox tbxAdvisor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.ComboBox cmbRegStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ListBox lbxDictionary;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRegister;
    }
}

