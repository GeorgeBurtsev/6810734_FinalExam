using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ExitGame() {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void DrivingGame() {
        SceneManager.LoadScene("Prototype 1");
        //Debug.Log("Drive");
    }
    public void SumoGame() {
        SceneManager.LoadScene("Prototype 4");
        //Debug.Log("Sumo");
    }
    public void FlyGame() {
        SceneManager.LoadScene("Challenge 1");
        // Debug.Log("Fly");
    }
}
