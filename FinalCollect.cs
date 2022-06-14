using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class FinalCollect : MonoBehaviour
{
    public int count;
    public int weaponCount;
    public int moneyCount;
    public TextMesh drugsCountText;
    public TextMesh creditCountText;
    public TextMesh moneyCountText;
    public TextMesh winText;

    public GameObject table;
    public GameObject button;

    public AudioClip WinSound;
    public TextMesh finalNumber;
    public int numberOfCollectibles = 15;
    private float test = GameManager.Instance.TotalGameplay;
    void Start()
    {
        count = 0;
        weaponCount = 0;
        moneyCount = 0;
        winText.text = "";
        table.SetActive(false);
        button.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
            if (count == 0) //first collected object - start timer
            {
                GameManager.Instance.TimerRunning = true;
            }

            other.gameObject.SetActive(false);
            count++;
            UpdateUI();
        }
        if (other.gameObject.CompareTag("credit"))
        {

            other.gameObject.SetActive(false);
            weaponCount = ++weaponCount;
            UpdateUI();
        }
        if (other.gameObject.CompareTag("drugs"))
        {

            other.gameObject.SetActive(false);
            moneyCount = ++moneyCount;
            UpdateUI();
        }
        if (other.gameObject.CompareTag("win"))
        {
            if ((count + weaponCount + moneyCount) >= numberOfCollectibles) //first collected object - start timer
            {
                GameManager.Instance.TimerRunning = false;
                GameManager.Instance.SpawnReward = true;
                table.SetActive(true);
                button.SetActive(true);
                PlayWinSound();



                UpdateWinUI();
            }


        }

    }
    void PlayWinSound()
    {
        AudioSource.PlayClipAtPoint(WinSound, transform.position);

    }
    void UpdateWinUI()
    {

        if ((count + weaponCount + moneyCount) == numberOfCollectibles)
        {

            DisplayTime(GameManager.Instance.TotalGameplay);

        }
    }

    void DisplayTime(float test)
    {
        test += 1;


        float minutes = Mathf.FloorToInt(test / 60);
        float seconds = Mathf.FloorToInt(test % 60);

        finalNumber.text = "You Completed Game in " + string.Format("{0:00}:{1:00}", minutes, seconds);
        Debug.Log(test);
    }


    void UpdateUI()
    {
        drugsCountText.text = "Money:" + count.ToString() + "/5";
        creditCountText.text = "Credit C" + weaponCount.ToString() + "/5";

        moneyCountText.text = "Drugs:" + moneyCount.ToString() + "/5";




        Debug.Log(GameManager.Instance.TotalGameplay);

        if ((count + weaponCount + moneyCount) >= numberOfCollectibles)
        {

            winText.text = "EscapeToCar";
            Debug.Log(GameManager.Instance.TotalGameplay);




        }
    }
}
