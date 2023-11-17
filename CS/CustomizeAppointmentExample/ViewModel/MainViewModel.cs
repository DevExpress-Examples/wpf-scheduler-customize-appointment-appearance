using System;
using System.Collections.ObjectModel;

namespace CustomizeAppointmentExample {
    public class MainViewModel {
        public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }
        protected MainViewModel() {
            Doctors = new ObservableCollection<Doctor>();
            Appointments = new ObservableCollection<MedicalAppointment>();
            CreateDoctors();
            FillTasks();
        }
        private void CreateDoctors() {
            Doctors.Add(Doctor.Create(Id: 1, Name: "Stomatologist"));
            Doctors.Add(Doctor.Create(Id: 2, Name: "Ophthalmologist"));
            Doctors.Add(Doctor.Create(Id: 3, Name: "Surgeon"));
        }

        private void FillTasks() {
            Random rand = new Random(DateTime.Now.Millisecond);
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddHours(10), EndTime: DateTime.Now.Date.AddHours(11.5), DoctorId: 1, Location: "101", PatientName: "Dave Murrel", Note: "Take care", FirstVisit: true));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(2).AddHours(15), EndTime: DateTime.Now.Date.AddDays(2).AddHours(16.5), DoctorId: 1, Location: "101", PatientName: "Mike Roller", Note: "Schedule next visit soon", FirstVisit: true));

            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(1).AddHours(11), EndTime: DateTime.Now.Date.AddDays(1).AddHours(12), DoctorId: 2, Location: "103", PatientName: "Bert Parkins", Note: "", FirstVisit: true));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(2).AddHours(10), EndTime: DateTime.Now.Date.AddDays(2).AddHours(12), DoctorId: 2, Location: "103", PatientName: "Carl Lucas", Note: "", FirstVisit: false));

            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddHours(12), EndTime: DateTime.Now.Date.AddHours(13.5), DoctorId: 3, Location: "104", PatientName: "Brad Barnes", Note: "Tests are necessary", FirstVisit: false));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(1).AddHours(14), EndTime: DateTime.Now.Date.AddDays(1).AddHours(15), DoctorId: 3, Location: "104", PatientName: "Richard Fisher", Note: "", FirstVisit: true));
        }
    }
}
