using UnityEngine;
using UnityEngine.UI;

public class SlidingMenu : MonoBehaviour
{
    [SerializeField] private RectTransform menuPanel;
    [SerializeField] private Button toggleButton;
    [SerializeField] private float slideSpeed = 5f;

    private Vector2 hiddenPosition;
    private Vector2 visiblePosition;
    private bool isMenuVisible = false;

    void Start()
    {
        hiddenPosition = new Vector2(-menuPanel.rect.width, 0);
        visiblePosition = Vector2.zero;
        menuPanel.anchoredPosition = hiddenPosition; 

        toggleButton.onClick.AddListener(ToggleMenu);
    }

    void Update()
    {
        if (isMenuVisible)
        {
            menuPanel.anchoredPosition = Vector2.Lerp(menuPanel.anchoredPosition, visiblePosition, Time.deltaTime * slideSpeed);
            if (Vector2.Distance(menuPanel.anchoredPosition, visiblePosition) < 0.1f)
            {
                menuPanel.anchoredPosition = visiblePosition;
            }
        }
        else
        {
            menuPanel.anchoredPosition = Vector2.Lerp(menuPanel.anchoredPosition, hiddenPosition, Time.deltaTime * slideSpeed);
            if (Vector2.Distance(menuPanel.anchoredPosition, hiddenPosition) < 0.1f)
            {
                menuPanel.anchoredPosition = hiddenPosition;
            }
        }
    }

    private void ToggleMenu()
    {
        isMenuVisible = !isMenuVisible;
    }
}