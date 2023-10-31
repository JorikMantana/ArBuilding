using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class StartGame : MonoBehaviour
{
    [FormerlySerializedAs("House")] [SerializeField] private GameObject house;
    [SerializeField] private GameObject helpText;
    [FormerlySerializedAs("MainPanel")] [SerializeField] private GameObject mainPanel;


    private void Awake()
    {
        house.SetActive(false);
        mainPanel.SetActive(false);
        helpText.SetActive(false);
        Time.timeScale = 1;
    }
    public void ActivateGame()
    {
        helpText.SetActive(true);
        Invoke("DeactivateHelpText", 2);
        Invoke("ActivateHouse", 3);
    }
    public void ActivateHouse()
    {
        house.SetActive(true);
        Invoke("DeactivateHouse", 3);
    }
    public void DeactivateHouse()
    {
        house.SetActive(false);
    }

    public void DeactivateHelpText()
    {
        helpText.SetActive(false);
    }

    private void StartingGame()
    {
        mainPanel.SetActive(true);
    }

    public void RestarGame()
    {
        SceneManager.LoadScene(0);
    }
}
