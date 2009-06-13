Imports System.Reflection
Imports System.Linq

Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim command = ComboBox1.Text
        Dim carr = command.Split(".")
        If Not carr.Length = 2 Then
            Return
        End If
        Dim pname = carr(0)
        Dim mname = carr(1)
        Dim Api = New XiaoNeiApi("", "", "", Nothing)

        Dim a = Assembly.Load("XiaoNei")
        Dim t = a.GetType("XiaoNei.Api." & pname)
        Dim _class = Activator.CreateInstance(t, Api)

        Dim ms = t.GetMethod(mname, BindingFlags.Public Xor _
                              BindingFlags.NonPublic Xor _
                              BindingFlags.Instance Xor _
                              BindingFlags.DeclaredOnly)

        Dim p = Join((From x In ms.GetParameters() Select x.ParameterType.ToString() & " : " & x.Name).ToArray(), ",")
        Debug(ms.Name & " " & p)

        '  Dim pro = pi.GetValue(Api, Nothing)

    End Sub
    Sub Debug(ByVal str)
        DebugTxt.AppendText(str.ToString() & vbCrLf)
    End Sub
End Class
