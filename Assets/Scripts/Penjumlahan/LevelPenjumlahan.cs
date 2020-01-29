using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelPenjumlahan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void level1()
    {
        SceneManager.LoadScene("Level1_Penjumlahan");
    }

    public void level2()
    {
        SceneManager.LoadScene("Level2_Penjumlahan");
    }

    public void level3()
    {
        SceneManager.LoadScene("Level3_Penjumlahan");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }
}
