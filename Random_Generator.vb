Module Module1

    Sub Main()
        Dim RNum(99) As Integer
        Dim count, x As Integer

        count = 0
        For x = 0 To 99
            RNum(x) = Int((200 * Rnd()) + 1)
            count = count + 1
        Next
        Console.WriteLine("The number of random numbers generated between 66 and 173 are:" & count)
        Console.ReadKey()
    End Sub

End Module
