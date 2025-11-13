namespace avalonia_alienDB.Models;

public class MovieModel
{
    public string Title { get; set; }
    public string TranslatedTitle { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string Screenplay { get; set; }
    public string Genre { get; set; }
    public int RunningTime { get; set; }
    public float Rating { get; set; }
    public string[] MainCharacters { get; set; }
    public string Ship { get; set; } 
    public string MovieDescription { get; set; }
    public string FunFact { get; set; }
}