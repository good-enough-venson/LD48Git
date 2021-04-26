using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats instance;

    public static int gems {
        get => instance ? instance._gems : 0;
        set { if (instance) instance._gems = value; }
    }

    public static int lives {
        get => instance ? instance._lives : 0;
        set { if (instance) instance._lives = value; }
    }

    [SerializeField]
    private int _gg = 0, _ll = 0;

    public int _gems { get => _gg; set { _gg = value; UpdateGameState(); } }
    public int _lives { get => _ll; set { _ll = value; UpdateGameState(); } }

    public TMP_Text livesText, gemsText;
    public GameObject face;

    private void Awake() {
        if (instance == null) instance = this;
        else Destroy(this);

        UpdateGameState();
    }

    private void UpdateGameState()
    {
        face.SetActive(false);
        if (livesText) livesText.text = string.Format("Health: {0}", lives);
        if (gemsText) gemsText.text = string.Format("Gems: {0}", gems);

        if (_lives < 1) SceneManager.LoadScene("GameOver");
        if (_gems == 6) face.SetActive(true);
    }
}
