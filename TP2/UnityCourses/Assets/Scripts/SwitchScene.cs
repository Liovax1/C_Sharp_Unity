using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScene : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            LoadScene();
        }
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("SceneGame");
    }
}
