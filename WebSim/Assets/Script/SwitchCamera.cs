using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject SecondaryCamera;

    private void Start()
    {
        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
            cameraPositionCounter++;
            cameraPositionChange(cameraPositionCounter);
        }
    }

    private void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if (camPosition == 0)
        {
            MainCamera.SetActive(true);
            SecondaryCamera.SetActive(false);
        }

        if (camPosition == 1)
        {
            SecondaryCamera.SetActive(true);
            MainCamera.SetActive(false);
        }
    }
}