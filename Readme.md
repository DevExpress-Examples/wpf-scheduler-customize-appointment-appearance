<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655874/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T545892)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [LabelToImageSourceConverter.cs](./CS/CustomizeAppointmentExample/Converters/LabelToImageSourceConverter.cs) (VB: [LabelToImageSourceConverter.vb](./VB/CustomizeAppointmentExample/Converters/LabelToImageSourceConverter.vb))
* [MainWindow.xaml](./CS/CustomizeAppointmentExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomizeAppointmentExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomizeAppointmentExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomizeAppointmentExample/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/CustomizeAppointmentExample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/CustomizeAppointmentExample/ViewModel/MainViewModel.vb))
<!-- default file list end -->
# How to customize the appointment appearance


This example follows the <a href="http://help.devexpress.com/#WPF/CustomDocument116758">How to: Customize Appointment Appearance</a> topic and demonstrates how to customize the appointment appearance with appointment style and a data template. The view's <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingDayViewBase_AppointmentContentTemplatetopic">AppointmentContentTemplate</a> and <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingDayViewBase_AppointmentStyletopic">AppointmentStyle </a>properties are used to assign custom templates. A custom converter provides an image for display based on the value of the appointment's custom field.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-customize-the-appointment-appearance-t545892/17.2.3+/media/8ab28532-1506-4694-9d11-f9988f99b956.png">

<br/>


