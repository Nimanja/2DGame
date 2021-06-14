using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        Move();
        DestroyAfter();
    }

    private void Move()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void DestroyAfter()
    {
        Destroy(this.gameObject, 30f);
    }

    //private void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if(collisionInfo.collider.tag == "obstacle")
    //    {
    //        FindObjectOfType<GameManager>().GameOver();
    //        FindObjectOfType<Player>().enabled = false;
    //    }
    //}


}
