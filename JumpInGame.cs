
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpInGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Basic Empty scene");
      
        Debug.Log("LoadSceneA");


    }



}
