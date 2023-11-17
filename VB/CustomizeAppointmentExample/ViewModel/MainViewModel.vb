Imports System
Imports System.Collections.ObjectModel

Namespace CustomizeAppointmentExample

    Public Class MainViewModel

        Public Overridable Property Doctors As ObservableCollection(Of Doctor)

        Public Overridable Property Appointments As ObservableCollection(Of MedicalAppointment)

        Protected Sub New()
            Doctors = New ObservableCollection(Of Doctor)()
            Appointments = New ObservableCollection(Of MedicalAppointment)()
            CreateDoctors()
            FillTasks()
        End Sub

        Private Sub CreateDoctors()
            Doctors.Add(Doctor.Create(Id:=1, Name:="Stomatologist"))
            Doctors.Add(Doctor.Create(Id:=2, Name:="Ophthalmologist"))
            Doctors.Add(Doctor.Create(Id:=3, Name:="Surgeon"))
        End Sub

        Private Sub FillTasks()
            Dim rand As Random = New Random(Date.Now.Millisecond)
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddHours(10), EndTime:=Date.Now.Date.AddHours(11.5), DoctorId:=1, Location:="101", PatientName:="Dave Murrel", Note:="Take care", FirstVisit:=True))
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddDays(2).AddHours(15), EndTime:=Date.Now.Date.AddDays(2).AddHours(16.5), DoctorId:=1, Location:="101", PatientName:="Mike Roller", Note:="Schedule next visit soon", FirstVisit:=True))
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddDays(1).AddHours(11), EndTime:=Date.Now.Date.AddDays(1).AddHours(12), DoctorId:=2, Location:="103", PatientName:="Bert Parkins", Note:="", FirstVisit:=True))
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddDays(2).AddHours(10), EndTime:=Date.Now.Date.AddDays(2).AddHours(12), DoctorId:=2, Location:="103", PatientName:="Carl Lucas", Note:="", FirstVisit:=False))
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddHours(12), EndTime:=Date.Now.Date.AddHours(13.5), DoctorId:=3, Location:="104", PatientName:="Brad Barnes", Note:="Tests are necessary", FirstVisit:=False))
            Appointments.Add(MedicalAppointment.Create(StartTime:=Date.Now.Date.AddDays(1).AddHours(14), EndTime:=Date.Now.Date.AddDays(1).AddHours(15), DoctorId:=3, Location:="104", PatientName:="Richard Fisher", Note:="", FirstVisit:=True))
        End Sub
    End Class
End Namespace
