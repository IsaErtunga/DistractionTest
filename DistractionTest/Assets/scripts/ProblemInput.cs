using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProblemInput : MonoBehaviour
{
    // The input from the user
    public string answer;

    // Index for current Problem
    public int currentProblem = 0;
    public int amountOfProblems = 3;

    // Correct Answers for problems 1 - 3,  Should be overwritten by the current scene in future
    public int[] correctAnswers = new int[] {
            42, 7, 69
        };
    
    // References to objects in InputUI
    public InputField inputField;
    public GameObject input;
    public GameObject displayAnswer;


    void Update()
    {
        // Sets focus on inputField
        inputField.ActivateInputField();

        

        // Get input and check input when "Enter" key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetInput();
            CheckAnswer();
            Debug.Log("Correct answers is: " + correctAnswers[currentProblem]);
        }
    }
    // Update is called once per frame
    public void GetInput()
    {
        // Gets answer from inputField
        answer = input.GetComponent<Text>().text;

        // Displays answer on HUD
        displayAnswer.GetComponent<Text>().text = "You answered : " + answer; 
    }

    public void CheckAnswer()
    {
        // Checks if answer is correct
        if (int.Parse(answer) == correctAnswers[currentProblem])
        {
            Debug.Log(answer);
            displayAnswer.GetComponent<Text>().text = "You answered : " + answer + " right!";
            if (currentProblem < amountOfProblems-1)
            {
                currentProblem++;
            }
            else
            {
                // Stop timer
                // Move to next scene
                Debug.Log("You did it your time was: ");
            }
        }
    }
}