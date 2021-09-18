using UnityEngine;

public class Poker_UI : MonoBehaviour
{
    [Header ("Master")]
    [SerializeField] private Poker_Master master;

    [Header ("Menues")]
    [SerializeField] private GameObject playMenu;
    [SerializeField] private GameObject notificationMenu;
    [SerializeField] private GameObject resultMenu;


    public void initialize() {
        notificationMenu.SetActive(false);
        resultMenu.SetActive(false);
    }

    public void btn_playAgain() => master.playAgain();
}
