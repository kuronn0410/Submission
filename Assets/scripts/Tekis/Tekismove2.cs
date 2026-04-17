using UnityEngine;

public class Tekismove2 : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    [SerializeField] Transform player;
    [SerializeField] float viewDistance;
    [SerializeField] float viewAngle = 60f;

    void Update()
    {
        move2();
    }


    void move2()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        // プレイヤーの方向
        Vector3 direction = (player.position - transform.position).normalized;
        float dot = Vector3.Dot(transform.right, direction);

        RaycastHit hit;
        RaycastHit hitRight, hitLeft;
        Vector3 raystart = transform.position + Vector3.up * 0.5f; // レイの開始位置を少し上げる

        bool isWallRight = Physics.Raycast(raystart, transform.right, out hitRight, 1f);
        bool isWallLeft = Physics.Raycast(raystart, -transform.right, out hitLeft, 1f);


        if (Physics.Raycast(raystart, transform.forward, out hit, 2f))
        {
            if (hit.collider.CompareTag("wall"))
            {
                if (dot > 0 && !isWallRight)
                    transform.Rotate(0,90,0);
                else if (dot < 0 && !isWallLeft)
                    transform.Rotate(0,-90, 0);
                else
                    transform.Rotate(0, 180, 0);
                return;
            }
        }

        if (isWallRight && hitRight.collider.CompareTag("wall"))
        {
            //Vector3 wallDir = Vector3.Cross(hitRight.normal, Vector3.up);
            //transform.rotation = Quaternion.LookRotation(wallDir);
            transform.position += transform.forward * speed * Time.deltaTime;

            return;
        }
        if (isWallLeft && hitLeft.collider.CompareTag("wall"))
        {
            //Vector3 wallDir = Vector3.Cross(Vector3.up, hitLeft.normal);
            //transform.rotation = Quaternion.LookRotation(wallDir);
            transform.position += transform.forward * speed * Time.deltaTime;
            return;

        }
        if (viewDistance >= distance)
        {
            transform.rotation = Quaternion.LookRotation(direction);
            transform.position += transform.forward * speed * Time.deltaTime;
           
        }

        
    }
}