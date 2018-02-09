' Program Name: WANG Rainfall Statistics
' Author:       Yufan Wang
' Date:         5/21/2017
' Purpose:      This application extracts a set of data(year and rainfall) and allows the user 
'               to select a year to view the rainfall inches for that year, as well as the 
'               average rainfall value of all years and the highest rainfall values for 3 years

Public Class frmRainfallStatistics

    Dim _intSizeOfArray As Integer = 17
    Private _strYear(_intSizeOfArray) As String
    Private _decRainfall(_intSizeOfArray) As Decimal
    Private _decRainfallSorted(_intSizeOfArray) As Decimal

    Private Sub frmRainfallStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loads form and reads the Rain.txt file into 2 parallel arrays, one for Years and 
        ' one for Rainfall

        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Rain.txt"
        Dim intCount As Integer = 0
        Dim intFill As Integer
        Dim strFileError As String = "The file is not available. Restart when the file is available"

        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)

            Do While objReader.Peek <> -1
                _strYear(intCount) = objReader.ReadLine()
                _decRainfall(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()

            For intFill = 0 To (_strYear.Length - 1)
                cboYears.Items.Add(_strYear(intFill))
            Next

            Array.Copy(_decRainfall, _decRainfallSorted, _intSizeOfArray) ' copies the rainfall array
            Array.Sort(_decRainfallSorted) ' new array is sorted so maximum can be found
            cboYears.SelectedIndex = 0
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Runs several functions based on selected year. The rainfall for the year is displayed,
        ' the average for all years is displayed, and the maximum rainfall is displayed

        Dim intSelected As Integer = cboYears.SelectedIndex
        Dim strYear As String = _strYear(intSelected)
        Dim decRainfall As Decimal = Format(_decRainfall(intSelected), "##.#")
        Dim decAverage As Decimal
        Dim strMax(2) As String

        decAverage = Format(Average(_decRainfall), "##.#")
        strMax = Find3(_strYear, _decRainfall)

        lblRainfall.Text = "The total rainfall in " & strYear & " is " & decRainfall & " inches."
        lblAverage.Text = "The average rainfall was " & decAverage & " inches."
        lblMost.Text = strMax(0) & " had the most rain between 2000-2017."
        lblSecond.Text = strMax(1) & " had the second most rain between 2000-2017."
        lblThird.Text = strMax(2) & " had the third most rain between 2000-2017."
        lblAverage.Visible = True
        lblRainfall.Visible = True
        lblMost.Visible = True
        lblSecond.Visible = True
        lblThird.Visible = True

    End Sub

    Private Function Average(ByVal decRainfall() As Decimal)
        ' Finds the average of all rainfall data

        Dim intCount As Integer
        Dim decTotal As Decimal = 0
        Dim decAverage As Decimal

        For intCount = 0 To (decRainfall.Length - 1)
            decTotal += decRainfall(intCount)
        Next

        decAverage = decTotal / decRainfall.Length

        Return decAverage

    End Function

    Private Function Find3(ByVal strYear() As String, ByVal decRainfall() As Decimal) As String()
        ' Finds the maximum of the rainfall data

        Dim intCount As Integer
        Dim strMax(2) As String
        Dim intMax As Integer = 0

        For intCount = 0 To (decRainfall.Length - 1)
            If _decRainfallSorted(decRainfall.Length - 1) = decRainfall(intCount) Then
                strMax(intMax) = _strYear(intCount)
            ElseIf _decRainfallSorted(decRainfall.Length - 2) = decRainfall(intCount) Then
                strMax(intMax + 1) = _strYear(intCount)
            ElseIf _decRainfallSorted(decRainfall.Length - 3) = decRainfall(intCount) Then
                strMax(intMax + 2) = _strYear(intCount)
            End If
        Next

        Return strMax

    End Function

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Makes all labels with data invisible to prepare for new user input

        lblAverage.Visible = False
        lblRainfall.Visible = False
        lblMost.Visible = False
        lblSecond.Visible = False
        lblThird.Visible = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exits the application

        Close()

    End Sub

End Class
