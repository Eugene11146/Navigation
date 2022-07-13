using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private int _nextScene= 2;
    public void Start()
    {
        SceneManager.LoadScene(_nextScene);
        _nextScene++;
    }
}
