using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotation = 0;
    [SerializeField] float yRotation = 0;
    [SerializeField] float zRotation = 0;
   
    
    void Update()
    {
        transform.Rotate(xRotation,yRotation,zRotation);
    }
}
