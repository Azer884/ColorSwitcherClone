using UnityEngine;
using TMPro;

public class InputDeviceDetector : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    void Start()
    {
        // Access the TextMeshProUGUI component on the GameObject
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        if (Input.anyKeyDown && !CheckForAnyMouseInput() && !CheckForXboxControllerInput())
        {
            string newText = textMeshPro.text = "Press <sprite=\"StyleSheet_Keyboard\" name=\"Space\">To Start";
            textMeshPro.text = newText;
        }

        if (CheckForAnyMouseInput())
        {
            string newText1 = textMeshPro.text = "Press <sprite=\"StyleSheet_Mouse\" name=\"Mouse_Left\">To Start";
            textMeshPro.text = newText1;
        }

        if (CheckForXboxControllerInput())
        {
            string newText2 = textMeshPro.text = "Press <sprite=\"StyleSheet_Xbox\" name=\"Xbox_A\">To Start";
            textMeshPro.text = newText2;
        }
    }

    private bool CheckForXboxControllerInput()
    {
        // Check Xbox controller buttons using KeyCode values
        bool aButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton0);
        bool bButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton1);
        bool xButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton2);
        bool yButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton3);

        bool leftBumperPressed = Input.GetKeyDown(KeyCode.JoystickButton4);
        bool rightBumperPressed = Input.GetKeyDown(KeyCode.JoystickButton5);

        bool backButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton6);
        bool startButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton7);

        bool leftStickButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton8);
        bool rightStickButtonPressed = Input.GetKeyDown(KeyCode.JoystickButton9);

        // Check Xbox controller triggers as buttons using KeyCode values
        bool leftTriggerPressed = Input.GetAxis("LeftTrigger") > 0.1f;
        bool rightTriggerPressed = Input.GetAxis("RightTrigger") > 0.1f;

        // Get Xbox controller joystick axes
        float leftStickX = Input.GetAxis("Horizontal1");
        float leftStickY = Input.GetAxis("Vertical1");
        float rightStickX = Input.GetAxis("Horizontal2");
        float rightStickY = Input.GetAxis("Vertical2");

        if (aButtonPressed || bButtonPressed || xButtonPressed || yButtonPressed ||
            leftBumperPressed || rightBumperPressed ||
            backButtonPressed || startButtonPressed ||
            leftStickButtonPressed || rightStickButtonPressed ||
            leftTriggerPressed || rightTriggerPressed ||
            Mathf.Abs(leftStickX) > 0.1f || Mathf.Abs(leftStickY) > 0.1f ||
            Mathf.Abs(rightStickX) > 0.1f || Mathf.Abs(rightStickY) > 0.1f)
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