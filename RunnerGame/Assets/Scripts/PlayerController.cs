using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
    [Header("INTERN AYARLARI")]
    public float Player_Speed;
    public Transform konum;
    public GameObject durma_noktasi;

    [Header("GENEL LEVEL AYARLARI")]
    public float coffe_odul_degeri;
    public float coffe2_odul_degeri;
    public float coffe_machine_odul_degeri;
    public float donut_ceza_degeri;
    public float dosya_odul_degeri;
    public float pc_ceza_degeri;
    public GameObject yurume_noktasi;
    public float internalLeft;
    public float internalRigth;

    [Header("EFEKTLER")]
    public List<GameObject> good_Reward;
    public List<GameObject> bad_Reward;

    float rigtLeftSpeed = 2f;
=======
    
>>>>>>> parent of 96b6d762 (update4)
    bool oyunsonu_Geldimi;
    bool yuru;

    public GameManager gamemanager;
<<<<<<< HEAD
    Rigidbody rg;
    //public coincollect coinCollect;
=======

>>>>>>> parent of 96b6d762 (update4)
   Animator anim;
    void Start()
    {
        oyunsonu_Geldimi = false;
           anim = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(!oyunsonu_Geldimi)
<<<<<<< HEAD
        transform.Translate(Vector3.forward * Player_Speed * Time.deltaTime,Space.World);
=======
        transform.Translate(Vector3.forward * 8f * Time.deltaTime);
>>>>>>> parent of 96b6d762 (update4)
    }
    void Update()
    {
        if (!oyunsonu_Geldimi)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (Input.GetAxis("Mouse X") < 0)
                {
                    if(this.gameObject.transform.position.x > internalLeft)
                    {
                        // transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f, transform.position.y,
                        //  transform.position.z), .3f);
                        transform.Translate(Vector3.left * rigtLeftSpeed * Time.deltaTime);
                    }
                  
                }
                if (Input.GetAxis("Mouse X") > 0)
                {
                    if (this.gameObject.transform.position.x < internalRigth)
                    {
                        // transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f, transform.position.y,
                        //transform.position.z), .3f);
                        transform.Translate(Vector3.left * rigtLeftSpeed * Time.deltaTime *-1);
                    }
                }
            }
<<<<<<< HEAD
            if (Input.touchCount > 0)
            {
                Touch parmak = Input.GetTouch(0);
                if (parmak.deltaPosition.x < 0)
                {
                    if (this.gameObject.transform.position.x > internalLeft)
                    {
                        /*transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - .1f, transform.position.y,
                            transform.position.z), 1f);*/
                        transform.Translate(Vector3.left * rigtLeftSpeed * Time.deltaTime);
                    }
                }
                if (parmak.deltaPosition.x > 0)
                {
                    if (this.gameObject.transform.position.x < internalRigth)
                    {
                        //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + .1f, transform.position.y,
                        //  transform.position.z), 1f);
                        transform.Translate(Vector3.left * rigtLeftSpeed * Time.deltaTime * -1);
                    }
                }

            }
=======


           /* if (Input.GetKeyDown(KeyCode.Space))
            {
                jump = true;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = false;
            }


            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                slide = true;
            }
            else
            {
                slide = false;
            }


            if (jump == true)
            {

                if (anim.GetBool("isJump") == false)
                {
                    anim.SetBool("isJump", jump);
                    //transform.Translate(Vector3.up * 25f * Time.deltaTime);

                }



            }
            else if (jump == false)
            {
                anim.SetBool("isJump", jump);

            }



            if (slide == true)
            {
                if (anim.GetBool("isSlide") == false)
                {
                    anim.SetBool("isSlide", slide);
                    transform.Translate(Vector3.forward * 8f * Time.deltaTime);
                }
            }
            else if (slide == false)
            {
                anim.SetBool("isSlide", slide);

            }
           */
>>>>>>> parent of 96b6d762 (update4)
        }

    }
    public void kazandikmi_kaybettikmi()
    {
        if(PlayerPrefs.GetFloat("reward") > gamemanager.istenilen_rate_düzeyi)
        {
            Debug.Log("kazandik");
        }
        else
        {
            Debug.Log("kaybettik");
        }
        if (yuru)
        {
            transform.Translate(Vector3.forward * 2f * Time.deltaTime);
        }
    }

    



    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
        if (other.CompareTag("engel"))
        {
            gamemanager.engelcalistir(int.Parse(other.gameObject.transform.parent.name));
            Debug.Log(other.gameObject.transform.parent.name);
        }
        if (other.CompareTag("coffe"))
