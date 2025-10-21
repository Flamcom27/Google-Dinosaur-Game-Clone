using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
