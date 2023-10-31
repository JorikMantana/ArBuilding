using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _timerCount;
    public bool isTimerActive;
    public FailGame failGame;

    private void Awake()
    {
        isTimerActive = false;
    }
    
    
    
    
    
    private void FixedUpdate()
    {
        if(isTimerActive == true)
        {
            _timerCount = _timerCount + 1 * Time.deltaTime;
        }
    }

    private void Update()
    {
        if(_timerCount >= 20)
        {
            failGame.FailingGame();
        }
    }
}
