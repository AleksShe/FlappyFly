using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private CameraFlash _cameraFlash;
    [SerializeField] private Bird _bird;
    [SerializeField] private View _view;
    private void Awake()
    {
        _cameraFlash.CameraFlashStart();
    }

    private bool _gameOver = false;
    private int _score;



    private void OnEnable()
    {
        _bird.OnTouchPipe += OnEndGame;
        _bird.OnTouchScore += OnScoreChanged;
        _view.OnClickStartButton += OnStartGame;
        _view.OnClickRestartButton += OnRestartGame;
        _view.OnClickJumpButton += OnPlayJumpSound;

    }
    private void OnDisable()
    {
        _bird.OnTouchPipe -= OnEndGame;
        _bird.OnTouchScore -= OnScoreChanged;
        _view.OnClickStartButton -= OnStartGame;
        _view.OnClickRestartButton -= OnRestartGame;
        _view.OnClickJumpButton -= OnPlayJumpSound;
    }
    private void OnEndGame()
    {
        if(!_gameOver)
        _soundPlayer.PlayHitSound();
        _gameOver = true;
        BaseObjectsHandler.Instance.StopAllObjects();
    }
    private void OnScoreChanged()
    {
        _score++;
        _soundPlayer.PlayPointSound();
        _view.SetScoreText(_score.ToString());
    }
    private void OnStartGame()
    {
        BaseObjectsHandler.Instance.StartAllObjects();
    }

    private void OnRestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void OnPlayJumpSound()
    {
        _soundPlayer.PlayWingSound();
    }
}
