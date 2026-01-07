using avalonia_alienDB.Models;
using ReactiveUI;

namespace avalonia_alienDB.ViewModels;

public class DetailsWindowViewModel : ReactiveObject
{
    public string MovieTitle { get; }
    public string TranslatedMovieTitle { get; }
    public string ReleaseYear { get; }
    public string Director { get; }
    public string Screenplay { get; }
    public string Genre { get; }
    public string RunningTime { get; }
    public string Rating { get; }
    public string[] MainCharacters { get; }
    public string Ship { get; }
    public string MovieDescription { get; }
    public string FunFact { get; }

    public DetailsWindowViewModel(MovieModel data)
    {
        MovieTitle = data.MovieTitle;
        TranslatedMovieTitle = data.TranslatedMovieTitle;
        ReleaseYear = data.ReleaseYear.ToString();
        Director = data.Director;
        Screenplay = data.Screenplay;
        Genre = data.Genre;
        RunningTime = data.RunningTime.ToString();
        Rating = data.Rating.ToString();
        MainCharacters = data.MainCharacters;
        Ship = data.Ship;
        MovieDescription = data.MovieDescription;
        FunFact = data.FunFact;
    }
}