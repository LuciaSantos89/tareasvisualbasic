<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JugarLoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.inputPremioSorteo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.botonAgregarAleatorio = New System.Windows.Forms.Button()
        Me.botonAgregarManual = New System.Windows.Forms.Button()
        Me.inputNumero6 = New System.Windows.Forms.NumericUpDown()
        Me.inputNumero5 = New System.Windows.Forms.NumericUpDown()
        Me.inputNumero4 = New System.Windows.Forms.NumericUpDown()
        Me.inputNumero3 = New System.Windows.Forms.NumericUpDown()
        Me.inputNumero2 = New System.Windows.Forms.NumericUpDown()
        Me.inputNumero1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tablaNumeros = New System.Windows.Forms.DataGridView()
        Me.Uno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuatro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cinco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.inputNumeroGanador6 = New System.Windows.Forms.TextBox()
        Me.inputNumeroGanador5 = New System.Windows.Forms.TextBox()
        Me.inputNumeroGanador4 = New System.Windows.Forms.TextBox()
        Me.inputNumeroGanador3 = New System.Windows.Forms.TextBox()
        Me.inputNumeroGanador2 = New System.Windows.Forms.TextBox()
        Me.inputNumeroGanador1 = New System.Windows.Forms.TextBox()
        Me.botonGenerarGanador = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.inputPremioSeis = New System.Windows.Forms.TextBox()
        Me.inputPremioCinco = New System.Windows.Forms.TextBox()
        Me.inputPremioCuatro = New System.Windows.Forms.TextBox()
        Me.inputGanadoresSeis = New System.Windows.Forms.TextBox()
        Me.inputGanadoresCinco = New System.Windows.Forms.TextBox()
        Me.inputGanadoresCuatro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.botonNuevoSorteo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.inputNumero6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputNumero5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputNumero4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputNumero3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputNumero2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputNumero1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.tablaNumeros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.inputPremioSorteo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 56)
        Me.Panel1.TabIndex = 0
        '
        'inputPremioSorteo
        '
        Me.inputPremioSorteo.Enabled = False
        Me.inputPremioSorteo.Location = New System.Drawing.Point(185, 16)
        Me.inputPremioSorteo.Name = "inputPremioSorteo"
        Me.inputPremioSorteo.Size = New System.Drawing.Size(100, 20)
        Me.inputPremioSorteo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Premio Sorteo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.botonAgregarAleatorio)
        Me.Panel2.Controls.Add(Me.botonAgregarManual)
        Me.Panel2.Controls.Add(Me.inputNumero6)
        Me.Panel2.Controls.Add(Me.inputNumero5)
        Me.Panel2.Controls.Add(Me.inputNumero4)
        Me.Panel2.Controls.Add(Me.inputNumero3)
        Me.Panel2.Controls.Add(Me.inputNumero2)
        Me.Panel2.Controls.Add(Me.inputNumero1)
        Me.Panel2.Location = New System.Drawing.Point(42, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 105)
        Me.Panel2.TabIndex = 1
        '
        'botonAgregarAleatorio
        '
        Me.botonAgregarAleatorio.Location = New System.Drawing.Point(216, 74)
        Me.botonAgregarAleatorio.Name = "botonAgregarAleatorio"
        Me.botonAgregarAleatorio.Size = New System.Drawing.Size(141, 23)
        Me.botonAgregarAleatorio.TabIndex = 7
        Me.botonAgregarAleatorio.Text = "Agregar boleto aleatorio"
        Me.botonAgregarAleatorio.UseVisualStyleBackColor = True
        '
        'botonAgregarManual
        '
        Me.botonAgregarManual.Location = New System.Drawing.Point(48, 74)
        Me.botonAgregarManual.Name = "botonAgregarManual"
        Me.botonAgregarManual.Size = New System.Drawing.Size(145, 23)
        Me.botonAgregarManual.TabIndex = 6
        Me.botonAgregarManual.Text = "Agregar boleto manual"
        Me.botonAgregarManual.UseVisualStyleBackColor = True
        '
        'inputNumero6
        '
        Me.inputNumero6.Location = New System.Drawing.Point(295, 22)
        Me.inputNumero6.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero6.Name = "inputNumero6"
        Me.inputNumero6.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero6.TabIndex = 5
        Me.inputNumero6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero5
        '
        Me.inputNumero5.Location = New System.Drawing.Point(248, 22)
        Me.inputNumero5.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero5.Name = "inputNumero5"
        Me.inputNumero5.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero5.TabIndex = 4
        Me.inputNumero5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero4
        '
        Me.inputNumero4.Location = New System.Drawing.Point(201, 22)
        Me.inputNumero4.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero4.Name = "inputNumero4"
        Me.inputNumero4.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero4.TabIndex = 3
        Me.inputNumero4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero3
        '
        Me.inputNumero3.Location = New System.Drawing.Point(154, 22)
        Me.inputNumero3.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero3.Name = "inputNumero3"
        Me.inputNumero3.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero3.TabIndex = 2
        Me.inputNumero3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero2
        '
        Me.inputNumero2.Location = New System.Drawing.Point(107, 22)
        Me.inputNumero2.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero2.Name = "inputNumero2"
        Me.inputNumero2.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero2.TabIndex = 1
        Me.inputNumero2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero1
        '
        Me.inputNumero1.Location = New System.Drawing.Point(60, 22)
        Me.inputNumero1.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero1.Name = "inputNumero1"
        Me.inputNumero1.Size = New System.Drawing.Size(41, 20)
        Me.inputNumero1.TabIndex = 0
        Me.inputNumero1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tablaNumeros)
        Me.Panel3.Location = New System.Drawing.Point(42, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(392, 162)
        Me.Panel3.TabIndex = 2
        '
        'tablaNumeros
        '
        Me.tablaNumeros.AllowUserToAddRows = False
        Me.tablaNumeros.AllowUserToDeleteRows = False
        Me.tablaNumeros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaNumeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Uno, Me.Dos, Me.Tres, Me.Cuatro, Me.Cinco, Me.Seis})
        Me.tablaNumeros.Location = New System.Drawing.Point(32, 12)
        Me.tablaNumeros.Name = "tablaNumeros"
        Me.tablaNumeros.ReadOnly = True
        Me.tablaNumeros.Size = New System.Drawing.Size(343, 150)
        Me.tablaNumeros.TabIndex = 0
        '
        'Uno
        '
        Me.Uno.HeaderText = "Uno"
        Me.Uno.Name = "Uno"
        Me.Uno.ReadOnly = True
        Me.Uno.Width = 50
        '
        'Dos
        '
        Me.Dos.HeaderText = "Dos"
        Me.Dos.Name = "Dos"
        Me.Dos.ReadOnly = True
        Me.Dos.Width = 50
        '
        'Tres
        '
        Me.Tres.HeaderText = "Tres"
        Me.Tres.Name = "Tres"
        Me.Tres.ReadOnly = True
        Me.Tres.Width = 50
        '
        'Cuatro
        '
        Me.Cuatro.HeaderText = "Cuatro"
        Me.Cuatro.Name = "Cuatro"
        Me.Cuatro.ReadOnly = True
        Me.Cuatro.Width = 50
        '
        'Cinco
        '
        Me.Cinco.HeaderText = "Cinco"
        Me.Cinco.Name = "Cinco"
        Me.Cinco.ReadOnly = True
        Me.Cinco.Width = 50
        '
        'Seis
        '
        Me.Seis.HeaderText = "Seis"
        Me.Seis.Name = "Seis"
        Me.Seis.ReadOnly = True
        Me.Seis.Width = 50
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.inputNumeroGanador6)
        Me.Panel4.Controls.Add(Me.inputNumeroGanador5)
        Me.Panel4.Controls.Add(Me.inputNumeroGanador4)
        Me.Panel4.Controls.Add(Me.inputNumeroGanador3)
        Me.Panel4.Controls.Add(Me.inputNumeroGanador2)
        Me.Panel4.Controls.Add(Me.inputNumeroGanador1)
        Me.Panel4.Controls.Add(Me.botonGenerarGanador)
        Me.Panel4.Location = New System.Drawing.Point(42, 362)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 75)
        Me.Panel4.TabIndex = 3
        '
        'inputNumeroGanador6
        '
        Me.inputNumeroGanador6.Enabled = False
        Me.inputNumeroGanador6.Location = New System.Drawing.Point(279, 38)
        Me.inputNumeroGanador6.Name = "inputNumeroGanador6"
        Me.inputNumeroGanador6.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador6.TabIndex = 6
        '
        'inputNumeroGanador5
        '
        Me.inputNumeroGanador5.Enabled = False
        Me.inputNumeroGanador5.Location = New System.Drawing.Point(236, 38)
        Me.inputNumeroGanador5.Name = "inputNumeroGanador5"
        Me.inputNumeroGanador5.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador5.TabIndex = 5
        '
        'inputNumeroGanador4
        '
        Me.inputNumeroGanador4.Enabled = False
        Me.inputNumeroGanador4.Location = New System.Drawing.Point(195, 38)
        Me.inputNumeroGanador4.Name = "inputNumeroGanador4"
        Me.inputNumeroGanador4.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador4.TabIndex = 4
        '
        'inputNumeroGanador3
        '
        Me.inputNumeroGanador3.Enabled = False
        Me.inputNumeroGanador3.Location = New System.Drawing.Point(153, 38)
        Me.inputNumeroGanador3.Name = "inputNumeroGanador3"
        Me.inputNumeroGanador3.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador3.TabIndex = 3
        '
        'inputNumeroGanador2
        '
        Me.inputNumeroGanador2.Enabled = False
        Me.inputNumeroGanador2.Location = New System.Drawing.Point(110, 38)
        Me.inputNumeroGanador2.Name = "inputNumeroGanador2"
        Me.inputNumeroGanador2.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador2.TabIndex = 2
        '
        'inputNumeroGanador1
        '
        Me.inputNumeroGanador1.Enabled = False
        Me.inputNumeroGanador1.Location = New System.Drawing.Point(69, 38)
        Me.inputNumeroGanador1.Name = "inputNumeroGanador1"
        Me.inputNumeroGanador1.Size = New System.Drawing.Size(37, 20)
        Me.inputNumeroGanador1.TabIndex = 1
        '
        'botonGenerarGanador
        '
        Me.botonGenerarGanador.Location = New System.Drawing.Point(115, 3)
        Me.botonGenerarGanador.Name = "botonGenerarGanador"
        Me.botonGenerarGanador.Size = New System.Drawing.Size(115, 23)
        Me.botonGenerarGanador.TabIndex = 0
        Me.botonGenerarGanador.Text = "Generar boleto "
        Me.botonGenerarGanador.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.inputPremioSeis)
        Me.Panel5.Controls.Add(Me.inputPremioCinco)
        Me.Panel5.Controls.Add(Me.inputPremioCuatro)
        Me.Panel5.Controls.Add(Me.inputGanadoresSeis)
        Me.Panel5.Controls.Add(Me.inputGanadoresCinco)
        Me.Panel5.Controls.Add(Me.inputGanadoresCuatro)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(41, 442)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(395, 126)
        Me.Panel5.TabIndex = 4
        '
        'inputPremioSeis
        '
        Me.inputPremioSeis.Enabled = False
        Me.inputPremioSeis.Location = New System.Drawing.Point(310, 85)
        Me.inputPremioSeis.Name = "inputPremioSeis"
        Me.inputPremioSeis.Size = New System.Drawing.Size(63, 20)
        Me.inputPremioSeis.TabIndex = 11
        '
        'inputPremioCinco
        '
        Me.inputPremioCinco.Enabled = False
        Me.inputPremioCinco.Location = New System.Drawing.Point(310, 59)
        Me.inputPremioCinco.Name = "inputPremioCinco"
        Me.inputPremioCinco.Size = New System.Drawing.Size(63, 20)
        Me.inputPremioCinco.TabIndex = 10
        '
        'inputPremioCuatro
        '
        Me.inputPremioCuatro.Enabled = False
        Me.inputPremioCuatro.Location = New System.Drawing.Point(310, 29)
        Me.inputPremioCuatro.Name = "inputPremioCuatro"
        Me.inputPremioCuatro.Size = New System.Drawing.Size(63, 20)
        Me.inputPremioCuatro.TabIndex = 9
        '
        'inputGanadoresSeis
        '
        Me.inputGanadoresSeis.Enabled = False
        Me.inputGanadoresSeis.Location = New System.Drawing.Point(133, 82)
        Me.inputGanadoresSeis.Name = "inputGanadoresSeis"
        Me.inputGanadoresSeis.Size = New System.Drawing.Size(63, 20)
        Me.inputGanadoresSeis.TabIndex = 8
        '
        'inputGanadoresCinco
        '
        Me.inputGanadoresCinco.Enabled = False
        Me.inputGanadoresCinco.Location = New System.Drawing.Point(133, 56)
        Me.inputGanadoresCinco.Name = "inputGanadoresCinco"
        Me.inputGanadoresCinco.Size = New System.Drawing.Size(63, 20)
        Me.inputGanadoresCinco.TabIndex = 7
        '
        'inputGanadoresCuatro
        '
        Me.inputGanadoresCuatro.Enabled = False
        Me.inputGanadoresCuatro.Location = New System.Drawing.Point(133, 26)
        Me.inputGanadoresCuatro.Name = "inputGanadoresCuatro"
        Me.inputGanadoresCuatro.Size = New System.Drawing.Size(63, 20)
        Me.inputGanadoresCuatro.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(217, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Premio cada uno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(218, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Premio cada uno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(217, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Premio cada uno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ganadores 6 números"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ganadores 5 números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ganadores 4 números"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.botonNuevoSorteo)
        Me.Panel6.Location = New System.Drawing.Point(40, 574)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(394, 57)
        Me.Panel6.TabIndex = 5
        '
        'botonNuevoSorteo
        '
        Me.botonNuevoSorteo.Location = New System.Drawing.Point(132, 13)
        Me.botonNuevoSorteo.Name = "botonNuevoSorteo"
        Me.botonNuevoSorteo.Size = New System.Drawing.Size(121, 23)
        Me.botonNuevoSorteo.TabIndex = 0
        Me.botonNuevoSorteo.Text = "Nuevo Sorteo"
        Me.botonNuevoSorteo.UseVisualStyleBackColor = True
        '
        'JugarLoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 649)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "JugarLoto"
        Me.Text = "Jugar Loto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.inputNumero6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputNumero5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputNumero4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputNumero3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputNumero2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputNumero1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.tablaNumeros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents inputNumero1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents inputPremioSorteo As System.Windows.Forms.TextBox
    Friend WithEvents botonAgregarAleatorio As System.Windows.Forms.Button
    Friend WithEvents botonAgregarManual As System.Windows.Forms.Button
    Friend WithEvents inputNumero6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents inputNumero5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents inputNumero4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents inputNumero3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents inputNumero2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents tablaNumeros As System.Windows.Forms.DataGridView
    Friend WithEvents Uno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuatro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cinco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents inputNumeroGanador6 As System.Windows.Forms.TextBox
    Friend WithEvents inputNumeroGanador5 As System.Windows.Forms.TextBox
    Friend WithEvents inputNumeroGanador4 As System.Windows.Forms.TextBox
    Friend WithEvents inputNumeroGanador3 As System.Windows.Forms.TextBox
    Friend WithEvents inputNumeroGanador2 As System.Windows.Forms.TextBox
    Friend WithEvents inputNumeroGanador1 As System.Windows.Forms.TextBox
    Friend WithEvents botonGenerarGanador As System.Windows.Forms.Button
    Friend WithEvents inputPremioSeis As System.Windows.Forms.TextBox
    Friend WithEvents inputPremioCinco As System.Windows.Forms.TextBox
    Friend WithEvents inputPremioCuatro As System.Windows.Forms.TextBox
    Friend WithEvents inputGanadoresSeis As System.Windows.Forms.TextBox
    Friend WithEvents inputGanadoresCinco As System.Windows.Forms.TextBox
    Friend WithEvents inputGanadoresCuatro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents botonNuevoSorteo As System.Windows.Forms.Button

End Class
