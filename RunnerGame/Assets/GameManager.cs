using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("UI OBJELER")]
    public Slider rate_slider;
    public GameObject oyundurdurma_paneli;
<<<<<<< HEAD
    public GameObject anamenuye_donulcekmi_panel;
    public Slider gamesound;
    public TextMeshProUGUI leveltext;
    public TextMeshProUGUI goaltext;
    public TextMeshProUGUI anlik_rate;

    [Header("GENEL LEVEL AYARLARI")]
    public float istenilen_rate_düzeyi;
    public Animator kapi_anim;
    public KameraTakip kamera;
    public GameObject[] engeller;
    float sayi;
    Scene scene;
    void Start()
    {
        PlayerPrefs.SetFloat("reward", 0f);
        rate_slider.value = PlayerPrefs.GetFloat("reward");
        gamesound.value= PlayerPrefs.GetFloat("oyunses");
        scene = SceneManager.GetActiveScene();
        leveltext.text = (scene.buildIndex - 2).ToString();
         sayi = istenilen_rate_düzeyi * 100f;
        goaltext.text =  "%"+sayi.ToString();
=======

    [Header("GENEL LEVEL AYARLARI")]
    public float istenilen_rate_düzeyi;
    
    void Start()
    {
        PlayerPrefs.SetFloat("reward", 0f);
        rate_slider.value = PlayerPrefs.GetFloat("reward"); 
        

>>>>>>> parent of 96b6d762 (update4)
    }

    public void rate_up(float odul_degeri)
    {
        if(PlayerPrefs.GetFloat("reward") + odul_degeri> 1)
        {
            PlayerPrefs.SetFloat("reward", 1);
            
        }
        else
        {
            PlayerPrefs.SetFloat("reward", PlayerPrefs.GetFloat("reward") + odul_degeri);
           
            
           
        }
      
        //Debug.Log(PlayerPrefs.GetFloat("reward"));
        //Debug.Log(slider_Value);
        rate_slider.value = PlayerPrefs.GetFloat("reward");
        sayi = PlayerPrefs.GetFloat("reward") * 100f;
        anlik_rate.text = "%" + sayi.ToString();
    }
    public void rate_down(float ceza_degeri)
    {
        if(PlayerPrefs.GetFloat("reward") - ceza_degeri < 0)
        {
            PlayerPrefs.SetFloat("reward", 0);
        }
        else
        {
            PlayerPrefs.SetFloat("reward", PlayerPrefs.GetFloat("reward") - ceza_degeri);
        }
        rate_slider.value = PlayerPrefs.GetFloat("reward");
        sayi = PlayerPrefs.GetFloat("reward") * 100f;
        anlik_rate.text = "%" + sayi.ToString();
    }

  public void oyunudurdur(){
        oyundurdurma_paneli.SetActive(true);
        Time.timeScale = 0;
    }
    public void oyundan_cikiliyormu(string key)
    { 
        if(key == "evet")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            oyundurdurma_paneli.SetActive(false);
            Time.timeScale = 1;
        }


    }

    void Update()
    {
       
    }
<<<<<<< HEAD
    public void anamenuye_donulcekmi(string key)
    {
        if(key== "evet")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            anamenuye_donulcekmi_panel.SetActive(false);
        }
    }
    public void ses_Ayarla(string hangi_ayar)
    {
        switch (hangi_ayar)
        {
            case "oyunses":
                PlayerPrefs.SetFloat("oyunses", gamesound.value);
                break;
        }
    }

    public void engelcalistir(int index)
    {
        Debug.Log("girdi");
        engeller[index].GetComponent<Animator>().enabled = true;
    }
=======
>>>>>>> parent of 96b6d762 (update4)
}
