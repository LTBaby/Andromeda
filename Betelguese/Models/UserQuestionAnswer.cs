namespace Betelguese.Models
{
    public class UserQuestionAnswer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}
