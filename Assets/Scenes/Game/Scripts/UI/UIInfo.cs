using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInfo : MonoBehaviour
{
    [SerializeField] private Image HPbar;
    [SerializeField] private Text ScoreText;
    public BotStatus Status;
    private float _startHp;
    private int _currentScore;
    

    private void Start()
    {
        _startHp = Status.Health;
        _currentScore = Status.Score;
    }

    public void UpdateHp()
    {
        float filling = Status.Health / _startHp;
        HPbar.fillAmount = filling;
    }
    public void UpdateScore()
    {
        if (_currentScore != Status.Score)
        {
            _currentScore = Status.Score;
            ScoreText.text = _currentScore.ToString();
        }
    }

}
