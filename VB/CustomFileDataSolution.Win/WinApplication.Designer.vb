Imports Microsoft.VisualBasic
Imports System
Namespace CustomFileDataSolution.Win
	Partial Public Class CustomFileDataSolutionWindowsFormsApplication
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
			Me.module3 = New CustomFileDataSolution.Module.CustomFileDataSolutionModule()
			Me.module4 = New CustomFileDataSolution.Module.Win.CustomFileDataSolutionWindowsFormsModule()
			Me.conditionalAppearanceModule = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
			Me.fileAttachmentsWindowsFormsModule = New DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule()
			Me.validationModule = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.validationWindowsFormsModule = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' CustomFileDataSolutionWindowsFormsApplication
			' 
			Me.ApplicationName = "CustomFileDataSolution"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.conditionalAppearanceModule)
			Me.Modules.Add(Me.fileAttachmentsWindowsFormsModule)
			Me.Modules.Add(Me.validationModule)
			Me.Modules.Add(Me.validationWindowsFormsModule)
			Me.UseOldTemplates = False
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.CustomFileDataSolutionWindowsFormsApplication_DatabaseVersionMismatch);
'			Me.CustomizeLanguagesList += New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(Me.CustomFileDataSolutionWindowsFormsApplication_CustomizeLanguagesList);

			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
		Private module3 As CustomFileDataSolution.Module.CustomFileDataSolutionModule
		Private module4 As CustomFileDataSolution.Module.Win.CustomFileDataSolutionWindowsFormsModule
		Private conditionalAppearanceModule As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
		Private fileAttachmentsWindowsFormsModule As DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
		Private validationModule As DevExpress.ExpressApp.Validation.ValidationModule
		Private validationWindowsFormsModule As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
	End Class
End Namespace
