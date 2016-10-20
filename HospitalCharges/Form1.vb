Imports System.Globalization
Imports System.Threading

Public Class Form1
    Const dayPrice As Decimal = 350.0
    Private days As Integer
    Private meds As Decimal
    Private surg As Decimal
    Private lab As Decimal
    Private phy As Decimal

    Public Sub New()
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txt_phy.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        If (ValidateInputFields()) Then
            lbl_cost.Text = "$" + String.Format(Globalization.CultureInfo.GetCultureInfo("en-US"), "{0:#,##0.00}", CalcTotalCharges())
        Else
            lbl_cost.Text = ""
        End If

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_cost.Text = ""
        lbl_days.Text = ""
        lbl_lab.Text = ""
        lbl_meds.Text = ""
        lbl_phy.Text = ""
        lbl_sur.Text = ""

        txt_days.Text = 0
        txt_lab.Text = 0
        txt_meds.Text = 0
        txt_phy.Text = 0
        txt_surg.Text = 0

        lab = 0
        meds = 0
        phy = 0
        days = 0
        surg = 0

    End Sub

    Private Function CalcStayCharges() As Decimal
        Return days * dayPrice
    End Function

    Private Function CalcMiscCharges() As Decimal
        Return lab + meds + phy + surg
    End Function

    Private Function CalcTotalCharges() As Decimal
        Return CalcStayCharges() + CalcMiscCharges()
    End Function

    Private Function ValidateInputFields() As Boolean

        Dim valid = True

        If (Integer.TryParse(txt_days.Text, days) And days >= 0 And IsNumeric(txt_days.Text)) Then
            lbl_days.Text = ""
        Else
            lbl_days.Text = "Must be zero or positive integer"
            valid = False
        End If

        If (Decimal.TryParse(txt_meds.Text, meds) And meds >= 0 And IsNumeric(txt_meds.Text)) Then
            lbl_meds.Text = ""
        Else
            lbl_meds.Text = "Must be zero or positive numeric"
            valid = False
        End If

        If (Decimal.TryParse(txt_surg.Text, surg) And surg >= 0 And IsNumeric(txt_surg.Text)) Then
            lbl_sur.Text = ""
        Else
            lbl_sur.Text = "Must be zero or positive numeric"
            valid = False
        End If

        If (Decimal.TryParse(txt_lab.Text, lab) And lab >= 0 And IsNumeric(txt_lab.Text)) Then
            lbl_lab.Text = ""
        Else
            lbl_lab.Text = "Must be zero or positive numeric"
            valid = False
        End If

        If (Decimal.TryParse(txt_phy.Text, phy) And phy >= 0 And IsNumeric(txt_phy.Text)) Then
            lbl_phy.Text = ""
        Else
            lbl_phy.Text = "Must be zero or positive numeric"
            valid = False
        End If

        Return valid
    End Function
End Class
