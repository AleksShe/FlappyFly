using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _hit, _point, _wing;


    public void PlayHitSound()
    {
        _audioSource.PlayOneShot(_hit);
    }
    public void PlayPointSound()
    {
        _audioSource.PlayOneShot(_point);
    }
    public void PlayWingSound()
    {
        _audioSource.PlayOneShot(_wing);
    }
}
