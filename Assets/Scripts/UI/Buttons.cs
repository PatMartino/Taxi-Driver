using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class Buttons : MonoBehaviour
    {
        [SerializeField] private GameObject Menu;
        [SerializeField] private GameObject Credit;
        public void PlayAgain()
        {
            SceneManager.LoadScene("SampleScene");
        }
        public void StartGame()
        {
            SceneManager.LoadScene("SampleScene");
        }
        public void Credits()
        {
            Menu.SetActive(false);
            Credit.SetActive(true);
        }

        public void Back()
        {
            Menu.SetActive(true);
            Credit.SetActive(false);
        }
        public void Quit()
        {
            Application.Quit();
        }
    }
}
