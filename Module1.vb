Imports System.Data.SqlClient

Module Module1

    Enum names
        Vivek
        Anjanaa
        Vivan
    End Enum


    Sub addnumber(x As Integer)
        x += 5
        Console.WriteLine("Addition: {0}", x)
        Console.ReadLine()
    End Sub


    Sub getDataFromDB()
        Try
            Dim con As New SqlConnection("Data Source=VIVEKANJANAA-PC;Initial Catalog=Example;Integrated Security=True")
            Dim com As New SqlCommand("SELECT * FROM dbo.Contacts", con)
            con.Open()

            Dim dr As SqlDataReader = com.ExecuteReader()

            Do While (dr.Read())
                Console.WriteLine("value of fname is: {0}", Convert.ToString(dr("lname")))
                Console.ReadLine()
            Loop

            dr.Close()

        Catch ex As Exception
            Console.WriteLine("Exception: {0}", ex.Message)

        End Try

    End Sub



    Sub Main()
        getDataFromDB()

        Dim truefalse As Boolean = False
        Dim truefalseint As Integer = truefalse
        Console.WriteLine("Integer value of truefalse is: {0}", truefalseint)
        Console.ReadLine()

        Dim addinput As Integer = 2
        addnumber(addinput)
        Console.WriteLine("Value of addinput: {0}", addinput)
        Console.ReadLine()
        Console.WriteLine("Hello VB")
        Console.ReadLine()

        Dim emp2 As New Employee

        emp2.age = 21
        emp2.getAge()


        Dim todaysDate As Date

        Dim emp As New Employee
        todaysDate = emp.getDate
        Console.WriteLine("Todays date is: {0}", todaysDate)

        emp.getNowTime()



        Dim x As Integer = 15
        Dim xResult As Boolean = x <= 25
        Console.WriteLine("Result of xResult is: {0} and value of x is: {1}", _
                          xResult, x)
        Console.ReadLine()

        Dim name As names = names.Vivan

        'Dim count As Integer = 0

        'While count <= 10
        '    Console.WriteLine("Value of count is: {0}", count)
        '    Console.ReadLine()
        '    count += 2
        'End While

        Dim textvalue As String = "palindrome"
        displayreverse(textvalue)

        Console.WriteLine("Entering Function reversestring")
        Dim reversed As String = reversestring("legitimate")
        Console.WriteLine("Reversed string through function is: {0}", reversed)
        Console.ReadLine()


    End Sub


    Sub displayreverse(text As String)

        Try
            For position As Integer = text.Length To 0 Step -1
                Console.WriteLine("{0} ", text(position))
            Next
            Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Exception caught is: {0}", ex.Message)
        End Try


    End Sub



    Function reversestring(text As String) As String
        Return StrReverse(text)
    End Function





End Module
