using UnityEngine;

public class Syokkaku : MonoBehaviour
{
    [Header("ジャンプ")]
    
    [SerializeField] float jumpForce = 5f;
    private Rigidbody rb;
    private PlayerMove playerMove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerMove = GetComponent<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {
        Jump();

    }

    // ===== ジャンプ =====
    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playerMove.isGrounded &&!GravityInversion.isActive)
        {
            float direction = GravityInversion.isActive ? -1f : 1f;
            rb.AddForce(Vector3.up * jumpForce * direction, ForceMode.Impulse);
            //Debug.Log("ジャンプ");
            playerMove.isGrounded = false;
        }
    }
}
