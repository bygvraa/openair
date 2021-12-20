using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OpenAir.Shared.Models
{
    public class ApplicationTask
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Coordinator { get; set; }
        public string VolunteerEmail { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }


        // Metoder til Get
        public int GetId() { return Id; }
        public string GetUserType() { return Type; }
        public string GetCategory() { return Category; }
        public string GetDescription() { return Description; }
        public string GetCoordinator() { return Coordinator; }
        public string GetVolunteer() { return VolunteerEmail; }
        public string GetLocation() { return Location; }
        public DateTime GetStartTime() { return StartTime; }
        public DateTime GetStopTime() { return StopTime; }
        public DateTime GetCreated() { return Created; }
        public DateTime GetModified() { return Modified; }
    }

    // Enums
    public enum UserType
    {
        Frivillig,
        Kontaktperson
    }

    public enum Category
    {
        Sceneopsætning,
        Rengøring,
        Bar,
        Entre,
        Vagt,
        Madbod,
        Backstage,
        Andet
    }
}
