
using UnityEngine;

public class PlayerHitSound : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
