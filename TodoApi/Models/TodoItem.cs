namespace TodoApi.Models;

public class TodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public Boolean IsComplete { get; set; }
    public string? Secret { get; set; }
}