Option Explicit On
Option Strict On
Option Compare Binary

Imports System

module Name
  Sub Main()
    Dim userInput as String
    console.WriteLine("What is your name good sir?")
    userInput = Console.ReadLine()
    Console.WriteLine("Nice to meet you " & userInput)
  End Sub
End Module
