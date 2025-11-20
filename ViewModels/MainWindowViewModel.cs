using System.Collections.ObjectModel;
using avalonia_alienDB.Models;
using ReactiveUI.Fody.Helpers;

namespace avalonia_alienDB.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<MovieModel> Movies { get; } = new()
    {
        new MovieModel
        {
            Title = "Alien",
            TranslatedTitle = "Obcy – ósmy pasażer Nostromo",
            ReleaseYear = 1979,
            Director = "Ridley Scott",
            Screenplay = "Dan O'Bannon",
            Genre = "Sci-fi / Horror",
            RunningTime = 117,
            Rating = 8.5f,
            MainCharacters = ["Ellen Ripley, Dallas, Ash, Lambert, Kane"],
            Ship = "USCSS Nostromo",
            MovieDescription = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            FunFact = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },
        new MovieModel
        {
            Title = "Aliens",
            TranslatedTitle = "Obcy – decydujące starcie",
            ReleaseYear = 1986,
            Director = "James Cameron",
            Screenplay = "James Cameron, David Giler, Walter Hill",
            Genre = "Sci-Fi / Akcja / Horror",
            RunningTime = 137,
            Rating = 8.4f,
            MainCharacters = ["Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez"],
            Ship = "USS Sulaco",
            MovieDescription = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFact = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },
        new MovieModel
        {
            Title = "Alien³",
            TranslatedTitle = "Obcy³",
            ReleaseYear = 1992,
            Director = "David Fincher",
            Screenplay = "David Giler, Walter Hill, Larry Ferguson",
            Genre = "Sci-Fi / Horror",
            RunningTime = 114,
            Rating = 6.5f,
            MainCharacters = ["Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews"],
            Ship = "E.E.V. z USS Sulaco (katastrofa)",
            MovieDescription =
                "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            FunFact =
                "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },
        new MovieModel
        {
            Title = "Alien: Resurrection",
            TranslatedTitle = "Obcy: Przebudzenie",
            ReleaseYear = 1997,
            Director = "Jean-Pierre Jeunet",
            Screenplay = "Joss Whedon",
            Genre = "Sci-Fi / Horror",
            RunningTime = 109,
            Rating = 6.2f,
            MainCharacters = ["Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman"],
            Ship = "USM Auriga",
            MovieDescription =
                "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            FunFact =
                "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },
        new MovieModel
        {
            Title = "Prometheus",
            TranslatedTitle = "Prometeusz",
            ReleaseYear = 2012,
            Director = "Ridley Scott",
            Screenplay = "Jon Spaihts, Damon Lindelof",
            Genre = "Sci-Fi / Thriller",
            RunningTime = 124,
            Rating = 7.0f,
            MainCharacters = ["Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers"],
            Ship = "USCSS Prometheus",
            MovieDescription = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            FunFact = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },
        new MovieModel
        {
            Title = "Alien: Covenant",
            TranslatedTitle = "Obcy: Przymierze",
            ReleaseYear = 2017,
            Director = "Ridley Scott",
            Screenplay = "John Logan, Dante Harper",
            Genre = "Sci-Fi / Horror",
            RunningTime = 122,
            Rating = 6.4f,
            MainCharacters = new[] { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            Ship = "USCSS Covenant",
            MovieDescription = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            FunFact = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }
    };
    [Reactive] public MovieModel SelectedMovie { get; set; }
}