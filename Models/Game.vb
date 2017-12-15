Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Game
    <Key>
    Public Property Awards As Integer

    <Required>
    <StringLength(50)>
    Public Property Music As String

    <Required>
    <StringLength(50)>
    Public Property Movies As String

    <Required>
    <StringLength(50)>
    Public Property Playlist As String
End Class
