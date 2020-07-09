using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> _scores;
    public HighScores(List<int> list)
    {
        _scores = new List<int>(list);
    }

    public List<int> Scores()
    {
        return _scores;
    }

    public int Latest()
    {
        return _scores[_scores.Count -1];
    }

    public int PersonalBest()
    {
        var bestScore = int.MinValue;
        foreach (int score in _scores)
        {
            bestScore = Math.Max(bestScore, score);
        }
        return bestScore;
    }

    public List<int> PersonalTopThree()
    {
        List<int> sorted_scores = _scores.OrderByDescending(c => c).ToList();
        if (_scores.Count < 3)
        {
            return sorted_scores;
        } else 
        {
        return sorted_scores.GetRange(0,3);
        }
    }
}