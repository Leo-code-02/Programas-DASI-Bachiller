Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "0"
    End Sub

    Private Sub Buttonpunto_Click(sender As Object, e As EventArgs) Handles Buttonpunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TextBox1.Text, ".", CompareMethod.Text) = 0 Then
            TextBox1.Text &= "."
        End If

    End Sub

    Private Sub Buttonsuma_Click(sender As Object, e As EventArgs) Handles Buttonsuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub Buttonresta_Click(sender As Object, e As EventArgs) Handles Buttonresta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub Buttonmultiplicacion_Click(sender As Object, e As EventArgs) Handles Buttonmultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub Buttondivision_Click(sender As Object, e As EventArgs) Handles Buttondivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub Buttonigual_Click(sender As Object, e As EventArgs) Handles Buttonigual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub Buttonborrar_Click(sender As Object, e As EventArgs) Handles Buttonborrar.Click
        TextBox1.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextBox1.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            TextBox1.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If

    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBox1.Text = ""
            SePresionaOperador = False
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub





End Class
