using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameObjectPanel;

    public GameObject gameEnd;

    public GameObject gameRestart;

    public float jumpForce;

    public float moveSpeed;

    private Rigidbody2D _rBody;

    private void Awake()
    {
        _rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
        //GameO();

    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.position = transform.position + new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(_rBody.velocity.y) < 0.001)
        {
            _rBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.CompareTag("Obstacle"))
        {
            gameObjectPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else if (target.CompareTag("CompleteEnd"))
        {
            gameEnd.SetActive(true);
            Time.timeScale = 0;
        }
        else if (target.CompareTag("Restart"))
        {
            gameRestart.SetActive(true);
            Time.timeScale = 0;
        }
               
    }

    //private void GameO()
    //{
    //    if (_rBody.position.y < 0f)
    //    {
    //        FindObjectOfType<GameManager>().GameOver();
    //    }
    //}

}//class

