using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void penjumlahan()
    {
        SceneManager.LoadScene("Menu_Penjumlahan");
    }

    public void pengurangan()
    {
        SceneManager.LoadScene("Menu_Pengurangan");
    }

    public void Back(){
        SceneManager.LoadScene("Home");
    }
}
