using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToDisable2;
    public GameObject objectToDisable3;
    public GameObject forest1,forest2,town1,pwt,tegal,crb,attaqwa,citypark,malang,bromo,uinsmr,mak,jogja,pwt2,pwt3,upi,uinjkt,beach,sea,sea2,desert,desert2,cairo,alazhar,yaman,sky,sky2,end;
    public GameObject nabrakudud;
    public GameObject tiba;
    public characterdatabase characterDB;
    public SpriteRenderer artworkSprite;
    public AudioSource scoreSound,mabur,kalah;
    private int selectedOption = 0;

    public static bool disabled = false;

    Rigidbody2D Rb;
    public float jumpForce;
    float score;
    public Text scoreTxt;
    public Text selesai;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("bgm").GetComponent<teruskanmusik>().StopMusic();
        forest1.SetActive (true);
        Time.timeScale = 1;
        Rb = GetComponent<Rigidbody2D>();

        if(!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpForce;
            mabur.Play();
        }
        if (score == 6) {
            forest1.SetActive (false);
            forest2.SetActive (true);
        } 
        if (score == 12) {
            forest2.SetActive (false);
            town1.SetActive (true);
        }
        if (score == 18) {
            town1.SetActive (false);
            pwt.SetActive (true);
        }
        if (score == 26) {
            pwt.SetActive (false);
            crb.SetActive (true);
        }
        if (score == 32) {
            crb.SetActive (false);
            attaqwa.SetActive (true);
        }
        if (score == 36) {
            attaqwa.SetActive (false);
            tegal.SetActive (true);
        }
        if (score == 42) {
            tegal.SetActive (false);
            citypark.SetActive (true);
        }
        if (score == 48) {
            citypark.SetActive (false);
            malang.SetActive (true);
        }
        if (score == 56) {
            malang.SetActive (false);
            bromo.SetActive (true);
        }
        if (score == 64) {
            bromo.SetActive (false);
            uinsmr.SetActive (true);
        }
        if (score == 72) {
            uinsmr.SetActive (false);
            mak.SetActive (true);
        }
        if (score == 80) {
            mak.SetActive (false);
            pwt2.SetActive (true);
        }
        if (score == 90) {
            pwt2.SetActive (false);
            jogja.SetActive (true);
        }
        if (score == 100) {
            jogja.SetActive (false);
            pwt3.SetActive (true);
        }
        if (score == 110) {
            pwt3.SetActive (false);
            upi.SetActive (true);
        }
        if (score == 120) {
            upi.SetActive (false);
            uinjkt.SetActive (true);
        }
        if (score == 130) {
            uinjkt.SetActive (false);
            beach.SetActive (true);
        }
        if (score == 135) {
            beach.SetActive (false);
            sea.SetActive (true);
        }
        if (score == 140) {
            sea.SetActive (false);
            sea2.SetActive (true);
        }
        if (score == 150) {
            sea2.SetActive (false);
            desert.SetActive (true);
        }
        if (score == 160) {
            desert.SetActive (false);
            desert2.SetActive (true);
        }
        if (score == 170) {
            desert2.SetActive (false);
            cairo.SetActive (true);
        }
        if (score == 180) {
            cairo.SetActive (false);
            alazhar.SetActive (true);
        }
        if (score == 190) {
            alazhar.SetActive (false);
            yaman.SetActive (true);
        }
        if (score == 200) {
            yaman.SetActive (false);
            sky.SetActive (true);
        }
        if (score == 210) {
            sky.SetActive (false);
            sky2.SetActive (true);
        }
        if (score == 220) {
            sky2.SetActive (false);
            end.SetActive (true);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="score")
        {
            score++;
            scoreSound.Play();
        }
        if(collision.gameObject.tag=="udud")
        {
            Time.timeScale = 0;
            objectToDisable.SetActive (false);
            objectToDisable2.SetActive (true);
            objectToDisable3.SetActive (false);
            nabrakudud.SetActive (true);
            kalah.Play();
        }
        if(collision.gameObject.tag=="jatuh")
        {
            Time.timeScale = 0;
            objectToDisable.SetActive (false);
            objectToDisable2.SetActive (true);
            objectToDisable3.SetActive (false);
            tiba.SetActive (true);
            kalah.Play();
        }
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
