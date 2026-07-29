using System;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour
{
    Camera cam;

    RaycastHit hit;

    [SerializeField]
    private float distance = 10f;

    [SerializeField]
    private LayerMask mask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    [SerializeField] private EventSystem eventSystem;

    void Update()
    {
        //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Ray ray = new Ray(transform.position, transform.forward);

        Debug.DrawRay(ray.origin, ray.direction * distance, Color.blue);

        PointerEventData ped = new PointerEventData(eventSystem);
        ped.position = new Vector2(Screen.width / 2f, Screen.height / 2f);

        List<RaycastResult> results = new List<RaycastResult>();
        eventSystem.RaycastAll(ped, results);

        foreach (RaycastResult result in results)
        {
            if (result.gameObject.tag == "Hoge")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Button button = result.gameObject.GetComponent<Button>();
                    button.onClick.Invoke();
                }
            }
        }
    }
}
