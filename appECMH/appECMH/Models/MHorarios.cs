

namespace appECMH.Models
{

    using Newtonsoft.Json;
    using System;
    
    public  class MHorarios
    {
        [JsonProperty(PropertyName = "PeopleID")]
        public string PeopleID { get; set; }

        [JsonProperty(PropertyName = "FirstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "MiddleName")]
        public string MiddleName { get; set; }

        [JsonProperty(PropertyName = "LastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "Suffix")]
        public object Suffix { get; set; }

        [JsonProperty(PropertyName = "LegalName")]
        public string LegalName { get; set; }

        [JsonProperty(PropertyName = "AcademicYear")]
        public string AcademicYear { get; set; }

        [JsonProperty(PropertyName = "AcademicTerm")]
        public string AcademicTerm { get; set; }

        [JsonProperty(PropertyName = "EventID")]
        public string EventID { get; set; }

        [JsonProperty(PropertyName = "EventLongName")]
        public string EventLongName { get; set; }

        [JsonProperty(PropertyName = "Credit")]
        public double Credit { get; set; }

        [JsonProperty(PropertyName = "StartTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty(PropertyName = "EndTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty(PropertyName = "MediumDesc")]
        public string MediumDesc { get; set; }

        [JsonProperty(PropertyName = "LongDesc")]
        public string LongDesc { get; set; }

        [JsonProperty(PropertyName = "Domingo")]
        public string Domingo { get; set; }

        [JsonProperty(PropertyName = "Lunes")]
        public string Lunes { get; set; }

        [JsonProperty(PropertyName = "Martes")]
        public string Martes { get; set; }

        [JsonProperty(PropertyName = "Miercoles")]
        public string Miercoles { get; set; }

        [JsonProperty(PropertyName = "Jueves")]
        public string Jueves { get; set; }

        [JsonProperty(PropertyName = "Viernes")]
        public string Viernes { get; set; }

        [JsonProperty(PropertyName = "Sabado")]
        public string Sabado { get; set; }

        [JsonProperty(PropertyName = "Section")]
        public string Section { get; set; }

        [JsonProperty(PropertyName = "RevisionDate")]
        public DateTime RevisionDate { get; set; }

        [JsonProperty(PropertyName = "RevisionTime")]
        public DateTime RevisionTime { get; set; }

    }
}
