using UnityEngine;

public class Tekismove1 : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float stopPositionZ = 10f;
    [SerializeField] float nextMove = 10f;
    bool isMoving = true;
    Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            move1();

        }


    }

    void move1()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z >= stopPositionZ)
        {
          isMoving = false;
            Invoke("TekisReset", nextMove); // 2秒後にTekisResetメソッドを呼び出す

        }


    }

    void TekisReset()
    {
        transform.position = startPosition;
        isMoving = true;
    }



}
