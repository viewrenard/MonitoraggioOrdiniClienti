<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoraggioOrdini
	Inherits System.Windows.Forms.Form

	'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Richiesto da Progettazione Windows Form
	Private components As System.ComponentModel.IContainer

	'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
	'Può essere modificata in Progettazione Windows Form.  
	'Non modificarla mediante l'editor del codice.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MonitoraggioOrdini))
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.AdapterOrdini = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterContainer = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterFatture = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterVoci = New System.Data.SqlClient.SqlDataAdapter()
		Me.GridOrdini = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.DataViewDettagli = New System.Data.DataView()
		Me.DsOrdini1 = New MonitoraggioOrdiniClienti.DsOrdini()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtGiorniPrima = New System.Windows.Forms.TextBox()
		Me.TxtGiorniDopo = New System.Windows.Forms.TextBox()
		Me.BtCarica = New System.Windows.Forms.Button()
		Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.AdapterDiscrepanze = New System.Data.SqlClient.SqlDataAdapter()
		Me.GridDiscrepanze = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
		Me.DsOrdini = New MonitoraggioOrdiniClienti.DsOrdini()
		Me.BkWorker1 = New System.ComponentModel.BackgroundWorker()
		CType(Me.GridOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataViewDettagli, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsOrdini1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridDiscrepanze, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DsOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection1
		Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@DataConsegna", System.Data.SqlDbType.SmallDateTime, 4, "dataConsegna"), New System.Data.SqlClient.SqlParameter("@dataconsegna1", System.Data.SqlDbType.SmallDateTime, 4, "dataConsegna")})
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=DATASERVER\SQLPROCEDURA;Initial Catalog=vermarnew;User ID=fox;Passwor" &
	"d=31iris46"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'AdapterOrdini
		'
		Me.AdapterOrdini.SelectCommand = Me.SqlSelectCommand1
		Me.AdapterOrdini.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArchivioFornitori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdOrdine", "IdOrdine"), New System.Data.Common.DataColumnMapping("DataOrdine", "DataOrdine"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Riferimento", "Riferimento"), New System.Data.Common.DataColumnMapping("RifOrdCliente", "RifOrdCliente"), New System.Data.Common.DataColumnMapping("dataConsegna", "dataConsegna"), New System.Data.Common.DataColumnMapping("luogoConsegna", "luogoConsegna"), New System.Data.Common.DataColumnMapping("Nave", "Nave"), New System.Data.Common.DataColumnMapping("Responsabile", "Responsabile"), New System.Data.Common.DataColumnMapping("Note", "Note")})})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
		Me.SqlSelectCommand2.Connection = Me.SqlConnection1
		Me.SqlSelectCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdOrdine", System.Data.SqlDbType.Int, 4, "IdOrd")})
		'
		'AdapterContainer
		'
		Me.AdapterContainer.SelectCommand = Me.SqlSelectCommand2
		Me.AdapterContainer.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ContainersOrdine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Flag", "Flag"), New System.Data.Common.DataColumnMapping("NumContainer", "NumContainer"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione")})})
		'
		'SqlSelectCommand3
		'
		Me.SqlSelectCommand3.CommandText = "SELECT        N_Fattura, Data, IdFattura, Intestazione, CodMRN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            F" &
	"atturazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY IdFattura DESC"
		Me.SqlSelectCommand3.Connection = Me.SqlConnection1
		'
		'AdapterFatture
		'
		Me.AdapterFatture.SelectCommand = Me.SqlSelectCommand3
		Me.AdapterFatture.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Fatturazione", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("N_Fattura", "N_Fattura"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("IdFattura", "IdFattura"), New System.Data.Common.DataColumnMapping("Intestazione", "Intestazione"), New System.Data.Common.DataColumnMapping("CodMRN", "CodMRN")})})
		'
		'SqlSelectCommand4
		'
		Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
		Me.SqlSelectCommand4.Connection = Me.SqlConnection1
		Me.SqlSelectCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@dataconsegna", System.Data.SqlDbType.SmallDateTime, 4, "dataConsegna"), New System.Data.SqlClient.SqlParameter("@dataconsegna1", System.Data.SqlDbType.SmallDateTime, 4, "dataConsegna")})
		'
		'AdapterVoci
		'
		Me.AdapterVoci.SelectCommand = Me.SqlSelectCommand4
		Me.AdapterVoci.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "VociSettimanali", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdOrdine", "IdOrdine"), New System.Data.Common.DataColumnMapping("Data", "Data"), New System.Data.Common.DataColumnMapping("Riferimento", "Riferimento"), New System.Data.Common.DataColumnMapping("Cliente", "Cliente"), New System.Data.Common.DataColumnMapping("Note", "Note"), New System.Data.Common.DataColumnMapping("dataConsegna", "dataConsegna"), New System.Data.Common.DataColumnMapping("luogoConsegna", "luogoConsegna"), New System.Data.Common.DataColumnMapping("Responsabile", "Responsabile"), New System.Data.Common.DataColumnMapping("RifOrdCliente", "RifOrdCliente"), New System.Data.Common.DataColumnMapping("SE_Fatt", "SE_Fatt"), New System.Data.Common.DataColumnMapping("SE_Scarico", "SE_Scarico"), New System.Data.Common.DataColumnMapping("Se_Dogana", "Se_Dogana"), New System.Data.Common.DataColumnMapping("Nave", "Nave")})})
		'
		'GridOrdini
		'
		Me.GridOrdini.AllowUpdate = False
		Me.GridOrdini.DataSource = Me.DataViewDettagli
		Me.GridOrdini.FetchRowStyles = True
		Me.GridOrdini.Images.Add(CType(resources.GetObject("GridOrdini.Images"), System.Drawing.Image))
		Me.GridOrdini.Location = New System.Drawing.Point(2, 3)
		Me.GridOrdini.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell
		Me.GridOrdini.Name = "GridOrdini"
		Me.GridOrdini.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.GridOrdini.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.GridOrdini.PreviewInfo.ZoomFactor = 75.0R
		Me.GridOrdini.PrintInfo.PageSettings = CType(resources.GetObject("GridOrdini.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.GridOrdini.PropBag = resources.GetString("GridOrdini.PropBag")
		Me.GridOrdini.RowHeight = 20
		Me.GridOrdini.Size = New System.Drawing.Size(1333, 462)
		Me.GridOrdini.TabIndex = 0
		Me.GridOrdini.Text = "C1TrueDBGrid1"
		'
		'DataViewDettagli
		'
		Me.DataViewDettagli.Table = Me.DsOrdini1.VociSettimanali
		'
		'DsOrdini1
		'
		Me.DsOrdini1.DataSetName = "DsOrdini"
		Me.DsOrdini1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(1341, 18)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(85, 46)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Giorni Precedenti alla Data Odierna"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(1341, 92)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(85, 46)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Giorni Successivi Alla Odierna"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtGiorniPrima
		'
		Me.TxtGiorniPrima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtGiorniPrima.Location = New System.Drawing.Point(1366, 67)
		Me.TxtGiorniPrima.Name = "TxtGiorniPrima"
		Me.TxtGiorniPrima.Size = New System.Drawing.Size(31, 22)
		Me.TxtGiorniPrima.TabIndex = 3
		Me.TxtGiorniPrima.Text = "1"
		Me.TxtGiorniPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TxtGiorniDopo
		'
		Me.TxtGiorniDopo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtGiorniDopo.Location = New System.Drawing.Point(1366, 141)
		Me.TxtGiorniDopo.Name = "TxtGiorniDopo"
		Me.TxtGiorniDopo.Size = New System.Drawing.Size(31, 22)
		Me.TxtGiorniDopo.TabIndex = 4
		Me.TxtGiorniDopo.Text = "2"
		Me.TxtGiorniDopo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'BtCarica
		'
		Me.BtCarica.Location = New System.Drawing.Point(1341, 183)
		Me.BtCarica.Name = "BtCarica"
		Me.BtCarica.Size = New System.Drawing.Size(75, 23)
		Me.BtCarica.TabIndex = 5
		Me.BtCarica.Text = "Carica Dati"
		Me.BtCarica.UseVisualStyleBackColor = True
		'
		'SqlSelectCommand5
		'
		Me.SqlSelectCommand5.CommandText = resources.GetString("SqlSelectCommand5.CommandText")
		Me.SqlSelectCommand5.Connection = Me.SqlConnection1
		Me.SqlSelectCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumOrdine", System.Data.SqlDbType.Int, 4, "IdOrd")})
		'
		'AdapterDiscrepanze
		'
		Me.AdapterDiscrepanze.SelectCommand = Me.SqlSelectCommand5
		Me.AdapterDiscrepanze.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ListGenDettagli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("progressivo", "progressivo"), New System.Data.Common.DataColumnMapping("IDRiga", "IDRiga"), New System.Data.Common.DataColumnMapping("Descrizione", "Descrizione"), New System.Data.Common.DataColumnMapping("DAA", "DAA"), New System.Data.Common.DataColumnMapping("FlagT1", "FlagT1"), New System.Data.Common.DataColumnMapping("NumOrdQuant", "NumOrdQuant"), New System.Data.Common.DataColumnMapping("NumOrdPrezzo", "NumOrdPrezzo"), New System.Data.Common.DataColumnMapping("UDM", "UDM"), New System.Data.Common.DataColumnMapping("colli", "colli"), New System.Data.Common.DataColumnMapping("NumContainer", "NumContainer"), New System.Data.Common.DataColumnMapping("ColliMagazzino", "ColliMagazzino"), New System.Data.Common.DataColumnMapping("FattQuantNumerico", "FattQuantNumerico"), New System.Data.Common.DataColumnMapping("FattPrezzoNumerico", "FattPrezzoNumerico")})})
		'
		'GridDiscrepanze
		'
		Me.GridDiscrepanze.AllowUpdate = False
		Me.GridDiscrepanze.DataMember = "Discrepanze"
		Me.GridDiscrepanze.DataSource = Me.DsOrdini1
		Me.GridDiscrepanze.Images.Add(CType(resources.GetObject("GridDiscrepanze.Images"), System.Drawing.Image))
		Me.GridDiscrepanze.Location = New System.Drawing.Point(2, 480)
		Me.GridDiscrepanze.Name = "GridDiscrepanze"
		Me.GridDiscrepanze.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.GridDiscrepanze.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.GridDiscrepanze.PreviewInfo.ZoomFactor = 75.0R
		Me.GridDiscrepanze.PrintInfo.PageSettings = CType(resources.GetObject("GridDiscrepanze.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.GridDiscrepanze.PropBag = resources.GetString("GridDiscrepanze.PropBag")
		Me.GridDiscrepanze.Size = New System.Drawing.Size(859, 190)
		Me.GridDiscrepanze.TabIndex = 6
		Me.GridDiscrepanze.Text = "C1TrueDBGrid1"
		'
		'DsOrdini
		'
		Me.DsOrdini.DataSetName = "DsOrdini"
		Me.DsOrdini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MonitoraggioOrdini
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1428, 668)
		Me.Controls.Add(Me.GridDiscrepanze)
		Me.Controls.Add(Me.BtCarica)
		Me.Controls.Add(Me.TxtGiorniDopo)
		Me.Controls.Add(Me.TxtGiorniPrima)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GridOrdini)
		Me.Name = "MonitoraggioOrdini"
		Me.Text = "Monitoraggio Ordini Clienti"
		CType(Me.GridOrdini, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataViewDettagli, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsOrdini1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridDiscrepanze, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DsOrdini, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
	Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
	Friend WithEvents AdapterOrdini As SqlClient.SqlDataAdapter
	Friend WithEvents DsOrdini1 As DsOrdini
	Friend WithEvents SqlSelectCommand2 As SqlClient.SqlCommand
	Friend WithEvents AdapterContainer As SqlClient.SqlDataAdapter
	Friend WithEvents SqlSelectCommand3 As SqlClient.SqlCommand
	Friend WithEvents AdapterFatture As SqlClient.SqlDataAdapter
	Friend WithEvents SqlSelectCommand4 As SqlClient.SqlCommand
	Friend WithEvents AdapterVoci As SqlClient.SqlDataAdapter
	Friend WithEvents DataViewDettagli As DataView
	Friend WithEvents GridOrdini As C1.Win.C1TrueDBGrid.C1TrueDBGrid
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TxtGiorniPrima As TextBox
	Friend WithEvents TxtGiorniDopo As TextBox
	Friend WithEvents BtCarica As Button
	Friend WithEvents SqlSelectCommand5 As SqlClient.SqlCommand
	Friend WithEvents AdapterDiscrepanze As SqlClient.SqlDataAdapter
	Friend WithEvents GridDiscrepanze As C1.Win.C1TrueDBGrid.C1TrueDBGrid
	Friend WithEvents DsOrdini As DsOrdini
	Friend WithEvents BkWorker1 As System.ComponentModel.BackgroundWorker
End Class
