Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnFruit.Checked = True
        rbtnPrePay.Checked = True
        lblPayment.Text = ""
        txtLoyalty.Clear()
        txtLoyalty.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rbtnFruit.Checked = True
        rbtnPrePay.Checked = True
        lblPayment.Text = ""
        txtLoyalty.Clear()
        txtLoyalty.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strLoyalty As String
        Dim intLoyalty As Integer
        Dim intUseLoyalty As Integer
        Dim decCheeseCost As Decimal = 49.99D
        Dim decPinwheelCost As Decimal = 59.99D
        Dim decVeggieCost As Decimal = 29.99D
        Dim decSausageCost As Decimal = 49.99D
        Dim decFruitCost As Decimal = 29.99D
        Dim strFoodChoice As String
        Dim strPayChoice As String
        Dim decFinalCost As Decimal
        Dim decDiscount As Decimal

        strLoyalty = txtLoyalty.Text
        intLoyalty = Convert.ToInt32(strLoyalty)

        If rbtnCheese.Checked = True Then
            decFinalCost = decCheeseCost
            strFoodChoice = "Gourmet Cheese"
        ElseIf rbtnWheel.Checked = True Then
            decFinalCost = decPinwheelCost
            strFoodChoice = "Pinwheel Wraps"
        ElseIf rbtnVeg.Checked = True Then
            decFinalCost = decVeggieCost
            strFoodChoice = "Veggie"
        ElseIf rbtnSausage.Checked = True Then
            decFinalCost = decSausageCost
            strFoodChoice = "Sausage and Cheese"
        Else
            decFinalCost = decFruitCost
            strFoodChoice = "Fruit"


        End If

        If rbtnPrePay.Checked = True Then
            strPayChoice = "Pre-Pay"
        Else
            strPayChoice = "Pay upon Pickup"
        End If


        'calculate discount, the discount is 5% for every 10 loyalty points
        'maybe use a loop where we do while loyalty is > 9 and subtract 10 
        'It adds 5% but is it 5% of total cost 
        decDiscount = decFinalCost * 0.05
        intUseLoyalty = intLoyalty

        If intLoyalty > 10 Then
            Do Until intUseLoyalty < 10
                decFinalCost -= decDiscount
                intUseLoyalty -= 10
            Loop
        End If

        If (decDiscount > decFinalCost) Then
            lblPayment.Text = ""
            MsgBox("Loyalty point discount can not exceed payment amount. Please try again!", 5, "Limit Exceeded!")
            txtLoyalty.Focus()
        Else
            lblPayment.Text = "Your order " & strFoodChoice & " platter costs " & decFinalCost.ToString("C") & " using " & vbCrLf & strPayChoice & " after discount of " & intLoyalty.ToString & " loyalty points."
        End If


    End Sub
End Class
