using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collinfo)
    {
        if(collinfo.CompareTag("Player"))
        {
            Debug.Log("GAME WON! :D");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
