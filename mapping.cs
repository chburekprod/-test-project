using UnityEngine;

public class Mapping : MonoBehaviour
{
    [SerializeField] private RectTransform gameObjectUI;
    [SerializeField] private Vector3 worldStartPos;
    [SerializeField] private Vector2 uiStartPos;

    private void Start()
    {
        worldStartPos = transform.position;
        uiStartPos = gameObjectUI.anchoredPosition;
    }

    private void Update()
    {
        Vector3 delta = transform.position - worldStartPos;
        gameObjectUI.anchoredPosition = uiStartPos + new Vector2(delta.x / 2, delta.z / 2);
    }
}