using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 100f;
    public float walkForce = 30f;
    public float maxWalkSpeed = 2f;

    public Sprite[] walkSprites;
    public Sprite jumpSprite;

    public float animationPeriod = 0.1f;
    float time = 0f;
    int idx = 0;
    Animator animator;

    SpriteRenderer sr;
    Rigidbody2D rb;

    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
            rb.AddForce(transform.right * walkForce);
        }
        if(rb.linearVelocityX < maxWalkSpeed)
        {
            //rb.AddForce(transform.right * walkForce);

        }

        time += Time.deltaTime;
        if (rb.linearVelocityY != 0)
        {
            animator.SetBool("isJump", true);
        }
        if (time > animationPeriod)
        {
            animator.SetBool("isJump", false);

        }

        //time += Time.deltaTime;
        //if(rb.linearVelocityY != 0)
        //{
        //    sr.sprite = jumpSprite;
        //}
        //if (time > animationPeriod)
        //{
        //    time = 0f;
        //    sr.sprite = walkSprites[idx];
        //    idx++;
        //    if(idx == walkSprites.Length)
        //    {
        //        idx=0;
        //    }
        //}

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("goal");
    }
}
