using UnityEngine;

public class Tekismove2 : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform  player;
    [SerializeField] float viewDistance;
    [SerializeField] float viewAngle = 60f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        move2();
    }

    void move2()
    {
        if (viewDistance > player)
        {

        }

    }
}
