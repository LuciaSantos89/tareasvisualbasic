<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombrePersona = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tipoClaseLab = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.precioClaseLab = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nombreClaseLab = New System.Windows.Forms.TextBox()
        Me.agregarClase = New System.Windows.Forms.Button()
        Me.listaClasesLabs = New System.Windows.Forms.ListBox()
        Me.cuentaTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numeroMensualidades = New System.Windows.Forms.TextBox()
        Me.calcularPagoMensualidad = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pagoMensualidad = New System.Windows.Forms.TextBox()
        Me.nuevaMatricula = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrícula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'nombrePersona
        '
        Me.nombrePersona.Location = New System.Drawing.Point(69, 42)
        Me.nombrePersona.MaxLength = 50
        Me.nombrePersona.Name = "nombrePersona"
        Me.nombrePersona.Size = New System.Drawing.Size(281, 20)
        Me.nombrePersona.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo"
        '
        'tipoClaseLab
        '
        Me.tipoClaseLab.DisplayMember = "Clase,Laboratorio"
        Me.tipoClaseLab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tipoClaseLab.FormattingEnabled = True
        Me.tipoClaseLab.Items.AddRange(New Object() {"Clase", "Laboratorio"})
        Me.tipoClaseLab.Location = New System.Drawing.Point(54, 82)
        Me.tipoClaseLab.Name = "tipoClaseLab"
        Me.tipoClaseLab.Size = New System.Drawing.Size(121, 21)
        Me.tipoClaseLab.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio"
        '
        'precioClaseLab
        '
        Me.precioClaseLab.Location = New System.Drawing.Point(250, 82)
        Me.precioClaseLab.Name = "precioClaseLab"
        Me.precioClaseLab.Size = New System.Drawing.Size(100, 20)
        Me.precioClaseLab.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre de la Clase"
        '
        'nombreClaseLab
        '
        Me.nombreClaseLab.Location = New System.Drawing.Point(156, 116)
        Me.nombreClaseLab.MaxLength = 50
        Me.nombreClaseLab.Name = "nombreClaseLab"
        Me.nombreClaseLab.Size = New System.Drawing.Size(169, 20)
        Me.nombreClaseLab.TabIndex = 8
        '
        'agregarClase
        '
        Me.agregarClase.Location = New System.Drawing.Point(139, 152)
        Me.agregarClase.Name = "agregarClase"
        Me.agregarClase.Size = New System.Drawing.Size(75, 23)
        Me.agregarClase.TabIndex = 9
        Me.agregarClase.Text = "Agregar"
        Me.agregarClase.UseVisualStyleBackColor = True
        '
        'listaClasesLabs
        '
        Me.listaClasesLabs.FormattingEnabled = True
        Me.listaClasesLabs.Location = New System.Drawing.Point(22, 199)
        Me.listaClasesLabs.Name = "listaClasesLabs"
        Me.listaClasesLabs.Size = New System.Drawing.Size(120, 95)
        Me.listaClasesLabs.TabIndex = 10
        '
        'cuentaTotal
        '
        Me.cuentaTotal.Location = New System.Drawing.Point(265, 238)
        Me.cuentaTotal.Name = "cuentaTotal"
        Me.cuentaTotal.Size = New System.Drawing.Size(100, 20)
        Me.cuentaTotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(182, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cuenta Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Número de Mensualidades"
        '
        'numeroMensualidades
        '
        Me.numeroMensualidades.Location = New System.Drawing.Point(165, 316)
        Me.numeroMensualidades.Name = "numeroMensualidades"
        Me.numeroMensualidades.Size = New System.Drawing.Size(64, 20)
        Me.numeroMensualidades.TabIndex = 14
        '
        'calcularPagoMensualidad
        '
        Me.calcularPagoMensualidad.Location = New System.Drawing.Point(265, 311)
        Me.calcularPagoMensualidad.Name = "calcularPagoMensualidad"
        Me.calcularPagoMensualidad.Size = New System.Drawing.Size(75, 23)
        Me.calcularPagoMensualidad.TabIndex = 15
        Me.calcularPagoMensualidad.Text = "Calcular"
        Me.calcularPagoMensualidad.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(104, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pago Mensual"
        '
        'pagoMensualidad
        '
        Me.pagoMensualidad.Location = New System.Drawing.Point(210, 357)
        Me.pagoMensualidad.Name = "pagoMensualidad"
        Me.pagoMensualidad.Size = New System.Drawing.Size(100, 20)
        Me.pagoMensualidad.TabIndex = 17
        '
        'nuevaMatricula
        '
        Me.nuevaMatricula.Location = New System.Drawing.Point(110, 406)
        Me.nuevaMatricula.Name = "nuevaMatricula"
        Me.nuevaMatricula.Size = New System.Drawing.Size(134, 23)
        Me.nuevaMatricula.TabIndex = 18
        Me.nuevaMatricula.Text = "Nueva Matricula"
        Me.nuevaMatricula.UseVisualStyleBackColor = True
        '
        'Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 508)
        Me.Controls.Add(Me.nuevaMatricula)
        Me.Controls.Add(Me.pagoMensualidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.calcularPagoMensualidad)
        Me.Controls.Add(Me.numeroMensualidades)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cuentaTotal)
        Me.Controls.Add(Me.listaClasesLabs)
        Me.Controls.Add(Me.agregarClase)
        Me.Controls.Add(Me.nombreClaseLab)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.precioClaseLab)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tipoClaseLab)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nombrePersona)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Matricula"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nombrePersona As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tipoClaseLab As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents precioClaseLab As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nombreClaseLab As System.Windows.Forms.TextBox
    Friend WithEvents agregarClase As System.Windows.Forms.Button
    Friend WithEvents listaClasesLabs As System.Windows.Forms.ListBox
    Friend WithEvents cuentaTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numeroMensualidades As System.Windows.Forms.TextBox
    Friend WithEvents calcularPagoMensualidad As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pagoMensualidad As System.Windows.Forms.TextBox
    Friend WithEvents nuevaMatricula As System.Windows.Forms.Button

End Class
