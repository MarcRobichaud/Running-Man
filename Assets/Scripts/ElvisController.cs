using UnityEngine;

public class ElvisController : MonoBehaviour
{
    public float speed = 0;
    public float acceleration = 1f;
    public float maxSpeed = 2f;
    public bool isCrouching;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && speed < maxSpeed)
        {
            speed += acceleration * Time.deltaTime;
        }
        else if (speed > 0)
        {
            speed -= acceleration * Time.deltaTime;
        }

        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
        else if (speed < 0)
        {
            speed = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("IsJumping");
        }

        anim.SetFloat("Speed", speed / maxSpeed);
        anim.SetBool("IsCrouching", Input.GetKey(KeyCode.DownArrow));
    }
}