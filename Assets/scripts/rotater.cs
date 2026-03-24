using UnityEngine;

public class rotater : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);  
    }
}
