using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Diagnostics;
using System.Diagnostics;
using System;

public class btnscript: MonoBehaviour
{

    public string scene_Name = "Lotto6aus49";
    public string scene_Name_2 = "EuroJackpot";
    public string menü_scene = "Menü";

    public void first_btn_click()
    {
        SceneManager.LoadScene(scene_Name);
    }

    public void second_btn_click()
    {
        SceneManager.LoadScene(scene_Name_2);
    }

    public void defaultlottoback_btn()
    {
        SceneManager.LoadScene(menü_scene);
    }

    public void quit_btn()
    {
        Application.Quit();
    }

    public void page()
    {
        try
        {
            Process.Start("https://programmerlp-net.vercel.app");
            Process.Start("https://programmerlp.net");
            Process.Start("https://programmerlp13.w3spaces.com");
        }
        catch (Exception e)
        {

        }
    }

}
