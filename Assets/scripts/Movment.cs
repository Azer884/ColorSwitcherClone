using UnityEngine;

public class Movment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jump = 15f;
    private int ClicksCounter = 0;
    public Animator IsPressingTheButton ;
    public GameObject PressToStart ;

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
            
        }
          
    }

}
