using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    public UnityAction OnClickJumpButton;

    [SerializeField] private Button _buttonJump;
    private void Start()
    {
        _buttonJump.onClick.AddListener(OnClickJumpButton);
    }
}
