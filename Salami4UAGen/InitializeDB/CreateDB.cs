
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Salami4UAGenNHibernate.EN.Salami4UA;
using Salami4UAGenNHibernate.CEN.Salami4UA;
using Salami4UAGenNHibernate.CAD.Salami4UA;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // ANIMALES DOMESTICOS

                PetsCEN pet = new PetsCEN ();

                pet.New_ ("Dog");
                pet.New_ ("Cat");
                pet.New_ ("Bird");
                pet.New_ ("Fish");
                pet.New_ ("Horse");
                pet.New_ ("Rabbit");
                pet.New_ ("Exotic animals");
                pet.New_ ("Hamster");
                pet.New_ ("I have not animals");
                pet.New_ ("Other");

                // ALTURA

                HeightCEN height = new HeightCEN ();

                height.New_ (140);
                height.New_ (145);
                height.New_ (150);
                height.New_ (155);
                height.New_ (160);
                height.New_ (165);
                height.New_ (170);
                height.New_ (175);
                height.New_ (180);
                height.New_ (185);
                height.New_ (190);
                height.New_ (195);
                height.New_ (200);
                height.New_ (205);
                height.New_ (210);
                height.New_ (215);
                height.New_ (220);

                // Hobbies

                HobbiesCEN hoobies = new HobbiesCEN ();

                hoobies.New_ ("Travel");
                hoobies.New_ ("Practice sports");
                hoobies.New_ ("To cook");
                hoobies.New_ ("Animals");
                hoobies.New_ ("Rides");
                hoobies.New_ ("Computers / Internet");
                hoobies.New_ ("Cars / Motorbikes");
                hoobies.New_ ("Dance");
                hoobies.New_ ("Video Games");
                hoobies.New_ ("Writing");
                hoobies.New_ ("Volunteering");
                hoobies.New_ ("Music");
                hoobies.New_ ("Reading");
                hoobies.New_ ("Photography");
                hoobies.New_ ("Theater");
                hoobies.New_ ("Exhibitions");
                hoobies.New_ ("Television");
                hoobies.New_ ("Painting / Drawing");
                hoobies.New_ ("Decoration");
                hoobies.New_ ("Gardening");
                hoobies.New_ ("Cardgames");
                hoobies.New_ ("BoardGames");

                // Sports

                SportsCEN sport = new SportsCEN ();

                sport.New_ ("Football");
                sport.New_ ("Fitness");
                sport.New_ ("Tennis");
                sport.New_ ("Basketball");
                sport.New_ ("Athletics");
                sport.New_ ("Gymnastics");
                sport.New_ ("Ski / Snowboard");
                sport.New_ ("Motorcycling");
                sport.New_ ("Martial arts");
                sport.New_ ("Volleyball");
                sport.New_ ("Sailing");
                sport.New_ ("Horse riding");
                sport.New_ ("Swimming");
                sport.New_ ("Cycling");
                sport.New_ ("Trekking");
                sport.New_ ("Motoring");
                sport.New_ ("Dance");
                sport.New_ ("Run");
                sport.New_ ("Extreme sports");
                sport.New_ ("Boxing");
                sport.New_ ("Table tennis");
                sport.New_ ("Other water sports");
                sport.New_ ("Handball");

                // Gustos Musicales

                MusicalTastesCEN musica = new MusicalTastesCEN ();

                musica.New_ ("Pop");
                musica.New_ ("Disco");
                musica.New_ ("Dance");
                musica.New_ ("Blues");
                musica.New_ ("Jazz");
                musica.New_ ("Rap");
                musica.New_ ("Country");
                musica.New_ ("Rock");
                musica.New_ ("Latin");
                musica.New_ ("Classical");
                musica.New_ ("Soul");
                musica.New_ ("Gospel");
                musica.New_ ("Hip-Hop");
                musica.New_ ("Opera");
                musica.New_ ("Tecno");
                musica.New_ ("International");
                musica.New_ ("Soundtracks");
                musica.New_ ("Traditional");

                // Nacionalidad

                NationalityCEN nacionalidad = new NationalityCEN ();

                nacionalidad.New_ ("Spanish");
                nacionalidad.New_ ("Danish");
                nacionalidad.New_ ("British");
                nacionalidad.New_ ("Estonian");
                nacionalidad.New_ ("Finnish");
                nacionalidad.New_ ("Icelandic");
                nacionalidad.New_ ("Irish");
                nacionalidad.New_ ("Latvian");
                nacionalidad.New_ ("Lithuanian");
                nacionalidad.New_ ("Norwegian");
                nacionalidad.New_ ("Scottish");
                nacionalidad.New_ ("Swedish");
                nacionalidad.New_ ("Welsh");
                nacionalidad.New_ ("Austrian");
                nacionalidad.New_ ("Belgian");
                nacionalidad.New_ ("French");
                nacionalidad.New_ ("German");
                nacionalidad.New_ ("Dutch");
                nacionalidad.New_ ("Swiss");
                nacionalidad.New_ ("Albanian");
                nacionalidad.New_ ("Croatian");
                nacionalidad.New_ ("Cypriot");
                nacionalidad.New_ ("Greek");
                nacionalidad.New_ ("Italian");
                nacionalidad.New_ ("Portuguese");
                nacionalidad.New_ ("Serbian");
                nacionalidad.New_ ("Slovenian");
                nacionalidad.New_ ("Belarusian");
                nacionalidad.New_ ("Bulgarian");
                nacionalidad.New_ ("Czech");
                nacionalidad.New_ ("Huagarian");
                nacionalidad.New_ ("Polish");
                nacionalidad.New_ ("Romanian");
                nacionalidad.New_ ("Russian");
                nacionalidad.New_ ("Slovak");
                nacionalidad.New_ ("Ukrainian");
                nacionalidad.New_ ("Canadian");
                nacionalidad.New_ ("Mexican");
                nacionalidad.New_ ("American");
                nacionalidad.New_ ("Cuban");
                nacionalidad.New_ ("Guatemalan");
                nacionalidad.New_ ("Jamaican");
                nacionalidad.New_ ("Argentinian");
                nacionalidad.New_ ("Bolivian");
                nacionalidad.New_ ("Brazilian");
                nacionalidad.New_ ("Chilean");
                nacionalidad.New_ ("Colombian");
                nacionalidad.New_ ("Ecuadorian");
                nacionalidad.New_ ("Paraguayan");
                nacionalidad.New_ ("Peruvian");
                nacionalidad.New_ ("Uruguayan");
                nacionalidad.New_ ("Venezuelan");
                nacionalidad.New_ ("Georgian");
                nacionalidad.New_ ("Iranian");
                nacionalidad.New_ ("Iraqi");
                nacionalidad.New_ ("Israeli");
                nacionalidad.New_ ("Jordanian");
                nacionalidad.New_ ("Kuwaiti");
                nacionalidad.New_ ("Lebanese");
                nacionalidad.New_ ("Palestinian");
                nacionalidad.New_ ("Saudi Arabian");
                nacionalidad.New_ ("Syrian");
                nacionalidad.New_ ("Turkish");
                nacionalidad.New_ ("Yemeni");
                nacionalidad.New_ ("Afghan");
                nacionalidad.New_ ("Bangladeshi");
                nacionalidad.New_ ("Indian");
                nacionalidad.New_ ("Kazakh");
                nacionalidad.New_ ("Nepalese");
                nacionalidad.New_ ("Pakistani");
                nacionalidad.New_ ("Sri Lankan");
                nacionalidad.New_ ("Chinese");
                nacionalidad.New_ ("Japanese");
                nacionalidad.New_ ("Mongolian");
                nacionalidad.New_ ("North Korean");
                nacionalidad.New_ ("South Korean");
                nacionalidad.New_ ("Taiwanese");
                nacionalidad.New_ ("Cambodian");
                nacionalidad.New_ ("Indonesian");
                nacionalidad.New_ ("Laotian");
                nacionalidad.New_ ("Malaysian");
                nacionalidad.New_ ("Burmese");
                nacionalidad.New_ ("Filipino");
                nacionalidad.New_ ("Singaporean");
                nacionalidad.New_ ("Thai");
                nacionalidad.New_ ("Vietnamese");
                nacionalidad.New_ ("Australian");
                nacionalidad.New_ ("Fijian");
                nacionalidad.New_ ("New Zealand");
                nacionalidad.New_ ("Algerian");
                nacionalidad.New_ ("Egyptian");
                nacionalidad.New_ ("Ghanaian");
                nacionalidad.New_ ("Ivorian");
                nacionalidad.New_ ("Lybian");
                nacionalidad.New_ ("Moroccan");
                nacionalidad.New_ ("Nigeria");
                nacionalidad.New_ ("Tunisian");
                nacionalidad.New_ ("Ethiopian");
                nacionalidad.New_ ("Kenyan");
                nacionalidad.New_ ("Somali");
                nacionalidad.New_ ("Sudanese");
                nacionalidad.New_ ("Tanzanian");
                nacionalidad.New_ ("Ugandan");
                nacionalidad.New_ ("Angola");
                nacionalidad.New_ ("Botswanan");
                nacionalidad.New_ ("Congolese");
                nacionalidad.New_ ("Malagasy");
                nacionalidad.New_ ("Mozambican");
                nacionalidad.New_ ("Namibian");
                nacionalidad.New_ ("South African");
                nacionalidad.New_ ("Zambian");
                nacionalidad.New_ ("Zimbabwean");

                // G�neros de cine

                GenreFilmsCEN genre = new GenreFilmsCEN ();

                genre.New_ ("Action");
                genre.New_ ("Adventure");
                genre.New_ ("Horror");
                genre.New_ ("Documentaries");
                genre.New_ ("Police");
                genre.New_ ("Fantasia");
                genre.New_ ("Erotic");
                genre.New_ ("Animated cartoon");
                genre.New_ ("Manga");
                genre.New_ ("Comedy");
                genre.New_ ("Science fiction");
                genre.New_ ("Romantic comedy");
                genre.New_ ("Historical");
                genre.New_ ("Drama");
                genre.New_ ("Animation");
                genre.New_ ("Musical");
                genre.New_ ("Western");
                genre.New_ ("Thriller");
                genre.New_ ("Other");

                // Caracteristicas personales

                CharacteristicFeaturesCEN feature = new CharacteristicFeaturesCEN ();

                feature.New_ ("No preference");
                feature.New_ ("Attentive");
                feature.New_ ("Adventurer");
                feature.New_ ("Good-humored");
                feature.New_ ("Conciliator");
                feature.New_ ("Demanding");
                feature.New_ ("Generous");
                feature.New_ ("Inspires confidence");
                feature.New_ ("Proud");
                feature.New_ ("Reserved");
                feature.New_ ("Sociable");
                feature.New_ ("Shy");
                feature.New_ ("Quiet");
































































































                /*List<Salami4UAGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<Salami4UAGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * Salami4UAGenNHibernate.EN.Mediaplayer.UserEN userEN = new Salami4UAGenNHibernate.EN.Mediaplayer.UserEN();
                 * Salami4UAGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new Salami4UAGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * Salami4UAGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new Salami4UAGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * Salami4UAGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new Salami4UAGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * Salami4UAGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new Salami4UAGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * Salami4UAGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new Salami4UAGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * Salami4UAGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new Salami4UAGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //Salami4UAGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new Salami4UAGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}