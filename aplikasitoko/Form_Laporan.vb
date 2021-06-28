Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form_Laporan
    Private Sub btn_View_Click(sender As Object, e As EventArgs) Handles btn_View.Click
        Try
            Dim cryrpt As New ReportDocument
            Dim crtablelogoninfo As New TableLogOnInfo
            Dim crconnectioninfo As New ConnectionInfo
            Dim crtables As Tables
            Dim crtable As Table
            Dim laporan As New Laporan_Penjualan_Harian
            cryrpt = laporan
            With crconnectioninfo
                .ServerName = Application.StartupPath & "\db_penjualan.mdb"
                .DatabaseName = Application.StartupPath & "\db_penjualan"
                .UserID = ""
                .Password = ""
            End With
            crtables = cryrpt.Database.Tables
            For Each crtable In crtables
                crtablelogoninfo = crtable.LogOnInfo
                crtablelogoninfo.ConnectionInfo = crconnectioninfo
                crtable.ApplyLogOnInfo(crtablelogoninfo)
            Next
            'CrystalReportViewer1.SelectionFormula = "({tbl_jual.tgl_jual})=#" & DateTimePicker1 & "#"
            CrystalReportViewer1.ReportSource = cryrpt
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        CrystalReportViewer1.PrintReport()
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        CrystalReportViewer1.ExportReport()
    End Sub
End Class