'Author: Bruce Brown
'Date: 2/10/2021
'Last Update: 3/4/2021
'Purpose: This app is designed to gather the age, weight, height, sex, and activity level of a user to determine 
'and display the base Resting Metabolic Rate (RMR) and RMR with the activity.

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmCalorieCalculator

    Dim lstUser As New BindingList(Of User)
    Dim objSelectedUser As User
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare Variables
        Dim intAge As Integer
        Dim intHeight As Integer
        Dim dblWeight As Double
        Dim dblWaist As Double
        Dim dblWrist As Double
        Dim dblHip As Double
        Dim dblForearm As Double
        Dim dblMultiplier As Double
        Dim strName As String

        'Verification Variables
        Dim blnIsAValidAge As Boolean
        Dim blnIsAValidWeight As Boolean
        Dim blnIsAValidHeight As Boolean
        Dim blnIsAValidWaist As Boolean
        Dim blnIsAValidWrist As Boolean
        Dim blnIsAValidHip As Boolean
        Dim blnIsAValidForeArm As Boolean

        'Assign Variables
        blnIsAValidAge = Integer.TryParse(txtAge.Text, intAge)
        blnIsAValidHeight = Integer.TryParse(txtHeight.Text, intHeight)
        blnIsAValidWeight = Double.TryParse(txtWeight.Text, dblWeight)
        blnIsAValidWaist = Double.TryParse(txtWaist.Text, dblWaist)
        blnIsAValidWrist = Double.TryParse(txtWrist.Text, dblWrist)
        blnIsAValidHip = Double.TryParse(txtHip.Text, dblHip)
        blnIsAValidForeArm = Double.TryParse(txtForearm.Text, dblForearm)
        strName = txtName.Text

        'Verify the text boxes are not empty
        If txtName.Text <> String.Empty Then

            If txtAge.Text <> String.Empty Then

                If txtWeight.Text <> String.Empty Then

                    If txtHeight.Text <> String.Empty Then

                        If txtWaist.Text <> String.Empty Then

                            If txtWrist.Text <> String.Empty Then

                                If txtHip.Text <> String.Empty Then

                                    If txtForearm.Text <> String.Empty Then

                                        'Verification of numbers
                                        If blnIsAValidAge = True Then
                                            If blnIsAValidHeight = True Then
                                                If blnIsAValidWeight = True Then
                                                    If blnIsAValidWaist = True Then
                                                        If blnIsAValidWrist = True Then
                                                            If blnIsAValidHip = True Then
                                                                If blnIsAValidForeArm = True Then

                                                                    'Sets the RMR multiplier based on Activity Level selection
                                                                    Select Case cboActivityLevel.SelectedIndex
                                                                        Case 0
                                                                            dblMultiplier = 1.2
                                                                        Case 1
                                                                            dblMultiplier = 1.3
                                                                        Case 2
                                                                            dblMultiplier = 1.4
                                                                        Case 3
                                                                            dblMultiplier = 1.5
                                                                        Case 4
                                                                            dblMultiplier = 1.6
                                                                        Case 5
                                                                            dblMultiplier = 1.7
                                                                        Case 6
                                                                            dblMultiplier = 1.8
                                                                    End Select

                                                                    'Instantiate a new user
                                                                    Dim objUser As New User(strName, intAge, dblWeight, intHeight, cboSex.SelectedItem.ToString, cboActivityLevel.SelectedItem.ToString, dblWaist, dblWrist, dblHip, dblForearm)

                                                                    'Calculates and populates data if data is numerical 
                                                                    If blnIsAValidAge AndAlso blnIsAValidHeight AndAlso blnIsAValidWeight AndAlso blnIsAValidWaist AndAlso blnIsAValidWrist AndAlso blnIsAValidHip AndAlso blnIsAValidForeArm Then

                                                                        'Calls Function for RMR Base amount
                                                                        objUser.RMR = CalcBase(intAge, intHeight, dblWeight)

                                                                        'Calls Function for RMR with Activity
                                                                        objUser.ActivityRMR = CalcActivity(dblMultiplier, objUser.RMR)

                                                                        'Calls Function for Body Fat Percentage calculation
                                                                        If cboSex.SelectedItem.ToString = "Male" Then
                                                                            objUser.BodyFatPerc = CalcMaleBFP(dblWaist, dblWeight)
                                                                        ElseIf cboSex.SelectedItem.ToString = "Female" Then
                                                                            objUser.BodyFatPerc = CalcFemaleBFP(dblWaist, dblWrist, dblHip, dblForearm, dblWeight)
                                                                        End If

                                                                        If btnCalculate.Text = "Calculate" Then

                                                                            'Add new customer object to list of customers
                                                                            lstUser.Add(objUser)

                                                                            'Insert the record
                                                                            InsertUser()

                                                                        ElseIf btnCalculate.Text = "Update" Then

                                                                            'Update the record
                                                                            UpdateUser()
                                                                        End If

                                                                        'Make the New user the selected character
                                                                        objSelectedUser = objUser

                                                                        'Select Case the current user In the listbox
                                                                        lbxUsers.SelectedItem = objUser

                                                                        'Display Stats and reset fields
                                                                        DisplayStats()
                                                                        ResetAll()

                                                                    End If

                                                                Else
                                                                    ResetAll()
                                                                    MessageBox.Show("Numerical values are required. Please try again.")
                                                                End If

                                                            Else
                                                                ResetAll()
                                                                MessageBox.Show("Numerical values are required. Please try again.")
                                                            End If

                                                        Else
                                                            ResetAll()
                                                            MessageBox.Show("Numerical values are required. Please try again.")
                                                        End If

                                                    Else
                                                        ResetAll()
                                                        MessageBox.Show("Numerical values are required. Please try again.")
                                                    End If

                                                Else
                                                    ResetAll()
                                                    MessageBox.Show("Numerical values are required. Please try again.")
                                                End If

                                            Else
                                                ResetAll()
                                                MessageBox.Show("Numerical values are required. Please try again.")
                                            End If

                                        Else
                                            ResetAll()
                                            MessageBox.Show("Numerical values are required. Please try again.")
                                        End If

                                    Else
                                        Call Msg("Forearm measurement field cannot be left blank. Please try again.")
                                        txtForearm.Focus()
                                    End If

                                Else
                                    Call Msg("Hip measurement field cannot be left blank. Please try again.")
                                    txtHip.Focus()
                                End If

                            Else
                                Call Msg("Wrist measurement field cannot be left blank. Please try again.")
                                txtWrist.Focus()
                            End If

                        Else
                            Call Msg("Waist measurement field cannot be left blank. Please try again.")
                            txtWaist.Focus()
                        End If

                    Else
                        Call Msg("Height field cannot be left blank. Please try again.")
                        txtHeight.Focus()
                    End If
                Else
                    Call Msg("Weight field cannot be left blank. Please try again.")
                    txtWeight.Focus()
                End If
            Else
                Call Msg("Age field cannot be left blank. Please try again.")
                txtAge.Focus()
            End If
        Else
            Call Msg("Name field cannot be left blank. Please try again.")
            txtName.Focus()
        End If

    End Sub

    Public Sub Msg(ByVal strMsg As String)
        MessageBox.Show(strMsg, "CalorieCalculator", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Resets all after Reset button is clicked
        ResetAll()

    End Sub

    Private Sub ResetAll()

        'Resets text boxes, output, and dropdown selections
        txtName.Clear()
        txtAge.Clear()
        txtWeight.Clear()
        txtHeight.Clear()
        cboSex.SelectedIndex = 0
        cboActivityLevel.SelectedIndex = 0
        txtWaist.Clear()
        txtWrist.Clear()
        txtHip.Clear()
        txtForearm.Clear()
        btnCalculate.Text = "Calculate"
        txtName.Focus()

    End Sub

    Private Sub frmCalorieCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Populate Sex (gender) List
        cboSex.Items.Add("Male")
        cboSex.Items.Add("Female")

        'Populate Activity Level List
        cboActivityLevel.Items.Add("Sitting or Lying all day")
        cboActivityLevel.Items.Add("Seated work, no exercise")
        cboActivityLevel.Items.Add("Seated work, light exercise")
        cboActivityLevel.Items.Add("Moderately physical work, no exercise")
        cboActivityLevel.Items.Add("Moderately physical work, light exercise")
        cboActivityLevel.Items.Add("Moderately physical work, heavy exercise")
        cboActivityLevel.Items.Add("Heavy work or Heavy Exercise")

        'Automatically selects the first Sex and Activity Level
        cboSex.SelectedIndex = 0
        cboActivityLevel.SelectedIndex = 0

        'Set Custom Binding List to Listbox
        lbxUsers.DataSource = lstUser
        lbxUsers.DisplayMember = "Name"

        Reload_lbxUsers()

    End Sub

    Function CalcBase(ByVal intAge As Integer, ByVal intHeight As Integer, ByVal dblWeight As Double) As Double

        'Calculates the base RMR
        Dim dblResult As Double

        If cboSex.SelectedIndex = 0 Then
            'Calculate for Male
            dblResult = ((88.4 + 13.4 * (dblWeight * 0.453592)) + (4.8 * (intHeight * 2.54)) - (5.68 * intAge))
        Else
            'Calculate for Female
            dblResult = ((447.6 + 9.25 * (dblWeight * 0.453592)) + (3.1 * (intHeight * 2.54)) - (4.33 * intAge))

        End If

        Return dblResult

    End Function

    Function CalcActivity(ByVal dblCalcMultiplier As Double, ByVal dblBase As Double) As Double

        'Calculates the RMR with Activity included
        Dim dblResult As Double

        dblResult = dblCalcMultiplier * dblBase

        Return dblResult
    End Function

    Function CalcMaleBFP(ByVal dblWaist As Double, dblWeight As Double) As Double

        'Declare Variables
        Dim dblFactor1 As Double
        Dim dblFactor2 As Double
        Dim dblLeanBodyMass As Double
        Dim dblBodyFatWeight As Double
        Dim dblBodyFatPercent As Double

        'Calculations for Body Fat Percentage
        dblFactor1 = (dblWeight * 1.082) + 94.42
        dblFactor2 = dblWaist * 4.15
        dblLeanBodyMass = dblFactor1 - dblFactor2
        dblBodyFatWeight = dblWeight - dblLeanBodyMass
        dblBodyFatPercent = (dblBodyFatWeight * 100) / dblWeight

        Return dblBodyFatPercent

    End Function

    Function CalcFemaleBFP(ByVal dblWaist As Double, ByVal dblWrist As Double, ByVal dblHip As Double, ByVal dblForearm As Double, ByVal dblWeight As Double) As Double

        'Declare Variables
        Dim dblFactor1 As Double
        Dim dblFactor2 As Double
        Dim dblFactor3 As Double
        Dim dblFactor4 As Double
        Dim dblFactor5 As Double
        Dim dblLeanBodyMass As Double
        Dim dblBodyFatWeight As Double
        Dim dblBodyFatPercent As Double

        'Calculations for Body Fat Percentage
        dblFactor1 = (dblWeight * 0.732) + 8.987
        dblFactor2 = dblWrist / 3.14
        dblFactor3 = dblWaist * 0.157
        dblFactor4 = dblHip * 0.249
        dblFactor5 = dblForearm * 0.434
        dblLeanBodyMass = dblFactor1 + dblFactor2 - dblFactor3 - dblFactor4 + dblFactor5
        dblBodyFatWeight = dblWeight - dblLeanBodyMass
        dblBodyFatPercent = (dblBodyFatWeight * 100) / dblWeight

        Return dblBodyFatPercent

    End Function

    Private Sub DisplayStats()

        'Output Stat Results
        If Not objSelectedUser Is Nothing Then
            lblFitIDStat.Text = objSelectedUser.FitnessID
            lblNameStat.Text = objSelectedUser.Name
            lblAgeStat.Text = objSelectedUser.Age.ToString
            lblWeightStat.Text = objSelectedUser.Weight.ToString
            lblHeightStat.Text = objSelectedUser.Height.ToString
            lblGenderStat.Text = objSelectedUser.Gender
            lblRMRStat.Text = objSelectedUser.RMR.ToString
            lblActivityRMRStat.Text = objSelectedUser.ActivityRMR.ToString
            lblActivityStat.Text = objSelectedUser.Activity
            lblBodyFatPercentStat.Text = objSelectedUser.BodyFatPerc.ToString
        Else
            lblFitIDStat.Text = "*"
            lblNameStat.Text = "*"
            lblAgeStat.Text = "*"
            lblWeightStat.Text = "*"
            lblHeightStat.Text = "*"
            lblGenderStat.Text = "*"
            lblRMRStat.Text = "*"
            lblActivityRMRStat.Text = "*"
            lblActivityStat.Text = "*"
            lblBodyFatPercentStat.Text = "*"
        End If

    End Sub

    Private Sub lbxUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUsers.SelectedIndexChanged

        If lbxUsers.SelectedIndex >= 0 Then
            objSelectedUser = CType(lbxUsers.SelectedItem, User)

            'Populate Textboxes with Selected User
            txtName.Text = objSelectedUser.Name
            txtAge.Text = objSelectedUser.Age.ToString
            txtWeight.Text = objSelectedUser.Weight.ToString
            txtHeight.Text = objSelectedUser.Height.ToString
            cboSex.SelectedItem = objSelectedUser.Gender
            cboActivityLevel.SelectedItem = objSelectedUser.Activity
            txtWaist.Text = objSelectedUser.Waist.ToString
            txtWrist.Text = objSelectedUser.Wrist.ToString
            txtHip.Text = objSelectedUser.Hip.ToString
            txtForearm.Text = objSelectedUser.Forearm.ToString

            'Determine if this is an edit or delete
            Dim intResult As Integer = MessageBox.Show("Are you updating this record?", "User List", MessageBoxButtons.YesNo)
            If intResult = DialogResult.Yes Then
                btnCalculate.Text = "Update"

            ElseIf intResult = DialogResult.No Then
                Dim intResultNext As Integer = MessageBox.Show("Are you deleting this record?", "User List", MessageBoxButtons.YesNo)

                If intResultNext = DialogResult.No Then
                    objSelectedUser = Nothing
                End If

                ResetAll()
            End If

        End If

        DisplayStats()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Remove the deleted character
        DeleteUser()
        objSelectedUser = Nothing
        DisplayStats()
    End Sub

    Private Sub Reload_lbxUsers()

        'Make sure the list box is empty by clearing the list box
        lstUser.Clear()

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create a Command Object
        Dim cmdSelect As New SqlCommand("Select * from User_Tbl;", dbConnection)

        'Execute Command into a DataReader
        Dim rdrUser As SqlDataReader = cmdSelect.ExecuteReader

        If rdrUser.HasRows Then
            While rdrUser.Read
                'Create temporary User Object to store from database to list of users
                Dim objStoredUser As New User(rdrUser.Item("Fitness_ID").ToString)
                objStoredUser.Name = rdrUser.Item("Name").ToString
                objStoredUser.Age = CInt(rdrUser.Item("Age"))
                objStoredUser.Weight = CDbl(rdrUser.Item("Weight"))
                objStoredUser.Height = CInt(rdrUser.Item("Height"))
                objStoredUser.Gender = rdrUser.Item("Gender").ToString
                objStoredUser.Activity = rdrUser.Item("Activity").ToString
                objStoredUser.Waist = CDbl(rdrUser.Item("Waist"))
                objStoredUser.Wrist = CDbl(rdrUser.Item("Wrist"))
                objStoredUser.Hip = CDbl(rdrUser.Item("Hip"))
                objStoredUser.Forearm = CDbl(rdrUser.Item("Forearm"))
                objStoredUser.RMR = CDbl(rdrUser.Item("RMR"))
                objStoredUser.ActivityRMR = CDbl(rdrUser.Item("Activity_RMR"))
                objStoredUser.BodyFatPerc = CDbl(rdrUser.Item("Body_Fat_Perc"))

                'Populating list with data from database
                lstUser.Add(objStoredUser)
            End While
        End If

        dbConnection.Close()
        dbConnection.Dispose()
    End Sub

    Private Function OpenDBConnection() As SqlConnection

        'Create a connection string
        'This give the full path into the bin/debug folder
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length
        'This strips off the bin/debug folder to point into your project folder.
        strPath = strPath.Substring(0, intPathLength - 9)

        Dim strconnection As String = "Server=(LocalDB)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + strPath + "Fitness.mdf"

        'Create a Connection object
        Dim dbConnection As New SqlConnection(strconnection)

        Try
            'Open Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return dbConnection

    End Function

    Public Sub InsertUser()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "Insert into User_Tbl (Name,Age,Weight,Height,Gender,RMR,Activity_RMR,Activity,Body_Fat_Perc,Waist,Wrist,Hip,Forearm) values (@Name,@Age,@Weight,@Height,@Gender,@RMR,@Activity_RMR,@Activity,@Body_Fat_Perc,@Waist,@Wrist,@Hip,@Forearm)"

        'Create Command Object
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate Parameters of the Insert using the last record added to the list object
        cmdInsert.Parameters.AddWithValue("Name", lstUser.Last.Name)
        cmdInsert.Parameters.AddWithValue("Age", lstUser.Last.Age)
        cmdInsert.Parameters.AddWithValue("Weight", lstUser.Last.Weight)
        cmdInsert.Parameters.AddWithValue("Height", lstUser.Last.Height)
        cmdInsert.Parameters.AddWithValue("Gender", lstUser.Last.Gender)
        cmdInsert.Parameters.AddWithValue("Activity", lstUser.Last.Activity)
        cmdInsert.Parameters.AddWithValue("Waist", lstUser.Last.Waist)
        cmdInsert.Parameters.AddWithValue("Wrist", lstUser.Last.Wrist)
        cmdInsert.Parameters.AddWithValue("Hip", lstUser.Last.Hip)
        cmdInsert.Parameters.AddWithValue("Forearm", lstUser.Last.Forearm)
        cmdInsert.Parameters.AddWithValue("RMR", lstUser.Last.RMR)
        cmdInsert.Parameters.AddWithValue("Activity_RMR", lstUser.Last.ActivityRMR)
        cmdInsert.Parameters.AddWithValue("Body_Fat_Perc", lstUser.Last.BodyFatPerc)


        Try
            Dim intRowsImpacted = cmdInsert.ExecuteNonQuery()
            If intRowsImpacted = 1 Then
                MessageBox.Show(lstUser.Last.Name & " was inserted.")
            Else
                MessageBox.Show("The insert failed")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Insert Failed" & ex.Message)

        End Try

        Reload_lbxUsers()

    End Sub

    Public Sub UpdateUser()
        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "Update User_Tbl set Name = '" & txtName.Text & "',Age = '" & txtAge.Text & "',Weight = '" & txtWeight.Text & "',Height = '" & txtHeight.Text & "',Gender = '" & cboSex.SelectedItem.ToString & "',Activity = '" & cboActivityLevel.SelectedItem.ToString & "',Waist = '" & txtWaist.Text & "',Wrist = '" & txtWrist.Text & "',Hip = '" & txtHip.Text & "',Forearm = '" & txtForearm.Text & "',RMR = '" & lblRMRStat.Text & "',Activity_RMR = '" & lblActivityRMRStat.Text & "',Body_Fat_Perc = '" & lblBodyFatPercentStat.Text & "' where Fitness_ID = '" & lblFitIDStat.Text & "'"

        MessageBox.Show(strSQL)

        'Create Command Object
        Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)


        Try
            Dim intRowsImpacted = cmdUpdate.ExecuteNonQuery()
            If intRowsImpacted = 1 Then
                MessageBox.Show(objSelectedUser.Name & " was updated.")
            Else
                MessageBox.Show("The update failed")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Update Failed" & ex.Message)

        End Try

        Reload_lbxUsers()
        ResetAll()
    End Sub

    Public Sub DeleteUser()

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "Delete from User_Tbl where Fitness_ID = '" & objSelectedUser.FitnessID & "'"

        MessageBox.Show(strSQL)

        'Create Command Object
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)


        Try
            Dim intRowsImpacted = cmdDelete.ExecuteNonQuery()
            If intRowsImpacted = 1 Then
                MessageBox.Show("Record was deleted.")
            Else
                MessageBox.Show("The delete failed")
            End If
        Catch ex As Exception
            MessageBox.Show("DB delete Failed" & ex.Message)

        End Try

        Reload_lbxUsers()
        ResetAll()

    End Sub

End Class
