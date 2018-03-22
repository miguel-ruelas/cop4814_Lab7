using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameLibrary
{
  public class GameFactory
  {
    public List<Game> games;
    XmlSerializer serial;

    public void CreateGameList()
    {
      games = new List<Game>();

      Game g = new Game("WonderTeam", 20, "Rockets", 30);
      games.Add(g);

      g = new Game("Impecables", 5, "Launchy", 0);
      games.Add(g);

      g = new Game("Keyboard Warriors", 15, "Angry Mob", 9);
      games.Add(g);

      g = new Game("Trigger Happy", 7, "Panthers", 50);
      games.Add(g);

      g = new Game("Gimpy", 5, "Noobs", 6);
      games.Add(g);

      g = new Game("Goofy", 11, "Monitors", 2);
      games.Add(g);
    }

    private string filePath = @"..\..\gameList.xml";

    public string FilePath
    {
      get { return filePath; }

    }

    public Boolean SerializeGameList()
    {
      
      try
      {

        
        serial = new XmlSerializer(games.GetType());
        StreamWriter sw = new StreamWriter(filePath);
        serial.Serialize(sw, games);
        sw.Close();

      }
      catch
      {
        return false;
      }
      return true;

    }

    public List<Game> DeserializeGameList()
    {
      games = new List<Game>();
      try
      {
        StreamReader sr = new StreamReader(filePath);
        serial = new XmlSerializer(games.GetType());
        games = (List<Game>)serial.Deserialize(sr);
        sr.Close();
      }
      catch
      {
        return GetGameList();
      }

      

      return GetGameList();
    }



    public List<Game> GetGameList()
    {
      return games;
    }


  }

}
