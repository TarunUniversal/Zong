using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _player;

    private Vector3 _sphereInitialPos;
    private Vector3 _playerInitialPos;
    private Quaternion _playerInitialRot;
    void Start()
    {
        _sphereInitialPos = _sphere.transform.position;
        _playerInitialPos = _player.transform.position;
        _playerInitialRot = _player.transform.rotation;
    }
    void OnTriggerEnter(Collider other) {
        if(other.name == "Sphere")
        {
           DoFunc();
        }
    }

    private void DoFunc()
    {
        StartCoroutine(DoFuncCR());
    }

    private IEnumerator DoFuncCR()
    {
        yield return new WaitForSeconds(3f);
        _sphere.transform.position = _sphereInitialPos;
        _player.transform.position = _playerInitialPos;
        _player.transform.rotation = _playerInitialRot;
    }
}
