using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;
    public List<Score> scores;

     public ScoreData ()
    {
        scores = new List<Score>();
    }
   
   void Awake ()
    {
        sd = new ScoreData();
    }

    public IEnumerable<Score> GetHighScores ()
    {
        return sd.Scores.OrderByDescending(x => x.score);
        
    }

    public void AddScore (Score score)
    {
        sd.Scores.Add(score);
    }
}
