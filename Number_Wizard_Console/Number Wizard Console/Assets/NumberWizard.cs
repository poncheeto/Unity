using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log($"The highest number you can pick is {max}");
        Debug.Log($"The lowest number you can pick is {min}");
        Debug.Log("Tell me if your number is higher or lower than my 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct ");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit Enter");
        }


    }
}
