namespace Week04Homework
{
    partial class FormManager
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
            this.tbxBirthYear = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.tbxBirthMonth = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.lblBirthMonth = new System.Windows.Forms.Label();
            this.tbxBirthDay = new System.Windows.Forms.TextBox();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpgDepartment = new System.Windows.Forms.TabPage();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnRegisterDepartment = new System.Windows.Forms.Button();
            this.lbxDepartment = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDepartmentCode = new System.Windows.Forms.TextBox();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpgProfessor = new System.Windows.Forms.TabPage();
            this.cmbProfessorDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveProfessor = new System.Windows.Forms.Button();
            this.btnRegisterProfessor = new System.Windows.Forms.Button();
            this.lbxProfessor = new System.Windows.Forms.ListBox();
            this.lblProfessorNumber = new System.Windows.Forms.Label();
            this.tbxProfessorNumber = new System.Windows.Forms.TextBox();
            this.tbxProfessorName = new System.Windows.Forms.TextBox();
            this.lblProfessorName = new System.Windows.Forms.Label();
            this.tpgStudent = new System.Windows.Forms.TabPage();
            this.cmbAdvisor = new System.Windows.Forms.ComboBox();
            this.tpgTestScore = new System.Windows.Forms.TabPage();
            this.btnTestRegScore = new System.Windows.Forms.Button();
            this.btnTestSearchStudent = new System.Windows.Forms.Button();
            this.lblTestCourse9Title = new System.Windows.Forms.Label();
            this.lblTestCourse6Title = new System.Windows.Forms.Label();
            this.lblTestCourse3Title = new System.Windows.Forms.Label();
            this.lblTestCourse8Title = new System.Windows.Forms.Label();
            this.lblTestCourse5Title = new System.Windows.Forms.Label();
            this.lblTestCourse2Title = new System.Windows.Forms.Label();
            this.lblTestCourse7Title = new System.Windows.Forms.Label();
            this.lblTestCourse4Title = new System.Windows.Forms.Label();
            this.lblTestCourse1Title = new System.Windows.Forms.Label();
            this.tbxTestScore9 = new System.Windows.Forms.TextBox();
            this.tbxTestScore6 = new System.Windows.Forms.TextBox();
            this.lblTestNumberTitle = new System.Windows.Forms.Label();
            this.tbxTestScore8 = new System.Windows.Forms.TextBox();
            this.tbxTestScore5 = new System.Windows.Forms.TextBox();
            this.tbxTestScore3 = new System.Windows.Forms.TextBox();
            this.tbxTestScore7 = new System.Windows.Forms.TextBox();
            this.tbxTestScore4 = new System.Windows.Forms.TextBox();
            this.tbxTestScore2 = new System.Windows.Forms.TextBox();
            this.tbxTestScore1 = new System.Windows.Forms.TextBox();
            this.tbxTestNumber = new System.Windows.Forms.TextBox();
            this.lblTestAverage = new System.Windows.Forms.Label();
            this.lblTestAverageTitle = new System.Windows.Forms.Label();
            this.lblTestTotalCount = new System.Windows.Forms.Label();
            this.lblTestTotalCountTitle = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.lblTestNameTitle = new System.Windows.Forms.Label();
            this.btnFileTest = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tpgDepartment.SuspendLayout();
            this.tpgProfessor.SuspendLayout();
            this.tpgStudent.SuspendLayout();
            this.tpgTestScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(164, 26);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(135, 28);
            this.tbxNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(27, 28);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 18);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "학번";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(491, 26);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(173, 28);
            this.tbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(396, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // lbxArray
            // 
            this.lbxArray.FormattingEnabled = true;
            this.lbxArray.ItemHeight = 18;
            this.lbxArray.Location = new System.Drawing.Point(690, 26);
            this.lbxArray.Name = "lbxArray";
            this.lbxArray.Size = new System.Drawing.Size(243, 148);
            this.lbxArray.TabIndex = 2;
            // 
            // tbxBirthYear
            // 
            this.tbxBirthYear.Location = new System.Drawing.Point(164, 84);
            this.tbxBirthYear.Name = "tbxBirthYear";
            this.tbxBirthYear.Size = new System.Drawing.Size(135, 28);
            this.tbxBirthYear.TabIndex = 0;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(27, 87);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(80, 18);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "생년월일";
            // 
            // tbxBirthMonth
            // 
            this.tbxBirthMonth.Location = new System.Drawing.Point(394, 82);
            this.tbxBirthMonth.Name = "tbxBirthMonth";
            this.tbxBirthMonth.Size = new System.Drawing.Size(73, 28);
            this.tbxBirthMonth.TabIndex = 0;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.Location = new System.Drawing.Point(321, 90);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(26, 18);
            this.lblBirthYear.TabIndex = 1;
            this.lblBirthYear.Text = "년";
            // 
            // lblBirthMonth
            // 
            this.lblBirthMonth.AutoSize = true;
            this.lblBirthMonth.Location = new System.Drawing.Point(484, 88);
            this.lblBirthMonth.Name = "lblBirthMonth";
            this.lblBirthMonth.Size = new System.Drawing.Size(26, 18);
            this.lblBirthMonth.TabIndex = 1;
            this.lblBirthMonth.Text = "월";
            // 
            // tbxBirthDay
            // 
            this.tbxBirthDay.Location = new System.Drawing.Point(551, 82);
            this.tbxBirthDay.Name = "tbxBirthDay";
            this.tbxBirthDay.Size = new System.Drawing.Size(73, 28);
            this.tbxBirthDay.TabIndex = 0;
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Location = new System.Drawing.Point(640, 90);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(26, 18);
            this.lblBirthDay.TabIndex = 1;
            this.lblBirthDay.Text = "일";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(27, 144);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 18);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "소속학과";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(164, 144);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(500, 26);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // lblAdvisor
            // 
            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Location = new System.Drawing.Point(27, 202);
            this.lblAdvisor.Name = "lblAdvisor";
            this.lblAdvisor.Size = new System.Drawing.Size(80, 18);
            this.lblAdvisor.TabIndex = 1;
            this.lblAdvisor.Text = "지도교수";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(27, 261);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 18);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "학년";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(164, 258);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(135, 26);
            this.cmbYear.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(391, 261);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 18);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "분반";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(500, 258);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(164, 26);
            this.cmbClass.TabIndex = 3;
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Location = new System.Drawing.Point(27, 320);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(80, 18);
            this.lblRegStatus.TabIndex = 1;
            this.lblRegStatus.Text = "재적상태";
            // 
            // cmbRegStatus
            // 
            this.cmbRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegStatus.FormattingEnabled = true;
            this.cmbRegStatus.Location = new System.Drawing.Point(164, 316);
            this.cmbRegStatus.Name = "cmbRegStatus";
            this.cmbRegStatus.Size = new System.Drawing.Size(135, 26);
            this.cmbRegStatus.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(27, 374);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(44, 18);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "주소";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(164, 370);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(500, 28);
            this.tbxAddress.TabIndex = 0;
            // 
            // tbxContact
            // 
            this.tbxContact.Location = new System.Drawing.Point(164, 428);
            this.tbxContact.Name = "tbxContact";
            this.tbxContact.Size = new System.Drawing.Size(500, 28);
            this.tbxContact.TabIndex = 0;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(27, 430);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(62, 18);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "연락처";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 18;
            this.lbxList.Location = new System.Drawing.Point(690, 202);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(243, 148);
            this.lbxList.TabIndex = 2;
            // 
            // lbxDictionary
            // 
            this.lbxDictionary.FormattingEnabled = true;
            this.lbxDictionary.ItemHeight = 18;
            this.lbxDictionary.Location = new System.Drawing.Point(690, 370);
            this.lbxDictionary.Name = "lbxDictionary";
            this.lbxDictionary.Size = new System.Drawing.Size(243, 202);
            this.lbxDictionary.TabIndex = 2;
            this.lbxDictionary.SelectedIndexChanged += new System.EventHandler(this.lbxDictionary_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(30, 494);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(119, 80);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "신규";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(164, 494);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(500, 80);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "등록";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpgDepartment);
            this.tabMain.Controls.Add(this.tpgProfessor);
            this.tabMain.Controls.Add(this.tpgStudent);
            this.tabMain.Controls.Add(this.tpgTestScore);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(64, 30);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(987, 668);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tpgDepartment
            // 
            this.tpgDepartment.Controls.Add(this.btnRemoveDepartment);
            this.tpgDepartment.Controls.Add(this.btnRegisterDepartment);
            this.tpgDepartment.Controls.Add(this.lbxDepartment);
            this.tpgDepartment.Controls.Add(this.label1);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentCode);
            this.tpgDepartment.Controls.Add(this.tbxDepartmentName);
            this.tpgDepartment.Controls.Add(this.label2);
            this.tpgDepartment.Location = new System.Drawing.Point(4, 34);
            this.tpgDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgDepartment.Name = "tpgDepartment";
            this.tpgDepartment.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgDepartment.Size = new System.Drawing.Size(979, 630);
            this.tpgDepartment.TabIndex = 0;
            this.tpgDepartment.Text = "학과정보";
            this.tpgDepartment.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(813, 500);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(103, 80);
            this.btnRemoveDepartment.TabIndex = 7;
            this.btnRemoveDepartment.Text = "삭제";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnRegisterDepartment
            // 
            this.btnRegisterDepartment.Location = new System.Drawing.Point(334, 24);
            this.btnRegisterDepartment.Name = "btnRegisterDepartment";
            this.btnRegisterDepartment.Size = new System.Drawing.Size(103, 80);
            this.btnRegisterDepartment.TabIndex = 7;
            this.btnRegisterDepartment.Text = "등록";
            this.btnRegisterDepartment.UseVisualStyleBackColor = true;
            this.btnRegisterDepartment.Click += new System.EventHandler(this.btnRegisterDepartment_Click);
            // 
            // lbxDepartment
            // 
            this.lbxDepartment.FormattingEnabled = true;
            this.lbxDepartment.ItemHeight = 18;
            this.lbxDepartment.Location = new System.Drawing.Point(39, 130);
            this.lbxDepartment.Name = "lbxDepartment";
            this.lbxDepartment.Size = new System.Drawing.Size(875, 346);
            this.lbxDepartment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "학과코드";
            // 
            // tbxDepartmentCode
            // 
            this.tbxDepartmentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDepartmentCode.Location = new System.Drawing.Point(131, 24);
            this.tbxDepartmentCode.Name = "tbxDepartmentCode";
            this.tbxDepartmentCode.Size = new System.Drawing.Size(173, 28);
            this.tbxDepartmentCode.TabIndex = 2;
            this.tbxDepartmentCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDepartmentCode_KeyDown);
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(131, 70);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(173, 28);
            this.tbxDepartmentName.TabIndex = 3;
            this.tbxDepartmentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDepartmentName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "학과이름";
            // 
            // tpgProfessor
            // 
            this.tpgProfessor.Controls.Add(this.cmbProfessorDepartment);
            this.tpgProfessor.Controls.Add(this.label5);
            this.tpgProfessor.Controls.Add(this.btnRemoveProfessor);
            this.tpgProfessor.Controls.Add(this.btnRegisterProfessor);
            this.tpgProfessor.Controls.Add(this.lbxProfessor);
            this.tpgProfessor.Controls.Add(this.lblProfessorNumber);
            this.tpgProfessor.Controls.Add(this.tbxProfessorNumber);
            this.tpgProfessor.Controls.Add(this.tbxProfessorName);
            this.tpgProfessor.Controls.Add(this.lblProfessorName);
            this.tpgProfessor.Location = new System.Drawing.Point(4, 34);
            this.tpgProfessor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgProfessor.Name = "tpgProfessor";
            this.tpgProfessor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgProfessor.Size = new System.Drawing.Size(979, 630);
            this.tpgProfessor.TabIndex = 1;
            this.tpgProfessor.Text = "교수정보";
            this.tpgProfessor.UseVisualStyleBackColor = true;
            // 
            // cmbProfessorDepartment
            // 
            this.cmbProfessorDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessorDepartment.FormattingEnabled = true;
            this.cmbProfessorDepartment.Location = new System.Drawing.Point(124, 22);
            this.cmbProfessorDepartment.Name = "cmbProfessorDepartment";
            this.cmbProfessorDepartment.Size = new System.Drawing.Size(304, 26);
            this.cmbProfessorDepartment.TabIndex = 16;
            this.cmbProfessorDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbProfessorDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "소속학과";
            // 
            // btnRemoveProfessor
            // 
            this.btnRemoveProfessor.Location = new System.Drawing.Point(806, 531);
            this.btnRemoveProfessor.Name = "btnRemoveProfessor";
            this.btnRemoveProfessor.Size = new System.Drawing.Size(103, 44);
            this.btnRemoveProfessor.TabIndex = 13;
            this.btnRemoveProfessor.Text = "삭제";
            this.btnRemoveProfessor.UseVisualStyleBackColor = true;
            this.btnRemoveProfessor.Click += new System.EventHandler(this.btnRemoveProfessor_Click);
            // 
            // btnRegisterProfessor
            // 
            this.btnRegisterProfessor.Location = new System.Drawing.Point(327, 70);
            this.btnRegisterProfessor.Name = "btnRegisterProfessor";
            this.btnRegisterProfessor.Size = new System.Drawing.Size(103, 80);
            this.btnRegisterProfessor.TabIndex = 14;
            this.btnRegisterProfessor.Text = "등록";
            this.btnRegisterProfessor.UseVisualStyleBackColor = true;
            this.btnRegisterProfessor.Click += new System.EventHandler(this.btnRegisterProfessor_Click);
            // 
            // lbxProfessor
            // 
            this.lbxProfessor.FormattingEnabled = true;
            this.lbxProfessor.ItemHeight = 18;
            this.lbxProfessor.Location = new System.Drawing.Point(31, 177);
            this.lbxProfessor.Name = "lbxProfessor";
            this.lbxProfessor.Size = new System.Drawing.Size(875, 346);
            this.lbxProfessor.TabIndex = 12;
            // 
            // lblProfessorNumber
            // 
            this.lblProfessorNumber.AutoSize = true;
            this.lblProfessorNumber.Location = new System.Drawing.Point(29, 74);
            this.lblProfessorNumber.Name = "lblProfessorNumber";
            this.lblProfessorNumber.Size = new System.Drawing.Size(80, 18);
            this.lblProfessorNumber.TabIndex = 10;
            this.lblProfessorNumber.Text = "교수번호";
            // 
            // tbxProfessorNumber
            // 
            this.tbxProfessorNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxProfessorNumber.Location = new System.Drawing.Point(124, 70);
            this.tbxProfessorNumber.Name = "tbxProfessorNumber";
            this.tbxProfessorNumber.Size = new System.Drawing.Size(173, 28);
            this.tbxProfessorNumber.TabIndex = 8;
            this.tbxProfessorNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxProfessorNumber_KeyDown);
            // 
            // tbxProfessorName
            // 
            this.tbxProfessorName.Location = new System.Drawing.Point(124, 117);
            this.tbxProfessorName.Name = "tbxProfessorName";
            this.tbxProfessorName.Size = new System.Drawing.Size(173, 28);
            this.tbxProfessorName.TabIndex = 9;
            this.tbxProfessorName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxProfessorName_KeyDown);
            // 
            // lblProfessorName
            // 
            this.lblProfessorName.AutoSize = true;
            this.lblProfessorName.Location = new System.Drawing.Point(29, 120);
            this.lblProfessorName.Name = "lblProfessorName";
            this.lblProfessorName.Size = new System.Drawing.Size(80, 18);
            this.lblProfessorName.TabIndex = 11;
            this.lblProfessorName.Text = "교수이름";
            // 
            // tpgStudent
            // 
            this.tpgStudent.Controls.Add(this.lblNumber);
            this.tpgStudent.Controls.Add(this.btnRegister);
            this.tpgStudent.Controls.Add(this.tbxNumber);
            this.tpgStudent.Controls.Add(this.btnNew);
            this.tpgStudent.Controls.Add(this.tbxBirthYear);
            this.tpgStudent.Controls.Add(this.cmbClass);
            this.tpgStudent.Controls.Add(this.cmbRegStatus);
            this.tpgStudent.Controls.Add(this.tbxAddress);
            this.tpgStudent.Controls.Add(this.cmbYear);
            this.tpgStudent.Controls.Add(this.tbxBirthMonth);
            this.tpgStudent.Controls.Add(this.cmbAdvisor);
            this.tpgStudent.Controls.Add(this.cmbDepartment);
            this.tpgStudent.Controls.Add(this.tbxContact);
            this.tpgStudent.Controls.Add(this.lbxDictionary);
            this.tpgStudent.Controls.Add(this.tbxBirthDay);
            this.tpgStudent.Controls.Add(this.lbxList);
            this.tpgStudent.Controls.Add(this.tbxName);
            this.tpgStudent.Controls.Add(this.lbxArray);
            this.tpgStudent.Controls.Add(this.lblBirth);
            this.tpgStudent.Controls.Add(this.lblName);
            this.tpgStudent.Controls.Add(this.lblDepartment);
            this.tpgStudent.Controls.Add(this.lblBirthDay);
            this.tpgStudent.Controls.Add(this.lblAdvisor);
            this.tpgStudent.Controls.Add(this.lblBirthMonth);
            this.tpgStudent.Controls.Add(this.lblYear);
            this.tpgStudent.Controls.Add(this.lblClass);
            this.tpgStudent.Controls.Add(this.lblRegStatus);
            this.tpgStudent.Controls.Add(this.lblBirthYear);
            this.tpgStudent.Controls.Add(this.lblAddress);
            this.tpgStudent.Controls.Add(this.lblContact);
            this.tpgStudent.Location = new System.Drawing.Point(4, 34);
            this.tpgStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgStudent.Name = "tpgStudent";
            this.tpgStudent.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgStudent.Size = new System.Drawing.Size(979, 630);
            this.tpgStudent.TabIndex = 2;
            this.tpgStudent.Text = "학생정보";
            this.tpgStudent.UseVisualStyleBackColor = true;
            // 
            // cmbAdvisor
            // 
            this.cmbAdvisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvisor.FormattingEnabled = true;
            this.cmbAdvisor.Location = new System.Drawing.Point(163, 200);
            this.cmbAdvisor.Name = "cmbAdvisor";
            this.cmbAdvisor.Size = new System.Drawing.Size(500, 26);
            this.cmbAdvisor.TabIndex = 3;
            // 
            // tpgTestScore
            // 
            this.tpgTestScore.Controls.Add(this.btnFileTest);
            this.tpgTestScore.Controls.Add(this.btnTestRegScore);
            this.tpgTestScore.Controls.Add(this.btnTestSearchStudent);
            this.tpgTestScore.Controls.Add(this.lblTestCourse9Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse6Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse3Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse8Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse5Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse2Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse7Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse4Title);
            this.tpgTestScore.Controls.Add(this.lblTestCourse1Title);
            this.tpgTestScore.Controls.Add(this.tbxTestScore9);
            this.tpgTestScore.Controls.Add(this.tbxTestScore6);
            this.tpgTestScore.Controls.Add(this.lblTestNumberTitle);
            this.tpgTestScore.Controls.Add(this.tbxTestScore8);
            this.tpgTestScore.Controls.Add(this.tbxTestScore5);
            this.tpgTestScore.Controls.Add(this.tbxTestScore3);
            this.tpgTestScore.Controls.Add(this.tbxTestScore7);
            this.tpgTestScore.Controls.Add(this.tbxTestScore4);
            this.tpgTestScore.Controls.Add(this.tbxTestScore2);
            this.tpgTestScore.Controls.Add(this.tbxTestScore1);
            this.tpgTestScore.Controls.Add(this.tbxTestNumber);
            this.tpgTestScore.Controls.Add(this.lblTestAverage);
            this.tpgTestScore.Controls.Add(this.lblTestAverageTitle);
            this.tpgTestScore.Controls.Add(this.lblTestTotalCount);
            this.tpgTestScore.Controls.Add(this.lblTestTotalCountTitle);
            this.tpgTestScore.Controls.Add(this.lblTestName);
            this.tpgTestScore.Controls.Add(this.lblTestNameTitle);
            this.tpgTestScore.Location = new System.Drawing.Point(4, 34);
            this.tpgTestScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgTestScore.Name = "tpgTestScore";
            this.tpgTestScore.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgTestScore.Size = new System.Drawing.Size(979, 630);
            this.tpgTestScore.TabIndex = 3;
            this.tpgTestScore.Text = "성적처리(TEST)";
            this.tpgTestScore.UseVisualStyleBackColor = true;
            // 
            // btnTestRegScore
            // 
            this.btnTestRegScore.Location = new System.Drawing.Point(380, 402);
            this.btnTestRegScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestRegScore.Name = "btnTestRegScore";
            this.btnTestRegScore.Size = new System.Drawing.Size(94, 72);
            this.btnTestRegScore.TabIndex = 41;
            this.btnTestRegScore.Text = "수정 및 완료";
            this.btnTestRegScore.UseVisualStyleBackColor = true;
            // 
            // btnTestSearchStudent
            // 
            this.btnTestSearchStudent.Location = new System.Drawing.Point(381, 32);
            this.btnTestSearchStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestSearchStudent.Name = "btnTestSearchStudent";
            this.btnTestSearchStudent.Size = new System.Drawing.Size(94, 72);
            this.btnTestSearchStudent.TabIndex = 40;
            this.btnTestSearchStudent.Text = "검색";
            this.btnTestSearchStudent.UseVisualStyleBackColor = true;
            this.btnTestSearchStudent.Click += new System.EventHandler(this.btnTestSearchStudent_Click);
            // 
            // lblTestCourse9Title
            // 
            this.lblTestCourse9Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse9Title.Location = new System.Drawing.Point(29, 442);
            this.lblTestCourse9Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse9Title.Name = "lblTestCourse9Title";
            this.lblTestCourse9Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse9Title.TabIndex = 15;
            this.lblTestCourse9Title.Text = "과목 9";
            this.lblTestCourse9Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse6Title
            // 
            this.lblTestCourse6Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse6Title.Location = new System.Drawing.Point(29, 321);
            this.lblTestCourse6Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse6Title.Name = "lblTestCourse6Title";
            this.lblTestCourse6Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse6Title.TabIndex = 16;
            this.lblTestCourse6Title.Text = "과목 6";
            this.lblTestCourse6Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse3Title
            // 
            this.lblTestCourse3Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse3Title.Location = new System.Drawing.Point(29, 196);
            this.lblTestCourse3Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse3Title.Name = "lblTestCourse3Title";
            this.lblTestCourse3Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse3Title.TabIndex = 17;
            this.lblTestCourse3Title.Text = "과목 3";
            this.lblTestCourse3Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse8Title
            // 
            this.lblTestCourse8Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse8Title.Location = new System.Drawing.Point(29, 402);
            this.lblTestCourse8Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse8Title.Name = "lblTestCourse8Title";
            this.lblTestCourse8Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse8Title.TabIndex = 18;
            this.lblTestCourse8Title.Text = "과목 8";
            this.lblTestCourse8Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse5Title
            // 
            this.lblTestCourse5Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse5Title.Location = new System.Drawing.Point(29, 280);
            this.lblTestCourse5Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse5Title.Name = "lblTestCourse5Title";
            this.lblTestCourse5Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse5Title.TabIndex = 19;
            this.lblTestCourse5Title.Text = "과목 5";
            this.lblTestCourse5Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse2Title
            // 
            this.lblTestCourse2Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse2Title.Location = new System.Drawing.Point(29, 156);
            this.lblTestCourse2Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse2Title.Name = "lblTestCourse2Title";
            this.lblTestCourse2Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse2Title.TabIndex = 20;
            this.lblTestCourse2Title.Text = "과목 2";
            this.lblTestCourse2Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse7Title
            // 
            this.lblTestCourse7Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse7Title.Location = new System.Drawing.Point(29, 362);
            this.lblTestCourse7Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse7Title.Name = "lblTestCourse7Title";
            this.lblTestCourse7Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse7Title.TabIndex = 21;
            this.lblTestCourse7Title.Text = "과목 7";
            this.lblTestCourse7Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse4Title
            // 
            this.lblTestCourse4Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse4Title.Location = new System.Drawing.Point(29, 240);
            this.lblTestCourse4Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse4Title.Name = "lblTestCourse4Title";
            this.lblTestCourse4Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse4Title.TabIndex = 22;
            this.lblTestCourse4Title.Text = "과목 4";
            this.lblTestCourse4Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestCourse1Title
            // 
            this.lblTestCourse1Title.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestCourse1Title.Location = new System.Drawing.Point(29, 116);
            this.lblTestCourse1Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestCourse1Title.Name = "lblTestCourse1Title";
            this.lblTestCourse1Title.Size = new System.Drawing.Size(160, 32);
            this.lblTestCourse1Title.TabIndex = 23;
            this.lblTestCourse1Title.Text = "과목 1";
            this.lblTestCourse1Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTestScore9
            // 
            this.tbxTestScore9.Location = new System.Drawing.Point(213, 444);
            this.tbxTestScore9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore9.Name = "tbxTestScore9";
            this.tbxTestScore9.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore9.TabIndex = 29;
            this.tbxTestScore9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore6
            // 
            this.tbxTestScore6.Location = new System.Drawing.Point(213, 322);
            this.tbxTestScore6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore6.Name = "tbxTestScore6";
            this.tbxTestScore6.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore6.TabIndex = 31;
            this.tbxTestScore6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTestNumberTitle
            // 
            this.lblTestNumberTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestNumberTitle.Location = new System.Drawing.Point(29, 30);
            this.lblTestNumberTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestNumberTitle.Name = "lblTestNumberTitle";
            this.lblTestNumberTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTestNumberTitle.TabIndex = 14;
            this.lblTestNumberTitle.Text = "학번";
            this.lblTestNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTestScore8
            // 
            this.tbxTestScore8.Location = new System.Drawing.Point(213, 404);
            this.tbxTestScore8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore8.Name = "tbxTestScore8";
            this.tbxTestScore8.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore8.TabIndex = 30;
            this.tbxTestScore8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore5
            // 
            this.tbxTestScore5.Location = new System.Drawing.Point(213, 282);
            this.tbxTestScore5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore5.Name = "tbxTestScore5";
            this.tbxTestScore5.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore5.TabIndex = 33;
            this.tbxTestScore5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore3
            // 
            this.tbxTestScore3.Location = new System.Drawing.Point(213, 198);
            this.tbxTestScore3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore3.Name = "tbxTestScore3";
            this.tbxTestScore3.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore3.TabIndex = 28;
            this.tbxTestScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore7
            // 
            this.tbxTestScore7.Location = new System.Drawing.Point(213, 363);
            this.tbxTestScore7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore7.Name = "tbxTestScore7";
            this.tbxTestScore7.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore7.TabIndex = 27;
            this.tbxTestScore7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore4
            // 
            this.tbxTestScore4.Location = new System.Drawing.Point(213, 242);
            this.tbxTestScore4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore4.Name = "tbxTestScore4";
            this.tbxTestScore4.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore4.TabIndex = 26;
            this.tbxTestScore4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore2
            // 
            this.tbxTestScore2.Location = new System.Drawing.Point(213, 158);
            this.tbxTestScore2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore2.Name = "tbxTestScore2";
            this.tbxTestScore2.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore2.TabIndex = 25;
            this.tbxTestScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestScore1
            // 
            this.tbxTestScore1.Location = new System.Drawing.Point(213, 117);
            this.tbxTestScore1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestScore1.Name = "tbxTestScore1";
            this.tbxTestScore1.Size = new System.Drawing.Size(141, 28);
            this.tbxTestScore1.TabIndex = 24;
            this.tbxTestScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTestNumber
            // 
            this.tbxTestNumber.Location = new System.Drawing.Point(214, 32);
            this.tbxTestNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTestNumber.Name = "tbxTestNumber";
            this.tbxTestNumber.Size = new System.Drawing.Size(141, 28);
            this.tbxTestNumber.TabIndex = 32;
            // 
            // lblTestAverage
            // 
            this.lblTestAverage.BackColor = System.Drawing.Color.White;
            this.lblTestAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestAverage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestAverage.Location = new System.Drawing.Point(681, 444);
            this.lblTestAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestAverage.Name = "lblTestAverage";
            this.lblTestAverage.Size = new System.Drawing.Size(142, 30);
            this.lblTestAverage.TabIndex = 39;
            this.lblTestAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestAverageTitle
            // 
            this.lblTestAverageTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestAverageTitle.Location = new System.Drawing.Point(497, 442);
            this.lblTestAverageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestAverageTitle.Name = "lblTestAverageTitle";
            this.lblTestAverageTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTestAverageTitle.TabIndex = 36;
            this.lblTestAverageTitle.Text = "평균";
            this.lblTestAverageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestTotalCount
            // 
            this.lblTestTotalCount.BackColor = System.Drawing.Color.White;
            this.lblTestTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestTotalCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestTotalCount.Location = new System.Drawing.Point(681, 406);
            this.lblTestTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestTotalCount.Name = "lblTestTotalCount";
            this.lblTestTotalCount.Size = new System.Drawing.Size(142, 30);
            this.lblTestTotalCount.TabIndex = 34;
            this.lblTestTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestTotalCountTitle
            // 
            this.lblTestTotalCountTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestTotalCountTitle.Location = new System.Drawing.Point(497, 405);
            this.lblTestTotalCountTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestTotalCountTitle.Name = "lblTestTotalCountTitle";
            this.lblTestTotalCountTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTestTotalCountTitle.TabIndex = 35;
            this.lblTestTotalCountTitle.Text = "총과목";
            this.lblTestTotalCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestName
            // 
            this.lblTestName.BackColor = System.Drawing.Color.White;
            this.lblTestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestName.Location = new System.Drawing.Point(213, 72);
            this.lblTestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(142, 30);
            this.lblTestName.TabIndex = 38;
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTestNameTitle
            // 
            this.lblTestNameTitle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTestNameTitle.Location = new System.Drawing.Point(29, 70);
            this.lblTestNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestNameTitle.Name = "lblTestNameTitle";
            this.lblTestNameTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTestNameTitle.TabIndex = 37;
            this.lblTestNameTitle.Text = "이름";
            this.lblTestNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFileTest
            // 
            this.btnFileTest.Location = new System.Drawing.Point(699, 288);
            this.btnFileTest.Name = "btnFileTest";
            this.btnFileTest.Size = new System.Drawing.Size(163, 37);
            this.btnFileTest.TabIndex = 42;
            this.btnFileTest.Text = "파일입출력테스트";
            this.btnFileTest.UseVisualStyleBackColor = true;
            this.btnFileTest.Click += new System.EventHandler(this.btnFileTest_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 668);
            this.Controls.Add(this.tabMain);
            this.Name = "FormManager";
            this.Text = "학생관리";
            this.tabMain.ResumeLayout(false);
            this.tpgDepartment.ResumeLayout(false);
            this.tpgDepartment.PerformLayout();
            this.tpgProfessor.ResumeLayout(false);
            this.tpgProfessor.PerformLayout();
            this.tpgStudent.ResumeLayout(false);
            this.tpgStudent.PerformLayout();
            this.tpgTestScore.ResumeLayout(false);
            this.tpgTestScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lbxArray;
        private System.Windows.Forms.TextBox tbxBirthYear;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox tbxBirthMonth;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.Label lblBirthMonth;
        private System.Windows.Forms.TextBox tbxBirthDay;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblAdvisor;
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
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpgDepartment;
        private System.Windows.Forms.TabPage tpgProfessor;
        private System.Windows.Forms.TabPage tpgStudent;
        private System.Windows.Forms.Button btnRegisterDepartment;
        private System.Windows.Forms.ListBox lbxDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDepartmentCode;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.ComboBox cmbProfessorDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveProfessor;
        private System.Windows.Forms.Button btnRegisterProfessor;
        private System.Windows.Forms.ListBox lbxProfessor;
        private System.Windows.Forms.Label lblProfessorNumber;
        private System.Windows.Forms.TextBox tbxProfessorNumber;
        private System.Windows.Forms.TextBox tbxProfessorName;
        private System.Windows.Forms.Label lblProfessorName;
        private System.Windows.Forms.ComboBox cmbAdvisor;
        private System.Windows.Forms.TabPage tpgTestScore;
        private System.Windows.Forms.Button btnTestRegScore;
        private System.Windows.Forms.Button btnTestSearchStudent;
        private System.Windows.Forms.Label lblTestCourse9Title;
        private System.Windows.Forms.Label lblTestCourse6Title;
        private System.Windows.Forms.Label lblTestCourse3Title;
        private System.Windows.Forms.Label lblTestCourse8Title;
        private System.Windows.Forms.Label lblTestCourse5Title;
        private System.Windows.Forms.Label lblTestCourse2Title;
        private System.Windows.Forms.Label lblTestCourse7Title;
        private System.Windows.Forms.Label lblTestCourse4Title;
        private System.Windows.Forms.Label lblTestCourse1Title;
        private System.Windows.Forms.TextBox tbxTestScore9;
        private System.Windows.Forms.TextBox tbxTestScore6;
        private System.Windows.Forms.Label lblTestNumberTitle;
        private System.Windows.Forms.TextBox tbxTestScore8;
        private System.Windows.Forms.TextBox tbxTestScore5;
        private System.Windows.Forms.TextBox tbxTestScore3;
        private System.Windows.Forms.TextBox tbxTestScore7;
        private System.Windows.Forms.TextBox tbxTestScore4;
        private System.Windows.Forms.TextBox tbxTestScore2;
        private System.Windows.Forms.TextBox tbxTestScore1;
        private System.Windows.Forms.TextBox tbxTestNumber;
        private System.Windows.Forms.Label lblTestAverage;
        private System.Windows.Forms.Label lblTestAverageTitle;
        private System.Windows.Forms.Label lblTestTotalCount;
        private System.Windows.Forms.Label lblTestTotalCountTitle;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label lblTestNameTitle;
        private System.Windows.Forms.Button btnFileTest;
    }
}

