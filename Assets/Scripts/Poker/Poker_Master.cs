using UnityEngine;

public class Poker_Master : MonoBehaviour
{
    [Header ("Scene References")]
    [SerializeField] private Poker_UI ui;
    [SerializeField] private Poker_System sys;


    void Start() => initialize();


    public  void playAgain() => sys.loadPokerScene();


    private void initialize() {
        ui.initialize();
    }
}
