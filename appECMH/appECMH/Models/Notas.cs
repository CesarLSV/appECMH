namespace appECMH.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;


    public class Notas
    {
        [JsonProperty(PropertyName = "PeopleID")]
        public string PeopleID { get; set; }

        [JsonProperty(PropertyName = "LegalName")]
        public string LegalName { get; set; }

        [JsonProperty("AcademicYear")]
        public string AcademicYear { get; set; }

        [JsonProperty("AcademicTerm")]
        public string AcademicTerm { get; set; }

        [JsonProperty("AcademicSession")]
        public string AcademicSession { get; set; }

        [JsonProperty("EventID")]
        public string EventID { get; set; }

        [JsonProperty("Section")]
        public string Section { get; set; }

        [JsonProperty("EventLongName")]
        public string EventLongName { get; set; }

        [JsonProperty("Carrera")]
        public string Carrera { get; set; }

        [JsonProperty("PrimerParcial")]
        public double? PrimerParcial { get; set; }

        [JsonProperty("SegundoParcial")]
        public double? SegundoParcial { get; set; }

        [JsonProperty("EvaluacionFinal")]
        public double? EvaluacionFinal { get; set; }

    }
}
