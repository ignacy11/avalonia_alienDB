using avalonia_alienDB.Models;

namespace avalonia_alienDB.ViewModels;

public class MovieViewModel : ViewModelBase
{
    public MovieModel Model { get; }
    public string MovieTitle => Model.MovieTitle;
    public string TranslatedMovieTitle => Model.TranslatedMovieTitle;
    public string ReleaseYear => Model.ReleaseYear.ToString();
    public string Director => Model.Director;
    public string Screenplay => Model.Screenplay;
    public string Genre => Model.Genre;
    public string RunningTime => Model.RunningTime.ToString();
    public string Rating => Model.Rating.ToString();
    public string[] MainCharacters => Model.MainCharacters;
    public string Ship => Model.Ship;
    public string MovieDescription => Model.MovieDescription;
    public string FunFact => Model.FunFact;
    
    public MovieViewModel(MovieModel model)
    {
        Model = model;
    }
}