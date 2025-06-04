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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalExpenditure = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.gbxRegIncome = new System.Windows.Forms.GroupBox();
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
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnFastRegIncome = new System.Windows.Forms.Button();
            this.tbxFastMoney = new System.Windows.Forms.TextBox();
            this.tbxFastContent = new System.Windows.Forms.TextBox();
            this.btnFastRegExpenditure = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxYearSet.SuspendLayout();
            this.gbxCurrentState.SuspendLayout();
            this.gbxRegIncome.SuspendLayout();
            this.grbRegExpenditure.SuspendLayout();
            this.gbxFastReg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
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
            this.gbxYearSet.Location = new System.Drawing.Point(30, 69);
            this.gbxYearSet.Name = "gbxYearSet";
            this.gbxYearSet.Size = new System.Drawing.Size(364, 111);
            this.gbxYearSet.TabIndex = 1;
            this.gbxYearSet.TabStop = false;
            this.gbxYearSet.Text = "연도 설정";
            // 
            // tbxTargetAmount
            // 
            this.tbxTargetAmount.Location = new System.Drawing.Point(62, 60);
            this.tbxTargetAmount.Name = "tbxTargetAmount";
            this.tbxTargetAmount.Size = new System.Drawing.Size(103, 21);
            this.tbxTargetAmount.TabIndex = 3;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(62, 25);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(80, 21);
            this.tbxYear.TabIndex = 3;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.AutoSize = true;
            this.lblTargetAmount.Location = new System.Drawing.Point(11, 63);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(45, 12);
            this.lblTargetAmount.TabIndex = 2;
            this.lblTargetAmount.Text = "목표액:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(11, 28);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 12);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "연도:";
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(182, 55);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(86, 29);
            this.btnStore.TabIndex = 0;
            this.btnStore.Text = "저장하기";
            this.btnStore.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(272, 55);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(86, 29);
            this.btnRestore.TabIndex = 0;
            this.btnRestore.Text = "불러오기";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(176, 29);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "신규(초기화)";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // gbxCurrentState
            // 
            this.gbxCurrentState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxCurrentState.Controls.Add(this.lblIsBlack);
            this.gbxCurrentState.Controls.Add(this.lblAmount);
            this.gbxCurrentState.Controls.Add(this.lblTotalExpenditure);
            this.gbxCurrentState.Controls.Add(this.lblTotalIncome);
            this.gbxCurrentState.Location = new System.Drawing.Point(402, 70);
            this.gbxCurrentState.Name = "gbxCurrentState";
            this.gbxCurrentState.Size = new System.Drawing.Size(246, 111);
            this.gbxCurrentState.TabIndex = 2;
            this.gbxCurrentState.TabStop = false;
            this.gbxCurrentState.Text = "현재 상태";
            // 
            // lblIsBlack
            // 
            this.lblIsBlack.AutoSize = true;
            this.lblIsBlack.Location = new System.Drawing.Point(148, 46);
            this.lblIsBlack.Name = "lblIsBlack";
            this.lblIsBlack.Size = new System.Drawing.Size(65, 12);
            this.lblIsBlack.TabIndex = 0;
            this.lblIsBlack.Text = "상태 : 흑자";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 69);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(59, 12);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "잔액 : 0원";
            // 
            // lblTotalExpenditure
            // 
            this.lblTotalExpenditure.AutoSize = true;
            this.lblTotalExpenditure.Location = new System.Drawing.Point(15, 46);
            this.lblTotalExpenditure.Name = "lblTotalExpenditure";
            this.lblTotalExpenditure.Size = new System.Drawing.Size(75, 12);
            this.lblTotalExpenditure.TabIndex = 0;
            this.lblTotalExpenditure.Text = "총 지출 : 0원";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Location = new System.Drawing.Point(15, 25);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(75, 12);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "총 수입 : 0원";
            // 
            // gbxRegIncome
            // 
            this.gbxRegIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.gbxRegIncome.Location = new System.Drawing.Point(30, 199);
            this.gbxRegIncome.Name = "gbxRegIncome";
            this.gbxRegIncome.Size = new System.Drawing.Size(296, 141);
            this.gbxRegIncome.TabIndex = 3;
            this.gbxRegIncome.TabStop = false;
            this.gbxRegIncome.Text = "수입 등록";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "월";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "년";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "금액:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "내역:";
            // 
            // btnRegIncome
            // 
            this.btnRegIncome.Location = new System.Drawing.Point(50, 98);
            this.btnRegIncome.Name = "btnRegIncome";
            this.btnRegIncome.Size = new System.Drawing.Size(176, 29);
            this.btnRegIncome.TabIndex = 0;
            this.btnRegIncome.Text = "수입 등록";
            this.btnRegIncome.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(11, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 12);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "날짜:";
            // 
            // tbxIncomeDay
            // 
            this.tbxIncomeDay.Location = new System.Drawing.Point(209, 20);
            this.tbxIncomeDay.Name = "tbxIncomeDay";
            this.tbxIncomeDay.Size = new System.Drawing.Size(34, 21);
            this.tbxIncomeDay.TabIndex = 3;
            // 
            // tbxIncomeMonth
            // 
            this.tbxIncomeMonth.Location = new System.Drawing.Point(142, 20);
            this.tbxIncomeMonth.Name = "tbxIncomeMonth";
            this.tbxIncomeMonth.Size = new System.Drawing.Size(34, 21);
            this.tbxIncomeMonth.TabIndex = 3;
            // 
            // tbxIncomeMoney
            // 
            this.tbxIncomeMoney.Location = new System.Drawing.Point(50, 71);
            this.tbxIncomeMoney.Name = "tbxIncomeMoney";
            this.tbxIncomeMoney.Size = new System.Drawing.Size(126, 21);
            this.tbxIncomeMoney.TabIndex = 3;
            // 
            // tbxIncomeContent
            // 
            this.tbxIncomeContent.Location = new System.Drawing.Point(50, 47);
            this.tbxIncomeContent.Name = "tbxIncomeContent";
            this.tbxIncomeContent.Size = new System.Drawing.Size(218, 21);
            this.tbxIncomeContent.TabIndex = 3;
            // 
            // tbxIncomeYear
            // 
            this.tbxIncomeYear.Location = new System.Drawing.Point(50, 20);
            this.tbxIncomeYear.Name = "tbxIncomeYear";
            this.tbxIncomeYear.Size = new System.Drawing.Size(63, 21);
            this.tbxIncomeYear.TabIndex = 3;
            // 
            // grbRegExpenditure
            // 
            this.grbRegExpenditure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.grbRegExpenditure.Location = new System.Drawing.Point(332, 199);
            this.grbRegExpenditure.Name = "grbRegExpenditure";
            this.grbRegExpenditure.Size = new System.Drawing.Size(296, 141);
            this.grbRegExpenditure.TabIndex = 4;
            this.grbRegExpenditure.TabStop = false;
            this.grbRegExpenditure.Text = "지출 등록";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "일";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(186, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "월";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "년";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(186, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "원";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "금액:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "내역:";
            // 
            // btnRegExpenditure
            // 
            this.btnRegExpenditure.Location = new System.Drawing.Point(50, 98);
            this.btnRegExpenditure.Name = "btnRegExpenditure";
            this.btnRegExpenditure.Size = new System.Drawing.Size(176, 29);
            this.btnRegExpenditure.TabIndex = 0;
            this.btnRegExpenditure.Text = "지출 등록";
            this.btnRegExpenditure.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "날짜:";
            // 
            // tbxExpenditureDay
            // 
            this.tbxExpenditureDay.Location = new System.Drawing.Point(209, 20);
            this.tbxExpenditureDay.Name = "tbxExpenditureDay";
            this.tbxExpenditureDay.Size = new System.Drawing.Size(34, 21);
            this.tbxExpenditureDay.TabIndex = 3;
            // 
            // tbxExpenditureMonth
            // 
            this.tbxExpenditureMonth.Location = new System.Drawing.Point(142, 20);
            this.tbxExpenditureMonth.Name = "tbxExpenditureMonth";
            this.tbxExpenditureMonth.Size = new System.Drawing.Size(34, 21);
            this.tbxExpenditureMonth.TabIndex = 3;
            // 
            // tbxExpenditureMoney
            // 
            this.tbxExpenditureMoney.Location = new System.Drawing.Point(50, 71);
            this.tbxExpenditureMoney.Name = "tbxExpenditureMoney";
            this.tbxExpenditureMoney.Size = new System.Drawing.Size(126, 21);
            this.tbxExpenditureMoney.TabIndex = 3;
            // 
            // tbxExpenditureContent
            // 
            this.tbxExpenditureContent.Location = new System.Drawing.Point(50, 47);
            this.tbxExpenditureContent.Name = "tbxExpenditureContent";
            this.tbxExpenditureContent.Size = new System.Drawing.Size(218, 21);
            this.tbxExpenditureContent.TabIndex = 3;
            // 
            // tbxExpenditureYear
            // 
            this.tbxExpenditureYear.Location = new System.Drawing.Point(50, 20);
            this.tbxExpenditureYear.Name = "tbxExpenditureYear";
            this.tbxExpenditureYear.Size = new System.Drawing.Size(63, 21);
            this.tbxExpenditureYear.TabIndex = 3;
            // 
            // gbxFastReg
            // 
            this.gbxFastReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxFastReg.Controls.Add(this.label18);
            this.gbxFastReg.Controls.Add(this.label19);
            this.gbxFastReg.Controls.Add(this.label20);
            this.gbxFastReg.Controls.Add(this.btnFastRegExpenditure);
            this.gbxFastReg.Controls.Add(this.btnFastRegIncome);
            this.gbxFastReg.Controls.Add(this.tbxFastMoney);
            this.gbxFastReg.Controls.Add(this.tbxFastContent);
            this.gbxFastReg.Location = new System.Drawing.Point(634, 199);
            this.gbxFastReg.Name = "gbxFastReg";
            this.gbxFastReg.Size = new System.Drawing.Size(296, 141);
            this.gbxFastReg.TabIndex = 5;
            this.gbxFastReg.TabStop = false;
            this.gbxFastReg.Text = "빠른 입력 (오늘날짜)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(186, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 1;
            this.label18.Text = "원";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "금액:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "내역:";
            // 
            // btnFastRegIncome
            // 
            this.btnFastRegIncome.Location = new System.Drawing.Point(50, 98);
            this.btnFastRegIncome.Name = "btnFastRegIncome";
            this.btnFastRegIncome.Size = new System.Drawing.Size(87, 29);
            this.btnFastRegIncome.TabIndex = 0;
            this.btnFastRegIncome.Text = "수입";
            this.btnFastRegIncome.UseVisualStyleBackColor = true;
            // 
            // tbxFastMoney
            // 
            this.tbxFastMoney.Location = new System.Drawing.Point(50, 65);
            this.tbxFastMoney.Name = "tbxFastMoney";
            this.tbxFastMoney.Size = new System.Drawing.Size(126, 21);
            this.tbxFastMoney.TabIndex = 3;
            // 
            // tbxFastContent
            // 
            this.tbxFastContent.Location = new System.Drawing.Point(50, 26);
            this.tbxFastContent.Name = "tbxFastContent";
            this.tbxFastContent.Size = new System.Drawing.Size(218, 21);
            this.tbxFastContent.TabIndex = 3;
            // 
            // btnFastRegExpenditure
            // 
            this.btnFastRegExpenditure.Location = new System.Drawing.Point(143, 98);
            this.btnFastRegExpenditure.Name = "btnFastRegExpenditure";
            this.btnFastRegExpenditure.Size = new System.Drawing.Size(87, 29);
            this.btnFastRegExpenditure.TabIndex = 0;
            this.btnFastRegExpenditure.Text = "지출";
            this.btnFastRegExpenditure.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(30, 361);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 197);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(892, 171);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(810, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 620);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbxFastReg);
            this.Controls.Add(this.grbRegExpenditure);
            this.Controls.Add(this.gbxRegIncome);
            this.Controls.Add(this.gbxCurrentState);
            this.Controls.Add(this.gbxYearSet);
            this.Controls.Add(this.label1);
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
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTotalExpenditure;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblIsBlack;
        private System.Windows.Forms.Label lblAmount;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExit;
    }
}

