using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour
{
    public void CarsGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

        public void BusGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

        public void TruckGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

        public void MotorcycleGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

        public void QuitGame() {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
