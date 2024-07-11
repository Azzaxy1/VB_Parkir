<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGateIn
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGateIn))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxNoPlat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTanggal = New System.Windows.Forms.TextBox()
        Me.TextBoxJam = New System.Windows.Forms.TextBox()
        Me.TextBoxKodeMasuk = New System.Windows.Forms.TextBox()
        Me.ComboBoxJenisKendaraan = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'TextBoxNoPlat
        '
        Me.TextBoxNoPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNoPlat.Location = New System.Drawing.Point(383, 87)
        Me.TextBoxNoPlat.Multiline = True
        Me.TextBoxNoPlat.Name = "TextBoxNoPlat"
        Me.TextBoxNoPlat.Size = New System.Drawing.Size(184, 40)
        Me.TextBoxNoPlat.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(224, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "TIKET MASUK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(294, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "No Kendaraan"
        '
        'ButtonTutup
        '
        Me.ButtonTutup.BackgroundImage = CType(resources.GetObject("ButtonTutup.BackgroundImage"), System.Drawing.Image)
        Me.ButtonTutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTutup.Location = New System.Drawing.Point(473, 153)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(47, 55)
        Me.ButtonTutup.TabIndex = 35
        Me.ButtonTutup.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackgroundImage = CType(resources.GetObject("ButtonSimpan.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimpan.Location = New System.Drawing.Point(377, 153)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(47, 55)
        Me.ButtonSimpan.TabIndex = 36
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(595, 43)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(597, 255)
        Me.ShapeContainer1.TabIndex = 37
        Me.ShapeContainer1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxTanggal)
        Me.Panel1.Controls.Add(Me.TextBoxJam)
        Me.Panel1.Controls.Add(Me.TextBoxKodeMasuk)
        Me.Panel1.Controls.Add(Me.ComboBoxJenisKendaraan)
        Me.Panel1.Location = New System.Drawing.Point(39, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 141)
        Me.Panel1.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Kode Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Jenis Kendaraan"
        '
        'TextBoxTanggal
        '
        Me.TextBoxTanggal.Enabled = False
        Me.TextBoxTanggal.Location = New System.Drawing.Point(117, 46)
        Me.TextBoxTanggal.Name = "TextBoxTanggal"
        Me.TextBoxTanggal.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxTanggal.TabIndex = 37
        '
        'TextBoxJam
        '
        Me.TextBoxJam.Enabled = False
        Me.TextBoxJam.Location = New System.Drawing.Point(117, 75)
        Me.TextBoxJam.Name = "TextBoxJam"
        Me.TextBoxJam.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxJam.TabIndex = 36
        '
        'TextBoxKodeMasuk
        '
        Me.TextBoxKodeMasuk.Location = New System.Drawing.Point(117, 107)
        Me.TextBoxKodeMasuk.Name = "TextBoxKodeMasuk"
        Me.TextBoxKodeMasuk.ReadOnly = True
        Me.TextBoxKodeMasuk.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxKodeMasuk.TabIndex = 35
        '
        'ComboBoxJenisKendaraan
        '
        Me.ComboBoxJenisKendaraan.FormattingEnabled = True
        Me.ComboBoxJenisKendaraan.Items.AddRange(New Object() {"Motor", "Mobil"})
        Me.ComboBoxJenisKendaraan.Location = New System.Drawing.Point(115, 13)
        Me.ComboBoxJenisKendaraan.Name = "ComboBoxJenisKendaraan"
        Me.ComboBoxJenisKendaraan.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxJenisKendaraan.TabIndex = 34
        '
        'FormGateIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(597, 255)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxNoPlat)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormGateIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gate In"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents TextBoxNoPlat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonTutup As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTanggal As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJam As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKodeMasuk As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxJenisKendaraan As System.Windows.Forms.ComboBox
End Class
