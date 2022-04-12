using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnnemi : MonoBehaviour
{
    public int MaxPvEnnemi;
    public int CurrentPvEnnemi;
    private Vector2 targetPos;
    private float healthBarLength;

    // Start is called before the first frame update
    void Start()
    {
        healthBarLength = Screen.width / 6;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("j'ai");
            Bullet bullet = collision.GetComponent<Bullet>();
            CurrentPvEnnemi -= bullet.damage;

        }
    }


    // Update is called once per frame
    void Update()
    {
        // Si les pv de l'ennemi tombent à 0, gagne de l'argent et le détruit
        if (CurrentPvEnnemi <= 0)
        {
            CashScore.moneyValue += 10;
            Destroy(gameObject);
        }
    }

    private void OnGUI()
    {
        // Affichage et positionnement de la barre de vie
        targetPos = Camera.main.WorldToScreenPoint(transform.position);
        GUI.Box(new Rect(targetPos.x -30, Screen.height - targetPos.y - 40, 60, 20), CurrentPvEnnemi + "/" + MaxPvEnnemi);
    }

}
