using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        public void SonrakiSahneyeGit()
        {
            // Şu anki sahnenin index numarasını al ve 1 ekle
            int mevcutSahneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(mevcutSahneIndex + 1);
        }
    
}
