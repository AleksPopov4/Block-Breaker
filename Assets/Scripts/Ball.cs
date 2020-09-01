using UnityEngine;

public class Ball : MonoBehaviour
{
    //config params
#pragma warning disable 649
    [SerializeField] Paddle paddle1;
#pragma warning restore 649
    [SerializeField] private float xPush = 2f;
    [SerializeField] private float yPush = 15f;
#pragma warning disable 649
    [SerializeField] private AudioClip[] ballSounds;
#pragma warning restore 649


    //state
    Vector2 paddleToBallVector;
    private bool hasStarted;

    //Cached component references
    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0, ballSounds.Length)];
            myAudioSource.PlayOneShot(clip, 0.3f);
        }
    }
}
