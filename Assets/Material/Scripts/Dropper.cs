using UnityEngine;

public class Dropper : MonoBehaviour
{
   
    [SerializeField] float timeToWait = 0;
    void Start()
    {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<MeshRenderer>().enabled = false;
    }

  
    void Update()
    {
       if (Time.time > timeToWait)
        {
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
