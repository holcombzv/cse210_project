public class WritingAssignment : Assignment {
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic) {
        _title = title;
    }
    public string GetWritinginformation() {
        return $"{_title} by {base.GetStudentName()}";
    }
}