using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Level1Pengurangan : MonoBehaviour
{
    public static int RandomAnswer;
    public GameObject Text1;
    public GameObject Text2;
    private int number1;
    private int number2;

    public GameObject resultPanel;
    public GameObject nextButton;
    public GameObject answer1;
    public GameObject resultText;

    AudioSource wrongAudio;


    // Start is called before the first frame update
    void Start()
    {
        wrongAudio = gameObject.GetComponent<AudioSource>();
        RandomAnswer = Random.Range(1, 10);
        number1 = Random.Range(RandomAnswer, 10);
        number2 = number1- RandomAnswer;
        Text1.GetComponent<TextMeshProUGUI>().text = number1.ToString();
        Text2.GetComponent<TextMeshProUGUI>().text = number2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (answer1.transform.childCount > 0)
        {
            string name = answer1.transform.GetChild(0).name;
            int answer = int.Parse(name);
            if (answer == RandomAnswer)
            {
                nextButton.SetActive(true);
                resultText.GetComponent<TextMeshProUGUI>().text = "You Win";
            }
            else
            {   
                resultText.GetComponent<TextMeshProUGUI>().text = "You Lose";
                nextButton.SetActive(false);
            }
            resultPanel.SetActive(true);
        }

    }

    public void restart(){
        SceneManager.LoadScene("Level1_Pengurangan");
    }

    public void Back(){
        SceneManager.LoadScene("Menu_Pengurangan");
    }

    public void Next(){
        SceneManager.LoadScene("Level2_Pengurangan");
    }
}
