using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject HouseBlock;
    [SerializeField] private int _blockIndex;
    public Score scoreClass;
    [SerializeField] private GameObject ErrorText;
    public ErrorText errorTextClass;

    public void CheckBlockIndex()
    {
        if(_blockIndex == scoreClass.BlockIndex)
        {
            HouseBlock.SetActive(true);
            scoreClass.BlockIndex++;
        }
        else
        {
            errorTextClass.ActivateErrorText();
        }
    }
}
