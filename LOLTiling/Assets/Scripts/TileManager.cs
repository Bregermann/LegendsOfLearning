using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    public Image tile1; public Image tile2; public Image tile3; public Image tile4;
    public Image tile5; public Image tile6; public Image tile7; public Image tile8;
    public Image tile9; public Image tile10; public Image tile11; public Image tile12;
    public Image tile13; public Image tile14; public Image tile15; public Image tile16;
    public Image tile17; public Image tile18; public Image tile19; public Image tile20;
    public Image tile21; public Image tile22; public Image tile23; public Image tile24;
    public Image tile25; public Image tile26; public Image tile27; public Image tile28;
    public Image tile29; public Image tile30; public Image tile31; public Image tile32;
    public Image tile33; public Image tile34; public Image tile35;

    public static bool hideAll;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (hideAll == true)
        {
            tile1.enabled = false; tile2.enabled = false; tile3.enabled = false; tile4.enabled = false;
            tile5.enabled = false; tile6.enabled = false; tile7.enabled = false; tile8.enabled = false;
            tile9.enabled = false; tile10.enabled = false; tile11.enabled = false; tile12.enabled = false;
            tile13.enabled = false; tile14.enabled = false; tile15.enabled = false; tile16.enabled = false;
            tile17.enabled = false; tile18.enabled = false; tile19.enabled = false; tile20.enabled = false;
            tile21.enabled = false; tile22.enabled = false; tile23.enabled = false; tile24.enabled = false;
            tile25.enabled = false; tile26.enabled = false; tile27.enabled = false; tile28.enabled = false;
            tile29.enabled = false; tile30.enabled = false; tile31.enabled = false; tile32.enabled = false;
            tile33.enabled = false; tile34.enabled = false; tile35.enabled = false;
        }
    }

    private void Problem1()
    {
        tile15.enabled = true;
    }

    private void Answer1()
    {
    }

    private void Problem2()
    {
        tile15.enabled = true; tile16.enabled = true;
    }

    private void Problem3()
    {
        tile25.enabled = true; tile18.enabled = true; tile11.enabled = true;
    }

    private void Problem4()
    {
        tile1.enabled = true; tile2.enabled = true; tile3.enabled = true; tile10.enabled = true;
    }

    private void Problem5()
    {
        tile18.enabled = true; tile11.enabled = true; tile17.enabled = true; tile19.enabled = true; tile25.enabled = true; tile26.enabled = true;
    }

    private void Problem6()
    {
        tile18.enabled = true; tile11.enabled = true; tile17.enabled = true; tile19.enabled = true; tile25.enabled = true; tile26.enabled = true;
        tile33.enabled = true; tile34.enabled = true; tile35.enabled = true;
    }

    private void Problem7()
    {
        tile18.enabled = true;
    }

    private void Problem8()
    {
        tile18.enabled = true;
    }

    private void Problem9()
    {
        tile18.enabled = true;
    }

    private void Problem10()
    {
        tile18.enabled = true;
    }
}