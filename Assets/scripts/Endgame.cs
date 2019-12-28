using UnityEngine;
using UnityEngine.SceneManagement;
public class Endgame : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D collinfo)
    {
        if (collinfo.CompareTag("collidable"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
