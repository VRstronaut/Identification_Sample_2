using UnityEngine;
using System.Collections;

public class GoBackScript : MonoBehaviour
{
    private KeyCode backKey = KeyCode.Escape;
    private KeyCode backButton = KeyCode.Joystick1Button1;

    private void Update()
    {
        if (Input.GetKeyDown(backKey) || Input.GetKeyDown(backButton))
        {
            Application.LoadLevel("StarterScene");
        }
    }
}