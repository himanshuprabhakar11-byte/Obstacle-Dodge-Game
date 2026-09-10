using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip crashSFX;
   
    int hits = 0;   
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
        
            hits++;
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(crashSFX);
            Debug.Log("You bumped with something this many times: " + hits);
        }

       



    }
}
