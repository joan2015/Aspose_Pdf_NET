'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System

Namespace ExtractImagesFromWholePDFExample
	Public Class Program
		Public Shared Sub Main()
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'open input PDF
			Dim pdfExtractor As New PdfExtractor()
			pdfExtractor.BindPdf(dataDir & "input.pdf")

			'extract all the images
			pdfExtractor.ExtractImage()

			'get all the extracted images
			Do While pdfExtractor.HasNextImage()
				pdfExtractor.GetNextImage(dataDir & DateTime.Now.Ticks.ToString() & ".jpg")
			Loop



		End Sub
	End Class
End Namespace