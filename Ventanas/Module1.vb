Module Module1

    Sub limpiarText(ByVal formulario As Form)
        Dim Text As Object
        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim textemp As TextBox = CType(Text, TextBox)
                textemp.Text = ""
            End If
        Next

    End Sub




    Public Function getValor(ByVal combo As ComboBox, ByVal dato As String) As String

        Try
            Dim result As String
            result = ""
            result = CType(combo.DataSource, DataTable).Rows(combo.SelectedIndex)(dato).ToString()
            Return result
        Catch ex As Exception

            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function getId(ByVal combo As ComboBox, ByVal dato As String) As Integer

        Try
            Dim result As Integer
            result = -1
            result = CInt(CType(combo.DataSource, DataTable).Rows(combo.SelectedIndex)(dato).ToString)

            Return result
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        End Try


    End Function


End Module
