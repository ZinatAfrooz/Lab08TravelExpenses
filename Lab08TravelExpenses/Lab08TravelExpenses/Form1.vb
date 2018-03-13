Public Class Form1
    'Constants for Reimbursement 
    Const decMEAL_REIMBURSEMENT As Decimal = 37D
    Const decPARKING_REIMBURSEMENT As Decimal = 10D
    Const decTAXI_REIMBURSEMENT As Decimal = 20D
    Const decLODGING_REIMBURSEMENT As Decimal = 95D
    Const decMILES_REIMBURSEMENT As Decimal = 0.27D


    Function CalcLodging() As Decimal
        Dim decLodgingReimbursement As Decimal
        decLodgingReimbursement = (CDec(txtDaysOnTrip.Text) * decLODGING_REIMBURSEMENT)
        Return decLodgingReimbursement
    End Function

    Function CalcMeals() As Decimal
        Dim decMealReimbursement As Decimal
        decMealReimbursement = (CDec(txtDaysOnTrip.Text) * decMEAL_REIMBURSEMENT)
        Return decMealReimbursement
    End Function

    Function CalcMileage() As Decimal
        Dim decMileageReimbursement As Decimal
        decMileageReimbursement = (CDec(txtMilesDriven.Text) * decMILES_REIMBURSEMENT)
        Return decMileageReimbursement
    End Function

    Function CalcParkingFees() As Decimal
        Dim decParkingReimbursement As Decimal
        decParkingReimbursement = CDec(txtDaysOnTrip.Text) * decPARKING_REIMBURSEMENT
        Return decParkingReimbursement
    End Function

    Function CalcTaxiFees() As Decimal
        Dim decTaxiReimbursement As Decimal
        decTaxiReimbursement = decTAXI_REIMBURSEMENT * CDec(txtDaysOnTrip.Text)
        Return decTaxiReimbursement
    End Function

    'Function Total Reimbursement is adding the previous functions from above
    Function CalcTotalReimbursement() As Decimal
        Dim decTotalReimbursement As Decimal
        decTotalReimbursement = CalcLodging() + CalcTaxiFees() +
        CalcMeals() + CalcParkingFees()
        Return decTotalReimbursement
    End Function

    Function CalcUnallowed() As Decimal
        Dim decUnallowed As Decimal
        decUnallowed = (CDec(txtParkingFees.Text) - CalcParkingFees()) + (CDec(txtTaxiFees.Text) - CalcTaxiFees()) + (CDec(txtLodgingCharge.Text) - CalcLodging()) + (CDec(txtMealExpenses.Text) - CalcMeals())
        Return decUnallowed
    End Function

    Function CalcSaved() As Decimal
        Dim decSaved As Decimal
        decSaved = (CDec(txtDaysOnTrip.Text) * decMEAL_REIMBURSEMENT - CDec(txtMealExpenses.Text)) + (CDec(txtDaysOnTrip.Text) * decPARKING_REIMBURSEMENT - CDec(txtParkingFees.Text)) +
        (CDec(txtDaysOnTrip.Text) * decTAXI_REIMBURSEMENT - CDec(txtTaxiFees.Text)) + (CDec(txtDaysOnTrip.Text) * decLODGING_REIMBURSEMENT - CDec(txtLodgingCharge.Text))
        Return decSaved
    End Function

    'Calculation Total was added as a function
    Function CalcTotal() As Decimal
        Dim decTotal As Decimal
        decTotal = CDec(txtAmountAirfare.Text) + CDec(txtRegisFees.Text) + CDec(txtMealExpenses.Text) + (CDec(txtMilesDriven.Text) * decMILES_REIMBURSEMENT) + CDec(txtCarRental.Text) + CDec(txtLodgingCharge.Text) + CDec(txtParkingFees.Text) + CDec(txtTaxiFees.Text)
        Return decTotal
    End Function

    'Function for Numeric Validation, returns True or false for all keyed fields
    Function InputNumeric() As Boolean
        Dim blnNumeric As Boolean
        If IsNumeric(txtAmountAirfare.Text) And
        IsNumeric(txtCarRental.Text) And
        IsNumeric(txtDaysOnTrip.Text) And
        IsNumeric(txtLodgingCharge.Text) And
        IsNumeric(txtMealExpenses.Text) And
        IsNumeric(txtMilesDriven.Text) And
        IsNumeric(txtParkingFees.Text) And
        IsNumeric(txtRegisFees.Text) And
        IsNumeric(txtTaxiFees.Text) Then
            blnNumeric = True
        End If
        Return blnNumeric
    End Function

    'Similar to the Numeric Validation except checks all fields for Positive numbers
    Function InputPositive() As Boolean
        Dim blnPositive As Boolean
        If CDbl(txtAmountAirfare.Text) >= 0 And
        CDbl(txtCarRental.Text) >= 0 And
        CDbl(txtDaysOnTrip.Text) >= 0 And
        CDbl(txtLodgingCharge.Text) >= 0 And
        CDbl(txtMealExpenses.Text) >= 0 And
        CDbl(txtMilesDriven.Text) >= 0 And
        CDbl(txtParkingFees.Text) >= 0 And
        CDbl(txtRegisFees.Text) >= 0 And
        CDbl(txtCarRental.Text) >= 0 Then
            blnPositive = True
        End If
        Return blnPositive
    End Function

    'if empty, then make equl to zeros
    Sub InputEmpty()
        If txtAmountAirfare.Text = String.Empty Then
            txtAmountAirfare.Text = "0"
        End If
        If txtCarRental.Text = String.Empty Then
            txtCarRental.Text = "0"
        End If
        If txtDaysOnTrip.Text = String.Empty Then
            txtDaysOnTrip.Text = "0"
        End If
        If txtLodgingCharge.Text = String.Empty Then
            txtLodgingCharge.Text = "0"
        End If
        If txtMealExpenses.Text = String.Empty Then
            txtMealExpenses.Text = "0"
        End If
        If txtMilesDriven.Text = String.Empty Then
            txtMilesDriven.Text = "0"
        End If
        If txtParkingFees.Text = String.Empty Then
            txtParkingFees.Text = "0"
        End If
        If txtRegisFees.Text = String.Empty Then
            txtRegisFees.Text = "0"
        End If
        If txtTaxiFees.Text = String.Empty Then
            txtTaxiFees.Text = "0"
        End If
        If lblAmountResponsible.Text = String.Empty Then
            lblAmountResponsible.Text = "0"
        End If
        If lblAmountSaved.Text = String.Empty Then
            lblAmountSaved.Text = "0"
        End If
        If lblTotalExpenses.Text = String.Empty Then
            lblTotalExpenses.Text = "0"
        End If
        If lblAllowExpenses.Text = String.Empty Then
            lblAllowExpenses.Text = "0"
        End If
    End Sub

    'Start Button Calculate
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Calling Sub procedure, this will set any empty strings in text fields to zeros
        InputEmpty()

        'Begin nested if statement by first checking numeric validation
        If InputNumeric() Then
            If InputPositive() Then
                If CalcTotalReimbursement() > 0 Then
                    lblTotalAllowExpenValue.Text = CStr(CalcTotalReimbursement().ToString("c"))
                Else
                    lblTotalAllowExpenValue.Text = String.Empty
                End If
                If CalcTotal() > 0 Then
                    lblTotExpenseValue.Text = CStr(CalcTotal().ToString("c"))
                Else
                    lblTotExpenseValue.Text = String.Empty
                End If
                If CalcUnallowed() > 0 Then
                    lblAmtResponsibleValue.Text = CStr(CalcUnallowed().ToString("c"))
                Else
                    lblAmtResponsibleValue.Text = String.Empty
                End If
                If CalcSaved() > 0 Then
                    lblAmuntSavedValue.Text = CStr(CalcSaved().ToString("c"))
                Else
                    lblAmuntSavedValue.Text = String.Empty
                End If
            Else
                MessageBox.Show("Enter a Positive Valid Amount")

            End If
        Else
            MessageBox.Show("Enter a Numeric Amount")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'clear all the input
        txtAmountAirfare.Text = String.Empty
        txtCarRental.Text = String.Empty
        txtDaysOnTrip.Text = String.Empty
        txtLodgingCharge.Text = String.Empty
        txtMealExpenses.Text = String.Empty
        txtMilesDriven.Text = String.Empty
        txtParkingFees.Text = String.Empty
        txtRegisFees.Text = String.Empty
        txtTaxiFees.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class