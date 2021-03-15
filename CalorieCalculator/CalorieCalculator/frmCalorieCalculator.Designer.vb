<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalorieCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblActivityLevel = New System.Windows.Forms.Label()
        Me.lblBFM = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.cboActivityLevel = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.lblInches = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblGeneralInfo = New System.Windows.Forms.Label()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblWaist = New System.Windows.Forms.Label()
        Me.txtWaist = New System.Windows.Forms.TextBox()
        Me.txtWrist = New System.Windows.Forms.TextBox()
        Me.lblWrist = New System.Windows.Forms.Label()
        Me.txtHip = New System.Windows.Forms.TextBox()
        Me.lblHip = New System.Windows.Forms.Label()
        Me.txtForearm = New System.Windows.Forms.TextBox()
        Me.lblForearm = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lbxUsers = New System.Windows.Forms.ListBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblRMR = New System.Windows.Forms.Label()
        Me.lblUserGender = New System.Windows.Forms.Label()
        Me.lblUserHeight = New System.Windows.Forms.Label()
        Me.lblUserWeight = New System.Windows.Forms.Label()
        Me.lblUserAge = New System.Windows.Forms.Label()
        Me.lbleActivityRMR = New System.Windows.Forms.Label()
        Me.lblUserActivity = New System.Windows.Forms.Label()
        Me.lblBodyFatPercent = New System.Windows.Forms.Label()
        Me.lblBodyFatPercentStat = New System.Windows.Forms.Label()
        Me.lblActivityStat = New System.Windows.Forms.Label()
        Me.lblActivityRMRStat = New System.Windows.Forms.Label()
        Me.lblNameStat = New System.Windows.Forms.Label()
        Me.lblRMRStat = New System.Windows.Forms.Label()
        Me.lblGenderStat = New System.Windows.Forms.Label()
        Me.lblHeightStat = New System.Windows.Forms.Label()
        Me.lblWeightStat = New System.Windows.Forms.Label()
        Me.lblAgeStat = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblAtFullestPoint = New System.Windows.Forms.Label()
        Me.lblAtNaval = New System.Windows.Forms.Label()
        Me.lblFitIDStat = New System.Windows.Forms.Label()
        Me.lblFitID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(20, 107)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(46, 20)
        Me.lblAge.TabIndex = 7
        Me.lblAge.Text = "Age:"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(20, 155)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(70, 20)
        Me.lblWeight.TabIndex = 8
        Me.lblWeight.Text = "Weight:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(20, 203)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(67, 20)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "Height:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(20, 258)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(74, 20)
        Me.lblSex.TabIndex = 10
        Me.lblSex.Text = "Gender:"
        '
        'lblActivityLevel
        '
        Me.lblActivityLevel.AutoSize = True
        Me.lblActivityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityLevel.Location = New System.Drawing.Point(20, 308)
        Me.lblActivityLevel.Name = "lblActivityLevel"
        Me.lblActivityLevel.Size = New System.Drawing.Size(118, 20)
        Me.lblActivityLevel.TabIndex = 11
        Me.lblActivityLevel.Text = "Activity Level:"
        '
        'lblBFM
        '
        Me.lblBFM.AutoSize = True
        Me.lblBFM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBFM.Location = New System.Drawing.Point(12, 419)
        Me.lblBFM.Name = "lblBFM"
        Me.lblBFM.Size = New System.Drawing.Size(204, 20)
        Me.lblBFM.TabIndex = 12
        Me.lblBFM.Text = "Body Fat Measurements"
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(156, 106)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(278, 22)
        Me.txtAge.TabIndex = 1
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(156, 205)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(278, 22)
        Me.txtHeight.TabIndex = 3
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(156, 155)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(278, 22)
        Me.txtWeight.TabIndex = 2
        '
        'cboSex
        '
        Me.cboSex.BackColor = System.Drawing.Color.LightGray
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(156, 258)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(158, 24)
        Me.cboSex.TabIndex = 4
        '
        'cboActivityLevel
        '
        Me.cboActivityLevel.BackColor = System.Drawing.Color.LightGray
        Me.cboActivityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActivityLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboActivityLevel.FormattingEnabled = True
        Me.cboActivityLevel.Location = New System.Drawing.Point(156, 307)
        Me.cboActivityLevel.Name = "cboActivityLevel"
        Me.cboActivityLevel.Size = New System.Drawing.Size(362, 24)
        Me.cboActivityLevel.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(86, 355)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(130, 31)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.SkyBlue
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(244, 355)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 31)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPounds.Location = New System.Drawing.Point(449, 155)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(69, 20)
        Me.lblPounds.TabIndex = 14
        Me.lblPounds.Text = "Pounds"
        '
        'lblInches
        '
        Me.lblInches.AutoSize = True
        Me.lblInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInches.Location = New System.Drawing.Point(449, 203)
        Me.lblInches.Name = "lblInches"
        Me.lblInches.Size = New System.Drawing.Size(63, 20)
        Me.lblInches.TabIndex = 15
        Me.lblInches.Text = "Inches"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.Location = New System.Drawing.Point(449, 107)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(56, 20)
        Me.lblYears.TabIndex = 13
        Me.lblYears.Text = "Years"
        '
        'lblGeneralInfo
        '
        Me.lblGeneralInfo.AutoSize = True
        Me.lblGeneralInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneralInfo.Location = New System.Drawing.Point(12, 20)
        Me.lblGeneralInfo.Name = "lblGeneralInfo"
        Me.lblGeneralInfo.Size = New System.Drawing.Size(170, 20)
        Me.lblGeneralInfo.TabIndex = 16
        Me.lblGeneralInfo.Text = "General Information"
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.Location = New System.Drawing.Point(536, 20)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(160, 20)
        Me.lblCurrentUser.TabIndex = 17
        Me.lblCurrentUser.Text = "Current User Stats"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(94, 20)
        Me.lblName.TabIndex = 18
        Me.lblName.Text = "Full Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(156, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(278, 22)
        Me.txtName.TabIndex = 0
        '
        'lblWaist
        '
        Me.lblWaist.AutoSize = True
        Me.lblWaist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaist.Location = New System.Drawing.Point(20, 482)
        Me.lblWaist.Name = "lblWaist"
        Me.lblWaist.Size = New System.Drawing.Size(59, 20)
        Me.lblWaist.TabIndex = 20
        Me.lblWaist.Text = "Waist:"
        '
        'txtWaist
        '
        Me.txtWaist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWaist.Location = New System.Drawing.Point(106, 480)
        Me.txtWaist.Name = "txtWaist"
        Me.txtWaist.Size = New System.Drawing.Size(166, 22)
        Me.txtWaist.TabIndex = 6
        '
        'txtWrist
        '
        Me.txtWrist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWrist.Location = New System.Drawing.Point(106, 572)
        Me.txtWrist.Name = "txtWrist"
        Me.txtWrist.Size = New System.Drawing.Size(166, 22)
        Me.txtWrist.TabIndex = 7
        '
        'lblWrist
        '
        Me.lblWrist.AutoSize = True
        Me.lblWrist.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrist.Location = New System.Drawing.Point(20, 574)
        Me.lblWrist.Name = "lblWrist"
        Me.lblWrist.Size = New System.Drawing.Size(55, 20)
        Me.lblWrist.TabIndex = 23
        Me.lblWrist.Text = "Wrist:"
        '
        'txtHip
        '
        Me.txtHip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHip.Location = New System.Drawing.Point(106, 614)
        Me.txtHip.Name = "txtHip"
        Me.txtHip.Size = New System.Drawing.Size(166, 22)
        Me.txtHip.TabIndex = 8
        '
        'lblHip
        '
        Me.lblHip.AutoSize = True
        Me.lblHip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHip.Location = New System.Drawing.Point(20, 614)
        Me.lblHip.Name = "lblHip"
        Me.lblHip.Size = New System.Drawing.Size(41, 20)
        Me.lblHip.TabIndex = 25
        Me.lblHip.Text = "Hip:"
        '
        'txtForearm
        '
        Me.txtForearm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForearm.Location = New System.Drawing.Point(106, 660)
        Me.txtForearm.Name = "txtForearm"
        Me.txtForearm.Size = New System.Drawing.Size(166, 22)
        Me.txtForearm.TabIndex = 9
        '
        'lblForearm
        '
        Me.lblForearm.AutoSize = True
        Me.lblForearm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForearm.Location = New System.Drawing.Point(20, 660)
        Me.lblForearm.Name = "lblForearm"
        Me.lblForearm.Size = New System.Drawing.Size(81, 20)
        Me.lblForearm.TabIndex = 27
        Me.lblForearm.Text = "Forearm:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(291, 419)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(56, 20)
        Me.lblUser.TabIndex = 28
        Me.lblUser.Text = "Users"
        '
        'lbxUsers
        '
        Me.lbxUsers.FormattingEnabled = True
        Me.lbxUsers.Location = New System.Drawing.Point(296, 449)
        Me.lbxUsers.Name = "lbxUsers"
        Me.lbxUsers.Size = New System.Drawing.Size(222, 238)
        Me.lbxUsers.TabIndex = 12
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(563, 118)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 20)
        Me.lblUserName.TabIndex = 34
        Me.lblUserName.Text = "Name:"
        '
        'lblRMR
        '
        Me.lblRMR.AutoSize = True
        Me.lblRMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRMR.Location = New System.Drawing.Point(566, 408)
        Me.lblRMR.Name = "lblRMR"
        Me.lblRMR.Size = New System.Drawing.Size(54, 20)
        Me.lblRMR.TabIndex = 33
        Me.lblRMR.Text = "RMR:"
        '
        'lblUserGender
        '
        Me.lblUserGender.AutoSize = True
        Me.lblUserGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserGender.Location = New System.Drawing.Point(566, 349)
        Me.lblUserGender.Name = "lblUserGender"
        Me.lblUserGender.Size = New System.Drawing.Size(74, 20)
        Me.lblUserGender.TabIndex = 32
        Me.lblUserGender.Text = "Gender:"
        '
        'lblUserHeight
        '
        Me.lblUserHeight.AutoSize = True
        Me.lblUserHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserHeight.Location = New System.Drawing.Point(566, 284)
        Me.lblUserHeight.Name = "lblUserHeight"
        Me.lblUserHeight.Size = New System.Drawing.Size(67, 20)
        Me.lblUserHeight.TabIndex = 31
        Me.lblUserHeight.Text = "Height:"
        '
        'lblUserWeight
        '
        Me.lblUserWeight.AutoSize = True
        Me.lblUserWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserWeight.Location = New System.Drawing.Point(566, 228)
        Me.lblUserWeight.Name = "lblUserWeight"
        Me.lblUserWeight.Size = New System.Drawing.Size(70, 20)
        Me.lblUserWeight.TabIndex = 30
        Me.lblUserWeight.Text = "Weight:"
        '
        'lblUserAge
        '
        Me.lblUserAge.AutoSize = True
        Me.lblUserAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAge.Location = New System.Drawing.Point(566, 174)
        Me.lblUserAge.Name = "lblUserAge"
        Me.lblUserAge.Size = New System.Drawing.Size(46, 20)
        Me.lblUserAge.TabIndex = 29
        Me.lblUserAge.Text = "Age:"
        '
        'lbleActivityRMR
        '
        Me.lbleActivityRMR.AutoSize = True
        Me.lbleActivityRMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleActivityRMR.Location = New System.Drawing.Point(566, 471)
        Me.lbleActivityRMR.Name = "lbleActivityRMR"
        Me.lbleActivityRMR.Size = New System.Drawing.Size(116, 20)
        Me.lbleActivityRMR.TabIndex = 35
        Me.lbleActivityRMR.Text = "Activity RMR:"
        '
        'lblUserActivity
        '
        Me.lblUserActivity.AutoSize = True
        Me.lblUserActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserActivity.Location = New System.Drawing.Point(563, 523)
        Me.lblUserActivity.Name = "lblUserActivity"
        Me.lblUserActivity.Size = New System.Drawing.Size(71, 20)
        Me.lblUserActivity.TabIndex = 36
        Me.lblUserActivity.Text = "Activity:"
        '
        'lblBodyFatPercent
        '
        Me.lblBodyFatPercent.AutoSize = True
        Me.lblBodyFatPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFatPercent.Location = New System.Drawing.Point(563, 579)
        Me.lblBodyFatPercent.Name = "lblBodyFatPercent"
        Me.lblBodyFatPercent.Size = New System.Drawing.Size(106, 20)
        Me.lblBodyFatPercent.TabIndex = 37
        Me.lblBodyFatPercent.Text = "Body Fat %:"
        '
        'lblBodyFatPercentStat
        '
        Me.lblBodyFatPercentStat.AutoSize = True
        Me.lblBodyFatPercentStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBodyFatPercentStat.Location = New System.Drawing.Point(700, 579)
        Me.lblBodyFatPercentStat.Name = "lblBodyFatPercentStat"
        Me.lblBodyFatPercentStat.Size = New System.Drawing.Size(16, 20)
        Me.lblBodyFatPercentStat.TabIndex = 46
        Me.lblBodyFatPercentStat.Text = "*"
        '
        'lblActivityStat
        '
        Me.lblActivityStat.AutoSize = True
        Me.lblActivityStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityStat.Location = New System.Drawing.Point(700, 523)
        Me.lblActivityStat.Name = "lblActivityStat"
        Me.lblActivityStat.Size = New System.Drawing.Size(16, 20)
        Me.lblActivityStat.TabIndex = 45
        Me.lblActivityStat.Text = "*"
        '
        'lblActivityRMRStat
        '
        Me.lblActivityRMRStat.AutoSize = True
        Me.lblActivityRMRStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActivityRMRStat.Location = New System.Drawing.Point(700, 469)
        Me.lblActivityRMRStat.Name = "lblActivityRMRStat"
        Me.lblActivityRMRStat.Size = New System.Drawing.Size(16, 20)
        Me.lblActivityRMRStat.TabIndex = 44
        Me.lblActivityRMRStat.Text = "*"
        '
        'lblNameStat
        '
        Me.lblNameStat.AutoSize = True
        Me.lblNameStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameStat.Location = New System.Drawing.Point(697, 116)
        Me.lblNameStat.Name = "lblNameStat"
        Me.lblNameStat.Size = New System.Drawing.Size(16, 20)
        Me.lblNameStat.TabIndex = 43
        Me.lblNameStat.Text = "*"
        '
        'lblRMRStat
        '
        Me.lblRMRStat.AutoSize = True
        Me.lblRMRStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRMRStat.Location = New System.Drawing.Point(700, 406)
        Me.lblRMRStat.Name = "lblRMRStat"
        Me.lblRMRStat.Size = New System.Drawing.Size(16, 20)
        Me.lblRMRStat.TabIndex = 42
        Me.lblRMRStat.Text = "*"
        '
        'lblGenderStat
        '
        Me.lblGenderStat.AutoSize = True
        Me.lblGenderStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderStat.Location = New System.Drawing.Point(700, 347)
        Me.lblGenderStat.Name = "lblGenderStat"
        Me.lblGenderStat.Size = New System.Drawing.Size(16, 20)
        Me.lblGenderStat.TabIndex = 41
        Me.lblGenderStat.Text = "*"
        '
        'lblHeightStat
        '
        Me.lblHeightStat.AutoSize = True
        Me.lblHeightStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightStat.Location = New System.Drawing.Point(700, 282)
        Me.lblHeightStat.Name = "lblHeightStat"
        Me.lblHeightStat.Size = New System.Drawing.Size(16, 20)
        Me.lblHeightStat.TabIndex = 40
        Me.lblHeightStat.Text = "*"
        '
        'lblWeightStat
        '
        Me.lblWeightStat.AutoSize = True
        Me.lblWeightStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightStat.Location = New System.Drawing.Point(700, 226)
        Me.lblWeightStat.Name = "lblWeightStat"
        Me.lblWeightStat.Size = New System.Drawing.Size(16, 20)
        Me.lblWeightStat.TabIndex = 39
        Me.lblWeightStat.Text = "*"
        '
        'lblAgeStat
        '
        Me.lblAgeStat.AutoSize = True
        Me.lblAgeStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeStat.Location = New System.Drawing.Point(697, 174)
        Me.lblAgeStat.Name = "lblAgeStat"
        Me.lblAgeStat.Size = New System.Drawing.Size(16, 20)
        Me.lblAgeStat.TabIndex = 38
        Me.lblAgeStat.Text = "*"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SkyBlue
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(392, 355)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(126, 31)
        Me.btnDelete.TabIndex = 47
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblAtFullestPoint
        '
        Me.lblAtFullestPoint.AutoSize = True
        Me.lblAtFullestPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtFullestPoint.Location = New System.Drawing.Point(12, 534)
        Me.lblAtFullestPoint.Name = "lblAtFullestPoint"
        Me.lblAtFullestPoint.Size = New System.Drawing.Size(144, 20)
        Me.lblAtFullestPoint.TabIndex = 48
        Me.lblAtFullestPoint.Text = "(At Fullest Point)"
        '
        'lblAtNaval
        '
        Me.lblAtNaval.AutoSize = True
        Me.lblAtNaval.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtNaval.Location = New System.Drawing.Point(12, 449)
        Me.lblAtNaval.Name = "lblAtNaval"
        Me.lblAtNaval.Size = New System.Drawing.Size(88, 20)
        Me.lblAtNaval.TabIndex = 49
        Me.lblAtNaval.Text = "(At Naval)"
        '
        'lblFitIDStat
        '
        Me.lblFitIDStat.AutoSize = True
        Me.lblFitIDStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFitIDStat.Location = New System.Drawing.Point(697, 67)
        Me.lblFitIDStat.Name = "lblFitIDStat"
        Me.lblFitIDStat.Size = New System.Drawing.Size(16, 20)
        Me.lblFitIDStat.TabIndex = 52
        Me.lblFitIDStat.Text = "*"
        '
        'lblFitID
        '
        Me.lblFitID.AutoSize = True
        Me.lblFitID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFitID.Location = New System.Drawing.Point(563, 67)
        Me.lblFitID.Name = "lblFitID"
        Me.lblFitID.Size = New System.Drawing.Size(97, 20)
        Me.lblFitID.TabIndex = 51
        Me.lblFitID.Text = "Fitness ID:"
        '
        'frmCalorieCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1140, 705)
        Me.Controls.Add(Me.lblFitIDStat)
        Me.Controls.Add(Me.lblFitID)
        Me.Controls.Add(Me.lblAtNaval)
        Me.Controls.Add(Me.lblAtFullestPoint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblBodyFatPercentStat)
        Me.Controls.Add(Me.lblActivityStat)
        Me.Controls.Add(Me.lblActivityRMRStat)
        Me.Controls.Add(Me.lblNameStat)
        Me.Controls.Add(Me.lblRMRStat)
        Me.Controls.Add(Me.lblGenderStat)
        Me.Controls.Add(Me.lblHeightStat)
        Me.Controls.Add(Me.lblWeightStat)
        Me.Controls.Add(Me.lblAgeStat)
        Me.Controls.Add(Me.lblBodyFatPercent)
        Me.Controls.Add(Me.lblUserActivity)
        Me.Controls.Add(Me.lbleActivityRMR)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblRMR)
        Me.Controls.Add(Me.lblUserGender)
        Me.Controls.Add(Me.lblUserHeight)
        Me.Controls.Add(Me.lblUserWeight)
        Me.Controls.Add(Me.lblUserAge)
        Me.Controls.Add(Me.lbxUsers)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtForearm)
        Me.Controls.Add(Me.lblForearm)
        Me.Controls.Add(Me.txtHip)
        Me.Controls.Add(Me.lblHip)
        Me.Controls.Add(Me.txtWrist)
        Me.Controls.Add(Me.lblWrist)
        Me.Controls.Add(Me.txtWaist)
        Me.Controls.Add(Me.lblWaist)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblCurrentUser)
        Me.Controls.Add(Me.lblGeneralInfo)
        Me.Controls.Add(Me.lblInches)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cboActivityLevel)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblBFM)
        Me.Controls.Add(Me.lblActivityLevel)
        Me.Controls.Add(Me.lblSex)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblAge)
        Me.Name = "frmCalorieCalculator"
        Me.Text = "Fitness Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAge As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblActivityLevel As Label
    Friend WithEvents lblBFM As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents cboActivityLevel As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPounds As Label
    Friend WithEvents lblInches As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents lblGeneralInfo As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblWaist As Label
    Friend WithEvents txtWaist As TextBox
    Friend WithEvents txtWrist As TextBox
    Friend WithEvents lblWrist As Label
    Friend WithEvents txtHip As TextBox
    Friend WithEvents lblHip As Label
    Friend WithEvents txtForearm As TextBox
    Friend WithEvents lblForearm As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lbxUsers As ListBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblRMR As Label
    Friend WithEvents lblUserGender As Label
    Friend WithEvents lblUserHeight As Label
    Friend WithEvents lblUserWeight As Label
    Friend WithEvents lblUserAge As Label
    Friend WithEvents lbleActivityRMR As Label
    Friend WithEvents lblUserActivity As Label
    Friend WithEvents lblBodyFatPercent As Label
    Friend WithEvents lblBodyFatPercentStat As Label
    Friend WithEvents lblActivityStat As Label
    Friend WithEvents lblActivityRMRStat As Label
    Friend WithEvents lblNameStat As Label
    Friend WithEvents lblRMRStat As Label
    Friend WithEvents lblGenderStat As Label
    Friend WithEvents lblHeightStat As Label
    Friend WithEvents lblWeightStat As Label
    Friend WithEvents lblAgeStat As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblAtFullestPoint As Label
    Friend WithEvents lblAtNaval As Label
    Friend WithEvents lblFitIDStat As Label
    Friend WithEvents lblFitID As Label
End Class
