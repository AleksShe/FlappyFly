using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : BaseObject
{
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _startGamePanel;
    [SerializeField] private GameObject _endGamePanel;
    public override void StartObject()
    {
       _gamePanel.SetActive(true);
        _startGamePanel.SetActive(false);
    }
    public override void StopObject()
    {
        _gamePanel.SetActive(false);
        _endGamePanel.SetActive(true);
    }

}
