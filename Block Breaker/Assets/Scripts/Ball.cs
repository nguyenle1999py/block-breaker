using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 12f;
    [SerializeField] AudioClip[] audioClip;
    //State
    Vector2 ballToPaddle;
    bool hasStarted = false;
    AudioSource audioSource;
    // Start is called before the first frame update'

    void Start()
    {
        ballToPaddle = transform.position - paddle.transform.position;
        hasStarted = false;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchBall();
        }
    }

    void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + ballToPaddle;
    }

    void LaunchBall()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            AudioClip rand = audioClip[UnityEngine.Random.Range(0, audioClip.Length)];

            audioSource.PlayOneShot(rand);
        }
    }
}
