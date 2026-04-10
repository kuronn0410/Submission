using UnityEngine;

public class Tekismove2 : MonoBehaviour
{
    [SerializeField] float speed = 5f;
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

        if (viewDistance >= distance)
        {
            // ƒvƒŒƒCƒ„[‚Ì•ûŒü
            Vector3 direction = (player.position - transform.position).normalized;

            // ˆÚ“®
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}