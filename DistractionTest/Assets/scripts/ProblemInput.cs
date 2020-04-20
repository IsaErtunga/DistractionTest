using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

// Gets input and checks if its correct move to next problem and when done in a Scene move to next Scene
public class ProblemInput : MonoBehaviour
{
    // The input from the user
    public string answer;

    // Index for current Problem
    static public int currentProblem = 0;
    static public int amountOfProblems = 3;
    static public int currentScene = 0;
    static public int amountOfScenes = 3;

    // Correct Answers for problems syntax -> correctAnswers[ currentScene, currentProblem ]

    public static float[,] times = new float[3, 3];

    public int[,] correctAnswers = new int[,] {
             { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }
    };

    // References to objects in InputUI
    public InputField inputField;
    public GameObject input;
    public GameObject displayAnswer;

    public static void addTime(float time)
    {
        times[currentScene, currentProblem] = time;
    }

    void Update()
    {
        // Sets focus on inputField
        inputField.ActivateInputField();

        // Get input and check input when "Enter" key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetInput();
            CheckAnswer();
            inputField.text = "";
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
        if (int.Parse(answer) == correctAnswers[currentScene, currentProblem])
        {
            //TimerScript.StopTimer();
            mailSetup.gameFinished();
            //doorlogic
            if (currentProblem == 0)
            {
                DoorScript1.doorLocked = false;
            }
            if (currentProblem == 1)
            {
                DoorScript2.doorLocked = false;
            }

            Debug.Log(answer);
            displayAnswer.GetComponent<Text>().text = "You answered : " + answer + " right!";

            // Move to next problem
            if (currentProblem < amountOfProblems-1)
            {
                // Increment problem index, stay on the same scene
                currentProblem++;
                Debug.Log("Correct answers is: " + correctAnswers[currentScene, currentProblem]);
            }

            // Move to next Scene
            else if (currentScene < amountOfScenes-1)
            {
                // Here timer for scene should stop
                Debug.Log("You did it your time was: ");
                currentProblem = 0;

                // Move to next scene, Scene must have name "ProblemSceneX" X being the number of the room
                currentScene++;
                SceneManager.LoadScene("ProblemScene" + currentScene.ToString());
                Debug.Log("Current scene: " + currentScene);
            }

            // Game end
            else
            {
                // Display times, move to game end Scene
                Debug.Log("You win your total time was ...");
            }
        }
    }
}