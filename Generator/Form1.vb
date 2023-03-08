Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Math
Imports Custom
Public Class Form1
    Dim formt As New BinaryFormatter()
    Public Shared liste As New List(Of Membre)
    Public Shared listeMembreDate As New List(Of Membre)
    Public Shared listetour As New List(Of Tour)
    Dim f As New Random(6)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fichier = New FileStream("Membres1.bin", FileMode.OpenOrCreate)
        fichier2 = New FileStream("MembresDate1.bin", FileMode.OpenOrCreate)

        If fichier.Length > 0 Then
            liste = CType(formt.Deserialize(fichier), List(Of Membre))
            ListBox1.DataSource = liste
            ListBox1.DisplayMember = "Nom"
        End If
        If fichier2.Length > 0 Then
            listeMembreDate = CType(formt.Deserialize(fichier2), List(Of Membre))
            ListBox2.DataSource = listeMembreDate
        End If


        fichier.Close()
        fichier.Dispose()
        fichier2.Close()
        fichier2.Dispose()
    End Sub
    Dim fichier As FileStream
    Dim fichier2 As FileStream
    Dim fichier3 As FileStream
    Public Sub save()
        'fichier = New FileStream("Membres2.bin", FileMode.OpenOrCreate)

        'fichier.Close()

        If liste.Count > 0 Then
            formt.Serialize(fichier, liste)
        End If
        fichier.Close()
        fichier.Dispose()
        ' fichier2 = New FileStream("MembresDate2.bin", FileMode.OpenOrCreate)

        If liste.Count > 0 Then
            formt.Serialize(fichier2, listeMembreDate)
        End If
        LoadTour()
        fichier2.Close()
        fichier2.Dispose()
    End Sub

    Public Sub saveTour()
        fichier3 = New FileStream("Tour2.bin", FileMode.OpenOrCreate)
        If listetour.Count > 0 Then
            formt.Serialize(fichier3, listetour)
        End If
        fichier3.Close()
        fichier3.Dispose()
    End Sub

    Public Sub LoadTour()
        fichier3 = New FileStream("Tour2.bin", FileMode.OpenOrCreate)
        If fichier3.Length > 0 Then
            listetour = CType(formt.Deserialize(fichier3), List(Of Tour))
        End If
        fichier3.Close()
        fichier3.Dispose()
    End Sub
    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Try
            Dim mm As New Membre(txtNom.Text)
            liste.Add(mm)
            save()
            MsgBox("Enregistrement Effectué !")
            Form1_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If fichier.CanWrite Then
                fichier.Close()
            End If

        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        RadForm1.Show()
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim h As Integer = ListBox1.SelectedIndices.Count()
        For i As Integer = 0 To h - 1
            liste.RemoveAt(ListBox1.SelectedIndices(i))
        Next
        save()
        Form1_Load(sender, e)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        txtNom.Text = CType(ListBox1.SelectedItem, Custom.Membre).Nom
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        For Each elt As Membre In liste
            If elt.Nom.Equals(CType(ListBox1.SelectedItem, Custom.Membre).Nom) Then
                elt.Nom = txtNom.Text
            End If
        Next
        save()
        Form1_Load(sender, e)
    End Sub

    Private Sub RadLabel3_Click(sender As Object, e As EventArgs) Handles RadLabel3.Click

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click

    End Sub
End Class