=======
        if(other.gameObject.tag == "engel")
>>>>>>> parent of 96b6d762 (update4)
        {
            Debug.Log("carpti");
            other.gameObject.SetActive(false);
<<<<<<< HEAD
            good_efekt_olustur(konum);
            Debug.Log("kahve");
            Destroy(other.gameObject);
            odul("coffe");
        }
        if (other.CompareTag("coffe2"))
        {
            other.gameObject.SetActive(false);
            good_efekt_olustur(konum);
            Debug.Log("kahve2");
            Destroy(other.gameObject);
            odul("coffe2");
        }
        if (other.CompareTag("dosya"))
        {
            other.gameObject.SetActive(false);
            good_efekt_olustur(konum);
            Debug.Log("dosya");
            Destroy(other.gameObject);
            odul("dosya");
        }
        if (other.CompareTag("coffe_machine"))
        {
            other.gameObject.SetActive(false);
            good_efekt_olustur(konum);
            Debug.Log("coffemachine");
            Destroy(other.gameObject);
            odul("coffe_machine");
        }

        if (other.CompareTag("donut"))
        {
            other.gameObject.SetActive(false);
            bad_efekt_olustur(konum);
            Debug.Log("donut");
            Destroy(other.gameObject);
            odul("donut"); 
        }
        if (other.CompareTag("pc"))
        {
            other.gameObject.SetActive(false);
            bad_efekt_olustur(konum);
            Debug.Log("pc");
            Destroy(other.gameObject);
            odul("pc");
=======
            gamemanager.rate_down(0.1f);
>>>>>>> parent of 96b6d762 (update4)
        }

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject, 0.2f);
        }
        if (other.CompareTag("reward"))
        {
            Debug.Log("odul kazandik");
            other.gameObject.SetActive(false);
            gamemanager.rate_up(0.1f);
        }
        if (other.CompareTag("bolum_sonu"))
        {
            oyunsonu_Geldimi = true;
<<<<<<< HEAD
            
                pozisyonayarla();


            anim.SetBool("oyunsonu", true);// eklenecek
            
            gamemanager.kazandikmi_kaybettikmi();
           
            Invoke("yurus", 4f);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("yurume_noktasi"))
        {
            yuru = false;
            anim.SetBool("walking", false);
            anim.SetBool("oyunsonu", true);// eklenecek
        }
    }
    void pozisyonayarla()
    {
        rg.isKinematic = true;
            Debug.Log("aaa");
            //transform.position = new Vector3(0.871f,-0.14f,536.0515f);
            transform.position = durma_noktasi.transform.position;
        
    }
    public void yurus()
    {
        anim.SetBool("walking", true);
        yuru = true;
    }
    public void odul(string key)
    {
        switch (key)
        {
            case "coffe":
                gamemanager.rate_up(coffe_odul_degeri);
                break;
            case "coffe2":
                gamemanager.rate_up(coffe2_odul_degeri);
                break;
            case "donut":
                gamemanager.rate_down(donut_ceza_degeri);
                break;
            case "dosya":
                gamemanager.rate_up(dosya_odul_degeri);
                break;
            case "coffe_machine":
                gamemanager.rate_up(coffe_machine_odul_degeri);
                break;
            case "pc":
                gamemanager.rate_down(pc_ceza_degeri);
                break;
        }
    }
  

    public void good_efekt_olustur(Transform pozisyon)
    {
      
            foreach (var item2 in good_Reward)
            {
                if (!item2.activeInHierarchy)
                {

                    item2.SetActive(true);
                    item2.transform.position = pozisyon.position;
                    item2.GetComponent<ParticleSystem>().Play();
               
                    break;
                }
            }
    }
    public void bad_efekt_olustur(Transform pozisyon)
    {

        foreach (var item2 in bad_Reward)
        {
            if (!item2.activeInHierarchy)
            {
                item2.SetActive(true);
                item2.transform.position = pozisyon.position;
                item2.GetComponent<ParticleSystem>().Play();

                break;
            }
        }
    }
}
=======
            kazandikmi_kaybettikmi();
        }


    }
}
>>>>>>> parent of 96b6d762 (update4)
