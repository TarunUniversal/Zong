using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    [SerializeField] private GameObject _messageUI;
    [SerializeField] private GameObject _particleEffect;

    [SerializeField] private AudioSource _dropAudio, _particleAudio;

    void OnTriggerEnter(Collider other) {
        if(other.name == "Sphere")
        {
            _messageUI.SetActive(true);
            _particleEffect.SetActive(true);
            _dropAudio.Play();
            _particleAudio.Play();
        }
    }

    void OnTriggerExit(Collider other) {
        if(other.name == "Sphere")
        {
            _messageUI.SetActive(false);
            _particleEffect.SetActive(false);
            _dropAudio.Stop();
            _particleAudio.Stop();
        }
    }
}
