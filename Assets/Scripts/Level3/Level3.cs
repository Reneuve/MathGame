using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour
{
    public List<Sprite> Sprites = new List<Sprite>();
    public GameObject Numb1Panel;
    public GameObject Numb2Panel;
    public GameObject AnswerPanel;
    private int Result;
    private int Number1;
    private int Number2;

    public GameObject WinPanel;
    public GameObject WinText;
    public GameObject NextButton;
    // Start is called before the first frame update
    void Start()
    {
        Result = Random.Range(1, 11);
        Number1 = Random.Range(0, Result);
        Number2 = Result - Number1;

        for (int i = 1; i <= 2; i++)
        {
            GameObject NumberObject = new GameObject();
            Image img = NumberObject.AddComponent<Image>();
            switch (i)
            {
                case 1:
                    img.sprite = Sprites[Number1];
                    NumberObject.transform.SetParent(Numb1Panel.transform);
                    break;
                case 2:
                    img.sprite = Sprites[Number2];
                    NumberObject.transform.SetParent(Numb2Panel.transform);
                    break;
                default:
                    break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        string name = AnswerPanel.transform.GetChild(0).name;
        int? answer = null;
        switch (name)
        {
            case "Box1":
                answer = 1;
                break;
            case "Box2":
                answer = 2;
                break;
            case "Box3":
                answer = 3;
                break;
            case "Box4":
                answer = 4;
                break;
            case "Box5":
                answer = 5;
                break;
            case "Box6":
                answer = 6;
                break;
            case "Box7":
                answer = 7;
                break;
            case "Box8":
                answer = 8;
                break;
            case "Box9":
                answer = 9;
                break;
            case "Box10":
                answer = 10;
                break;
            default:
                break;
        }
        CheckResult(answer);
    }

    void CheckResult(int? answer)
    {
        if (answer == Result)
        {
            WinText.GetComponent<TextMeshProUGUI>().text = "You Win";
            NextButton.SetActive(true);
        }
        else
        {
            WinText.GetComponent<TextMeshProUGUI>().text = "You Lose";
            NextButton.SetActive(false);
        }
        WinPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Back(){
        SceneManager.LoadScene("Home");
    }

    public void Next(){
        SceneManager.LoadScene("Level4");
    }
}
