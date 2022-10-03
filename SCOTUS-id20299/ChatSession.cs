namespace SCOTUS_id20299
{
    public class ChatSession
    {
        //This could potentially be from SQL and consumed using EntityFramework
        //This is just memory
        public List<Message> Messages { get; set; } = new List<Message>();
    }

    public record struct Message(string Name, string Body);
}
