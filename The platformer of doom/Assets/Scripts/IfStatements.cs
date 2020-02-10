using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public CharacterController player;
    public int a = 4;

    public int b = 6;

    public int c = 10;

    public string password = "this is a password";
    // Start is called before the first frame update
    void Start()
    {
        if (a + b == c)
        {
            print("butts");
        }

        if (a + b != c)
        {
            print("no match");
        }

        if (password == "this is a password")
        {
            print("you did it");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isGrounded)
        {
            print("I cant flyyyyyy");
        }
    }
}
