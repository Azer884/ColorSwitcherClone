using UnityEngine;

public class ColorSwitcherBall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerColorSwitcher playerColorSwitcher = collision.gameObject.GetComponent<PlayerColorSwitcher>();
            if (playerColorSwitcher != null)
            {
                playerColorSwitcher.SwitchColor();
            }
            Destroy(gameObject);
        }
    }
}
