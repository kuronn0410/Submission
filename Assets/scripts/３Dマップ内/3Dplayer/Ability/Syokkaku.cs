using UnityEngine;

public class Syokkaku : MonoBehaviour
{
    [Header("ジャンプ")]
    [SerializeField] float jumpForce = 5f;
    private bool isGrounded = true;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GravityInversion.isActive = false;
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("InversionGround"))
        {
            isGrounded = true;
        }
    }

    // ===== ジャンプ =====
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float direction = GravityInversion.isActive ? -1f : 1f;
            rb.AddForce(Vector3.up * jumpForce * direction, ForceMode.Impulse);
            //Debug.Log("ジャンプ");
            isGrounded = false;
        }
    }
}
