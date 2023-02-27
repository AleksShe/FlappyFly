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

    [SerializeField] private Button _buttonJump;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Text _scoreText;

    private void Start()
    {
        _buttonJump.onClick.AddListener(OnClickJumpButton);
        _startButton.onClick.AddListener(OnClickStartButton);
        _restartButton.onClick.AddListener(OnClickRestartButton);
    }

    public void SetScoreText(string score)
    {
        _scoreText.text = score;
    }
}
