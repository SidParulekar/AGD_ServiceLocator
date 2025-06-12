using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class GameService : GenericSingleton<GameService>
{
    public PlayerService playerService { get; private set; }
    [Header("Player Service")]
    [SerializeField] public PlayerScriptableObject playerScriptableObject;

    public SoundService soundService { get; private set; }
    [Header("Sound Service")]
    [SerializeField] private SoundScriptableObject soundScriptableObject;
    [SerializeField] private AudioSource audioEffects;
    [SerializeField] private AudioSource backgroundMusic;

    [Header("UI Service")]
    [SerializeField] private UIService uIService;
    public UIService UIService => uIService;

    private void Start()
    {
        playerService = new PlayerService(playerScriptableObject);
        soundService = new SoundService(soundScriptableObject, audioEffects, backgroundMusic);
    }

    private void Update()
    {
        playerService.Update();
    }


}
