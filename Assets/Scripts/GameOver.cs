using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public TextMeshProUGUI roundsText;

   public string menuScreenName = "MainMenu";

   public SceneFader sceneFader;

   public void Retry()
   {
      sceneFader.FadeTo(SceneManager.GetActiveScene().name);
   }

   public void Menu()
   {
      sceneFader.FadeTo(menuScreenName);
   }
}
