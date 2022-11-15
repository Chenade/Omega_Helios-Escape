using UnityEngine;

public class Gun : MonoBehaviour
{
    //public GameObject[] asteroids;
    private int counter = 0;

    public float damage = 10f;
    public float range = 5000f;

    public Camera fpsCam;

    void Start() {
        //Amno_System.amno = 22;
        Score_System.score = 0;


    }

    // Update is called once per frame
    void Update()
    {

      
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
            Amno_System.amno -= 1;
          
        }


        void Shoot() 
        {
            RaycastHit hit;
            if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                //UnityEngine.Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
               
                if (target != null)
                {                 
                    Destroy(target.gameObject);
                    Score_System.score += 1;
                }
            }
        }

        void Die()
        {
            UnityEngine.Debug.Log("Die");

            if(Score_System.score > 10)
            {
                Static_BassardRamjet.Bass_01 = false; 
            }
            Static_BassardRamjet.current_part = 99;
        }
    }
}
