using UnityEngine;
using UnityEngine.SceneManagement;

public class AppLogic : MonoBehaviour
{

    private static AppLogic instance;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Wolf");
    }

}
