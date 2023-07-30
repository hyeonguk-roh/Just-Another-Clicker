using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    private double clickUpgradeCost;
    private int clickUpgradeLevel;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("ClickUpgradeCost")) {
            clickUpgradeCost = double.Parse(PlayerPrefs.GetString("ClickUpgradeCost"), System.Globalization.CultureInfo.InvariantCulture);
        } else {
            PlayerPrefs.SetString("ClickUpgradeCost", clickUpgradeCost.ToString());
        }
        if (PlayerPrefs.HasKey("ClickUpgradeLevel")) {
            clickUpgradeLevel = PlayerPrefs.GetInt("ClickUpgradeLevel");
        } else {
            PlayerPrefs.SetInt("ClickUpgradeLevel", clickUpgradeLevel);
        }
    }
}
