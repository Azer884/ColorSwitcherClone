using UnityEngine;
using UnityEngine.UI;

public class InputDeviceDetector : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown && !CheckForAnyMouseInput() && !CheckForXboxControllerInput())
        {
            Debug.Log("Keyboard Input Detected");
        }

        if (CheckForAnyMouseInput())
        {
            Debug.Log("Mouse Input Detected");
        }

        if (CheckForXboxControllerInput())
        {
            Debug.Log("Controller Input Detected");
        }
    }

    private bool CheckForXboxControllerInput()
    {
        bool aButtonPressed = Input.GetKey(KeyCode.JoystickButton0);  // A
        bool bButtonPressed = Input.GetKey(KeyCode.JoystickButton1);  // B
        bool xButtonPressed = Input.GetKey(KeyCode.JoystickButton2);  // X
        bool yButtonPressed = Input.GetKey(KeyCode.JoystickButton3);  // Y

        bool leftBumperPressed = Input.GetKey(KeyCode.JoystickButton4);   // Left Bumper
        bool rightBumperPressed = Input.GetKey(KeyCode.JoystickButton5);  // Right Bumper

        bool backButtonPressed = Input.GetKey(KeyCode.JoystickButton6);  // Back
        bool startButtonPressed = Input.GetKey(KeyCode.JoystickButton7);  // Start

        bool leftStickButtonPressed = Input.GetKey(KeyCode.JoystickButton8);   // Left Stick Button
        bool rightStickButtonPressed = Input.GetKey(KeyCode.JoystickButton9);  // Right Stick Button

        float leftStickX = Input.GetAxis("Horizontal");
        float leftStickY = Input.GetAxis("Vertical");

        float rightStickX = Input.GetAxis("RightStickHorizontal");
        float rightStickY = Input.GetAxis("RightStickVertical");

        float leftTrigger = Input.GetAxis("Xbox_LeftTrigger");
        float rightTrigger = Input.GetAxis("Xbox_RightTrigger");

        if (aButtonPressed || bButtonPressed || xButtonPressed || yButtonPressed ||
            leftBumperPressed || rightBumperPressed ||
            backButtonPressed || startButtonPressed ||
            leftStickButtonPressed || rightStickButtonPressed ||
            Mathf.Abs(leftStickX) > 0.1f || Mathf.Abs(leftStickY) > 0.1f ||
            Mathf.Abs(rightStickX) > 0.1f || Mathf.Abs(rightStickY) > 0.1f ||
            Mathf.Abs(leftTrigger) > 0.1f || Mathf.Abs(rightTrigger) > 0.1f)
        {
            return true;
        }

        return false;
    }
    
    private bool CheckForAnyMouseInput()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
        {
            return true;
        }

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        if (Mathf.Abs(mouseX) > 0.01f || Mathf.Abs(mouseY) > 0.01f)
        {
            return true;
        }

        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        if (Mathf.Abs(scrollWheel) > 0.01f)
        {
            return true;
        }

        return false;
    }
}