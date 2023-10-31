using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorText : MonoBehaviour
{
    [SerializeField] private GameObject _errorText;

    public void ActivateErrorText()
    {
        _errorText.SetActive(true);
        Invoke("DeactivateErrorText", 2);
    }

    public void DeactivateErrorText()
    {
        _errorText.SetActive(false);
    }
}
