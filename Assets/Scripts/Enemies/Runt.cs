using UnityEngine;

public class Runt : Enemy
{
    public GameObject RuntBullet;
    public Transform bulletSpawnPoint;

    public void Update()
    {
        //Move();
    }
    public override void Move()
    {
        enemyAgent.SetDestination(position_of_interest);
    }

    public override void Attack(Transform target)
    {
        Instantiate(RuntBullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation).GetComponent<Rigidbody>().AddForce((target.position - transform.position).normalized * 1500f);
    }
}
