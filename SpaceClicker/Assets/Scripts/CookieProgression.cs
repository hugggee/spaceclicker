using UnityEngine;
using UnityEngine.UI;

public class SpaceProgression : MonoBehaviour
{
    [SerializeField] private Click progressionScript;
    [SerializeField] private Sprite[] spaceSprites;
    private Image spaceImage;

    private void Start()
    {
        spaceImage = GetComponent<Image>();
    }

    private void Update()
    {
        int currentProgression = progressionScript.GetProgression();
        UpdateSpaceImage(currentProgression);
    }

    private void UpdateSpaceImage(int progression)
    {
        if (progression >= 4000)
        {
            spaceImage.sprite = spaceSprites[4]; // svarta hålet
        }

        else if (progression >= 3000)
        {
            spaceImage.sprite = spaceSprites[3]; // sol
        }
        else if (progression >= 2000) // jupiter
        {
            spaceImage.sprite = spaceSprites[2];
        }
        else if (progression >= 1000)
        {
            spaceImage.sprite = spaceSprites[1]; // planet
        }
        else
        {
            spaceImage.sprite = spaceSprites[0]; // lilla månen
        }
    }
}
