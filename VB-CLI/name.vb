Option Explicit On
Option Strict On
Option Compare Binary

Imports System

module Name_Specific
  Sub Main()
    Dim userInput as String

    console.WriteLine("What is your name human person?")
    userInput = Console.ReadLine()

    If userInput = ("Emily") Then
      console.WriteLine("Welcome Emily")
    ElseIf userInput = ("Joe") Then
        console.WriteLine("Welcome Joe")
    ElseIf userInput = ("Adam") Then
      console.writeLine("Adam loves Ashley")
    Else console.WriteLine("Hello There " & userInput)
    End If

  End Sub
End Module
