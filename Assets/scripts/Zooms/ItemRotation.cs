using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    [SerializeField] Transform parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    float k = 500f;
    // Update is called once per frame
    //‰ñ“]‚³‚¹‚é
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float x = -Input.GetAxis("Mouse X") * Time.deltaTime * k;
            //float y = -Input.GetAxis("Mouse Y") * Time.deltaTime * k;
            //transform.Rotate(0, y, 0);
            transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles)*Vector3.up,x);
            //transform.RotateAround(transform.position, Quaternion.Euler(parent.rotation.eulerAngles)*Vector3.right,y);
        }

    }
}
