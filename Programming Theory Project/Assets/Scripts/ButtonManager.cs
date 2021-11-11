using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}