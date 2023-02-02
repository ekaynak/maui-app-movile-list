namespace MAUI_APP_1.Models;
public class Movie
{
    public string Name { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public static List<Movie> PopulateMovies()
    {
        var list = new List<Movie>();
        list.Add(new Movie
        {
            Name = "Fight Club",
            Year = 1999,
            Description = "Fight Club is a 1999 American film directed by David Fincher and starring Brad Pitt, Edward Norton, and Helena Bonham Carter. It is based on the 1996 novel of the same name by Chuck Palahniuk. Norton plays the unnamed narrator, who is discontented with his white-collar job. He forms a \"fight club\" with soap salesman Tyler Durden (Pitt), and becomes embroiled in a relationship with a mysterious[5][6] woman, Marla Singer (Bonham Carter).",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg"
        });

        list.Add(new Movie
        {
            Name = "The Matrix",
            Year = 1999,
            Description = "The Matrix is a 1999 science fiction action film[5][6] written and directed by the Wachowskis.[a] It is the first installment in the Matrix film series, starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and depicts a dystopian future in which humanity is unknowingly trapped inside the Matrix, a simulated reality that intelligent machines have created to distract humans while using their bodies as an energy source.[7] When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he joins a rebellion against the machines along with other people who have been freed from the Matrix.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Matrix_Poster.jpg/220px-The_Matrix_Poster.jpg"
        });

        list.Add(new Movie
        {
            Name = "City of Angels",
            Year = 1998,
            Description = "City of Angels is a 1998 American romantic fantasy film directed by Brad Silberling and starring Nicolas Cage and Meg Ryan. Set in Los Angeles, California, the film is a loose remake of Wim Wenders' 1987 film Wings of Desire (Der Himmel über Berlin), which was set in Berlin. As with the original, City of Angels tells the story of an angel (Cage) who falls in love with a mortal woman (Ryan), and wishes to become human in order to be with her. With the guidance of a man (Dennis Franz) who has already made the transition from immortality, the angel falls and discovers the human experience.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e1/City_Of_Angels.jpg"
        });

        list.Add(new Movie
        {
            Name = "The Jackal",
            Year = 1997,
            Description = "The Jackal is a 1997 American action thriller film directed by Michael Caton-Jones, and starring Bruce Willis, Richard Gere, and Sidney Poitier in his final film role. The film involves the hunt for a paid assassin. It is a loose remake of the 1973 film The Day of the Jackal, which starred Edward Fox, and was based on the 1971 novel of the same name by Frederick Forsyth. Although the film earned mostly negative reviews from critics, it was a commercial success and grossed $159.3 million worldwide against a $60 million budget.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/ca/Jackal_film.jpg/220px-Jackal_film.jpg"
        });

        list.Add(new Movie
        {
            Name = "The Lord of the Rings: The Fellowship of the Ring",
            Year = 2001,
            Description = "The Lord of the Rings: The Fellowship of the Ring is a 2001 epic fantasy adventure film directed by Peter Jackson from a screenplay by Fran Walsh, Philippa Boyens, and Jackson, based on 1954's The Fellowship of the Ring, the first volume of the novel The Lord of the Rings by J. R. R. Tolkien. The film is the first installment in The Lord of the Rings trilogy. It features an ensemble cast including Elijah Wood, Ian McKellen, Liv Tyler, Viggo Mortensen, Sean Astin, Cate Blanchett, John Rhys-Davies, Billy Boyd, Dominic Monaghan, Orlando Bloom, Christopher Lee, Hugo Weaving, Sean Bean, Ian Holm, and Andy Serkis.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg"
        });

        list.Add(new Movie
        {
            Name = "You've Got Mail",
            Year = 1998,
            Description = "You've Got Mail is a 1998 American romantic comedy film directed by Nora Ephron and starring Tom Hanks and Meg Ryan. Inspired by the 1937 Hungarian play Parfumerie by Miklós László (which had earlier been adapted in 1940 as The Shop Around the Corner and in 1949 as In the Good Old Summertime),[3] it was co-written by Nora and Delia Ephron. It tells the story of two people in an online romance who are unaware they are also business rivals. It marked the third pairing of Hanks and Ryan, who previously appeared together in Joe Versus the Volcano (1990) and Sleepless in Seattle (1993), the latter directed by Ephron. The film takes its name from the greeting AOL users receive when they get new e-mail.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/e/ee/You%27ve_Got_Mail.jpg/220px-You%27ve_Got_Mail.jpg"
        });

        list.Add(new Movie
        {
            Name = "The Last Samurai",
            Year = 2003,
            Description = "The Last Samurai is a 2003 epic period action drama film directed and co-produced by Edward Zwick, who also co-wrote the screenplay with John Logan and Marshall Herskovitz from a story devised by Logan. The film stars Ken Watanabe in the title role, with Tom Cruise, who also co-produced, as a soldier-turned-samurai who befriends him, and Timothy Spall, Billy Connolly, Tony Goldwyn, Hiroyuki Sanada, Koyuki, and Shin Koyamada in supporting roles.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c6/The_Last_Samurai.jpg/220px-The_Last_Samurai.jpg"
        });

        list.Add(new Movie
        {
            Name = "Pirates of the Caribbean: The Curse of the Black Pearl",
            Year = 2003,
            Description = "Pirates of the Caribbean: The Curse of the Black Pearl is a 2003 American supernatural swashbuckler film directed by Gore Verbinski and the first film in the Pirates of the Caribbean film series. Produced by Walt Disney Pictures and Jerry Bruckheimer, the film is based on Walt Disney's Pirates of the Caribbean attraction at Disney theme parks.[3] The story follows pirate Jack Sparrow (Johnny Depp) and blacksmith Will Turner (Orlando Bloom) as they rescue the kidnapped Elizabeth Swann (Keira Knightley) from the cursed crew of the Black Pearl, captained by Hector Barbossa (Geoffrey Rush), who become undead skeletons in moonlight.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/8/89/Pirates_of_the_Caribbean_-_The_Curse_of_the_Black_Pearl.png/220px-Pirates_of_the_Caribbean_-_The_Curse_of_the_Black_Pearl.png"
        });

        list.Add(new Movie
        {
            Name = "Men in Black",
            Year = 1997,
            Description = "Men in Black (stylized as MIB: Men in Black) is a 1997 American science fiction action comedy film[2] based on the Marvel Comics series of a similar name. The film was directed by Barry Sonnenfeld, written by Ed Solomon, and is the first installment in the Men in Black franchise. It stars Tommy Lee Jones, Will Smith, Linda Fiorentino, Vincent D'Onofrio, and Rip Torn. In the film, Kevin Brown / Agent K (Jones) and James Darrell Edwards III / Agent J (Smith) investigate a series of seemingly unrelated criminal incidents related to the extraterrestrial lifeforms which live in secret on Earth.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fb/Men_in_Black_Poster.jpg"
        });

        return list;
    }
}