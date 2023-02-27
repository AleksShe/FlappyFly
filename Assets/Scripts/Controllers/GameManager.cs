using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private View _view;
    private int _score;



    private void OnEnable()
    {
        _bird.OnTouchPipe += OnEndGame;
        _bird.OnTouchScore += OnScoreChanged;
        _view.OnClickStartButton += OnStartGame;
        _view.OnClickRestartButton += OnRestartGame;

    }
    private void OnDisable()
    {
        _bird.OnTouchPipe -= OnEndGame;
        _bird.OnTouchScore -= OnScoreChanged;
        _view.OnClickStartButton -= OnStartGame;
        _view.OnClickRestartButton -= OnRestartGame;
    }
    private void OnEndGame()
    {
        BaseObjectsHandler.Instance.StopAllObjects();
    }
    private void OnScoreChanged()
    {
        _score++;
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


}
