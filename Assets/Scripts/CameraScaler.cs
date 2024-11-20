using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraScaler : MonoBehaviour
{
    //basic size for the Orthographic Size למצב אופקי
    [SerializeField]
    private float baseOrthographicSize = 5f;

    void Start()
    {
        AdjustCameraSize();
    }

    void Update()
    {
        // check if the camera need update in real time 
        AdjustCameraSize();
    }

    private void AdjustCameraSize()
    {
        Camera camera = GetComponent<Camera>();

        float aspectRatio = (float)Screen.width / Screen.height;

        // update the size of the camera
        camera.orthographicSize = baseOrthographicSize / aspectRatio;
    }
}
