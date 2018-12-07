Imports DevExpress.Utils.Design
Imports DevExpress.Xpf.Core
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Text
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media

Namespace CustomizeAppointmentExample
    #Region "#ConditionToImageSourceConverter"
    Public Class ConditionToImageSourceConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If value IsNot Nothing Then
                If DirectCast(value, Boolean) Then
                    Return DXImageHelper.GetImageSource("Office2013\Actions\Show_16x16.png")
                End If
            End If
            Return Nothing
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return value
        End Function
    End Class
    #End Region ' #ConditionToImageSourceConverter

    #Region "#ConditionToImageSourceConverterExtension"
    Public Class ConditionToImageSourceConverterExtension
        Inherits MarkupExtension

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return New ConditionToImageSourceConverter()
        End Function
    End Class
    #End Region ' #ConditionToImageSourceConverterExtension
End Namespace
