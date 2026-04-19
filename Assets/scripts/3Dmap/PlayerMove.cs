using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Header("éQè∆")]
    public Transform Camera;

    [Header("à⁄ìÆ")]
    public float PlayerSpeed = 5f;

    [Header("âÒì]")]
    public float RotationSpeed = 120f;
    public float CameraRotationSpeed = 80f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private float cameraRotationX = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;

        // ï®óùê›íËÅièüéËÇ…ì|ÇÍÇ»Ç¢ÇÊÇ§Ç…Åj
        rb.freezeRotation = true;
    }

    void Update()
    {
        RotatePlayer();
        CameraFollow();
    }

    void FixedUpdate()
    {
        Move();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rb.MovePosition(startPosition);
        }
    }

    // ===== à⁄ìÆ =====
    void Move()
    {
        Vector3 direction = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direction += transform.forward;
            Debug.Log("WâüÇ≥ÇÍÇƒÇÈ");
        }
           
        if (Input.GetKey(KeyCode.S)) direction -= transform.forward;
        if (Input.GetKey(KeyCode.D)) direction += transform.right;
        if (Input.GetKey(KeyCode.A)) direction -= transform.right;

        Vector3 velocity = direction.normalized * PlayerSpeed;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    // ===== âÒì] =====
    void RotatePlayer()
    {
        float rotationY = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) rotationY -= RotationSpeed;
        if (Input.GetKey(KeyCode.RightArrow)) rotationY += RotationSpeed;

        if (Input.GetKey(KeyCode.UpArrow))
            cameraRotationX -= CameraRotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            cameraRotationX += CameraRotationSpeed * Time.deltaTime;

        cameraRotationX = Mathf.Clamp(cameraRotationX, -60f, 60f);

        transform.Rotate(0f, rotationY * Time.deltaTime, 0f);
    }

    // ===== ÉJÉÅÉâí«è] =====
    void CameraFollow()
    {
        if (Camera == null) return;

        Vector3 offset = new Vector3(0f, 2f, -5f);

        Camera.position = transform.position + transform.rotation * offset;
        Camera.rotation = Quaternion.Euler(cameraRotationX, transform.eulerAngles.y, 0f);
    }
}