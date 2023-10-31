using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailGame : MonoBehaviour
{
    [SerializeField] private GameObject FailPanel;
    [SerializeField] private GameObject MainPanel;

    private void Awake()
    {
        FailPanel.SetActive(false);
    }
    public void FailingGame()
    {
        MainPanel.SetActive(false);
        FailPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
