using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStory : MonoBehaviour
{
    [SerializeField]
    private string path;

    void Start()
    {
        Process p = new Process();
        p.StartInfo.UseShellExecute = true;
        p.StartInfo.FileName = path;
        p.Start();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
