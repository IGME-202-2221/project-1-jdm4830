using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Bullet bullet;
    private List<Bullet> fired = new List<Bullet>();
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    public void ShootBullets()
    {
        Vector3 mousePos = MousePosition();
        Vector3 direction = mousePos - transform.position;
        float speed = 1f;
        Vector3 velocity = direction * speed * Time.deltaTime;
        Bullet spawnedBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        spawnedBullet.Shoot(speed, velocity, direction);
        fired.Add(spawnedBullet);
    }

    private Vector3 MousePosition()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
