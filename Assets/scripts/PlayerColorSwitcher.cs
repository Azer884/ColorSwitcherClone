using UnityEngine;

public class PlayerColorSwitcher : MonoBehaviour
{
    public Material[] possibleColors;
    public Material currentColor;

    void Start()
    {
        currentColor = GetComponent<Renderer>().material;
        SwitchColor();
    }

    public void SwitchColor()
    {
        Material newColor;
        do
        {
            newColor = possibleColors[Random.Range(0, possibleColors.Length)];
        } while (newColor == currentColor);

        currentColor = newColor;
        GetComponent<Renderer>().material = currentColor;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != currentColor.name )
        {
            if (col.tag != "Changer")
            {
                Destroy(gameObject);
            }
            
        }
    }
}
