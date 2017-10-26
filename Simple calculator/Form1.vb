Imports System.Math
Public Class Form1
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		TextBox1.Visible = True
		TextBox2.Visible = True
		Label3.Visible = True
		Button1.Visible = True
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		TextBox1.Visible = True
		TextBox2.Visible = True
		Label5.Visible = True
		Button7.Visible = True
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		TextBox1.Visible = True
		TextBox2.Visible = True
		Label4.Visible = True
		Button8.Visible = True
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		TextBox1.Visible = True
		TextBox2.Visible = True
		Label2.Visible = True
		Button9.Visible = True
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
		TextBox1.Visible = True
		TextBox2.Visible = True
		Label6.Visible = True
		Button10.Visible = True
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim sum As Double
		sum = CDec(TextBox1.Text) +
			CDec(TextBox2.Text)
		Label8.Text = sum.ToString
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		Dim sum As Double
		sum = CDec(TextBox1.Text) -
			CDec(TextBox2.Text)
		Label8.Text = sum.ToString
	End Sub

	Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
		Dim sum As Double
		sum = CDec(TextBox1.Text) *
			CDec(TextBox2.Text)
		Label8.Text = sum.ToString
	End Sub

	Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
		Dim sum As Double
		sum = CDec(TextBox1.Text) /
			CDec(TextBox2.Text)
		Label8.Text = sum.ToString
	End Sub

	Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
		Dim sum As Double
		sum = CDec(TextBox1.Text) ^
			CDec(TextBox2.Text)
		Label8.Text = sum.ToString
	End Sub

	Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
		Me.Close()
	End Sub
End Class
