 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{

    public float ilerigerihareket = 0.25f;
    public float yanahareket = 0.25f;
    public float asagiyukarihareket = 0.25f;

    private Dictionary<string, KeyCode> movementKeyBindings = new Dictionary<string, KeyCode>()
        {
            { "ileri", KeyCode.W },
            { "geri", KeyCode.S },
            { "sol", KeyCode.A },
            { "sag", KeyCode.D },
            { "yukari", KeyCode.Space },
            { "asagi", KeyCode.LeftShift }
        };

    public void FixedUpdate()
    {
        if (Input.GetKey(this.movementKeyBindings["ileri"]))
        {
            this.transform.position += new Vector3(
                this.transform.forward.x * (-this.ilerigerihareket / 0.2f),
                0,
                this.transform.forward.z * (-this.ilerigerihareket / 0.2f)
            );
        }
        if (Input.GetKey(this.movementKeyBindings["geri"]))
        {
            this.transform.position += new Vector3(
                this.transform.forward.x * (this.ilerigerihareket / 0.2f),
                0,
                this.transform.forward.z * (this.ilerigerihareket / 0.2f)
            );
        }

        

        if (Input.GetKey(this.movementKeyBindings["sag"]))
        {
            this.transform.Translate(Vector3.left * (this.yanahareket / 0.2f));
        }

        if (Input.GetKey(this.movementKeyBindings["sol"]))
        {
            this.transform.Translate(Vector3.right * (this.yanahareket / 0.2f));
        }

        if (Input.GetKey(this.movementKeyBindings["yukari"]))
        {
            this.transform.Translate(Vector3.up * (this.asagiyukarihareket / 0.2f));
        }

        if (Input.GetKey(this.movementKeyBindings["asagi"]))
        {
            this.transform.Translate(Vector3.down * (this.asagiyukarihareket / 0.2f));
        }
    }
}
