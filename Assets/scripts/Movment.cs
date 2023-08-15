using UnityEngine;

public class Movment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jump = 15f;
    private int ClicksCounter = 0;
    public Animator IsPressingTheButton ;
    public GameObject PressToStart ;
    public AudioSource src ;
    public AudioClip sfx1 ;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            ClicksCounter += 1;
            if (ClicksCounter == 1)
            {
                rb.velocity = Vector2.up * (Jump+5) ;
                IsPressingTheButton.Play("Pressing");
                Destroy(PressToStart, 5); 
            }
            else
            {
                rb.velocity = Vector2.up * Jump;
            }
            src.clip = sfx1;
            src.pitch = 0.7f ;
            src.Play();
            
        }
          
    }

}
