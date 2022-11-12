using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text redScoreText, yellowScoreText, greenScoreText, blueScoreText;

    [SerializeField] private int minScore, maxScore;

    [SerializeField] private MusicManager musicManager;

    private int _redScore = 900, _yellowScore = 900, _greenScore = 900, _blueScore = 900;

    private const string RedText = "Red Score : ", YellowText = "Yellow Score : ", GreenText = "Green Score : ", BlueText = "Blue Score : ";

    #region ColorsScore
    
    public int RedScore
    {
        get => _redScore;
        set
        {
            _redScore = value;

            if (_redScore > maxScore) _redScore = maxScore;
            else if (_redScore < minScore) _redScore = minScore;
            
            musicManager.LeadSongCheck(_redScore + _yellowScore + _greenScore + _blueScore);
            
            musicManager.ChangeAudio(_redScore, MusicManager.Channel.Bass);
            
            redScoreText.text = RedText + _redScore;
        }
    }
    
    public int YellowScore
    {
        get => _yellowScore;
        set
        {
            _yellowScore = value;
            
            if (_yellowScore > maxScore) _yellowScore = maxScore;
            else if (_yellowScore < minScore) _yellowScore = minScore;
            
            musicManager.LeadSongCheck(_redScore + _yellowScore + _greenScore + _blueScore);
            
            musicManager.ChangeAudio(_yellowScore, MusicManager.Channel.Drum);

            yellowScoreText.text = YellowText + _yellowScore;
        }
    }
    
    public int GreenScore
    {
        get => _greenScore;
        set
        {
            _greenScore = value;

            if (_greenScore > maxScore) _greenScore = maxScore;
            else if (_greenScore < minScore) _greenScore = minScore;
            
            musicManager.LeadSongCheck(_redScore + _yellowScore + _greenScore + _blueScore);
            
            musicManager.ChangeAudio(_greenScore, MusicManager.Channel.Guitar);
            
            greenScoreText.text = GreenText + _greenScore;
        }
    }
    
    public int BlueScore
    {
        get => _blueScore;
        set
        {
            _blueScore = value;

            if (_blueScore > maxScore) _blueScore = maxScore;
            else if (_blueScore < minScore) _blueScore = minScore;
            
            musicManager.LeadSongCheck(_redScore + _yellowScore + _greenScore + _blueScore);
            
            musicManager.ChangeAudio(_blueScore, MusicManager.Channel.Organ);
            
            blueScoreText.text = BlueText + _blueScore;
        }
    }
    
    #endregion
}