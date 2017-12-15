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
    Public Class Games2Controller
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: Games2
        Function Index() As ActionResult
            Return View(db.Games2.ToList())
        End Function

        ' GET: Games2/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim games2 As Games2 = db.Games2.Find(id)
            If IsNothing(games2) Then
                Return HttpNotFound()
            End If
            Return View(games2)
        End Function

        ' GET: Games2/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Games2/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Best_singer,Awards,Vocal,Onstage")> ByVal games2 As Games2) As ActionResult
            If ModelState.IsValid Then
                db.Games2.Add(games2)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(games2)
        End Function

        ' GET: Games2/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim games2 As Games2 = db.Games2.Find(id)
            If IsNothing(games2) Then
                Return HttpNotFound()
            End If
            Return View(games2)
        End Function

        ' POST: Games2/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Best_singer,Awards,Vocal,Onstage")> ByVal games2 As Games2) As ActionResult
            If ModelState.IsValid Then
                db.Entry(games2).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(games2)
        End Function

        ' GET: Games2/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim games2 As Games2 = db.Games2.Find(id)
            If IsNothing(games2) Then
                Return HttpNotFound()
            End If
            Return View(games2)
        End Function

        ' POST: Games2/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim games2 As Games2 = db.Games2.Find(id)
            db.Games2.Remove(games2)
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
