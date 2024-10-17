using System.Collections;
using TMPro;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    private Click clickScript;
    private int upgradeCost = 50;
    private int upgradeCount = 0;
    private float increasePercentage = 0.20f;

    public TMP_Text autoClickerPriceText;

    void Start()
    {
        GameObject clickingButton = GameObject.Find("ClickingButton");
        if (clickingButton != null)
        {
            clickScript = clickingButton.GetComponent<Click>();
        }
        UpdateAutoClickerPriceText();
    }

    public void PurchaseAutoClicker()
    {
        if (clickScript != null && clickScript.GetCurrentClicks() >= upgradeCost)
        {
            clickScript.SetClicks(clickScript.GetCurrentClicks() - upgradeCost);
            clickScript.UpdateClickText();

            upgradeCount++;
            upgradeCost = (int)(upgradeCost * (1 + increasePercentage));
            UpdateAutoClickerPriceText();
            StartCoroutine(AutoClickCoroutine());
        }
    }

    private IEnumerator AutoClickCoroutine()
    {
        while (true)
        {
            clickScript.AddClick();
            clickScript.UpdateClickText();
            yield return new WaitForSeconds(1f);
        }
    }

    private void UpdateAutoClickerPriceText()
    {
        if (autoClickerPriceText != null)
        {
            autoClickerPriceText.text = "Autoclicker: " + upgradeCost;
        }
    }
}
