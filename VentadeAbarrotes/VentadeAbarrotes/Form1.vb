Public Class Form1

    Const precioarroz As Double = 2.0
    Const preciofrijol As Double = 1.75
    Const precioazucar As Double = 2.5
    Const IVA As Double = 0.12


    Dim pagoSiniva As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoConiva As Double = 0
    Dim descuento As Double = 0
    Dim pagototal As Double = 0



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbsdearroz.Click
        pagoSiniva = (Val(txtArroz.Text) * precioarroz) + (Val(txtFrijol.Text) * preciofrijol) + (Val(txtAzucar.Text) * precioazucar)
        valorIVA = pagoSiniva * IVA
        pagoConiva = pagoSiniva + valorIVA
        descuento = pagoConiva * 0.025
        pagototal = pagoConiva - descuento


        LblR1.Text = pagoSiniva
        LblR2.Text = valorIVA
        LblR3.Text = pagoConiva
        LblR4.Text = descuento
        LblR5.Text = pagototal
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub txtArroz_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArroz.KeyPress

    End Sub
End Class
