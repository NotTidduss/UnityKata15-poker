using UnityEngine;
using UnityEngine.SceneManagement;

public class Poker_System : MonoBehaviour
{
    [Header ("Scene Management")]
    public string pokerSceneName = "1_Poker";


    public void loadPokerScene() => SceneManager.LoadScene(pokerSceneName);
}
