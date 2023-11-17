using DevExpress.Mvvm.POCO;
using System;

namespace CustomizeAppointmentExample {
    public class MedicalAppointment {
        public static MedicalAppointment Create() {
            return ViewModelSource.Create(() => new MedicalAppointment());
        }
        internal static MedicalAppointment Create(DateTime StartTime, DateTime EndTime, int DoctorId, string Location, string PatientName, string Note, bool FirstVisit) {
            MedicalAppointment apt = MedicalAppointment.Create();
            apt.StartTime = StartTime;
            apt.EndTime = EndTime;
            apt.DoctorId = DoctorId;
            apt.Note = Note;
            apt.Location = Location;
            apt.PatientName = PatientName;
            apt.FirstVisit = FirstVisit;
            return apt;
        }

        protected MedicalAppointment() { }
        public virtual int Id { get; set; }
        public virtual bool AllDay { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string Note { get; set; }
        public virtual string Subject { get; set; }
        public virtual int PaymentStateId { get; set; }
        public virtual int IssueId { get; set; }
        public virtual int Type { get; set; }
        public virtual string Location { get; set; }
        public virtual string RecurrenceInfo { get; set; }
        public virtual string ReminderInfo { get; set; }
        public virtual int? DoctorId { get; set; }
        public virtual bool FirstVisit { get; set; }
    }
}
