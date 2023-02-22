Module Module1

    Sub Main()
        Dim word As String
        Console.WriteLine("Enter a word to check for plaindrome: ")
        word = Console.ReadLine()

        If Plaindrome(word) = True Then
            Console.WriteLine("It's a plaindrome")
        Else
            Console.WriteLine("It's not a plaindrome")
        End If
        Console.ReadKey()
    End Sub
    Function Plaindrome(word As String) As Boolean
        Dim word_2, word_3 As String
        Dim alpha As Char
        Dim l As Integer

        word_2 = ""
        l = Int(Len(word)) - 1
        While l <> -1
            word_3 = UCase(word)
            alpha = word_3(l)
            word_2 = word_2 + alpha
            l = l - 1
        End While
        If word_2 = word_3 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
