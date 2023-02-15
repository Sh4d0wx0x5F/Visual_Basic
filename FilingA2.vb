Module Module1
    'Prompt a menu with options
    '1 : to create a new file "MyFile.txt" and store rollno, name and marks of 30 students
    '2 : to display the contents of the file
    '3 : to edit the marks of a student on behalf of thier rollno
    '4 : exit the program

    Sub Main()
        Dim choice As Integer
        While choice <> 6
            Console.Clear()
            Console.WriteLine(" 1 to create new a file Or Overwrite the existing one ")
            Console.WriteLine(" 2 to append an existing file ")
            Console.WriteLine(" 3 to Display a file ")
            Console.WriteLine(" 4 to edit a file ")
            Console.WriteLine(" 5 to delete a record ")
            Console.WriteLine(" 6 to exit ")
            Console.Write(" Enter Your Choice ")
            choice = Console.ReadLine()
            Select Case choice
                Case 1 : Createfile()
                Case 2 : appendfile()
                Case 3 : Displayfile()
                Case 4 : editfile()
                Case 5 : deletere()
                Case 6
                Case Else
                    Console.Write(" wrong number press, enter again : ")
                    choice = Console.ReadLine()
                    Console.ReadKey()
            End Select
        End While
    End Sub
    Sub Createfile()
        Dim rollno, marks As Integer
        Dim name As String
        FileOpen(1, My.Application.Info.DirectoryPath & "\MyFile.txt", OpenMode.Output)
        For x = 1 To 3
            Console.Write("Enter roll number : ")
            rollno = Console.ReadLine()
            Console.Write("Enter name : ")
            name = Console.ReadLine()
            Console.Write("Enter marks : ")
            marks = Console.ReadLine()
            WriteLine(1, rollno, name, marks)
        Next
        FileClose(1)
        Console.WriteLine(" your file has been created ")
        Console.ReadKey()
    End Sub
    Sub appendfile()
        Dim rollno, marks As Integer
        Dim name As String
        FileOpen(1, My.Application.Info.DirectoryPath & "\MyFile.txt", OpenMode.Append)
        For x = 1 To 3
            Console.Write("Enter roll number : ")
            rollno = Console.ReadLine()
            Console.Write("Enter name : ")
            name = Console.ReadLine()
            Console.Write("Enter marks : ")
            marks = Console.ReadLine()
            WriteLine(1, rollno, name, marks)
        Next
        FileClose(1)
        Console.WriteLine(" your file has been append ")
        Console.ReadKey()
    End Sub
    Sub Displayfile()
        Dim rno, mks As Integer
        Dim nm As String
        Try
            FileOpen(1, My.Application.Info.DirectoryPath & "\MyFile.txt", OpenMode.Input)
            While Not EOF(1)
                Input(1, rno)
                Input(1, nm)
                Input(1, mks)
                Console.WriteLine(" The Roll No " & rno & " The Name " & nm & " and Marks " & mks)
            End While
            FileClose(1)
        Catch
            Console.WriteLine(" File does not exist ")
        End Try
        Console.ReadKey()

    End Sub
    Sub editfile()
        Dim rno, mks As Integer
        Dim nm As String
        Dim updatemarks As Integer
        Dim editrollno As Integer
        Console.Write(" Enter roll no to update marks : ")
        editrollno = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "\MyFile.txt", OpenMode.Input)
        FileOpen(2, My.Application.Info.DirectoryPath & "\temp.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, rno)
            Input(1, nm)
            Input(1, mks)
            If editrollno = rno Then
                Console.Write(" enter marks to update : ")
                updatemarks = Console.ReadLine()
                WriteLine(2, rno, nm, updatemarks)
            Else
                WriteLine(2, rno, nm, mks)
            End If
        End While
        FileClose(1)
        FileClose(2)
        Kill(My.Application.Info.DirectoryPath & "\MyFile.txt")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\temp.txt", "MyFile.txt")
        Console.WriteLine(" Marks of " & editrollno & " has been updated ")
        Console.ReadKey()
    End Sub

    Sub deletere()
        Dim rno, mks As Integer
        Dim nm As String
        Dim editrollno As Integer
        Console.Write(" Enter roll no to delete a record : ")
        editrollno = Console.ReadLine()
        FileOpen(1, My.Application.Info.DirectoryPath & "\MyFile.txt", OpenMode.Input)
        FileOpen(2, My.Application.Info.DirectoryPath & "\temp.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, rno)
            Input(1, nm)
            Input(1, mks)
            If editrollno <> rno Then
                WriteLine(2, rno, nm, mks)
            End If
        End While
        FileClose(1)
        FileClose(2)
        Kill(My.Application.Info.DirectoryPath & "\MyFile.txt")
        My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\temp.txt", "MyFile.txt")
        Console.WriteLine(" Record of " & editrollno & " has been Deleted ")
        Console.ReadKey()
    End Sub
End Module
