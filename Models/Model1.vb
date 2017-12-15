Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DefaultConnection")
    End Sub

    Public Overridable Property Games As DbSet(Of Game)
    Public Overridable Property Games2 As DbSet(Of Games2)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Game)() _
            .Property(Function(e) e.Music) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Game)() _
            .Property(Function(e) e.Movies) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Game)() _
            .Property(Function(e) e.Playlist) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Games2)() _
            .Property(Function(e) e.Best_singer) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Games2)() _
            .Property(Function(e) e.Vocal) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Games2)() _
            .Property(Function(e) e.Onstage) _
            .IsUnicode(False)
    End Sub
End Class
