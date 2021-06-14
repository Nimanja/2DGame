
using UnityEngine;

public class coinValue : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject soundManger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            scoreText.GetComponent<scoer>().coinValue = scoreText.GetComponent<scoer>().coinValue + 100;
            soundManger.GetComponent<coinSound>().PlayCoinSound();
            Destroy(gameObject);
        }
    }
}
