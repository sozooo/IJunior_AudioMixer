using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioChannel;

    private float _maxVolume = 0;
    private float _minVolume = -80;

    public void MuteChannel(bool mute)
    {
        _audioChannel.audioMixer.SetFloat(_audioChannel.name, mute ? _minVolume : _maxVolume);
    }

    public void ChangeVolume(float volume)
    {
        _audioChannel.audioMixer.SetFloat(_audioChannel.name, Mathf.Log10(volume) * 20);
    }
}
