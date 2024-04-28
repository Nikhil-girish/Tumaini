using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGameCam : MonoBehaviour
{
    public GameObject Cam1;
    public GameObject Cam2;
    public int Manager;


    public void ChangeCamera()
    {
        GetComponent<Animator>().SetTrigger("Change");
    }
    public void ManageCamera()
    {
        if(Manager == 0)
        {
            Cam_2();
            Manager = 1;
        }
        else
        {
            Cam_1();
            Manager = 0;
        }
    }

    void Cam_1()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
    }

    void Cam_2()
    {
        Cam1.SetActive(false);
        Cam2.SetActive(true);
    }
}
