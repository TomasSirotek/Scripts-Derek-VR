
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinReturn : MonoBehaviour
{

    public void ExitGame()
    {
        SceneManager.LoadScene("StartingMenu");

        Debug.Log("LoadSceneStart");


    }


}
