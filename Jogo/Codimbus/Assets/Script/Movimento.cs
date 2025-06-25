using UnityEngine;
using UnityEngine.TextCore.Text;

public class Movement : MonoBehaviour
{
    CharacterController Controller;

    void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimento = new Vector3(horizontal, vertical, 0);
        
        Controller.Move(movimento * Time.deltaTime * 9);
        Controller.Move(new Vector3(horizontal, vertical, 0 ) * Time.deltaTime);
    }
}

