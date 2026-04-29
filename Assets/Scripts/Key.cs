using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Key : MonoBehaviour
{

    public AudioClip coinClip;
    private TextMeshProUGUI coinText;

    private void Start()
    {
        coinText = GameObject.FindWithTag("KeyAmount").GetComponent<TextMeshProUGUI>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.key += 1;
            player.PlaySFX(coinClip, 0.4f);
            coinText.text = player.key.ToString();
            Destroy(gameObject);
        }
    }
}
