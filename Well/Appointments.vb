﻿Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Appointments

    Dim connectionString As String = "Data Source=144.24.38.124\SQLEXPRESS,1433;Initial Catalog=Project ;User Id=admin;Password=adminadminadmin"
    Dim sqlConnection As New SqlConnection(connectionString)
    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load()

    End Sub

    Protected Sub Load()
        ' สร้าง query
        Dim query1 As String = "SELECT * FROM Appointments"

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

            ' Create a SQL SELECT statement to retrieve patient informationr
            Dim selectQuery As String

            If String.IsNullOrWhiteSpace(searchText) Then
                ' If the search box is empty, retrieve all patient records
                selectQuery = "SELECT * FROM Appointments"
            Else
                ' If a search term is entered, filter by FirstName, LastName, or Tel
                selectQuery = "SELECT * FROM Appointments WHERE AppointmentsID LIKE @SearchText OR PatientID LIKE @SearchText OR AppointmentDate LIKE @SearchText OR WardID LIKE @SearchText OR Diagnosis LIKE @SearchText OR TreatmentPlan LIKE @SearchText"
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
        Dim query As String = "SELECT MAX(AppointmentID) FROM Appointments"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim maxPatientID As Object = command.ExecuteScalar()

                If maxPatientID Is DBNull.Value Then
                    ' ถ้าไม่มีข้อมูลจะเริ่มที่ P0001
                    Return "A001"
                Else
                    Dim currentID As Integer = Integer.Parse(maxPatientID.ToString().Substring(1))
                    Dim nextID As Integer = currentID + 1
                    Return "A" & nextID.ToString("D3")
                End If
            End Using
        End Using
    End Function

    Private Sub butAdd_Click(sender As Object, e As EventArgs) Handles butAdd.Click




        Dim waitingDateString As String = appointmentdate.Value


        Dim dateFormat As String = "dd/MM/yyyy"
        Dim waitingDate As DateTime



        Try
            ' Get the next available patient ID
            Dim nextID As String = GetNextID()

            ' Create a SQL INSERT statement with the formatted patient Diagnosis
            Dim sqlin As String = "INSERT INTO Appointments (AppointmentID, PatientID, AppointmentDate, WardID, Diagnosis, TreatmentPlan) " &
                                  "VALUES('" & nextID & "','" & PatientIDtxt.Text & "', '" & waitingDate & "', '" & WardIDtxt.Text & "', '" & Diagnosistxt.Text & "', '" & TreatmentPlantxt.Text & "')"

            Dim sqlCmd = sqlConnection.CreateCommand()
            sqlCmd.CommandText = sqlin

            sqlConnection.Open()
            sqlCmd.ExecuteNonQuery()

            MessageBox.Show("บันทึกข้อมูลสำเร็จ")
        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล: " & ex.Message & waitingDate)
        Finally
            sqlConnection.Close()
        End Try

        Load()

    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Try
            ' Check if any rows are selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Retrieve the unique identifier (e.g., a primary key) from the selected row
                Dim primaryKeyValue As String = selectedRow.Cells("PatientID").Value.ToString()

                ' Create a SQL DELETE statement
                Dim deleteQuery As String = "DELETE FROM Patients WHERE PatientID = @PrimaryKey"

                ' Create a SqlConnection and SqlCommand
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(deleteQuery, connection)
                        ' Add a parameter for the primary key value
                        command.Parameters.AddWithValue("@PrimaryKey", primaryKeyValue)

                        ' Open the database connection
                        connection.Open()

                        ' Execute the DELETE query
                        command.ExecuteNonQuery()

                        ' Close the database connection
                        connection.Close()
                    End Using
                End Using

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.Remove(selectedRow)
            End If
        Catch ex As Exception
            ' Handle any exceptions and show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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