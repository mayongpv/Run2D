using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rigid;
    public Vector2 jumpForce = new Vector2(0, 1000);
    public float gravityScale = 7;
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponentInChildren<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = gravityScale;
        animator.Play("Run");

    }

    public float speed = 20;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(jumpForce);
        }
    }
}
