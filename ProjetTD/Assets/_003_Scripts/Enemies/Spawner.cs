using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _timer;
    public GameObject[] _ennemiPrefab;
    public float _cooldownTimer;
    private int _probaEnnemi;
    public float _reductionCooldownTimer;
    private int _wave;
    public int _waveMax;

    // Temps pendant lequel les ennemis spawn (dur�e de la vague)
    private float _globalTimer;
    public float _globalTimerPublic;

    // Temps entre les vagues o� les ennemis ne spawn plus
    private float _cdGlobalTimer;
    public float _cdGlobalTimerPublic;


    // Start is called before the first frame update
    void Start()
    {
        _timer = _cooldownTimer;
        _globalTimer = _globalTimerPublic;
        _cdGlobalTimer = _cdGlobalTimerPublic;
        _wave = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (_globalTimer > 0)
        {
            // Probabilit� d'apparition du type d'ennemi
            if (_timer <= 0 && _wave <= _waveMax)
            {
                int randomEnnemi;
                _probaEnnemi = Random.Range(0, 100);
                if (_probaEnnemi < 50)
                {
                    randomEnnemi = 0;
                }
                else
                {
                    randomEnnemi = 1;
                }

                // Faire appara�tre un ennemi � une position pr�cise
                Vector2 spawnPosition = new Vector2(-9, 2);
                GameObject spawned = Instantiate(_ennemiPrefab[randomEnnemi], spawnPosition, Quaternion.Euler(transform.up));
                _timer = _cooldownTimer;

            }
            else
            {
                _timer = _timer - Time.deltaTime;

                // � chaque d�but de vague, r�initialise le cooldown entre les vagues
                _cdGlobalTimer = _cdGlobalTimerPublic;
            }

            // Faire tourner le timer de la vague en cours
            _globalTimer = _globalTimer - Time.deltaTime;

        }
        else
        {
            // Faire tourner le timer entre les vagues
            _cdGlobalTimer = _cdGlobalTimer - Time.deltaTime;
        }

        // Quand il est temps de passer � la vague suivante, r�initialise le temps de la vague et acc�l�re la vitesse de spawn
        if (_cdGlobalTimer <= 0)
        {
            _globalTimer = _globalTimerPublic;
            _cooldownTimer = _cooldownTimer - _reductionCooldownTimer;
            _wave = _wave + 1;
        }

    }

}