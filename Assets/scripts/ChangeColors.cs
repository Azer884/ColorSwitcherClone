using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColors : MonoBehaviour
{
    public Renderer player;
    public GameObject ColorSwitcher;
    private string TheColor = "White"; 

    void Start()
    {
        ColorChanger();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Changer")
        {
            ColorChanger();
            Destroy(ColorSwitcher);
        }
        else if (col.tag != TheColor)
        {
            Destroy(gameObject);
        }
    }
    public void ColorChanger()
    {
        int colorNum = Random.Range(1, 5);
        Debug.Log(colorNum);
        if (colorNum == 1)
        {
            if (TheColor != "Purple")
            {
                player.material.color = new Color(140f / 255f, 19f / 255f, 251f / 255f);
                TheColor = "Purple";
            }
            else
            {
                colorNum = Random.Range(2, 5);
                Debug.Log(colorNum);
            }
        }
        else if (colorNum == 2 )
        {
            if (TheColor != "Cyan")
            {
                player.material.color = new Color(53f / 255f, 226f / 255f, 242f / 255f);
                TheColor = "Cyan";
            }
            else
            {
                colorNum = Random.Range(1, 5);
                Debug.Log(colorNum);
            }
        }
        else if (colorNum == 3)
        {
            if (TheColor != "Pink")
            {
                player.material.color = new Color(255f / 255f, 0f / 255f, 128f / 255f);
                TheColor = "Pink";
            }
            else
            {
                colorNum = Random.Range(1, 5);
                Debug.Log(colorNum);
            }
        }
        else if (colorNum == 4)
        {
            if (TheColor != "Yellow")
            {
                player.material.color = new Color(246f / 255f, 223f / 255f, 14f / 255f);
                TheColor = "Yellow";
            }
            else
            {
                colorNum = Random.Range(1, 5);
                Debug.Log(colorNum);
            }
        }
    }
}