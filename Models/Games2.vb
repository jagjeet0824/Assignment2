Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial


Partial Public Class Games2
    Public Property Awards As Integer

    <Key>
    <StringLength(50)>
    Public Property Best_singer As String

    <Required>
    <StringLength(50)>
    Public Property Vocal As String

    <Required>
    <StringLength(50)>
    Public Property Onstage As String
End Class
