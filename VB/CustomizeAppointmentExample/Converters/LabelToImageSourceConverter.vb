Imports DevExpress.Xpf.Core
Imports System
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup

Namespace CustomizeAppointmentExample

#Region "#LabelToImageSourceConverter"
    Public Class LabelToImageSourceConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If CInt(value) = 1 Then
                Return DXImageHelper.GetImageSource("Office2013\Tasks\Status_16x16.png")
            Else
                Return DXImageHelper.GetImageSource("Office2013\Support\Info_16x16.png")
            End If
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function
    End Class

#End Region  ' #LabelToImageSourceConverter
#Region "#LabelToImageSourceConverterExtension"
    Public Class LabelToImageSourceConverterExtension
        Inherits MarkupExtension

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return New LabelToImageSourceConverter()
        End Function
    End Class
#End Region  ' #LabelToImageSourceConverterExtension
End Namespace
