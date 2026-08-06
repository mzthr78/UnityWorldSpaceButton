using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera userCamera;
    public Camera pcCamera;

    public Camera[] securityCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        userCamera.enabled = true;
        pcCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
