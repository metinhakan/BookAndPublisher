namespace BookAndPublisher.Models;


public class Books
{
    public int Id { get; set; }
    public  string BookName { get; set; }
    
    
    public int BookPublisherId { get; set; }
    public Publisher BookPublisher { get; set; }
    
   

}

public class Publisher
{
    public int PublisherId { get; set; }
    public string PublisherName { get; set; }
    
    public ICollection<Books> Book { get; set; }
    
}