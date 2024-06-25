<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128655874/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T545892)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Scheduler - Customize Appointment Appearance

This example demonstrates how to use styles and templates to customize appointment appearance. The [DayViewBase.AppointmentContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.AppointmentContentTemplate) property changes the layout of appointment elements. The [DayViewBase.AppointmentStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.AppointmentStyle) property displays a custom image in the appointment. The **ConditionToImageSourceConverter** returns this image based on a [custom field](https://docs.devexpress.com/WPF/119962/controls-and-libraries/scheduler/data-binding/custom-fields) value.

![image](https://github.com/DevExpress-Examples/how-to-customize-the-appointment-appearance-t545892/assets/65009440/74559f62-5dba-4903-8f7d-9596afecbde5)

## Files to Review

* [MainWindow.xaml](./CS/CustomizeAppointmentExample/MainWindow.xaml)
* [LabelToImageSourceConverter.cs](./CS/CustomizeAppointmentExample/Converters/LabelToImageSourceConverter.cs) (VB: [LabelToImageSourceConverter.vb](./VB/CustomizeAppointmentExample/Converters/LabelToImageSourceConverter.vb))

## Documentation

* [Customize Appointment Appearance](https://docs.devexpress.com/WPF/116758/controls-and-libraries/scheduler/examples/how-to-customize-appointment-appearance)
* [Customize Appointments](https://docs.devexpress.com/WPF/119867/controls-and-libraries/scheduler/styles-and-templates/visual-appointment)
* [DayViewBase.AppointmentContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.AppointmentContentTemplate)
* [DayViewBase.AppointmentStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.DayViewBase.AppointmentStyle)

## More Examples

* [WPF Scheduler - Handle the CustomAppointmentBackground Event to Change the Appointment Background](https://github.com/DevExpress-Examples/wpf-scheduler-handle-customappointmentbackground-event-to-change-appointment-background)
* [WPF Scheduler - Customize the Appointment Flyout and Tooltip](https://github.com/DevExpress-Examples/how-to-customize-the-appointment-flyout-t584389)
* [WPF Scheduler - Disable Resource Colorization](https://github.com/DevExpress-Examples/how-to-disable-resource-colorization)
* [WPF Scheduler - Customize Cell Colors](https://github.com/DevExpress-Examples/how-to-set-the-cell-color-using-different-approaches-t604609)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-customize-appointment-appearance&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-scheduler-customize-appointment-appearance&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
