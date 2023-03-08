Imports System.Math

Public Class RadForm1
    Dim ran As New Random()
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim valeur As String
        Dim etat As Boolean = True
        Dim ent As Integer = ran.Next(0, Form1.liste.Count())
        For Each mb As Membre In Form1.listeMembreDate
            If (mb.datetir.Date = Date.Now.Date) Then
                etat = False
            End If
        Next
        If etat Then
            If Form1.liste.Count() > Form1.listeMembreDate.Count Then

                While verif(Form1.liste(ent).Nom)
                    'valeur = Form1.liste(ran.Next(0, Form1.liste.Count() - 1)).Nom
                    ent = ran.Next(0, Form1.liste.Count() - 1)
                End While
                txtgene.Text = Form1.liste(ent).Nom
                Dim meb As New Membre(Form1.liste(ent).Nom, Date.Now())
                Form1.listeMembreDate.Add(meb)
                Form1.liste.RemoveAt(ent)
                If Form1.liste.Count() = 0 Then
                    Form1.listetour.Add(New Tour(Date.Now))
                    Form1.saveTour()
                    Form1.LoadTour()
                    If Form1.listetour.Count() > 0 Then
                        RadLabelElement1.Text = Form1.listetour.Count().ToString
                    Else
                        RadLabelElement1.Text = "0"
                    End If
                End If

                Dim frp As New Form1()
                frp.save()
                Timer1.Stop()
            End If
        Else
            Timer1.Stop()
            MsgBox("Un tirage deja effectué pour cette journée !", MsgBoxStyle.Information)
        End If

    End Sub

    Private Function verif(chain As String) As Boolean
        For Each elt As Membre In Form1.listeMembreDate
            If elt.Nom.Equals(chain) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub RadForm1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
    End Sub
    Dim tab(5) As Telerik.WinControls.UI.RadRadioButton
    Private Sub RadForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tab(0) = rb1
        tab(1) = rb2
        tab(2) = rb3
        tab(3) = rb4
        tab(4) = rb5
        If Form1.listetour.Count() > 0 Then
            RadLabelElement2.Text = Form1.listetour.Count().ToString
        Else
            RadLabelElement2.Text = "0"
        End If
        Timer1.Start()
    End Sub
    Dim j As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If j = 4 Then
            j = 0
        Else
            j = j + 1
        End If
        tab(j).IsChecked = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class
