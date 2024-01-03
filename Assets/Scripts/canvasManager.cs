using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasManager : MonoBehaviour
{
    public int canvNum;
    public GameObject fromBasic;
    public GameObject fromLight1;
    public GameObject fromBalanced;
    public GameObject fromHeavy1;
    public GameObject fromLight2;
    public GameObject fromBalancedLight1;
    public GameObject fromBalancedHeavy1;
    public GameObject fromHeavy2;


    public GameObject UIOverlay;


    [SerializeField]
    Text waveCountText;

    [SerializeField]
    Text FlyingEyeCount;

    [SerializeField]
    Text GoblinCount;


    public void setCanvNum(int newCanvNum)
    {
        canvNum = newCanvNum;

    }

    public void chooseCanvas(int canvNum)
    {
        
        if(canvNum == 0)
        {
            fromBasic.SetActive(true);
            
            waveCountText.text = "2";
            FlyingEyeCount.text = "19";
            GoblinCount.text = "13";
            UIOverlay.SetActive(true);

        }
        
        if (canvNum == 1)
        {
            fromLight1.SetActive(true);
            waveCountText.text = "3";
            FlyingEyeCount.text = "26";
            GoblinCount.text = "21";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 2)
        {
            fromBalanced.SetActive(true);
            waveCountText.text = "3";
            FlyingEyeCount.text = "26";
            GoblinCount.text = "21";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 3)
        {
            fromHeavy1.SetActive(true);
            waveCountText.text = "3";
            FlyingEyeCount.text = "26";
            GoblinCount.text = "21";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 4)
        {
            fromLight2.SetActive(true);
            waveCountText.text = "4";
            FlyingEyeCount.text = "35";
            GoblinCount.text = "35";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 5)
        {
            fromBalancedLight1.SetActive(true);
            waveCountText.text = "4";
            FlyingEyeCount.text = "35";
            GoblinCount.text = "35";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 6)
        {
            fromBalancedHeavy1.SetActive(true);
            waveCountText.text = "4";
            FlyingEyeCount.text = "35";
            GoblinCount.text = "35";
            UIOverlay.SetActive(true);
        }

        if (canvNum == 7)
        {
            fromHeavy2.SetActive(true);
            waveCountText.text = "4";
            FlyingEyeCount.text = "35";
            GoblinCount.text = "35";
            UIOverlay.SetActive(true);
        }
    }

    public void closeCanvas(int canvNum)
    {

        if (canvNum == 0)
        {
            fromBasic.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 1)
        {
            fromLight1.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 2)
        {
            fromBalanced.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 3)
        {
            fromHeavy1.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 4)
        {
            fromLight2.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 5)
        {
            fromBalancedLight1.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 6)
        {
            fromBalancedHeavy1.SetActive(false);
            UIOverlay.SetActive(false);
        }

        if (canvNum == 7)
        {
            fromHeavy2.SetActive(false);
            UIOverlay.SetActive(false);
        }
    }
}
