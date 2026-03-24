using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
        hits ++;
        Debug.Log("You have bumped into something this many time: " + hits);

        }
    }
}
