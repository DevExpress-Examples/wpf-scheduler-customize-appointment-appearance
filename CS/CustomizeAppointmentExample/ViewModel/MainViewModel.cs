#region #usings
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
#endregion #usings

namespace CustomizeAppointmentExample
{
    public class MainViewModel
    {
		public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }
        protected MainViewModel()
        {
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
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddHours(10), EndTime: DateTime.Now.Date.AddHours(11), DoctorId: 1, Notes: "", Location: "101", PatientName: "Dave Murrel", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: true));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(2).AddHours(15), EndTime: DateTime.Now.Date.AddDays(2).AddHours(16), DoctorId: 1, Notes: "", Location: "101", PatientName: "Mike Roller", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: true));

            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(1).AddHours(11), EndTime: DateTime.Now.Date.AddDays(1).AddHours(12), DoctorId: 2, Notes: "", Location: "103", PatientName: "Bert Parkins", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: true));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(2).AddHours(10), EndTime: DateTime.Now.Date.AddDays(2).AddHours(12), DoctorId: 2, Notes: "", Location: "103", PatientName: "Carl Lucas", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: false));

            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddHours(12), EndTime: DateTime.Now.Date.AddHours(13), DoctorId: 3, Notes: "Blood test results are required", Location: "104", PatientName: "Brad Barnes", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: false));
            Appointments.Add(MedicalAppointment.Create(StartTime: DateTime.Now.Date.AddDays(1).AddHours(14), EndTime: DateTime.Now.Date.AddDays(1).AddHours(15), DoctorId: 3, Notes: "", Location: "104", PatientName: "Richard Fisher", InsuranceNumber: GenerateNineNumbers(rand), FirstVisit: true));
        }

        private string GenerateNineNumbers(Random rand) {
            string result = "";
            for (int i = 0; i < 9; i++) {
                result += rand.Next(9).ToString();
            }
            return result;
        }
    }

    public class Doctor {
        public static Doctor Create() {
            return ViewModelSource.Create(() => new Doctor());
        }
        public static Doctor Create(int Id, string Name) {
            Doctor doctor = Doctor.Create();
            doctor.Id = Id;
            doctor.Name = Name;
            return doctor;
        }

        protected Doctor() { }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
    
    public class MedicalAppointment {
        public static MedicalAppointment Create() {
            return ViewModelSource.Create(() => new MedicalAppointment());
        }
        internal static MedicalAppointment Create(DateTime StartTime, DateTime EndTime, int DoctorId, string Notes, string Location, string PatientName, string InsuranceNumber, bool FirstVisit) {
            MedicalAppointment apt = MedicalAppointment.Create();
            apt.StartTime = StartTime;
            apt.EndTime = EndTime;
            apt.DoctorId = DoctorId;
            apt.Notes = Notes;
            apt.Location = Location;
            apt.PatientName = PatientName;
            apt.InsuranceNumber = InsuranceNumber;
            apt.FirstVisit = FirstVisit;
            return apt;
        }

        protected MedicalAppointment() { }
        public virtual int Id { get; set; }
        public virtual bool AllDay { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Subject { get; set; }
        public virtual int PaymentStateId { get; set; }
        public virtual int IssueId { get; set; }
        public virtual int Type { get; set; }
        public virtual string Location { get; set; }
        public virtual string RecurrenceInfo { get; set; }
        public virtual string ReminderInfo { get; set; }
        public virtual int? DoctorId { get; set; }
        public virtual string InsuranceNumber { get; set; }
        public virtual bool FirstVisit { get; set; }
    }
}

