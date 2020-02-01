using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{
    public int ammo = 20;
    public bool fire = false;

    public Text ammoUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammoUI.text = ammo.ToString();
        if(Input.GetMouseButtonDown(0) && !fire)
        {
            fire = true;
            ammo--;
            fire = false;
        }
    }
}
