Imports System
Imports System.IO
Imports System.Text
Class MainWindow
    Dim iNbMot As Integer
    Dim posPicture As Integer
    Dim fichier As String
    Dim findMot As String
    Dim findLettre As String
    Dim image000 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image00.png"))
    Dim image001 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image01.png"))
    Dim image002 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image02.png"))
    Dim image003 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image03.png"))
    Dim image004 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image04.png"))
    Dim image005 As New BitmapImage(New Uri("pack://application:,,,/Pendu;component/Resources/image05.png"))
    Private Sub btx_Click(sender As Object, e As RoutedEventArgs) Handles bts.Click


    End Sub
    Private Sub btStartgame_Click(sender As Object, e As RoutedEventArgs) Handles btStartgame.Click
        posPicture = 1
        'picturePendu()

        Dim randomvalue As Integer
        Dim i As Integer
        Dim position As Integer
        i = 0
        position = 0
        findMot = ""
        findLettre = ""
        lCacher.Content = ""
        Randomize() 'Initialize the random-number generator.
        randomvalue = CInt(Int((iNbMot - 2 + 1) * Rnd() + 2))

        ' Chercher le mot

        While i < My.Resources.ResourceManager.BaseName.Length
            If fichier(i) = "," Then
                position = position + 1
                i = i + 1
            End If
            If randomvalue = position Then
                findMot = findMot + fichier(i)
                findLettre = findLettre + fichier(i)
                lCacher.Content = lCacher.Content + "_ "
            End If
            i = i + 1
        End While
        findLettre = findLettre.ToLower()

        findLettre = Replace(findLettre, "é", "e")
        findLettre = Replace(findLettre, "è", "e")
        findLettre = Replace(findLettre, "ê", "e")
        findLettre = Replace(findLettre, "ë", "e")

        findLettre = Replace(findLettre, "î", "i")
        findLettre = Replace(findLettre, "ï", "i")

        findLettre = Replace(findLettre, "à", "a")
        findLettre = Replace(findLettre, "â", "a")

        findLettre = Replace(findLettre, "ô", "o")
        findLettre = Replace(findLettre, "ö", "o")

        findLettre = Replace(findLettre, "ù", "u")
        findLettre = Replace(findLettre, "û", "u")
        findLettre = Replace(findLettre, "ü", "u")

        findLettre = Replace(findLettre, "ç", "c")

        findLettre = Replace(findLettre, " ", "$")

        findLettre = Replace(findLettre, " ", "-")
    End Sub
    Function rechercheMot(ByVal lettre As String) As Boolean
        Dim i As Integer
        i = 0
        If findLettre <> Replace(findLettre, lettre, "$") Then
            findLettre = Replace(findLettre, lettre, "$")
            lCacherMgr()
            i = 0
            While i < findLettre.Length
                If findLettre(i) <> "$" Then
                    Console.Write(findLettre)
                    Return True
                End If
                i = i + 1
            End While
            MsgBox("Vous avez gagné !", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Attention")
            lockey(False)
            Return True
        Else
            Return False
        End If
    End Function
    Function lockey(ByVal bool As Boolean)
        bta.IsEnabled = bool
        btb.IsEnabled = bool
        btc.IsEnabled = bool
        btd.IsEnabled = bool
        bte.IsEnabled = bool
        btf.IsEnabled = bool
        btg.IsEnabled = bool
        bth.IsEnabled = bool
        bti.IsEnabled = bool
        btj.IsEnabled = bool
        btk.IsEnabled = bool
        btl.IsEnabled = bool
        btm.IsEnabled = bool
        btn.IsEnabled = bool
        bto.IsEnabled = bool
        btp.IsEnabled = bool
        btq.IsEnabled = bool
        btr.IsEnabled = bool
        bts.IsEnabled = bool
        btt.IsEnabled = bool
        btu.IsEnabled = bool
        btv.IsEnabled = bool
        btw.IsEnabled = bool
        btx.IsEnabled = bool
        bty.IsEnabled = bool
        btz.IsEnabled = bool
    End Function
    Function lockLetter(ByVal letter As String, ByVal bool As Boolean)
        If letter = "a" Then
            bta.IsEnabled = bool
        End If
        If letter = "b" Then
            btb.IsEnabled = bool
        End If
        If letter = "c" Then
            btc.IsEnabled = bool
        End If
        If letter = "d" Then
            btd.IsEnabled = bool
        End If
        If letter = "e" Then
            bte.IsEnabled = bool
        End If
        If letter = "f" Then
            btf.IsEnabled = bool
        End If
        If letter = "g" Then
            btg.IsEnabled = bool
        End If
        If letter = "h" Then
            bth.IsEnabled = bool
        End If
        If letter = "i" Then
            bti.IsEnabled = bool
        End If
        If letter = "j" Then
            btj.IsEnabled = bool
        End If
        If letter = "k" Then
            btk.IsEnabled = bool
        End If
        If letter = "l" Then
            btl.IsEnabled = bool
        End If
        If letter = "m" Then
            btm.IsEnabled = bool
        End If
        If letter = "n" Then
            btn.IsEnabled = bool
        End If
        If letter = "o" Then
            bto.IsEnabled = bool
        End If
        If letter = "p" Then
            btp.IsEnabled = bool
        End If
        If letter = "q" Then
            btq.IsEnabled = bool
        End If
        If letter = "r" Then
            btr.IsEnabled = bool
        End If
        If letter = "s" Then
            bts.IsEnabled = bool
        End If
        If letter = "t" Then
            btt.IsEnabled = bool
        End If
        If letter = "u" Then
            btu.IsEnabled = bool
        End If
        If letter = "v" Then
            btv.IsEnabled = bool
        End If
        If letter = "w" Then
            btw.IsEnabled = bool
        End If
        If letter = "x" Then
            btx.IsEnabled = bool
        End If
        If letter = "y" Then
            bty.IsEnabled = bool
        End If
        If letter = "z" Then
            btz.IsEnabled = bool
        End If
    End Function
    Function lCacherMgr() As Boolean
        Dim i As Integer
        i = 0
        lCacher.Content = ""
        While i < findLettre.Length
            If findLettre(i) = "$" Then
                lCacher.Content = lCacher.Content + findMot(i)
            Else
                lCacher.Content = lCacher.Content + "_ "
            End If
            i = i + 1
        End While
        Return 0
    End Function
    Function picturePendu()
        Select Case posPicture
            Case 1
                pbImages.Source = image000
            Case 2
                pbImages.Source = image001
            Case 3
                pbImages.Source = image002
            Case 4
                pbImages.Source = image003
            Case 5
                pbImages.Source = image004
            Case 6
                pbImages.Source = image005
            Case Else
                pbImages.Source = image000
                lockey(False)
                MsgBox("Vous avez perdu !", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Attention")
                Dim i As Integer
                i = 0
                While i < findLettre.Length
                    If findLettre(i) <> "$" Then
                        findLettre = Replace(findLettre, findLettre(i), "$")
                    End If
                    i = i + 1
                End While
                i = 0
                lCacher.Content = ""
                While i < findLettre.Length
                    If findLettre(i) = "$" Then
                        lCacher.Content = lCacher.Content + findMot(i)
                    Else
                        lCacher.Content = lCacher.Content + "_ "
                    End If
                    i = i + 1
                End While
        End Select
        posPicture = posPicture + 1
    End Function

    Private Sub button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        '******************************************** MAT9ISCH HADCHI *********************************************'
        'MsgBox("vhhvhhbrv")
        'button.Content = "ffff"
        'pbImages.Source = image000
        'Dim path As String = "C:\Users\soufian\Downloads\51349-1298259-le-jeu-du-pendu\Pendu\pendu\Resources\liste_francais.txt"

        ' Delete the file if it exists.
        'If File.Exists(path) Then
        'MsgBox("existe and found")
        'Else
        'MsgBox("not found")
        'End If
        MsgBox("ddddd")
        pbImages.Source = image000
        'Dim fs As FileStream = File.OpenRead(path)
        'Dim b(1024) As Byte
        'Dim temp As UTF8Encoding = New UTF8Encoding(True)


    End Sub
End Class
