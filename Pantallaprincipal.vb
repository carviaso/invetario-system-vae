 
Imports MySql.Data.MySqlClient
Public Class Pantallaprincipal

    Private Sub Pantallaprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AllTabs As List(Of TabPage) = New List(Of TabPage)
        Dim datos_tiempo As DateTime = DateTime.Now

        label_hora.Text = datos_tiempo.ToLongTimeString()
        label_fecha.Text = datos_tiempo.ToLongDateString()

        'label_fecha.Text = datos_tiempo.ToString("ddd") especifica el formato
        lbusuario.Text = usuario.nombre_user



        If TabControl1.TabPages.ContainsKey("TabPage5") Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabPage5"))
        End If
        If TabControl1.TabPages.ContainsKey("TabPage5") Then
            TabControl1.TabPages.Remove(TabControl1.TabPages("TabPage5"))
        End If
        TabControl1.TabPages.Add(AllTabs(Nothing))



    End Sub
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AcercaDe.Show()
    End Sub






    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        modificar_provedor.Show()

    End Sub

    Private Sub Btnbusc_proveedor_Click(sender As Object, e As EventArgs) Handles Btnbusc_proveedor.Click
        TabControl1.TabPages.Remove(TbP_producto)
        TabControl1.TabPages.Remove(TbP_inicio)
        TabControl1.TabPages.Remove(TbP_venta)
        TabControl1.TabPages.Insert(0, TbP_provedor)
        image_berraEstado.Image = Global.System_VAE.My.Resources.Resources.prove
        image_berraEstado.Text = "Proveedores"
    End Sub

    Private Sub BtnBusca_producto_Click(sender As Object, e As EventArgs) Handles BtnBusca_producto.Click
        TabControl1.TabPages.Remove(TbP_inicio)
        TabControl1.TabPages.Remove(TbP_producto)
        TabControl1.TabPages.Remove(TbP_venta)
        TabControl1.TabPages.Insert(0, TbP_producto)
        image_berraEstado.Image = Global.System_VAE.My.Resources.Resources.producto
        image_berraEstado.Text = "Productos"
    End Sub

    Private Sub hora_Tick(sender As Object, e As EventArgs) Handles hora.Tick
        'Actualizar cada segundo la Hora y fecha
        label_hora.Text = DateTime.Now.ToLongTimeString()

    End Sub



    Private Sub btn_Inventario_Click(sender As Object, e As EventArgs) Handles btn_Inventario.Click
        image_berraEstado.Image = Global.System_VAE.My.Resources.Resources.inventario2
        image_berraEstado.Text = "Inventario"


    End Sub

    Private Sub Btnbus_ventas_Click(sender As Object, e As EventArgs) Handles Btnbus_ventas.Click
        image_berraEstado.Image = Global.System_VAE.My.Resources.Resources.ventas
        image_berraEstado.Text = "Ventas"
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Dat_ingr_Producto.Show()

    End Sub

    Private Sub Pantallaprincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        End

    End Sub
End Class
