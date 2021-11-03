using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float movementSpeed = 2f;

    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 movement = new Vector3();

        if (Input.GetKey(KeyCode.RightArrow))
            movement += new Vector3(1, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            movement += new Vector3(-1, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            movement += new Vector3(0, 1);
        if (Input.GetKey(KeyCode.DownArrow))
            movement += new Vector3(0, -1);

        transform.position += movement * movementSpeed * Time.deltaTime;
        anim.SetInteger("HorzSpeed", (int)movement.x);
        anim.SetInteger("VertSpeed", (int)movement.y);
    }
}