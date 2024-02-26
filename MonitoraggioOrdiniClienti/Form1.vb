Imports System.ComponentModel
Imports C1.Win.C1TrueDBGrid

Public Class MonitoraggioOrdini
	Private Sub MonitoraggioOrdini_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
	Private Sub Carica_tutto()
		DsOrdini1.Clear()
		GridOrdini.Caption = "Ordini dal: " & Today.AddDays(-7).ToShortDateString & " Al: " & Today.ToShortDateString
		AdapterVoci.SelectCommand.Parameters("@dataconsegna").Value = Today.AddDays(-CInt(TxtGiorniPrima.Text))
		AdapterVoci.SelectCommand.Parameters("@dataconsegna1").Value = Today.AddDays(CInt(TxtGiorniDopo.Text))
		AdapterVoci.Fill(DsOrdini1.VociSettimanali)
		Dim righe() As DataRow
		Dim rigapass As DataRow

		Dim riga As DataRow
		For Each riga In DsOrdini1.VociSettimanali
			If riga.RowState <> DataRowState.Deleted Then
				If IsNumeric(riga("FattQuantita")) Then riga("Fattquantita") = Format(CDec(riga("Fattquantita")), "#,###.00")
				If IsNumeric(riga("OrdineQuantita")) Then riga("Ordinequantita") = Format(CDec(riga("Ordinequantita")), "#,###.00")
				If IsNumeric(riga("CaricoQuantita")) Then riga("CaricoQuantita") = Format(CDec(riga("CaricoQuantita")), "#,###.00")
				'If CInt(riga("SE_FATT")) > 1 Then riga("SE_FATT") = CInt(CInt(riga("SE_FATT")) - (CInt(riga("SE_FATT_Con_Null")) - CInt(riga("SE_FATT"))))
				'If riga("SE_Scarico") = riga("NumArt") And riga("SE_FATT").ToString = "0" Then riga.Delete() Else riga("NumArt") = CInt(riga("NumArt")) - CInt(riga("Se_Scarico"))
				riga("NumArt") = CInt(riga("NumArt")) - CInt(riga("Se_Scarico"))
				If Not IsNumeric(riga("Fattquantita")) Then riga("FattQuantita") = 0
				If riga("FattQuantita") = riga("OrdineQuantita") Then riga.Delete()
			End If
		Next
		DsOrdini1.VociSettimanali.AcceptChanges()

	End Sub

	Private Sub GridOrdini_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles GridOrdini.OwnerDrawCell
		Select Case e.Column.Name
			Case "Num. Fatt."
				If GridOrdini(e.Row, "Num. Fatt.").ToString = "0" Then e.Style.BackColor = Color.Gold
			Case "Num. Boll."
				If GridOrdini(e.Row, "Num. Boll.").ToString = "0" Then e.Style.BackColor = Color.Khaki
			Case "Articoli  Non Fatt."
				If GridOrdini(e.Row, "Articoli  Non Fatt.").ToString <> "0" Then e.Style.BackColor = Color.OrangeRed
		End Select
	End Sub

	Private Sub TxtGiorniPrima_Leave(sender As Object, e As EventArgs) Handles TxtGiorniPrima.Leave
		If CInt(TxtGiorniPrima.Text) > 3 Or CInt(TxtGiorniPrima.Text) < 0 Then
			TxtGiorniPrima.SelectAll()
			TxtGiorniPrima.Focus()

		End If
	End Sub

	Private Sub TxtGiorniDopo_Leave(sender As Object, e As EventArgs) Handles TxtGiorniDopo.Leave
		If CInt(TxtGiorniDopo.Text) > 3 Or CInt(TxtGiorniDopo.Text) < 0 Then
			TxtGiorniDopo.SelectAll()
			TxtGiorniDopo.Focus()

		End If
	End Sub

	Private Sub BtCarica_Click(sender As Object, e As EventArgs) Handles BtCarica.Click
		Carica_tutto()
		BkWorker1.RunWorkerAsync()
	End Sub



	Private Sub GridOrdini_MouseUp(sender As Object, e As MouseEventArgs) Handles GridOrdini.MouseUp
		If GridOrdini.PointAt(e.X, e.Y) <> PointAtEnum.AtDataArea Then Exit Sub
		DsOrdini1.Discrepanze.Clear()
		AdapterDiscrepanze.SelectCommand.Parameters("@NumOrdine").Value = GridOrdini(GridOrdini.Row, "ordine").ToString
		AdapterDiscrepanze.Fill(DsOrdini1.Discrepanze)
		Dim riga As DataRow
		For Each riga In DsOrdini1.Discrepanze.Rows
			If IsNumeric(riga("FattQuantNumerico")) Then riga("FattQuantNumerico") = Format(CDec(riga("FattQuantNumerico")), "#,###.00")
			If IsNumeric(riga("FattQuantNumerico")) Then riga("FattQuantNumerico") = Format(CDec(riga("FattQuantNumerico")), "#,###.00")
		Next
	End Sub

	Private Sub BkWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BkWorker1.DoWork
		Dim numero As Integer = 0
		Dim ggg As MouseEventArgs

		Do Until numero > GridOrdini.RowCount
			If GridOrdini(numero, "Articoli Non Fatt.").ToString <> "0" Then
				numero = numero + 1
				GridOrdini.Row = numero
				GridOrdini_MouseUp(e, ggg)


			End If
		Loop




	End Sub
End Class
