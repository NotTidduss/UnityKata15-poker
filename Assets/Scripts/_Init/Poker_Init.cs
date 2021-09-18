using UnityEngine;
using UnityEngine.SceneManagement;

public class Poker_Init : MonoBehaviour
{
    void Awake() {
        initializePlayerPrefs();
        SceneManager.LoadScene("1_Poker");
    }
    
    private void initializePlayerPrefs() {

    }
}
