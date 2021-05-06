<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCollege
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollege))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblNumberOfUnits = New System.Windows.Forms.Label()
        Me.grpCAmpus = New System.Windows.Forms.GroupBox()
        Me.rdbOnCampus = New System.Windows.Forms.RadioButton()
        Me.rdbOffCampus = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMajor = New System.Windows.Forms.ComboBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumberOfUnits = New System.Windows.Forms.MaskedTextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.grpHousingBoard = New System.Windows.Forms.GroupBox()
        Me.rdbJulianSultes = New System.Windows.Forms.RadioButton()
        Me.rdbCraigHall = New System.Windows.Forms.RadioButton()
        Me.rdbCooperDorm = New System.Windows.Forms.RadioButton()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCAmpus.SuspendLayout()
        Me.grpHousingBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.Navy
        Me.lblRegister.Location = New System.Drawing.Point(276, 46)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(332, 78)
        Me.lblRegister.TabIndex = 1
        Me.lblRegister.Text = "Register for Classes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bedford College"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.ForeColor = System.Drawing.Color.Navy
        Me.lblStudent.Location = New System.Drawing.Point(21, 198)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(91, 19)
        Me.lblStudent.TabIndex = 2
        Me.lblStudent.Text = "StudentID: "
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Navy
        Me.lblStudentName.Location = New System.Drawing.Point(21, 231)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(120, 19)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblNumberOfUnits
        '
        Me.lblNumberOfUnits.AutoSize = True
        Me.lblNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfUnits.ForeColor = System.Drawing.Color.Navy
        Me.lblNumberOfUnits.Location = New System.Drawing.Point(21, 267)
        Me.lblNumberOfUnits.Name = "lblNumberOfUnits"
        Me.lblNumberOfUnits.Size = New System.Drawing.Size(140, 19)
        Me.lblNumberOfUnits.TabIndex = 4
        Me.lblNumberOfUnits.Text = "Number Of Units: "
        '
        'grpCAmpus
        '
        Me.grpCAmpus.Controls.Add(Me.rdbOnCampus)
        Me.grpCAmpus.Controls.Add(Me.rdbOffCampus)
        Me.grpCAmpus.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCAmpus.ForeColor = System.Drawing.Color.Navy
        Me.grpCAmpus.Location = New System.Drawing.Point(25, 310)
        Me.grpCAmpus.Name = "grpCAmpus"
        Me.grpCAmpus.Size = New System.Drawing.Size(148, 86)
        Me.grpCAmpus.TabIndex = 8
        Me.grpCAmpus.TabStop = False
        Me.grpCAmpus.Text = "Residence"
        '
        'rdbOnCampus
        '
        Me.rdbOnCampus.AutoSize = True
        Me.rdbOnCampus.Location = New System.Drawing.Point(7, 57)
        Me.rdbOnCampus.Name = "rdbOnCampus"
        Me.rdbOnCampus.Size = New System.Drawing.Size(111, 23)
        Me.rdbOnCampus.TabIndex = 1
        Me.rdbOnCampus.TabStop = True
        Me.rdbOnCampus.Text = "On-Campus"
        Me.rdbOnCampus.UseVisualStyleBackColor = True
        '
        'rdbOffCampus
        '
        Me.rdbOffCampus.AutoSize = True
        Me.rdbOffCampus.Location = New System.Drawing.Point(7, 31)
        Me.rdbOffCampus.Name = "rdbOffCampus"
        Me.rdbOffCampus.Size = New System.Drawing.Size(112, 23)
        Me.rdbOffCampus.TabIndex = 0
        Me.rdbOffCampus.TabStop = True
        Me.rdbOffCampus.Text = "Off-Campus"
        Me.rdbOffCampus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(368, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Major: "
        '
        'cboMajor
        '
        Me.cboMajor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMajor.FormattingEnabled = True
        Me.cboMajor.Items.AddRange(New Object() {"Technology Education", "Busniess", "Art", "Law", "Music", "Finance", "Physical Education"})
        Me.cboMajor.Location = New System.Drawing.Point(434, 307)
        Me.cboMajor.Name = "cboMajor"
        Me.cboMajor.Size = New System.Drawing.Size(192, 27)
        Me.cboMajor.TabIndex = 10
        Me.cboMajor.Text = "Select A Major"
        '
        'btnCost
        '
        Me.btnCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.Navy
        Me.btnCost.Location = New System.Drawing.Point(126, 402)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(164, 31)
        Me.btnCost.TabIndex = 11
        Me.btnCost.Text = "Calculate Cost"
        Me.btnCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Navy
        Me.btnClear.Location = New System.Drawing.Point(338, 402)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(164, 31)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(179, 190)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(100, 27)
        Me.txtStudentID.TabIndex = 13
        '
        'txtNumberOfUnits
        '
        Me.txtNumberOfUnits.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfUnits.Location = New System.Drawing.Point(179, 259)
        Me.txtNumberOfUnits.Name = "txtNumberOfUnits"
        Me.txtNumberOfUnits.Size = New System.Drawing.Size(22, 27)
        Me.txtNumberOfUnits.TabIndex = 15
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Navy
        Me.lblCost.Location = New System.Drawing.Point(300, 439)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 19)
        Me.lblCost.TabIndex = 16
        Me.lblCost.Visible = False
        '
        'grpHousingBoard
        '
        Me.grpHousingBoard.Controls.Add(Me.rdbJulianSultes)
        Me.grpHousingBoard.Controls.Add(Me.rdbCraigHall)
        Me.grpHousingBoard.Controls.Add(Me.rdbCooperDorm)
        Me.grpHousingBoard.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHousingBoard.ForeColor = System.Drawing.Color.Navy
        Me.grpHousingBoard.Location = New System.Drawing.Point(179, 296)
        Me.grpHousingBoard.Name = "grpHousingBoard"
        Me.grpHousingBoard.Size = New System.Drawing.Size(183, 94)
        Me.grpHousingBoard.TabIndex = 17
        Me.grpHousingBoard.TabStop = False
        Me.grpHousingBoard.Text = "Housing Board"
        '
        'rdbJulianSultes
        '
        Me.rdbJulianSultes.AutoSize = True
        Me.rdbJulianSultes.Location = New System.Drawing.Point(6, 71)
        Me.rdbJulianSultes.Name = "rdbJulianSultes"
        Me.rdbJulianSultes.Size = New System.Drawing.Size(115, 23)
        Me.rdbJulianSultes.TabIndex = 2
        Me.rdbJulianSultes.TabStop = True
        Me.rdbJulianSultes.Text = "Julian Sultes"
        Me.rdbJulianSultes.UseVisualStyleBackColor = True
        '
        'rdbCraigHall
        '
        Me.rdbCraigHall.AutoSize = True
        Me.rdbCraigHall.Location = New System.Drawing.Point(6, 45)
        Me.rdbCraigHall.Name = "rdbCraigHall"
        Me.rdbCraigHall.Size = New System.Drawing.Size(96, 23)
        Me.rdbCraigHall.TabIndex = 1
        Me.rdbCraigHall.TabStop = True
        Me.rdbCraigHall.Text = "Craig Hall"
        Me.rdbCraigHall.UseVisualStyleBackColor = True
        '
        'rdbCooperDorm
        '
        Me.rdbCooperDorm.AutoSize = True
        Me.rdbCooperDorm.Location = New System.Drawing.Point(7, 19)
        Me.rdbCooperDorm.Name = "rdbCooperDorm"
        Me.rdbCooperDorm.Size = New System.Drawing.Size(123, 23)
        Me.rdbCooperDorm.TabIndex = 0
        Me.rdbCooperDorm.TabStop = True
        Me.rdbCooperDorm.Text = "Cooper Dorm"
        Me.rdbCooperDorm.UseVisualStyleBackColor = True
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(179, 223)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(401, 27)
        Me.txtStudentName.TabIndex = 18
        '
        'frmCollege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(629, 467)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.grpHousingBoard)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtNumberOfUnits)
        Me.Controls.Add(Me.txtStudentID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.cboMajor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpCAmpus)
        Me.Controls.Add(Me.lblNumberOfUnits)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.lblStudent)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCollege"
        Me.Text = "College Registration Costs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCAmpus.ResumeLayout(False)
        Me.grpCAmpus.PerformLayout()
        Me.grpHousingBoard.ResumeLayout(False)
        Me.grpHousingBoard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblStudent As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblNumberOfUnits As Label
    Friend WithEvents grpCAmpus As GroupBox
    Friend WithEvents rdbOnCampus As RadioButton
    Friend WithEvents rdbOffCampus As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMajor As ComboBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtStudentID As MaskedTextBox
    Friend WithEvents txtNumberOfUnits As MaskedTextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents grpHousingBoard As GroupBox
    Friend WithEvents rdbCraigHall As RadioButton
    Friend WithEvents rdbCooperDorm As RadioButton
    Friend WithEvents rdbJulianSultes As RadioButton
    Friend WithEvents txtStudentName As TextBox
End Class
