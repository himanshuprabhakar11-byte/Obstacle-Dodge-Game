using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    float levelLoadDelay = 0.6f;

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            GetComponent<MeshRenderer>().material.color = Color.lightYellow;
            gameObject.tag = "Hit";
            Invoke(nameof(ReloadLevel), levelLoadDelay);
        }
    }
    void ReloadLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

}
