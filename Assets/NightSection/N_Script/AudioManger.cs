using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;
public class AudioManger : MonoBehaviour
{

    public static AudioManger instance; // Singleton instance

    [Header("Audio Sources")]
    public AudioSource MusicSource; // Reference to the AudioSource component
    public AudioSource SFXSource; // Reference to the AudioSource component

    [Header("Audio Clips")]
    public AudioClip CoinClip;
    public AudioClip Bg;

    [Header("Toggles")]
    public Toggle MusicToggle; // Reference to the music toggle UI element
    public Toggle SFXToggle; // Reference to the sound effects toggle UI element

    public Light2D spotlight;
   
    private void Awake()
    {
        // Implementing the Singleton pattern
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    private void Start()
    {
        MusicSource.clip = Bg; // Set the background music clip
        MusicSource.Play(); // Play the background music

        MusicToggle.isOn = true;
        SFXToggle.isOn = true;


        MusicToggle.onValueChanged.AddListener(ToggleMusic); // Add listener for music toggle
        SFXToggle.onValueChanged.AddListener(ToggleSFX); // Add listener for sound effects toggle

       string levelName = SceneManager.GetActiveScene().name;
            

    }
    private void Update()
    {
        if( Input.GetKeyDown(KeyCode.M))
        {
            // spotlight.enabled = false; // Toggle the spotlight on or off when the "M" key is pressed
            spotlight.intensity = 5f;

        }
    }


    public void CoinCollectedClip()
    {

        SFXSource.PlayOneShot(CoinClip); // Play the coin collection sound effect
    }

    public void ToggleMusic(bool isOn)
    {
        MusicSource.mute = !isOn; // Mute or unmute the music based on the toggle state
       
    }

    public void ToggleSFX(bool isOn)
    {
        SFXSource.mute = !isOn; // Mute or unmute the sound effects based on the toggle state
    }

    public void levelMusic( string LvlName)
    {
        if(LvlName == "Levelone")
        {
            MusicSource.clip = Bg; // Set the background music clip for Levelone
            MusicSource.Play(); // Play the background music for Levelone
        }
        else if(LvlName == "Leveltwo")
        {
            MusicSource.clip = Bg; // Set the background music clip for Leveltwo
            MusicSource.Play(); // Play the background music for Leveltwo
        }   
    }


}
