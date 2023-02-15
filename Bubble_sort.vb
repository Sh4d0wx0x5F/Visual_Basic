Module Module1
    Dim name() = {"Bekham", "Steve", "Eve", "Wick"}
    Sub Main()
        Console.WriteLine("Name Array before sort ")
        For x = 0 To 3
            Console.WriteLine(name(x))
        Next
        bsort()
        Console.WriteLine("Name Array after sort ")
        For x = 0 To 3
            Console.WriteLine(name(x))
        Next
        Console.ReadKey()
    End Sub
    Sub bsort()

        Dim temp As String
        Dim count As Integer
        Dim flag As Boolean
        Dim maxsize As Integer
        maxsize = 3
        flag = True
        While flag <> False
            count = 0
            flag = False
            For count = 0 To maxsize - 1
                If name(count) > name(count + 1) Then
                    temp = name(count)
                    name(count) = name(count + 1)
                    name(count + 1) = temp
                    flag = True
                End If
            Next
        End While

    End Sub
End Module
