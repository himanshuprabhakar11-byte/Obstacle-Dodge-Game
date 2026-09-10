using UnityEngine;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip winSFX;
    float levelLoadDelay = 3f;

    int hits = 0;   
    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Finish")
        {
            Invoke(nameof(ReloadLevel), levelLoadDelay);
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(winSFX);
            Debug.Log("BOOYAH");
        }

    }
    void ReloadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
        
            

       



