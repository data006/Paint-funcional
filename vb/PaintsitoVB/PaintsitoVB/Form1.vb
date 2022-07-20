Imports System.Math

Public Class frmPaintsitoVB

    Dim pintar As Boolean
    Dim rectangulo, elipse, triangle, diamond, texto, flecha, fill, formasSolidas As Boolean
    Dim colorsito As String = "Black"
    Dim tamano As Integer = 5
    Dim x1, y1 As Integer
    Dim formas As Boolean = False


    'Timer
    Private Sub tmrTiempo_Tick(sender As Object, e As EventArgs) Handles tmrTiempo.Tick

        Dim MouseX As Integer = Cursor.Position.X
        Dim MouseY As Integer = Cursor.Position.Y

        ToolStripStatusLabel1.Text = MouseX
        ToolStripStatusLabel3.Text = MouseY
    End Sub




    'File > Cerrar programa
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub






    Private Sub frmPaintsitoVB_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            pintar = True
        End If

        If e.Button = MouseButtons.Right Then
            ContextMenuStrip.Show(MousePosition.X, MousePosition.Y)
        End If

        If formas = True Then

            If rectangulo = True Then
                x1 = e.X
                y1 = e.Y


            ElseIf elipse = True Then

                x1 = e.X
                y1 = e.Y

            ElseIf triangle = True Then

                x1 = e.X
                y1 = e.Y

            ElseIf diamond = True Then

                x1 = e.X
                y1 = e.Y


            ElseIf flecha = True Then

                x1 = e.X
                y1 = e.Y




            End If



        End If




    End Sub

    Private Sub frmPaintsitoVB_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        Static coords As New Point


        'Sino tienes seleccionado ninguna figura, entras
        If formas = False Then

            If texto = False Then
                If fill = False Then
                    If pintar = True Then

                        Dim dibujito As Graphics = CreateGraphics()
                        Dim plumita As New Pen(Color.FromName(colorsito), tamano)
                        plumita.StartCap = Drawing2D.LineCap.Round
                        plumita.EndCap = Drawing2D.LineCap.Round
                        dibujito.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                        dibujito.DrawLine(plumita, coords.X, coords.Y, e.X, e.Y)

                    End If
                End If
            End If

            End If

        coords = e.Location

    End Sub

    Private Sub frmPaintsitoVB_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        pintar = False

        'Si tengo seleccionada una figura, entra
        If formas = True Then

            If rectangulo = True Then

                Dim dibujito As Graphics = CreateGraphics()
                If e.X > x1 And e.Y > y1 Then

                    If formasSolidas = True Then
                        dibujito.FillRectangle(New SolidBrush(Color.FromName(colorsito)), x1, y1, e.X - x1, e.Y - y1)

                    Else
                        dibujito.DrawRectangle(New Pen(Color.FromName(colorsito)), x1, y1, e.X - x1, e.Y - y1)

                    End If


                ElseIf e.X > x1 And e.Y < y1 Then

                    If formasSolidas = True Then
                        dibujito.FillRectangle(New SolidBrush(Color.FromName(colorsito)), x1, e.Y, Abs(e.X - x1), Abs(e.Y - y1))
                    Else
                        dibujito.DrawRectangle(New Pen(Color.FromName(colorsito)), x1, e.Y, Abs(e.X - x1), Abs(e.Y - y1))
                    End If

                ElseIf e.X < x1 And e.Y > y1 Then

                    If formasSolidas = True Then
                        dibujito.FillRectangle(New SolidBrush(Color.FromName(colorsito)), e.X, y1, Abs(e.X - x1), Abs(e.Y - y1))

                    Else
                        dibujito.DrawRectangle(New Pen(Color.FromName(colorsito)), e.X, y1, Abs(e.X - x1), Abs(e.Y - y1))

                    End If

                Else
                    If formasSolidas = True Then
                        dibujito.FillRectangle(New SolidBrush(Color.FromName(colorsito)), e.X, e.Y, Abs(e.X - x1), Abs(e.Y - y1))
                    Else
                        dibujito.DrawRectangle(New Pen(Color.FromName(colorsito)), e.X, e.Y, Abs(e.X - x1), Abs(e.Y - y1))

                    End If


                End If






            ElseIf elipse = True Then

                Dim dibujito As Graphics = CreateGraphics()
                If e.X > x1 And e.Y > y1 Then

                    If formasSolidas = True Then
                        dibujito.FillEllipse(New SolidBrush(Color.FromName(colorsito)), x1, y1, e.X - x1, e.Y - y1)
                    Else
                        dibujito.DrawEllipse(New Pen(Color.FromName(colorsito)), x1, y1, e.X - x1, e.Y - y1)

                    End If

                ElseIf e.X > x1 And e.Y < y1 Then
                    If formasSolidas = True Then
                        dibujito.FillEllipse(New SolidBrush(Color.FromName(colorsito)), x1, e.Y, Abs(e.X - x1), Abs(e.Y - y1))
                    Else
                        dibujito.DrawEllipse(New Pen(Color.FromName(colorsito)), x1, e.Y, Abs(e.X - x1), Abs(e.Y - y1))

                    End If

                ElseIf e.X < x1 And e.Y > y1 Then
                    If formasSolidas = True Then
                        dibujito.FillEllipse(New SolidBrush(Color.FromName(colorsito)), e.X, y1, Abs(e.X - x1), Abs(e.Y - y1))
                    Else
                        dibujito.DrawEllipse(New Pen(Color.FromName(colorsito)), e.X, y1, Abs(e.X - x1), Abs(e.Y - y1))

                    End If

                Else
                    If formasSolidas = True Then
                        dibujito.FillEllipse(New SolidBrush(Color.FromName(colorsito)), e.X, e.Y, Abs(e.X - x1), Abs(e.Y - y1))
                    Else
                        dibujito.DrawEllipse(New Pen(Color.FromName(colorsito)), e.X, e.Y, Abs(e.X - x1), Abs(e.Y - y1))

                    End If


                End If








            ElseIf triangle = True Then

                Dim dibujito As Graphics = CreateGraphics()
                Dim lineas As New Drawing2D.GraphicsPath

                If e.X > x1 And e.Y > y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, e.X, e.Y)
                    lineas.AddLine(e.X, e.Y, x1, e.Y)
                    lineas.AddLine(x1, e.Y, x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X > x1 And e.Y < y1 Then


                    lineas.AddLine(x1, y1, e.X, y1)
                    lineas.AddLine(e.X, y1, x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, x1, y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X < x1 And e.Y > y1 Then

                    lineas.AddLine(e.X, e.Y, x1, e.Y)
                    lineas.AddLine(x1, e.Y, x1 - ((x1 - e.X) \ 2), y1)
                    lineas.AddLine((x1 - (x1 - e.X) \ 2), y1, e.X, e.Y)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If
                Else

                    lineas.AddLine(x1, y1, e.X, y1)
                    lineas.AddLine(e.X, y1, x1 - ((x1 - e.X) \ 2), e.Y)
                    lineas.AddLine(x1 - ((x1 - e.X) \ 2), e.Y, x1, y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                End If









            ElseIf diamond = True Then


                Dim dibujito As Graphics = CreateGraphics()
                Dim lineas As New Drawing2D.GraphicsPath

                If e.X > x1 And e.Y > y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X > x1 And e.Y < y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), e.X + ((x1 - e.X) \ 2), e.Y)
                    lineas.AddLine(e.X + ((x1 - e.X) \ 2), e.Y, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), y1)


                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X < x1 And e.Y > y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If
                Else

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                End If





            ElseIf flecha = True Then



                Dim dibujito As Graphics = CreateGraphics()
                Dim lineas As New Drawing2D.GraphicsPath

                If e.X > x1 And e.Y > y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, x1 + ((e.X - x1) \ 2), y1)


                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)

                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X > x1 And e.Y < y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, e.X, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(e.X, y1 + ((e.Y - y1) \ 2), e.X + ((x1 - e.X) \ 2), e.Y)
                    lineas.AddLine(e.X + ((x1 - e.X) \ 2), e.Y, x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                ElseIf e.X < x1 And e.Y > y1 Then

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If
                Else

                    lineas.AddLine(x1 + ((e.X - x1) \ 2), y1, x1, y1 + ((e.Y - y1) \ 2))
                    lineas.AddLine(x1, y1 + ((e.Y - y1) \ 2), x1 + ((e.X - x1) \ 2), e.Y)
                    lineas.AddLine(x1 + ((e.X - x1) \ 2), e.Y, x1 + ((e.X - x1) \ 2), y1)

                    If formasSolidas = True Then
                        dibujito.FillPath(New SolidBrush(Color.FromName(colorsito)), lineas)
                    Else
                        dibujito.DrawPath(New Pen(Color.FromName(colorsito)), lineas)

                    End If

                End If

            End If


        End If












        'Si tengo seleccionado insertar texto
        If texto = True Then

            Dim letritas As Graphics = CreateGraphics()


            letritas.DrawString(InputBox("Texto a ingresar: "), New Font(Label1.Font.Name, 20), New SolidBrush(Color.FromName(colorsito)), e.X, e.Y)



        End If


        'Si tengo seleccionado fill
        If fill = True Then

            Dim dibujito As Graphics = CreateGraphics()
            dibujito.FillRectangle(New SolidBrush(Color.FromName(colorsito)), 0, 100, 1380, 720)

        End If

    End Sub





    'Funciones de Edit
    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click, RedToolStripMenuItem1.Click, btnRed.Click

        If texto = True Then

            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill

        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill



        End If
        colorsito = "red"
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click, GreenToolStripMenuItem1.Click, btnGreen.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        colorsito = "green"
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click, BlueToolStripMenuItem1.Click, btnBlue.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        colorsito = "blue"
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click, YellowToolStripMenuItem1.Click, btnYellow.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        colorsito = "yellow"
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click, BlackToolStripMenuItem1.Click, btnBlack.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        colorsito = "black"
    End Sub

    Private Sub BrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrownToolStripMenuItem.Click, BrownToolStripMenuItem1.Click, btnBrown.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If
        colorsito = "brown"
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click, PurpleToolStripMenuItem1.Click, btnPurple.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If
        colorsito = "purple"

    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click, GrayToolStripMenuItem1.Click, btnGray.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If
        colorsito = "gray"
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click, OrangeToolStripMenuItem1.Click, btnOrange.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False
        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If
        colorsito = "orange"
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click, PinkToolStripMenuItem1.Click, btnPink.Click

        If texto = True Then
            btnText.BackgroundImage = My.Resources.TextSelected
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.pen2
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If

        Text = False

        If colorsito = "white" Then
            colorsito = "black"

            btnText.BackgroundImage = My.Resources.Text
            btnEraser.BackgroundImage = My.Resources.eraser3
            btnPen.BackgroundImage = My.Resources.penselected
            btnRectangle.BackgroundImage = My.Resources.rectangulo
            btnElipse.BackgroundImage = My.Resources.circulo
            btnTriangle.BackgroundImage = My.Resources.triangulo
            btnFlecha.BackgroundImage = My.Resources.flecha
            btnDiamond.BackgroundImage = My.Resources.rombo
            btnFill.BackgroundImage = My.Resources.fill
        End If
        colorsito = "pink"
    End Sub









    'Tamanos
    Private Sub cmbTamanos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTamanos.SelectedIndexChanged

        If cmbTamanos.SelectedItem = "2" Then
            tamano = 2

        ElseIf cmbTamanos.SelectedItem = "5" Then
            tamano = 5

        ElseIf cmbTamanos.SelectedItem = "8" Then
            tamano = 8

        ElseIf cmbTamanos.SelectedItem = "11" Then
            tamano = 11

        ElseIf cmbTamanos.SelectedItem = "20" Then
            tamano = 20

        End If

    End Sub

    Private Sub IncreaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseToolStripMenuItem.Click
        If tamano = 2 Then
            tamano = 5
            cmbTamanos.SelectedIndex = 1

        ElseIf tamano = 5 Then
            tamano = 8
            cmbTamanos.SelectedIndex = 2

        ElseIf tamano = 8 Then
            tamano = 11
            cmbTamanos.SelectedIndex = 3

        ElseIf tamano = 11 Then
            tamano = 20
            cmbTamanos.SelectedIndex = 4

        End If

        btnRectangle.Text = tamano
    End Sub

    Private Sub DecreaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseToolStripMenuItem.Click

        If tamano = 20 Then
            tamano = 11
            cmbTamanos.SelectedIndex = 3

        ElseIf tamano = 11 Then
            tamano = 8
            cmbTamanos.SelectedIndex = 2

        ElseIf tamano = 8 Then
            tamano = 5
            cmbTamanos.SelectedIndex = 1

        ElseIf tamano = 5 Then
            tamano = 2
            cmbTamanos.SelectedIndex = 0

        End If

        btnRectangle.Text = tamano
    End Sub







    'Herramientas
    Private Sub btnEraser_Click(sender As Object, e As EventArgs) Handles btnEraser.Click

        formas = False
        texto = False
        fill = False

        colorsito = "white"

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraserselected
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill

    End Sub



    Private Sub btnPen_Click(sender As Object, e As EventArgs) Handles btnPen.Click

        formas = False
        texto = False
        fill = False


        If colorsito = "white" Then
            colorsito = "black"
        End If

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.penselected
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
    End Sub

    Private Sub btnCirculoNoFill_Click(sender As Object, e As EventArgs) Handles btnCirculoNoFill.Click
        formas = True
        rectangulo = False
        elipse = True
        triangle = False
        diamond = False
        fill = False
        flecha = False
        formasSolidas = False
        texto = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circuloSelected
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If
    End Sub

    Private Sub btnTrianguloNoFill_Click(sender As Object, e As EventArgs) Handles btnTrianguloNoFill.Click
        formas = True
        rectangulo = False
        elipse = False
        fill = False
        triangle = True
        formasSolidas = False
        diamond = False
        texto = False
        flecha = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.trianguloSelected
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If
    End Sub

    Private Sub btnRomboNoFill_Click(sender As Object, e As EventArgs) Handles btnRomboNoFill.Click
        formas = True
        formasSolidas = False
        rectangulo = False
        elipse = False
        triangle = False
        diamond = True
        texto = False
        fill = False
        flecha = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.romboSelected
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If
    End Sub

    Private Sub btnFlechaNoFill_Click(sender As Object, e As EventArgs) Handles btnFlechaNoFill.Click
        formas = True
        formasSolidas = False
        rectangulo = False
        elipse = False
        triangle = False
        diamond = False
        fill = False
        texto = False
        flecha = True

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flechaSelected
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Paintsito" & vbCrLf & "by Carlos Salas" & vbCrLf & "Programacion Visual" & vbCrLf & "teacher: Luis Salazar" & vbCrLf & "UTCH, 2020")
    End Sub

    Private Sub frmPaintsitoVB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTamanos.SelectedIndex = 1
    End Sub

    Private Sub btnRectanguloNoFill_Click(sender As Object, e As EventArgs) Handles btnRectanguloNoFill.Click

        formas = True
        rectangulo = True
        elipse = False
        flecha = False
        triangle = False
        diamond = False
        texto = False
        fill = False
        formasSolidas = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectanguloSelected
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub

    Private Sub btnFill_Click(sender As Object, e As EventArgs) Handles btnFill.Click
        formas = False
        texto = False
        fill = True

        If colorsito = "white" Then
            colorsito = "black"
        End If

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fillselected

    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click

        formas = False
        texto = True
        fill = False

        If colorsito = "white" Then
            colorsito = "black"
        End If

        btnText.BackgroundImage = My.Resources.TextSelected
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill

    End Sub








    'FORMAS
    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click

        formas = True
        rectangulo = True
        elipse = False
        flecha = False
        triangle = False
        diamond = False
        texto = False
        fill = False
        formasSolidas = True

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectanguloSelected
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub



    Private Sub btnElipse_Click(sender As Object, e As EventArgs) Handles btnElipse.Click


        formas = True
        rectangulo = False
        elipse = True
        triangle = False
        diamond = False
        fill = False
        flecha = False
        formasSolidas = True
        texto = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circuloSelected
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub


    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click

        formas = True
        rectangulo = False
        elipse = False
        fill = False
        triangle = True
        formasSolidas = True
        diamond = False
        texto = False
        flecha = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.trianguloSelected
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub



    Private Sub btnDiamond_Click(sender As Object, e As EventArgs) Handles btnDiamond.Click

        formas = True
        formasSolidas = True
        rectangulo = False
        elipse = False
        triangle = False
        diamond = True
        texto = False
        fill = False
        flecha = False

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flecha
        btnDiamond.BackgroundImage = My.Resources.romboSelected
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub


    Private Sub btnFlecha_Click(sender As Object, e As EventArgs) Handles btnFlecha.Click

        formas = True
        formasSolidas = True
        rectangulo = False
        elipse = False
        triangle = False
        diamond = False
        fill = False
        texto = False
        flecha = True

        btnText.BackgroundImage = My.Resources.Text
        btnEraser.BackgroundImage = My.Resources.eraser3
        btnPen.BackgroundImage = My.Resources.pen2
        btnRectangle.BackgroundImage = My.Resources.rectangulo
        btnElipse.BackgroundImage = My.Resources.circulo
        btnTriangle.BackgroundImage = My.Resources.triangulo
        btnFlecha.BackgroundImage = My.Resources.flechaSelected
        btnDiamond.BackgroundImage = My.Resources.rombo
        btnFill.BackgroundImage = My.Resources.fill
        If colorsito = "white" Then
            colorsito = "black"
        End If

    End Sub


End Class
