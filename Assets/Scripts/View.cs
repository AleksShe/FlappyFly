using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public UnityAction OnClickJumpButton;
    public UnityAction OnClickStartButton;
    public UnityAction OnClickRestartButton;
    public UnityAction OnClickLeaderBoardButton;

    [SerializeField] private Button _buttonJump;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _leaderBoardButton;
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _leaderText;

    private void Start()
    {
        _buttonJump.onClick.AddListener(OnClickJumpButton);
        _startButton.onClick.AddListener(OnClickStartButton);
        _restartButton.onClick.AddListener(OnClickRestartButton);
        _leaderBoardButton.onClick.AddListener(OnClickLeaderBoardButton);
    }

    public void SetScoreText(string score)
    {
        _scoreText.text = score;
    }
    public void ShowLeaderBoard(string text)
    {
        _leaderText.text = text;
    }
}
