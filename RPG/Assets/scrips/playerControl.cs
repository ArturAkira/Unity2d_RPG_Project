using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed, jumpForce, alturaCamera;
    private bool jump, isGrounded, restartPlayer, win;
    private GameObject camerapos, inicialpos;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        camerapos = GameObject.Find("Main Camera");
        inicialpos = GameObject.Find("inicialPos");
        win = false;
    }

    
    void Update()
    {
        movePlayer = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
        player.linearVelocity = new Vector2(movePlayer * speed, player.linearVelocity.y);
        camerapos.transform.position = new Vector3(camerapos.transform.position.x, player.transform.position.y+alturaCamera, camerapos.transform.position.z);
        print(win);
        if (jump == true && isGrounded == true)
        {
            player.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
        }
        restart();
        wingame();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.layer == 6)
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("armadilha") == true);
        {
            restartPlayer = true;
        }
        if (col.CompareTag("win") == true)
        {
            win = true;
        }
    }

    private void restart()
    {
        if(restartPlayer == true)
        {
            player.transform.position = new Vector2(inicialpos.transform.position.x, inicialpos.transform.position.y);
            restartPlayer = false;
        }
    }

    private void wingame()
    {
        if(win == true)
        {
            player.linearVelocity = new Vector2(0, player.linearVelocity.y);
        }
    }
}
