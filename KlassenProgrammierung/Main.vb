Imports System.Threading

Module Main

    Public Sub main1()
        Dim count As Integer

        For count = 1 To 100
            arbeiter1()
        Next

    End Sub


    Public Sub arbeiter1()
        Dim arbeit As New Class1(10000) 'Die Klasse initialisieren
        'arbeit.Lookup() 'direkt aufrufen & alles blockieren

        If running = True Then Exit Sub 'Rückmeldung über globale Variable, ob der thread bereits läuft

        Dim arbeitthread As New Thread(AddressOf arbeit.Lookup)
        arbeitthread.Start()

        While arbeitthread.IsAlive
            running = True
            Application.DoEvents()
        End While
        arbeitthread.Abort()
        Console.WriteLine("thread beendet")
        running = False
    End Sub

End Module
