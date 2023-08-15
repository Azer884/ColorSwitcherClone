using UnityEngine;

public class ColorSwitcherBall : MonoBehaviour
{
    public AudioSource src ;
    public AudioClip sfx ;
    private Vector3 NewPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewPos.y = 10f ;
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerColorSwitcher playerColorSwitcher = collision.gameObject.GetComponent<PlayerColorSwitcher>();
            if (playerColorSwitcher != null)
            {
                playerColorSwitcher.SwitchColor();
                src.clip = sfx ;
                src.pitch = 0.4f ;
                src.Play();
            }
            transform.position += NewPos;
        }
    }
}
