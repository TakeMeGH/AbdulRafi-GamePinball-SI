using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsUIController : MonoBehaviour
{
    [SerializeField] Button portofolioButton;
    [SerializeField] Button mainMenuButton;
    // Start is called before the first frame update
    void Start()
    {
        portofolioButton.onClick.AddListener(OpenPortofolio);
        mainMenuButton.onClick.AddListener(BackToMainMenu);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenPortofolio()
    {
        Application.OpenURL("https://takemegh.github.io/");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("S_MainMenu");
    }

}
