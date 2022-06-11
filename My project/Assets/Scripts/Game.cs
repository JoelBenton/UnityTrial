using System;
using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    // Clicker
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    // Shop
    public int fireMagePrice;
    public Text fireMageText;

    public int earthMagePrice;
    public Text earthMageText;

    public int airMagePrice;
    public Text airMageText;

    public int auraMagePrice;
    public Text auraMageText;

    public int holyMagePrice;
    public Text holyMageText;

    public int darkMagePrice;
    public Text darkMageText;
    public bool empty;



    //Amount
    public Text fireMageAmount;
    public int fireMageCount;
    public float fireMageProfit;

    public Text earthMageAmount;
    public int earthMageCount;
    public float earthMageProfit;

    public Text airMageAmount;
    public int airMageCount;
    public float airMageProfit;

    public Text auraMageAmount;
    public int auraMageCount;
    public float auraMageProfit;

    public Text holyMageAmount;
    public int holyMageCount;
    public float holyMageProfit;

    public Text darkMageAmount;
    public int darkMageCount;
    public float darkMageProfit;

    // Start is called before the first frame update
    void Start()
    {

        //Clicker
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
        
    }   // Update is called once per frame
    void Update()
    {
        
        // Clicker
        scoreText.text = (int)currentScore + " pebbles";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasedPerSecond;

        // Shop
        fireMageText.text = fireMagePrice + " pebbles";
        earthMageText.text = earthMagePrice + " pebbles";
        airMageText.text = airMagePrice + " pebbles";
        auraMageText.text = auraMagePrice + " pebbles";
        holyMageText.text = holyMagePrice + " pebbles";
        darkMageText.text = darkMagePrice + " pebbles";

        // Amount
        fireMageAmount.text = "fire Mage: " + fireMageCount + " Mages: " + fireMageProfit + "/s";
        earthMageAmount.text = "earth Mage: " + earthMageCount + " Mages: " + earthMageProfit + "/s";
        airMageAmount.text = "air Mage: " + airMageCount + " Mages: " + airMageProfit + "/s";
        auraMageAmount.text = "aura Mage: " + auraMageCount + " Mages: " + auraMageProfit + "/s";
        holyMageAmount.text = "holy Mage: " + holyMageCount + " Mages: " + holyMageProfit + "/s";
        darkMageAmount.text = "dark Mage: " + darkMageCount + " Mages: " + darkMageProfit + "/s";

    }

    // Hit
    public void Hit()
    {
        currentScore = currentScore + hitPower;
    }

    // Shop

    public void FireMage()
    {
        if (currentScore>= fireMagePrice)
        {
            currentScore = currentScore - fireMagePrice;
            fireMageCount += 1;
            fireMageProfit += 1;
            x += 1;
            fireMagePrice += 5;
        }
    }

    public void EarthMage()
    {
        if (currentScore >= earthMagePrice)
        {
            currentScore = currentScore - earthMagePrice;
            earthMageCount += 1;
            earthMageProfit += 15;
            x += 15;
            earthMagePrice += 25;
        }
    }

    public void AirMage()
    {
        if (currentScore >= airMagePrice)
        {
            currentScore = currentScore - airMagePrice;
            airMageCount += 1;
            airMageProfit += 225;
            x += 225;
            airMagePrice += 300;
        }
    }

    public void AuraMage()
    {
        if (currentScore >= auraMagePrice)
        {
            currentScore = currentScore - auraMagePrice;
            auraMageCount += 1;
            auraMageProfit += 3375;
            x += 3375;
            auraMagePrice += 5000;
        }
    }

    public void HolyMage()
    {
        if (currentScore >= holyMagePrice)
        {
            currentScore = currentScore - holyMagePrice;
            holyMageCount += 1;
            holyMageProfit += 50625;
            x += 50625;
            holyMagePrice += 75000;
        }
    }

    public void DarkMage()
    {
        if (currentScore >= darkMagePrice)
        {
            currentScore = currentScore - darkMagePrice;
            darkMageCount += 1;
            darkMageProfit += 759375;
            x += 759375;
            darkMagePrice += 8000000;
        }
    }
}