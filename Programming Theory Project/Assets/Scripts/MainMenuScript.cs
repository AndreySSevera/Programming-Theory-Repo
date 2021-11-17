using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class MainMenuScript : MonoBehaviour
{
    public class Data
    {
        public int countSlab;
        public float countMass;
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
