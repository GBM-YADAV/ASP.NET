namespace WMVC_View_model_DepT_emp.Models
{
    public class StudentsDetails
    {
        public int Id { get; set; }
        public Student student { get; set; }
        public Address address { get; set; }
        public string Title { get; set; }
        public string University { get; set; }
    }
}
