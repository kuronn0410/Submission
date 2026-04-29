using UnityEngine;

public class Tekismove1 : MonoBehaviour
{

    [SerializeField] float speed = 5f;
    [SerializeField] float moveDistance = 10f;
    [SerializeField] float nextMove = 10f;
    [SerializeField] Vector3 moveDirection = Vector3.forward;

    //(0, 0, 1) → 前（今と同じ）
    //(1, 0, 0) → 右
    //(-1, 0, 0) → 左
    //(0, 0, -1) → 後ろ
    //(1, 0, 1) → 斜め
      
        Vector3 targetPosition;

    bool isMoving = true;
    Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + moveDirection.normalized * moveDistance;

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
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
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
