namespace Proj_FinancialLedger_202001098
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxYearSet = new System.Windows.Forms.GroupBox();
            this.tbxTargetAmount = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gbxCurrentState = new System.Windows.Forms.GroupBox();
            this.lblIsBlack = new System.Windows.Forms.Label();
            this.lblIs = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lbl434 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalExpenditure = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lbl231 = new System.Windows.Forms.Label();
            this.gbxRegIncome = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegIncome = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbxIncomeDay = new System.Windows.Forms.TextBox();
            this.tbxIncomeMonth = new System.Windows.Forms.TextBox();
            this.tbxIncomeMoney = new System.Windows.Forms.TextBox();
            this.tbxIncomeContent = new System.Windows.Forms.TextBox();
            this.tbxIncomeYear = new System.Windows.Forms.TextBox();
            this.grbRegExpenditure = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRegExpenditure = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxExpenditureDay = new System.Windows.Forms.TextBox();
            this.tbxExpenditureMonth = new System.Windows.Forms.TextBox();
            this.tbxExpenditureMoney = new System.Windows.Forms.TextBox();
            this.tbxExpenditureContent = new System.Windows.Forms.TextBox();
            this.tbxExpenditureYear = new System.Windows.Forms.TextBox();
            this.gbxFastReg = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnFastRegExpenditure = new System.Windows.Forms.Button();
            this.btnFastRegIncome = new System.Windows.Forms.Button();
            this.tbxFastMoney = new System.Windows.Forms.TextBox();
            this.tbxFastContent = new System.Windows.Forms.TextBox();
            this.tapMain = new System.Windows.Forms.TabControl();
            this.tpgIncome = new System.Windows.Forms.TabPage();
            this.lbxIncome = new System.Windows.Forms.ListBox();
            this.tpgExpenditure = new System.Windows.Forms.TabPage();
            this.lbxExpenditure = new System.Windows.Forms.ListBox();
            this.tpgAll = new System.Windows.Forms.TabPage();
            this.lbxAll = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxYearSet.SuspendLayout();
            this.gbxCurrentState.SuspendLayout();
            this.gbxRegIncome.SuspendLayout();
            this.grbRegExpenditure.SuspendLayout();
            this.gbxFastReg.SuspendLayout();
            this.tapMain.SuspendLayout();
            this.tpgIncome.SuspendLayout();
            this.tpgExpenditure.SuspendLayout();
            this.tpgAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "가계부 관리 시스템";
            // 
            // gbxYearSet
            // 
            this.gbxYearSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbxYearSet.Controls.Add(this.tbxTargetAmount);
            this.gbxYearSet.Controls.Add(this.tbxYear);
            this.gbxYearSet.Controls.Add(this.lblTargetAmount);
            this.gbxYearSet.Controls.Add(this.lblYear);
            this.gbxYearSet.Controls.Add(this.btnStore);
            this.gbxYearSet.Controls.Add(this.btnRestore);
            this.gbxYearSet.Controls.Add(this.btnReset);
            this.gbxYearSet.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxYearSet.Location = new System.Drawing.Point(43, 104);
            this.gbxYearSet.Margin = new System.Windows.Forms.Padding(4);
            this.gbxYearSet.Name = "gbxYearSet";
            this.gbxYearSet.Padding = new System.Windows.Forms.Padding(4);
            this.gbxYearSet.Size = new System.Drawing.Size(590, 166);
            this.gbxYearSet.TabIndex = 1;
            this.gbxYearSet.TabStop = false;
            this.gbxYearSet.Text = "연도 설정";
            // 
            // tbxTargetAmount
            // 
            this.tbxTargetAmount.Location = new System.Drawing.Point(89, 90);
            this.tbxTargetAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTargetAmount.Name = "tbxTargetAmount";
            this.tbxTargetAmount.Size = new System.Drawing.Size(145, 28);
            this.tbxTargetAmount.TabIndex = 1;
            this.tbxTargetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(89, 38);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(113, 28);
            this.tbxYear.TabIndex = 0;
            this.tbxYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Location = new System.Drawing.Point(16, 94);
            this.lblTargetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(70, 21);
            this.lblTargetAmount.TabIndex = 2;
            this.lblTargetAmount.Text = "목표액:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 42);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 21);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "연도:";
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStore.Location = new System.Drawing.Point(302, 82);
            this.btnStore.Margin = new System.Windows.Forms.Padding(4);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(123, 44);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "저장하기";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestore.Location = new System.Drawing.Point(431, 82);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(123, 44);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "불러오기";
            this.btnRestore.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(302, 30);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(251, 44);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "신규(초기화)";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // gbxCurrentState
            // 
            this.gbxCurrentState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxCurrentState.Controls.Add(this.lblIsBlack);
            this.gbxCurrentState.Controls.Add(this.lblIs);
            this.gbxCurrentState.Controls.Add(this.lblA);
            this.gbxCurrentState.Controls.Add(this.lbl434);
            this.gbxCurrentState.Controls.Add(this.lblTotalAmount);
            this.gbxCurrentState.Controls.Add(this.lblTotalExpenditure);
            this.gbxCurrentState.Controls.Add(this.lblTotalIncome);
            this.gbxCurrentState.Controls.Add(this.lbl231);
            this.gbxCurrentState.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxCurrentState.Location = new System.Drawing.Point(867, 104);
            this.gbxCurrentState.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCurrentState.Name = "gbxCurrentState";
            this.gbxCurrentState.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCurrentState.Size = new System.Drawing.Size(462, 166);
            this.gbxCurrentState.TabIndex = 2;
            this.gbxCurrentState.TabStop = false;
            this.gbxCurrentState.Text = "현재 상태";
            // 
            // lblIsBlack
            // 
            this.lblIsBlack.AutoSize = true;
            this.lblIsBlack.Location = new System.Drawing.Point(399, 69);
            this.lblIsBlack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsBlack.Name = "lblIsBlack";
            this.lblIsBlack.Size = new System.Drawing.Size(16, 21);
            this.lblIsBlack.TabIndex = 0;
            this.lblIsBlack.Text = " ";
            // 
            // lblIs
            // 
            this.lblIs.AutoSize = true;
            this.lblIs.Location = new System.Drawing.Point(342, 69);
            this.lblIs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIs.Name = "lblIs";
            this.lblIs.Size = new System.Drawing.Size(58, 21);
            this.lblIs.TabIndex = 0;
            this.lblIs.Text = "상태 :";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(23, 104);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(58, 21);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "잔액 :";
            // 
            // lbl434
            // 
            this.lbl434.AutoSize = true;
            this.lbl434.ForeColor = System.Drawing.Color.Red;
            this.lbl434.Location = new System.Drawing.Point(21, 69);
            this.lbl434.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl434.Name = "lbl434";
            this.lbl434.Size = new System.Drawing.Size(82, 21);
            this.lbl434.TabIndex = 0;
            this.lbl434.Text = "총 지출 :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(81, 104);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(22, 21);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "0";
            // 
            // lblTotalExpenditure
            // 
            this.lblTotalExpenditure.AutoSize = true;
            this.lblTotalExpenditure.ForeColor = System.Drawing.Color.Red;
            this.lblTotalExpenditure.Location = new System.Drawing.Point(101, 70);
            this.lblTotalExpenditure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExpenditure.Name = "lblTotalExpenditure";
            this.lblTotalExpenditure.Size = new System.Drawing.Size(22, 21);
            this.lblTotalExpenditure.TabIndex = 0;
            this.lblTotalExpenditure.Text = "0";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalIncome.Location = new System.Drawing.Point(100, 39);
            this.lblTotalIncome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(22, 21);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "0";
            // 
            // lbl231
            // 
            this.lbl231.AutoSize = true;
            this.lbl231.ForeColor = System.Drawing.Color.Blue;
            this.lbl231.Location = new System.Drawing.Point(21, 38);
            this.lbl231.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl231.Name = "lbl231";
            this.lbl231.Size = new System.Drawing.Size(88, 21);
            this.lbl231.TabIndex = 0;
            this.lbl231.Text = "총 수입 : ";
            // 
            // gbxRegIncome
            // 
            this.gbxRegIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxRegIncome.Controls.Add(this.label15);
            this.gbxRegIncome.Controls.Add(this.label4);
            this.gbxRegIncome.Controls.Add(this.label3);
            this.gbxRegIncome.Controls.Add(this.label2);
            this.gbxRegIncome.Controls.Add(this.label7);
            this.gbxRegIncome.Controls.Add(this.label6);
            this.gbxRegIncome.Controls.Add(this.label5);
            this.gbxRegIncome.Controls.Add(this.btnRegIncome);
            this.gbxRegIncome.Controls.Add(this.lblDate);
            this.gbxRegIncome.Controls.Add(this.tbxIncomeDay);
            this.gbxRegIncome.Controls.Add(this.tbxIncomeMonth);
            this.gbxRegIncome.Controls.Add(this.tbxIncomeMoney);
            this.gbxRegIncome.Controls.Add(this.tbxIncomeContent);
            this.gbxRegIncome.Controls.Add(this.tbxIncomeYear);
            this.gbxRegIncome.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxRegIncome.Location = new System.Drawing.Point(43, 298);
            this.gbxRegIncome.Margin = new System.Windows.Forms.Padding(4);
            this.gbxRegIncome.Name = "gbxRegIncome";
            this.gbxRegIncome.Padding = new System.Windows.Forms.Padding(4);
            this.gbxRegIncome.Size = new System.Drawing.Size(423, 212);
            this.gbxRegIncome.TabIndex = 3;
            this.gbxRegIncome.TabStop = false;
            this.gbxRegIncome.Text = "수입 등록";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Green;
            this.label15.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(135, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 34);
            this.label15.TabIndex = 4;
            this.label15.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "월";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "년";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "금액:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "내역:";
            // 
            // btnRegIncome
            // 
            this.btnRegIncome.BackColor = System.Drawing.Color.Green;
            this.btnRegIncome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegIncome.Location = new System.Drawing.Point(71, 147);
            this.btnRegIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegIncome.Name = "btnRegIncome";
            this.btnRegIncome.Size = new System.Drawing.Size(251, 57);
            this.btnRegIncome.TabIndex = 10;
            this.btnRegIncome.Text = "     수입 등록";
            this.btnRegIncome.UseVisualStyleBackColor = false;
            this.btnRegIncome.Click += new System.EventHandler(this.btnRegIncome_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(16, 39);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "날짜:";
            // 
            // tbxIncomeDay
            // 
            this.tbxIncomeDay.Location = new System.Drawing.Point(299, 30);
            this.tbxIncomeDay.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIncomeDay.Name = "tbxIncomeDay";
            this.tbxIncomeDay.Size = new System.Drawing.Size(47, 28);
            this.tbxIncomeDay.TabIndex = 7;
            this.tbxIncomeDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxIncomeMonth
            // 
            this.tbxIncomeMonth.Location = new System.Drawing.Point(203, 30);
            this.tbxIncomeMonth.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIncomeMonth.Name = "tbxIncomeMonth";
            this.tbxIncomeMonth.Size = new System.Drawing.Size(47, 28);
            this.tbxIncomeMonth.TabIndex = 6;
            this.tbxIncomeMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxIncomeMoney
            // 
            this.tbxIncomeMoney.Location = new System.Drawing.Point(71, 106);
            this.tbxIncomeMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIncomeMoney.Name = "tbxIncomeMoney";
            this.tbxIncomeMoney.Size = new System.Drawing.Size(178, 28);
            this.tbxIncomeMoney.TabIndex = 9;
            this.tbxIncomeMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxIncomeContent
            // 
            this.tbxIncomeContent.Location = new System.Drawing.Point(71, 70);
            this.tbxIncomeContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIncomeContent.Name = "tbxIncomeContent";
            this.tbxIncomeContent.Size = new System.Drawing.Size(310, 28);
            this.tbxIncomeContent.TabIndex = 8;
            // 
            // tbxIncomeYear
            // 
            this.tbxIncomeYear.Location = new System.Drawing.Point(71, 30);
            this.tbxIncomeYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbxIncomeYear.Name = "tbxIncomeYear";
            this.tbxIncomeYear.Size = new System.Drawing.Size(88, 28);
            this.tbxIncomeYear.TabIndex = 5;
            this.tbxIncomeYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grbRegExpenditure
            // 
            this.grbRegExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbRegExpenditure.Controls.Add(this.label16);
            this.grbRegExpenditure.Controls.Add(this.label8);
            this.grbRegExpenditure.Controls.Add(this.label9);
            this.grbRegExpenditure.Controls.Add(this.label10);
            this.grbRegExpenditure.Controls.Add(this.label11);
            this.grbRegExpenditure.Controls.Add(this.label12);
            this.grbRegExpenditure.Controls.Add(this.label13);
            this.grbRegExpenditure.Controls.Add(this.btnRegExpenditure);
            this.grbRegExpenditure.Controls.Add(this.label14);
            this.grbRegExpenditure.Controls.Add(this.tbxExpenditureDay);
            this.grbRegExpenditure.Controls.Add(this.tbxExpenditureMonth);
            this.grbRegExpenditure.Controls.Add(this.tbxExpenditureMoney);
            this.grbRegExpenditure.Controls.Add(this.tbxExpenditureContent);
            this.grbRegExpenditure.Controls.Add(this.tbxExpenditureYear);
            this.grbRegExpenditure.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grbRegExpenditure.Location = new System.Drawing.Point(474, 298);
            this.grbRegExpenditure.Margin = new System.Windows.Forms.Padding(4);
            this.grbRegExpenditure.Name = "grbRegExpenditure";
            this.grbRegExpenditure.Padding = new System.Windows.Forms.Padding(4);
            this.grbRegExpenditure.Size = new System.Drawing.Size(423, 212);
            this.grbRegExpenditure.TabIndex = 4;
            this.grbRegExpenditure.TabStop = false;
            this.grbRegExpenditure.Text = "지출 등록";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Red;
            this.label16.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(131, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 36);
            this.label16.TabIndex = 4;
            this.label16.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "월";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "년";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "원";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "금액:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "내역:";
            // 
            // btnRegExpenditure
            // 
            this.btnRegExpenditure.BackColor = System.Drawing.Color.Red;
            this.btnRegExpenditure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegExpenditure.Location = new System.Drawing.Point(71, 147);
            this.btnRegExpenditure.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegExpenditure.Name = "btnRegExpenditure";
            this.btnRegExpenditure.Size = new System.Drawing.Size(251, 57);
            this.btnRegExpenditure.TabIndex = 16;
            this.btnRegExpenditure.Text = "     지출 등록";
            this.btnRegExpenditure.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 39);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "날짜:";
            // 
            // tbxExpenditureDay
            // 
            this.tbxExpenditureDay.Location = new System.Drawing.Point(299, 30);
            this.tbxExpenditureDay.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExpenditureDay.Name = "tbxExpenditureDay";
            this.tbxExpenditureDay.Size = new System.Drawing.Size(47, 28);
            this.tbxExpenditureDay.TabIndex = 13;
            this.tbxExpenditureDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxExpenditureMonth
            // 
            this.tbxExpenditureMonth.Location = new System.Drawing.Point(203, 30);
            this.tbxExpenditureMonth.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExpenditureMonth.Name = "tbxExpenditureMonth";
            this.tbxExpenditureMonth.Size = new System.Drawing.Size(47, 28);
            this.tbxExpenditureMonth.TabIndex = 12;
            this.tbxExpenditureMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxExpenditureMoney
            // 
            this.tbxExpenditureMoney.Location = new System.Drawing.Point(71, 106);
            this.tbxExpenditureMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExpenditureMoney.Name = "tbxExpenditureMoney";
            this.tbxExpenditureMoney.Size = new System.Drawing.Size(178, 28);
            this.tbxExpenditureMoney.TabIndex = 15;
            this.tbxExpenditureMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxExpenditureContent
            // 
            this.tbxExpenditureContent.Location = new System.Drawing.Point(71, 70);
            this.tbxExpenditureContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExpenditureContent.Name = "tbxExpenditureContent";
            this.tbxExpenditureContent.Size = new System.Drawing.Size(310, 28);
            this.tbxExpenditureContent.TabIndex = 14;
            // 
            // tbxExpenditureYear
            // 
            this.tbxExpenditureYear.Location = new System.Drawing.Point(71, 30);
            this.tbxExpenditureYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExpenditureYear.Name = "tbxExpenditureYear";
            this.tbxExpenditureYear.Size = new System.Drawing.Size(88, 28);
            this.tbxExpenditureYear.TabIndex = 11;
            this.tbxExpenditureYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbxFastReg
            // 
            this.gbxFastReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxFastReg.Controls.Add(this.label21);
            this.gbxFastReg.Controls.Add(this.label17);
            this.gbxFastReg.Controls.Add(this.label18);
            this.gbxFastReg.Controls.Add(this.label19);
            this.gbxFastReg.Controls.Add(this.label20);
            this.gbxFastReg.Controls.Add(this.btnFastRegExpenditure);
            this.gbxFastReg.Controls.Add(this.btnFastRegIncome);
            this.gbxFastReg.Controls.Add(this.tbxFastMoney);
            this.gbxFastReg.Controls.Add(this.tbxFastContent);
            this.gbxFastReg.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbxFastReg.Location = new System.Drawing.Point(906, 298);
            this.gbxFastReg.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFastReg.Name = "gbxFastReg";
            this.gbxFastReg.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFastReg.Size = new System.Drawing.Size(423, 212);
            this.gbxFastReg.TabIndex = 5;
            this.gbxFastReg.TabStop = false;
            this.gbxFastReg.Text = "빠른 입력 (오늘날짜)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Red;
            this.label21.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(223, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 36);
            this.label21.TabIndex = 4;
            this.label21.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Green;
            this.label17.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(87, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 36);
            this.label17.TabIndex = 4;
            this.label17.Text = "+";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 102);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 21);
            this.label18.TabIndex = 1;
            this.label18.Text = "원";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 102);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 21);
            this.label19.TabIndex = 1;
            this.label19.Text = "금액:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 44);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 21);
            this.label20.TabIndex = 1;
            this.label20.Text = "내역:";
            // 
            // btnFastRegExpenditure
            // 
            this.btnFastRegExpenditure.BackColor = System.Drawing.Color.Red;
            this.btnFastRegExpenditure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFastRegExpenditure.Location = new System.Drawing.Point(204, 147);
            this.btnFastRegExpenditure.Margin = new System.Windows.Forms.Padding(4);
            this.btnFastRegExpenditure.Name = "btnFastRegExpenditure";
            this.btnFastRegExpenditure.Size = new System.Drawing.Size(124, 57);
            this.btnFastRegExpenditure.TabIndex = 20;
            this.btnFastRegExpenditure.Text = "    지출";
            this.btnFastRegExpenditure.UseVisualStyleBackColor = false;
            // 
            // btnFastRegIncome
            // 
            this.btnFastRegIncome.BackColor = System.Drawing.Color.Green;
            this.btnFastRegIncome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFastRegIncome.Location = new System.Drawing.Point(71, 147);
            this.btnFastRegIncome.Margin = new System.Windows.Forms.Padding(4);
            this.btnFastRegIncome.Name = "btnFastRegIncome";
            this.btnFastRegIncome.Size = new System.Drawing.Size(124, 57);
            this.btnFastRegIncome.TabIndex = 19;
            this.btnFastRegIncome.Text = "    수입";
            this.btnFastRegIncome.UseVisualStyleBackColor = false;
            // 
            // tbxFastMoney
            // 
            this.tbxFastMoney.Location = new System.Drawing.Point(71, 98);
            this.tbxFastMoney.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFastMoney.Name = "tbxFastMoney";
            this.tbxFastMoney.Size = new System.Drawing.Size(178, 28);
            this.tbxFastMoney.TabIndex = 18;
            this.tbxFastMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxFastContent
            // 
            this.tbxFastContent.Location = new System.Drawing.Point(71, 39);
            this.tbxFastContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFastContent.Name = "tbxFastContent";
            this.tbxFastContent.Size = new System.Drawing.Size(310, 28);
            this.tbxFastContent.TabIndex = 17;
            // 
            // tapMain
            // 
            this.tapMain.Controls.Add(this.tpgIncome);
            this.tapMain.Controls.Add(this.tpgExpenditure);
            this.tapMain.Controls.Add(this.tpgAll);
            this.tapMain.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tapMain.Location = new System.Drawing.Point(43, 542);
            this.tapMain.Margin = new System.Windows.Forms.Padding(4);
            this.tapMain.Name = "tapMain";
            this.tapMain.SelectedIndex = 0;
            this.tapMain.Size = new System.Drawing.Size(1286, 306);
            this.tapMain.TabIndex = 6;
            // 
            // tpgIncome
            // 
            this.tpgIncome.Controls.Add(this.lbxIncome);
            this.tpgIncome.Location = new System.Drawing.Point(4, 30);
            this.tpgIncome.Margin = new System.Windows.Forms.Padding(4);
            this.tpgIncome.Name = "tpgIncome";
            this.tpgIncome.Padding = new System.Windows.Forms.Padding(4);
            this.tpgIncome.Size = new System.Drawing.Size(1278, 272);
            this.tpgIncome.TabIndex = 0;
            this.tpgIncome.Text = "수입 내역";
            this.tpgIncome.UseVisualStyleBackColor = true;
            // 
            // lbxIncome
            // 
            this.lbxIncome.FormattingEnabled = true;
            this.lbxIncome.ItemHeight = 21;
            this.lbxIncome.Location = new System.Drawing.Point(8, 8);
            this.lbxIncome.Name = "lbxIncome";
            this.lbxIncome.Size = new System.Drawing.Size(1256, 256);
            this.lbxIncome.TabIndex = 0;
            // 
            // tpgExpenditure
            // 
            this.tpgExpenditure.Controls.Add(this.lbxExpenditure);
            this.tpgExpenditure.Location = new System.Drawing.Point(4, 30);
            this.tpgExpenditure.Margin = new System.Windows.Forms.Padding(4);
            this.tpgExpenditure.Name = "tpgExpenditure";
            this.tpgExpenditure.Padding = new System.Windows.Forms.Padding(4);
            this.tpgExpenditure.Size = new System.Drawing.Size(1278, 272);
            this.tpgExpenditure.TabIndex = 1;
            this.tpgExpenditure.Text = "지출 내역";
            this.tpgExpenditure.UseVisualStyleBackColor = true;
            // 
            // lbxExpenditure
            // 
            this.lbxExpenditure.FormattingEnabled = true;
            this.lbxExpenditure.ItemHeight = 21;
            this.lbxExpenditure.Location = new System.Drawing.Point(11, 9);
            this.lbxExpenditure.Name = "lbxExpenditure";
            this.lbxExpenditure.Size = new System.Drawing.Size(1256, 256);
            this.lbxExpenditure.TabIndex = 1;
            // 
            // tpgAll
            // 
            this.tpgAll.Controls.Add(this.lbxAll);
            this.tpgAll.Location = new System.Drawing.Point(4, 30);
            this.tpgAll.Margin = new System.Windows.Forms.Padding(4);
            this.tpgAll.Name = "tpgAll";
            this.tpgAll.Padding = new System.Windows.Forms.Padding(4);
            this.tpgAll.Size = new System.Drawing.Size(1278, 272);
            this.tpgAll.TabIndex = 2;
            this.tpgAll.Text = "전체 내역";
            this.tpgAll.UseVisualStyleBackColor = true;
            // 
            // lbxAll
            // 
            this.lbxAll.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbxAll.FormattingEnabled = true;
            this.lbxAll.ItemHeight = 21;
            this.lbxAll.Location = new System.Drawing.Point(11, 9);
            this.lbxAll.Name = "lbxAll";
            this.lbxAll.Size = new System.Drawing.Size(1256, 256);
            this.lbxAll.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1157, 868);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 40);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 930);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tapMain);
            this.Controls.Add(this.gbxFastReg);
            this.Controls.Add(this.grbRegExpenditure);
            this.Controls.Add(this.gbxRegIncome);
            this.Controls.Add(this.gbxCurrentState);
            this.Controls.Add(this.gbxYearSet);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "가계부 관리 시스템";
            this.gbxYearSet.ResumeLayout(false);
            this.gbxYearSet.PerformLayout();
            this.gbxCurrentState.ResumeLayout(false);
            this.gbxCurrentState.PerformLayout();
            this.gbxRegIncome.ResumeLayout(false);
            this.gbxRegIncome.PerformLayout();
            this.grbRegExpenditure.ResumeLayout(false);
            this.grbRegExpenditure.PerformLayout();
            this.gbxFastReg.ResumeLayout(false);
            this.gbxFastReg.PerformLayout();
            this.tapMain.ResumeLayout(false);
            this.tpgIncome.ResumeLayout(false);
            this.tpgExpenditure.ResumeLayout(false);
            this.tpgAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxYearSet;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxTargetAmount;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.GroupBox gbxCurrentState;
        private System.Windows.Forms.Label lbl434;
        private System.Windows.Forms.Label lbl231;
        private System.Windows.Forms.Label lblIs;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox gbxRegIncome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxIncomeDay;
        private System.Windows.Forms.TextBox tbxIncomeMonth;
        private System.Windows.Forms.TextBox tbxIncomeContent;
        private System.Windows.Forms.TextBox tbxIncomeYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegIncome;
        private System.Windows.Forms.TextBox tbxIncomeMoney;
        private System.Windows.Forms.GroupBox grbRegExpenditure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRegExpenditure;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxExpenditureDay;
        private System.Windows.Forms.TextBox tbxExpenditureMonth;
        private System.Windows.Forms.TextBox tbxExpenditureMoney;
        private System.Windows.Forms.TextBox tbxExpenditureContent;
        private System.Windows.Forms.TextBox tbxExpenditureYear;
        private System.Windows.Forms.GroupBox gbxFastReg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnFastRegIncome;
        private System.Windows.Forms.TextBox tbxFastMoney;
        private System.Windows.Forms.TextBox tbxFastContent;
        private System.Windows.Forms.Button btnFastRegExpenditure;
        private System.Windows.Forms.TabControl tapMain;
        private System.Windows.Forms.TabPage tpgIncome;
        private System.Windows.Forms.TabPage tpgExpenditure;
        private System.Windows.Forms.TabPage tpgAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTotalExpenditure;
        private System.Windows.Forms.Label lblIsBlack;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ListBox lbxIncome;
        private System.Windows.Forms.ListBox lbxExpenditure;
        private System.Windows.Forms.ListBox lbxAll;
    }
}

