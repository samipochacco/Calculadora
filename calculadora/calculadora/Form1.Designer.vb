<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        suma = New Button()
        resta = New Button()
        multiplicacion = New Button()
        division = New Button()
        numero1 = New TextBox()
        numero2 = New TextBox()
        limpiar = New Button()
        resultado = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' suma
        ' 
        suma.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        suma.Location = New Point(532, 86)
        suma.Name = "suma"
        suma.Size = New Size(104, 44)
        suma.TabIndex = 0
        suma.Text = "sumar"
        suma.UseVisualStyleBackColor = True
        ' 
        ' resta
        ' 
        resta.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resta.Location = New Point(532, 162)
        resta.Name = "resta"
        resta.Size = New Size(104, 44)
        resta.TabIndex = 1
        resta.Text = "restar"
        resta.UseVisualStyleBackColor = True
        ' 
        ' multiplicacion
        ' 
        multiplicacion.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        multiplicacion.Location = New Point(532, 236)
        multiplicacion.Name = "multiplicacion"
        multiplicacion.Size = New Size(120, 44)
        multiplicacion.TabIndex = 2
        multiplicacion.Text = "multiplicar"
        multiplicacion.UseVisualStyleBackColor = True
        ' 
        ' division
        ' 
        division.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        division.Location = New Point(532, 303)
        division.Name = "division"
        division.Size = New Size(104, 44)
        division.TabIndex = 3
        division.Text = "dividir"
        division.UseVisualStyleBackColor = True
        ' 
        ' numero1
        ' 
        numero1.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numero1.Location = New Point(114, 100)
        numero1.Name = "numero1"
        numero1.Size = New Size(125, 26)
        numero1.TabIndex = 4
        ' 
        ' numero2
        ' 
        numero2.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numero2.Location = New Point(114, 162)
        numero2.Name = "numero2"
        numero2.Size = New Size(125, 26)
        numero2.TabIndex = 5
        ' 
        ' limpiar
        ' 
        limpiar.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        limpiar.Location = New Point(114, 318)
        limpiar.Name = "limpiar"
        limpiar.Size = New Size(117, 29)
        limpiar.TabIndex = 6
        limpiar.Text = "limpiar"
        limpiar.UseVisualStyleBackColor = True
        ' 
        ' resultado
        ' 
        resultado.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        resultado.Location = New Point(114, 222)
        resultado.Name = "resultado"
        resultado.Size = New Size(125, 26)
        resultado.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 26)
        Label1.TabIndex = 8
        Label1.Text = "Calcula cuantas veces madreaeron a mark"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.wp10565339
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(resultado)
        Controls.Add(limpiar)
        Controls.Add(numero2)
        Controls.Add(numero1)
        Controls.Add(division)
        Controls.Add(multiplicacion)
        Controls.Add(resta)
        Controls.Add(suma)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents suma As Button
    Friend WithEvents resta As Button
    Friend WithEvents multiplicacion As Button
    Friend WithEvents division As Button
    Friend WithEvents numero1 As TextBox
    Friend WithEvents numero2 As TextBox
    Friend WithEvents limpiar As Button
    Friend WithEvents resultado As TextBox
    Friend WithEvents Label1 As Label

End Class
