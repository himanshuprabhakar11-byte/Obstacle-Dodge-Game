using UnityEngine;

public class Mover : MonoBehaviour
{
   [SerializeField] int moveSpeed = 40;
       
    void Update()
    {
        int yValue = 0;
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed  ;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
     

        transform.Translate(xValue, yValue, zValue);
        

    }

   
}
  
  
  

