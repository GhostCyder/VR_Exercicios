using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        int totalScenes = SceneManager.sceneCountInBuildSettings;

        int nextScene = (currentScene + 1) % totalScenes;

        SceneManager.LoadScene(nextScene);
    }
}