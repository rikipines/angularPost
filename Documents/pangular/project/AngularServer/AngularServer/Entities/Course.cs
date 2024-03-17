namespace AngularServer.Entities
{
    public enum Way_Of_Learning { Frontaly, Zoom };
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int LessonsAmount { get; set; }
        public DateTime DateOfStart { get; set; }
        public List<string> syllibus { get; set; }
        public int LecturerId { get; set; }
        public string Image { get; set; }
        public Way_Of_Learning Way_Of_Learning { get; set; }




    }
}
