using UnityEngine;

public class DeleteEye : MonoBehaviour
{
    [SerializeField] private GameObject eyeObject;
    // Update is called once per frame
   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            eyeObject.SetActive(false);
        }
    }

}
