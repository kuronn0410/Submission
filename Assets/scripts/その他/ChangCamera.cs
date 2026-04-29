using UnityEngine;

public class ChangCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public Transform pointE;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position = pointA.position;
            transform.rotation = Quaternion.Euler(21, -8, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {

            transform.position = pointB.position;
            transform.rotation = Quaternion.Euler(21, -8, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position = pointC.position;
            transform.rotation = Quaternion.Euler(21,- 8, 0);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            // DキーでpointCに移動しているときだけZキーでpointDに行ける
            if (transform.position == pointC.position)
            {
                transform.position = pointD.position;
            }
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            // DキーでpointCに移動しているときだけXキーでpointDに行ける
            if (transform.position == pointC.position)
            {
                transform.position = pointE.position;
                transform.Rotate(-15f, -82f, 20);
            }

        }
    }

}
