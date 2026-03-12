using UnityEngine;

public class Silver : MonoBehaviour
{
    public AudioClip silverClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            rb.gravityScale-=0.5f;
            if (rb.gravityScale < 0.5f)
            {
                rb.gravityScale = 0.5f;
            }
            player.PlaySFX(silverClip, 0.4f);

            Destroy(gameObject);
        }
    }
}
