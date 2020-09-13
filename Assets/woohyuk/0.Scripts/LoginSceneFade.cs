using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginSceneFade : MonoBehaviour
{
    public UnityEngine.UI.Image fadePanel;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FadeInCorutine");
    }

    public void LoginSuccess()
    {
        StartCoroutine("FadeOutCorutine");
    }

    IEnumerator FadeInCorutine()
    {
        for (float i = 1f; i >= 0; i -= 0.05f)
        {
            fadePanel.color = new Color(0, 0, 0, i);
            yield return null;
        }
    }

    IEnumerator FadeOutCorutine()
    {
        for (float i = 0f; i <= 1; i += 0.01f)
        {
            fadePanel.color = new Color(0, 0, 0, i);
            yield return null;
        }

        SceneManager.LoadScene("2.Lobby");
    }
}
