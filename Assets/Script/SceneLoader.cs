using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //씬 이동 함수
    public void LoadScene(string a)
    {
        SceneManager.LoadScene(a);
    }
}
