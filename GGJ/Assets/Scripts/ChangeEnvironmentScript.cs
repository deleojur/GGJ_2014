﻿using UnityEngine;
using System.Collections;
using System;

internal enum CurrentEnvironment
{ 
    Blue,
    Red,
    Green,
    Yellow
};

public class ChangeEnvironmentScript : MonoBehaviour
{
    private CurrentEnvironment _currentEnvironment;
    private CurrentEnvironment _previousEnviroment;
    public GameObject go_platformList;
	// Use this for initialization
    IEnumerator Start( )
    {
        _previousEnviroment = CurrentEnvironment.Yellow;
        _currentEnvironment = CurrentEnvironment.Blue;
        MoveDown();
        ChangeEnvironment();
        
        while ( true )
        {
            InputHandling();
            yield return null;
        }
    }

    private void InputHandling()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ++_currentEnvironment;
            _currentEnvironment = (CurrentEnvironment)((int)(_currentEnvironment) % 4);
            print("current env: " + _currentEnvironment);
        }
        if (Input.GetKeyDown("joystick button 0"))
        {
            _currentEnvironment = CurrentEnvironment.Green;
        } if (Input.GetKeyDown("joystick button 1"))
        {
            _currentEnvironment = CurrentEnvironment.Red;
        } if (Input.GetKeyDown("joystick button 2"))
        {
            _currentEnvironment = CurrentEnvironment.Blue;
        } if (Input.GetKeyDown("joystick button 3"))
        {
            _currentEnvironment = CurrentEnvironment.Yellow;
        }
        if (_currentEnvironment != _previousEnviroment)
        {
            ChangeEnvironment();
        }
    }  
    private void ChangeEnvironment()
    {
        foreach(Transform t in go_platformList.transform){
            //checks the current enviroment. If the colour matches the current colour it updates every platform with the same color
            if (_currentEnvironment == CurrentEnvironment.Blue && t.name.StartsWith("Blue"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldOut();
            } else if (_currentEnvironment == CurrentEnvironment.Green && t.name.StartsWith("Green"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldOut();
            } else if (_currentEnvironment == CurrentEnvironment.Red && t.name.StartsWith("Red"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldOut();
            } else if (_currentEnvironment == CurrentEnvironment.Yellow && t.name.StartsWith("Yellow"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldOut();
            }

            //checks the previous enviroment. If the colour matches the current colour it updates every platform with the same color
            if (_previousEnviroment == CurrentEnvironment.Blue && t.name.StartsWith("Blue"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldIn();
            }
            else if (_previousEnviroment == CurrentEnvironment.Green && t.name.StartsWith("Green"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldIn();
            }
            else if (_previousEnviroment == CurrentEnvironment.Red && t.name.StartsWith("Red"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldIn();
            }
            else if (_previousEnviroment == CurrentEnvironment.Yellow && t.name.StartsWith("Yellow"))
            {
                t.GetChild(0).GetComponent<PlatformHandler>().FoldIn();
            }
        }
        _previousEnviroment = _currentEnvironment;
    }

    private void MoveDown()
    {
        foreach (Transform t in go_platformList.transform)
        {
             t.GetChild(0).GetComponent<PlatformHandler>().FoldIn();
        }
    }

}