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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Location = New System.Drawing.Point(10, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 50)
        Me.Panel1.TabIndex = 0
        '
        'inputPremioSorteo
        '
        Me.inputPremioSorteo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.inputPremioSorteo.BackColor = System.Drawing.Color.AliceBlue
        Me.inputPremioSorteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPremioSorteo.Enabled = False
        Me.inputPremioSorteo.ForeColor = System.Drawing.Color.Black
        Me.inputPremioSorteo.Location = New System.Drawing.Point(248, 16)
        Me.inputPremioSorteo.Name = "inputPremioSorteo"
        Me.inputPremioSorteo.Size = New System.Drawing.Size(150, 27)
        Me.inputPremioSorteo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Premio Sorteo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Location = New System.Drawing.Point(10, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 105)
        Me.Panel2.TabIndex = 1
        '
        'botonAgregarAleatorio
        '
        Me.botonAgregarAleatorio.BackColor = System.Drawing.Color.LightSteelBlue
        Me.botonAgregarAleatorio.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.botonAgregarAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAgregarAleatorio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAgregarAleatorio.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.botonAgregarAleatorio.Location = New System.Drawing.Point(272, 60)
        Me.botonAgregarAleatorio.Name = "botonAgregarAleatorio"
        Me.botonAgregarAleatorio.Size = New System.Drawing.Size(220, 30)
        Me.botonAgregarAleatorio.TabIndex = 7
        Me.botonAgregarAleatorio.Text = "Agregar boleto aleatorio"
        Me.botonAgregarAleatorio.UseVisualStyleBackColor = False
        '
        'botonAgregarManual
        '
        Me.botonAgregarManual.BackColor = System.Drawing.Color.LightSteelBlue
        Me.botonAgregarManual.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.botonAgregarManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonAgregarManual.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAgregarManual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.botonAgregarManual.Location = New System.Drawing.Point(23, 60)
        Me.botonAgregarManual.Name = "botonAgregarManual"
        Me.botonAgregarManual.Size = New System.Drawing.Size(220, 30)
        Me.botonAgregarManual.TabIndex = 6
        Me.botonAgregarManual.Text = "Agregar boleto manual"
        Me.botonAgregarManual.UseVisualStyleBackColor = False
        '
        'inputNumero6
        '
        Me.inputNumero6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero6.Location = New System.Drawing.Point(363, 16)
        Me.inputNumero6.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero6.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero6.Name = "inputNumero6"
        Me.inputNumero6.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero6.TabIndex = 5
        Me.inputNumero6.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero5
        '
        Me.inputNumero5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero5.Location = New System.Drawing.Point(316, 16)
        Me.inputNumero5.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero5.Name = "inputNumero5"
        Me.inputNumero5.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero5.TabIndex = 4
        Me.inputNumero5.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero4
        '
        Me.inputNumero4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero4.Location = New System.Drawing.Point(269, 16)
        Me.inputNumero4.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero4.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero4.Name = "inputNumero4"
        Me.inputNumero4.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero4.TabIndex = 3
        Me.inputNumero4.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero3
        '
        Me.inputNumero3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero3.Location = New System.Drawing.Point(222, 16)
        Me.inputNumero3.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero3.Name = "inputNumero3"
        Me.inputNumero3.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero3.TabIndex = 2
        Me.inputNumero3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero2
        '
        Me.inputNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero2.Location = New System.Drawing.Point(175, 16)
        Me.inputNumero2.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero2.Name = "inputNumero2"
        Me.inputNumero2.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero2.TabIndex = 1
        Me.inputNumero2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'inputNumero1
        '
        Me.inputNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumero1.Location = New System.Drawing.Point(128, 16)
        Me.inputNumero1.Maximum = New Decimal(New Integer() {33, 0, 0, 0})
        Me.inputNumero1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.inputNumero1.Name = "inputNumero1"
        Me.inputNumero1.Size = New System.Drawing.Size(40, 27)
        Me.inputNumero1.TabIndex = 0
        Me.inputNumero1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.tablaNumeros)
        Me.Panel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel3.Location = New System.Drawing.Point(10, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 175)
        Me.Panel3.TabIndex = 2
        '
        'tablaNumeros
        '
        Me.tablaNumeros.AllowUserToAddRows = False
        Me.tablaNumeros.AllowUserToDeleteRows = False
        Me.tablaNumeros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CornflowerBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tablaNumeros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tablaNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablaNumeros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Uno, Me.Dos, Me.Tres, Me.Cuatro, Me.Cinco, Me.Seis})
        Me.tablaNumeros.Location = New System.Drawing.Point(4, 10)
        Me.tablaNumeros.Name = "tablaNumeros"
        Me.tablaNumeros.ReadOnly = True
        Me.tablaNumeros.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.tablaNumeros.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablaNumeros.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.tablaNumeros.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.tablaNumeros.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.AliceBlue
        Me.tablaNumeros.Size = New System.Drawing.Size(511, 157)
        Me.tablaNumeros.TabIndex = 0
        '
        'Uno
        '
        Me.Uno.HeaderText = "Uno"
        Me.Uno.Name = "Uno"
        Me.Uno.ReadOnly = True
        Me.Uno.Width = 78
        '
        'Dos
        '
        Me.Dos.HeaderText = "Dos"
        Me.Dos.Name = "Dos"
        Me.Dos.ReadOnly = True
        Me.Dos.Width = 78
        '
        'Tres
        '
        Me.Tres.HeaderText = "Tres"
        Me.Tres.Name = "Tres"
        Me.Tres.ReadOnly = True
        Me.Tres.Width = 78
        '
        'Cuatro
        '
        Me.Cuatro.HeaderText = "Cuatro"
        Me.Cuatro.Name = "Cuatro"
        Me.Cuatro.ReadOnly = True
        Me.Cuatro.Width = 78
        '
        'Cinco
        '
        Me.Cinco.HeaderText = "Cinco"
        Me.Cinco.Name = "Cinco"
        Me.Cinco.ReadOnly = True
        Me.Cinco.Width = 78
        '
        'Seis
        '
        Me.Seis.HeaderText = "Seis"
        Me.Seis.Name = "Seis"
        Me.Seis.ReadOnly = True
        Me.Seis.Width = 78
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
        Me.Panel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel4.Location = New System.Drawing.Point(10, 339)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(520, 91)
        Me.Panel4.TabIndex = 3
        '
        'inputNumeroGanador6
        '
        Me.inputNumeroGanador6.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador6.Enabled = False
        Me.inputNumeroGanador6.Location = New System.Drawing.Point(360, 53)
        Me.inputNumeroGanador6.Name = "inputNumeroGanador6"
        Me.inputNumeroGanador6.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador6.TabIndex = 6
        '
        'inputNumeroGanador5
        '
        Me.inputNumeroGanador5.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador5.Enabled = False
        Me.inputNumeroGanador5.Location = New System.Drawing.Point(314, 53)
        Me.inputNumeroGanador5.Name = "inputNumeroGanador5"
        Me.inputNumeroGanador5.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador5.TabIndex = 5
        '
        'inputNumeroGanador4
        '
        Me.inputNumeroGanador4.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador4.Enabled = False
        Me.inputNumeroGanador4.Location = New System.Drawing.Point(268, 53)
        Me.inputNumeroGanador4.Name = "inputNumeroGanador4"
        Me.inputNumeroGanador4.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador4.TabIndex = 4
        '
        'inputNumeroGanador3
        '
        Me.inputNumeroGanador3.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador3.Enabled = False
        Me.inputNumeroGanador3.Location = New System.Drawing.Point(221, 53)
        Me.inputNumeroGanador3.Name = "inputNumeroGanador3"
        Me.inputNumeroGanador3.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador3.TabIndex = 3
        '
        'inputNumeroGanador2
        '
        Me.inputNumeroGanador2.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador2.Enabled = False
        Me.inputNumeroGanador2.Location = New System.Drawing.Point(174, 53)
        Me.inputNumeroGanador2.Name = "inputNumeroGanador2"
        Me.inputNumeroGanador2.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador2.TabIndex = 2
        '
        'inputNumeroGanador1
        '
        Me.inputNumeroGanador1.BackColor = System.Drawing.Color.AliceBlue
        Me.inputNumeroGanador1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputNumeroGanador1.Enabled = False
        Me.inputNumeroGanador1.Location = New System.Drawing.Point(128, 53)
        Me.inputNumeroGanador1.Name = "inputNumeroGanador1"
        Me.inputNumeroGanador1.Size = New System.Drawing.Size(40, 27)
        Me.inputNumeroGanador1.TabIndex = 1
        '
        'botonGenerarGanador
        '
        Me.botonGenerarGanador.BackColor = System.Drawing.Color.LightSteelBlue
        Me.botonGenerarGanador.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.botonGenerarGanador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonGenerarGanador.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonGenerarGanador.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.botonGenerarGanador.Location = New System.Drawing.Point(155, 10)
        Me.botonGenerarGanador.Name = "botonGenerarGanador"
        Me.botonGenerarGanador.Size = New System.Drawing.Size(220, 30)
        Me.botonGenerarGanador.TabIndex = 0
        Me.botonGenerarGanador.Text = "Generar boleto "
        Me.botonGenerarGanador.UseVisualStyleBackColor = False
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
        Me.Panel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Location = New System.Drawing.Point(10, 429)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(520, 131)
        Me.Panel5.TabIndex = 4
        '
        'inputPremioSeis
        '
        Me.inputPremioSeis.BackColor = System.Drawing.Color.AliceBlue
        Me.inputPremioSeis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPremioSeis.Enabled = False
        Me.inputPremioSeis.Location = New System.Drawing.Point(411, 88)
        Me.inputPremioSeis.Name = "inputPremioSeis"
        Me.inputPremioSeis.Size = New System.Drawing.Size(60, 27)
        Me.inputPremioSeis.TabIndex = 11
        '
        'inputPremioCinco
        '
        Me.inputPremioCinco.BackColor = System.Drawing.Color.AliceBlue
        Me.inputPremioCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPremioCinco.Enabled = False
        Me.inputPremioCinco.Location = New System.Drawing.Point(411, 51)
        Me.inputPremioCinco.Name = "inputPremioCinco"
        Me.inputPremioCinco.Size = New System.Drawing.Size(60, 27)
        Me.inputPremioCinco.TabIndex = 10
        '
        'inputPremioCuatro
        '
        Me.inputPremioCuatro.BackColor = System.Drawing.Color.AliceBlue
        Me.inputPremioCuatro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputPremioCuatro.Enabled = False
        Me.inputPremioCuatro.Location = New System.Drawing.Point(411, 10)
        Me.inputPremioCuatro.Name = "inputPremioCuatro"
        Me.inputPremioCuatro.Size = New System.Drawing.Size(60, 27)
        Me.inputPremioCuatro.TabIndex = 9
        '
        'inputGanadoresSeis
        '
        Me.inputGanadoresSeis.BackColor = System.Drawing.Color.AliceBlue
        Me.inputGanadoresSeis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputGanadoresSeis.Enabled = False
        Me.inputGanadoresSeis.Location = New System.Drawing.Point(194, 88)
        Me.inputGanadoresSeis.Name = "inputGanadoresSeis"
        Me.inputGanadoresSeis.Size = New System.Drawing.Size(60, 27)
        Me.inputGanadoresSeis.TabIndex = 8
        '
        'inputGanadoresCinco
        '
        Me.inputGanadoresCinco.BackColor = System.Drawing.Color.AliceBlue
        Me.inputGanadoresCinco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputGanadoresCinco.Enabled = False
        Me.inputGanadoresCinco.Location = New System.Drawing.Point(194, 51)
        Me.inputGanadoresCinco.Name = "inputGanadoresCinco"
        Me.inputGanadoresCinco.Size = New System.Drawing.Size(60, 27)
        Me.inputGanadoresCinco.TabIndex = 7
        '
        'inputGanadoresCuatro
        '
        Me.inputGanadoresCuatro.BackColor = System.Drawing.Color.AliceBlue
        Me.inputGanadoresCuatro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputGanadoresCuatro.Enabled = False
        Me.inputGanadoresCuatro.Location = New System.Drawing.Point(194, 10)
        Me.inputGanadoresCuatro.Name = "inputGanadoresCuatro"
        Me.inputGanadoresCuatro.Size = New System.Drawing.Size(60, 27)
        Me.inputGanadoresCuatro.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(266, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Premio cada uno"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(266, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Premio cada uno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Premio cada uno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Ganadores 6 números"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ganadores 5 números"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ganadores 4 números"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.botonNuevoSorteo)
        Me.Panel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Panel6.Location = New System.Drawing.Point(10, 569)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(520, 51)
        Me.Panel6.TabIndex = 5
        '
        'botonNuevoSorteo
        '
        Me.botonNuevoSorteo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.botonNuevoSorteo.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.botonNuevoSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.botonNuevoSorteo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonNuevoSorteo.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.botonNuevoSorteo.Location = New System.Drawing.Point(155, 12)
        Me.botonNuevoSorteo.Name = "botonNuevoSorteo"
        Me.botonNuevoSorteo.Size = New System.Drawing.Size(220, 30)
        Me.botonNuevoSorteo.TabIndex = 0
        Me.botonNuevoSorteo.Text = "Nuevo Sorteo"
        Me.botonNuevoSorteo.UseVisualStyleBackColor = False
        '
        'JugarLoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(544, 622)
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
    Friend WithEvents Uno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuatro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cinco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Seis As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
