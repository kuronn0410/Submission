using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [Header("参照")]
    public Transform Camera;

    [Header("移動")]
    public float PlayerSpeed = 5f;

    [Header("回転")]
    public float RotationSpeed = 120f;
    public float CameraRotationSpeed = 80f;

    /*[Header("ジャンプ")]
    [SerializeField] float jumpForce = 5f;
    private bool isGrounded = true;
    */

    [Header("Public")]
    public float gravityChange = 1f;
    [SerializeField] float gravityScale = 9.81f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private float cameraRotationX = 0f;

    void Start()
    {
        
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // カスタム重力を使用するため、Unityの重力は無効にする
        // 物理設定（勝手に倒れないように）
        rb.freezeRotation = true;
    }

    void Update()
    {
        RotatePlayer();
        CameraFollow();
        //Jump();

        
    }

    void FixedUpdate()
    {
        Move();
        float currentGravityDirection = GravityInversion.isActive ? -1f : 1f;
        Vector3 customGravity = Vector3.down * gravityScale * currentGravityDirection;
        rb.AddForce(customGravity, ForceMode.Acceleration);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rb.MovePosition(startPosition);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Poison"))
        {
            rb.MovePosition(startPosition);
        }
    }

    // ===== 移動 =====
    void Move()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.forward;
            //Debug.Log("W押されてる");
        }
           
        if (Input.GetKey(KeyCode.S)) direction -= transform.forward;
        if (Input.GetKey(KeyCode.D)) direction += transform.right;
        if (Input.GetKey(KeyCode.A)) direction -= transform.right;

        Vector3 velocity = direction.normalized * PlayerSpeed;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    // ===== 回転 =====
    void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X") * RotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * CameraRotationSpeed;
        transform.Rotate(0f, mouseX * Time.deltaTime, 0f);
        cameraRotationX -= mouseY * Time.deltaTime;
        cameraRotationX = Mathf.Clamp(cameraRotationX, -60f, 60f);
        Camera.localRotation = Quaternion.Euler(cameraRotationX, 0f, 0f);

  
    }

    // ===== カメラ追従 =====
    void CameraFollow()
    {
        if (Camera == null) return;

        Vector3 offset = new Vector3(0f, 0f, 0f);

        Camera.position = transform.position + transform.rotation * offset;
        Camera.rotation = Quaternion.Euler(cameraRotationX, transform.eulerAngles.y, 0f);
    }

    // ===== ジャンプ =====
    /*void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            float direction = GravityInversion.isActive ? -1f : 1f;
            rb.AddForce(Vector3.up * jumpForce * direction, ForceMode.Impulse);
            //Debug.Log("ジャンプ");
            isGrounded = false;
        }
    }*/
}