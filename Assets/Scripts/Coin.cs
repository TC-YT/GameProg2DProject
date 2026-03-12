using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;

            if(player.coins == 5)
            {
                player.extraJumpValue++;
                player.coins = 0;
            }

            Destroy(gameObject);
        }
    }
}
