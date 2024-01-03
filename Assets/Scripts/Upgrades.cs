using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    public Transform bulletSize;
    public GameObject player;
    public GameObject bullet;
    public GameObject canvasManager;
    public GameObject waves;

    [SerializeField]
    Text CurrentUpgrade;




    public void MouseClick(string buttonType)
    {

        if (buttonType == "Light 1")
        {
            player.GetComponent<Shooting>().setFireRate(4);
            player.GetComponent<Shooting>().setBulletForce(35);
            player.GetComponent<PlayerMovement2>().setSpeed(25);
            bullet.GetComponent<Bullet>().setDamage(8);
            bulletSize.localScale = new Vector3(0.6f, 0.6f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(1);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Light 1";
            waves.SetActive(true);
        }
        
        if (buttonType == "Balanced")
        {
            player.GetComponent<Shooting>().setFireRate(3);
            player.GetComponent<Shooting>().setBulletForce(30);
            player.GetComponent<PlayerMovement2>().setSpeed(22);
            bullet.GetComponent<Bullet>().setDamage(12);
            bulletSize.localScale = new Vector3(0.9f, 0.9f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(2);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Balanced";
            waves.SetActive(true);
        }
        
        if (buttonType == "Heavy 1")
        {
            player.GetComponent<Shooting>().setFireRate(1.8f);
            player.GetComponent<Shooting>().setBulletForce(20);
            player.GetComponent<PlayerMovement2>().setSpeed(16);
            bullet.GetComponent<Bullet>().setDamage(16);
            bulletSize.localScale = new Vector3(1.2f, 1.2f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(3);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Heavy 1";
            waves.SetActive(true);
        }

        if (buttonType == "Light 2")
        {
            player.GetComponent<Shooting>().setFireRate(10);
            player.GetComponent<Shooting>().setBulletForce(45);
            player.GetComponent<PlayerMovement2>().setSpeed(30);
            bullet.GetComponent<Bullet>().setDamage(6);
            bulletSize.localScale = new Vector3(0.5f, 0.5f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(4);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Light 2";
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Light 1")
        {
            player.GetComponent<Shooting>().setFireRate(6);
            player.GetComponent<Shooting>().setBulletForce(40);
            player.GetComponent<PlayerMovement2>().setSpeed(25);
            bullet.GetComponent<Bullet>().setDamage(9);
            bulletSize.localScale = new Vector3(0.7f, 0.7f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(5);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Balanced Light 1";
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Heavy 1")
        {
            player.GetComponent<Shooting>().setFireRate(1.8f);
            player.GetComponent<Shooting>().setBulletForce(20);
            player.GetComponent<Shooting>().setShooterCounter(1);
            player.GetComponent<PlayerMovement2>().setSpeed(15);
            bullet.GetComponent<Bullet>().setDamage(16);
            bulletSize.localScale = new Vector3(0.8f, 0.8f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(6);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Balanced Heavy 1";
            waves.SetActive(true);
        }

        if (buttonType == "Heavy 2")
        {
            player.GetComponent<Shooting>().setFireRate(1.3f);
            player.GetComponent<Shooting>().setBulletForce(15);
            player.GetComponent<PlayerMovement2>().setSpeed(11);
            bullet.GetComponent<Bullet>().setDamage(34);
            bulletSize.localScale = new Vector3(1.5f, 1.5f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            canvasManager.GetComponent<canvasManager>().setCanvNum(7);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Heavy 2";
            waves.SetActive(true);
        }

        if (buttonType == "Sniper")
        {
            player.GetComponent<Shooting>().setFireRate(1.5f);
            player.GetComponent<Shooting>().setBulletForce(90);
            player.GetComponent<Shooting>().setShooterCounter(5);
            player.GetComponent<PlayerMovement2>().setSpeed(30);
            bulletSize.localScale = new Vector3(0.5f, 0.5f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Sniper";
            waves.SetActive(true);
        }

        if (buttonType == "Light 3")
        {
            player.GetComponent<Shooting>().setFireRate(25);
            player.GetComponent<Shooting>().setBulletForce(55);
            player.GetComponent<PlayerMovement2>().setSpeed(37);
            bullet.GetComponent<Bullet>().setDamage(7);
            bulletSize.localScale = new Vector3(0.3f, 0.3f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Light 3";
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Light 2")
        {
            player.GetComponent<Shooting>().setFireRate(13);
            player.GetComponent<Shooting>().setBulletForce(50);
            player.GetComponent<Shooting>().setShooterCounter(1);
            player.GetComponent<PlayerMovement2>().setSpeed(30);
            bullet.GetComponent<Bullet>().setDamage(5);
            bulletSize.localScale = new Vector3(0.2f, 0.2f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Balanced Light 2";
            waves.SetActive(true);
        }

        if (buttonType == "Balanced Heavy 2")
        {
            player.GetComponent<Shooting>().setFireRate(1.8f);
            player.GetComponent<Shooting>().setBulletForce(15);
            player.GetComponent<Shooting>().setShooterCounter(2);
            player.GetComponent<PlayerMovement2>().setSpeed(14);
            bullet.GetComponent<Bullet>().setDamage(30);
            bulletSize.localScale = new Vector3(0.7f, 0.7f, 0);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Balanced Heavy 2";
            waves.SetActive(true);
        }

        if (buttonType == "Heavy 3")
        {
            player.GetComponent<Shooting>().setFireRate(0.9f);
            player.GetComponent<Shooting>().setBulletForce(10);
            player.GetComponent<Shooting>().setShooterCounter(3);
            player.GetComponent<PlayerMovement2>().setSpeed(7);
            bulletSize.localScale = new Vector3(0.8f, 0.8f, 0);
            bullet.GetComponent<Bullet>().setDamage(20);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Heavy 3";
            waves.SetActive(true);
        }

        if (buttonType == "Battle Tank")
        {
            player.GetComponent<Shooting>().setFireRate(0.5f);
            player.GetComponent<Shooting>().setBulletForce(10);
            player.GetComponent<Shooting>().setShooterCounter(4);
            player.GetComponent<PlayerMovement2>().setSpeed(4);
            bullet.GetComponent<Bullet>().setDamage(80);
            canvasManager.GetComponent<canvasManager>().closeCanvas(canvasManager.GetComponent<canvasManager>().canvNum);
            GetComponent<AudioSource>().Play();
            CurrentUpgrade.text = "Battle Tank";
            waves.SetActive(true);
        }

    }


    void Update()
    {

    }
}
