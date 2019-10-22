using UnityEngine;

public class ASL_HP : MonoBehaviour
{
    public float HP = 50f;  // variable on how much hp the object has.

    public void DmgTaken(float ammount)
    {
        HP -= ammount;
        if (HP <= 0)   // if the target's HP reaches 0, call the Destroy function
        {
            Destroy();                   
        }
    }

    void Destroy()
    {
        ASL_Score.ScoreV += 10; // add 10 points to score and destroy object
        Destroy(gameObject);  // Destroy function, does exactly what it says, destroys the game obhject.       
    }
}