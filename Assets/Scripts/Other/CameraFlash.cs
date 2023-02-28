using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraFlash : MonoBehaviour
{
    [SerializeField] private float _flashTimelength = .2f;
    [SerializeField] private Image _flashImage;
    [SerializeField] private GameObject _imageObj;

    private bool _doCameraFlash = false;
    private bool _flashing = false;
    private float _startTime;

   private void Start()
    {
        _imageObj.SetActive(true);
           Color col = _flashImage.color;
        col.a = 0.0f;
        _flashImage.color = col;
    }

   private void Update()
    {
        if (_doCameraFlash && !_flashing)
        {
            CameraFlashStart();
        }
        else
        {
            _doCameraFlash = false;
        }
    }


    public void CameraFlashStart()
    {
        _flashImage.enabled = true;
        // initial color
        Color col = _flashImage.color;

        // start time to fade over time
        _startTime = Time.time;

        // so we can flash again
        _doCameraFlash = false;

        // start it as alpha = 1.0 (opaque)
        col.a = 1.0f;

        // flash image start color
        _flashImage.color = col;

        // flag we are flashing so user can't do 2 of them
        _flashing = true;

        StartCoroutine(FlashCoroutine());
    }

  private IEnumerator FlashCoroutine()
    {
        bool done = false;

        while (!done)
        {
            float perc;
            Color col = _flashImage.color;

            perc = Time.time - _startTime;
            perc = perc / _flashTimelength;

            if (perc > 1.0f)
            {
                perc = 1.0f;
                done = true;
            }

            col.a = Mathf.Lerp(1.0f, 0.0f, perc);
            _flashImage.color = col;
            _flashing = true;

            yield return null;
        }

        _flashing = false;
        _flashImage.enabled = false;
        yield break;
    }

}