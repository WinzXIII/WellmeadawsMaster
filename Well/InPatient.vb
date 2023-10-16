﻿Imports System.Data.SqlClient
Imports System.Globalization

Public Class InPatient
    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)

    Private Sub InPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' สร้าง query
        Dim query1 As String = "SELECT * FROM InPatients"

        ' สร้าง command
        Dim command1 As New SqlCommand(query1, sqlConnection)

        ' สร้าง DataAdapter เพื่อดึงข้อมูล
        Dim adapter As New SqlDataAdapter(command1)

        ' สร้าง DataSet เพื่อเก็บข้อมูล
        Dim dataSet As New DataSet()

        ' เตรียมข้อมูลใน DataSet
        adapter.Fill(dataSet)

        ' แสดงข้อมูลใน DataGridView
        DataGridView1.DataSource = dataSet.Tables(0)

        ' ปิดการเชื่อมต่อ
        sqlConnection.Close()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Try
            ' Retrieve the search criteria entered by the user
            Dim searchText As String = txtBoxSearch.Text.Trim()

            ' Create a SQL SELECT statement to retrieve patient information
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM InPatients"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM InPatients WHERE AdmitID LIKE @SearchText OR PatientID LIKE @SearchText OR WardID LIKE @SearchText OR DatePlacedOnWaitingList LIKE @SearchText OR DatePlacedInWard LIKE @SearchText OR DateExpectedToLeaveWard LIKE @SearchText OR ActualDatePatientLeftWard LIKE @SearchText"
            End If

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(selectQuery, connection)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        ' Add a parameter for the search term
                        command.Parameters.AddWithValue("@SearchText", "%" & searchText & "%")
                    End If

                    connection.Open()

                    ' Create a DataTable to store the retrieved data
                    Dim dataTable As New DataTable()

                    ' Execute the query and fill the DataTable with the patient information
                    Dim dataAdapter As New SqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    DataGridView1.DataSource = dataTable

                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions and display an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetNextID() As String
        ' อย่าลืมเปลี่ยนชื่อ Table นะจ้ะ
        Dim query As String = "SELECT MAX(AdmitID) FROM InPatients"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ A0001
                    Return "A0001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "A" & nextID.ToString("D4")
                End If
            End Using
        End Using
    End Function

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click
        ' Assuming the date format is "dd/MM/yyyy"
        Dim waitingDateString As String = lblWaitingDate.Value
        Dim datePlacedString As String = lblDatePlaced.Value
        Dim expectedLeaveString As String = lblExpectedLeave.Value
        Dim actualLeftString As String = lblActualLeft.Value

        Dim dateFormat As String = "dd/MM/yyyy"
        Dim waitingDate As DateTime
        Dim datePlaced As DateTime
        Dim expectedLeave As DateTime
        Dim actualLeft As DateTime

        If DateTime.TryParseExact(waitingDateString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, waitingDate) AndAlso
           DateTime.TryParseExact(datePlacedString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, datePlaced) AndAlso
           DateTime.TryParseExact(expectedLeaveString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, expectedLeave) AndAlso
           DateTime.TryParseExact(actualLeftString, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, actualLeft) Then

            Try
                ' Get the next available patient ID
                Dim nextID As String = GetNextID()

                ' Create a SQL INSERT statement with the formatted patient ID
                Dim sqlin As String = "INSERT INTO InPatients (AdmitID, PatientID, WardID, DatePlacedOnWaitingList, ExpectedDurationOfStay, DatePlacedInWard, DateExpectedToLeaveWard, ActualDatePatientLeftWard) " &
                                      "VALUES('" & nextID & "','" & PatientIDtxt.Text & "', '" & WardIDtxt.Text & "', '" & datePlaced.ToString("MM/dd/yyyy") & "', '" & lblDurationOfStay.Value & "', '" & datePlaced.ToString("MM/dd/yyyy") & "','" & expectedLeave.ToString("MM/dd/yyyy") & "','" & actualLeft.ToString("MM/dd/yyyy") & "')"

                Dim sqlCmd = sqlConnection.CreateCommand()
                sqlCmd.CommandText = sqlin

                sqlConnection.Open()
                sqlCmd.ExecuteNonQuery()

                MessageBox.Show("บันทึกข้อมูลสำเร็จ")
            Catch ex As Exception
                MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message)
            Finally
                sqlConnection.Close()
            End Try
        Else
            MessageBox.Show("Invalid date format.")
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim newFormSChoPatien As ChoosPatien ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChoosPatien()
        newFormSChoPatien.ShowDialog()
        PatientIDtxt.Text = newFormSChoPatien.PatienID
        TextBox1.Text = newFormSChoPatien.PatienName
        TextBox2.Text = newFormSChoPatien.PatienLastname

        PatientIDtxt.ReadOnly = True
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim newFormSChoPatien As ChooseWard ' สร้างตัวแปรสำหรับฟอร์มใหม่
        newFormSChoPatien = New ChooseWard()
        newFormSChoPatien.ShowDialog()
        WardIDtxt.Text = newFormSChoPatien.PatientId
        TextBox3.Text = newFormSChoPatien.PatientName


        WardIDtxt.ReadOnly = True
        TextBox3.ReadOnly = True

    End Sub


End Class