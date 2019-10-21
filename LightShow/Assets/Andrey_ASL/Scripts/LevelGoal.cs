
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGoal : MonoBehaviour
{
    public string st_next_scene;

    // Use this for initialization
    void Start()
    {
        // Disable the renderer and collider
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

    }

    // Detect if something enters the Trigger
    void OnTriggerEnter2D(Collider2D _cl_detected)
    {
        if (_cl_detected.tag == "Player")
        {
          
            SceneManager.LoadScene(st_next_scene);
        }
    }

}
