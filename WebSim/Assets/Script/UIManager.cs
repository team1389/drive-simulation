using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static float speedChange = 7;
    public static float rotateChange = 150;

    public void OnPlaySubmit()
    {
        SceneManager.LoadScene(1);      //1 is play scene
    }

    public void OnSettingsSubmit()
    {
        SceneManager.LoadScene(2);      //2 is settings scene
    }

    public void OnBackSubmit()
    {
        SceneManager.LoadScene(0);      //0 is main menu scene
    }

    public void OnReturnSubmit()
    {
        SceneManager.LoadScene(0);
    }

    public void OnGithubClick()
    {
        Application.OpenURL("https://github.com/team1389/drive-simulation");
    }

    public void OnTeamLinkClick()
    {
        Application.OpenURL("https://team1389.org");
    }

    public void OnRotationDropDownChanged(int index)
    {
        rotateChange = 50 + (index + 1) * 15;
        Debug.Log(rotateChange);
    }

    public void OnMovementDropDownChanged(int index)
    {
        speedChange = index + 3;
        Debug.Log(speedChange);
    }
}
