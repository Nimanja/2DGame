
using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            FindObjectOfType<GameManager>().LevelComplete();
            PlayerPrefs.SetFloat("ScoreInLevel", FindObjectOfType<scoer>().scoreInLevel); 
        }
    }

}
