using UnityEngine;

public class PlayerColorSwitcher : MonoBehaviour
{
    public Material[] possibleColors;
    private Material currentColor;
    public GameObject particle1 , particle2;
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
                particle1.transform.position = transform.position ;
                particle2.transform.position = transform.position ;
                particle1.SetActive(true);
                particle2.SetActive(true);
            }
            
        }
    }
}
