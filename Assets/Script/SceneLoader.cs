using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //�� �̵� �Լ�
    public void LoadScene(string a)
    {
        SceneManager.LoadScene(a);
    }
}
