Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ass1

Namespace Controllers
    <Authorize>
    Public Class GamesController

        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: Games
        Function Index() As ActionResult
            Return View(db.Games.ToList())
        End Function

        ' GET: Games/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim game As Game = db.Games.Find(id)
            If IsNothing(game) Then
                Return HttpNotFound()
            End If
            Return View(game)
        End Function

        ' GET: Games/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Games/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Awards,Music,Movies,Playlist")> ByVal game As Game) As ActionResult
            If ModelState.IsValid Then
                db.Games.Add(game)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(game)
        End Function

        ' GET: Games/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim game As Game = db.Games.Find(id)
            If IsNothing(game) Then
                Return HttpNotFound()
            End If
            Return View(game)
        End Function

        ' POST: Games/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Awards,Music,Movies,Playlist")> ByVal game As Game) As ActionResult
            If ModelState.IsValid Then
                db.Entry(game).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(game)
        End Function

        ' GET: Games/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim game As Game = db.Games.Find(id)
            If IsNothing(game) Then
                Return HttpNotFound()
            End If
            Return View(game)
        End Function

        ' POST: Games/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim game As Game = db.Games.Find(id)
            db.Games.Remove(game)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
