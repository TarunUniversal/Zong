using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownButton : MonoBehaviour
{
    [SerializeField] private GameObject _verticalLayoutGroup;
    [SerializeField] private GameObject _dropdownItems;
    private bool _isOpen = false;
    
    public void OnDropdownButtonClick()
    {
        if(!_isOpen)
        {
            _dropdownItems.SetActive(true);
            _isOpen = !_isOpen;
        }
        else
        {
            _dropdownItems.SetActive(false);
            _isOpen = !_isOpen;
        }

        _verticalLayoutGroup.SetActive(!_verticalLayoutGroup.activeSelf);
        _verticalLayoutGroup.SetActive(!_verticalLayoutGroup.activeSelf);
    }
}
