using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private View _view;
    [SerializeField] private BirdMover _birdMover;


    private void OnEnable()
    {
        _view.OnClickJumpButton += OnMoveBird;
    }
    private void OnDisable()
    {
        _view.OnClickJumpButton -= OnMoveBird;
    }

    private void OnMoveBird()
    {
        _birdMover.MoveBird();
    }




}
