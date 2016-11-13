Public Class Class1

    Private Name As String

    Private City As String

    Private Watittime As Integer

    ' Ein Ereignis, dass über das Ende des Tasks informiert. siehe multithread sample
    'Public Event Class1Completed(ByVal sender As Object, ByVal e As WeatherLookupCompletedEventArgs)

    Public Sub New(Zeit As Integer)
        Watittime = Zeit 'Variable von aussen übernehmen
    End Sub

    Public Sub Lookup()

        ' Dieser Code würde normalerweise die Datenbank nach den verlangten Informationen

        ' abfragen.
        If Watittime = 0 Then
            Console.WriteLine("Waittime = 0 -- Abbruch --")
            Exit Sub
        End If
        Console.WriteLine("Starte warten: " & Watittime.ToString)
        System.Threading.Thread.Sleep(Watittime) 'hier soll das programm stehenbleiben um ein hängen zu prüfen
        Console.WriteLine("Warten fertig " & TimeOfDay.Ticks.ToString)


    End Sub


End Class
