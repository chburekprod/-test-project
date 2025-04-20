using UnityEngine;

public class DragMap : MonoBehaviour
{
    private RectTransform map;
    private Vector2 lastMousePos;

    void Start()
    {
        map = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 currentMousePos = Input.mousePosition;
            Vector2 delta = currentMousePos - lastMousePos;

            map.anchoredPosition += delta;
            lastMousePos = currentMousePos;
        }
    }
    public void Pressed()
    {
        Debug.Log("я пидор");
    }
}