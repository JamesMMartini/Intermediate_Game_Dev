using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiRockMechanism : ButtonObject
{
    public GameObject[] rocks;

    public override void ButtonPressed(GameObject box)
    {
        foreach (GameObject rock in rocks)
        {
            rock.GetComponent<SpriteRenderer>().enabled = false;
            rock.GetComponent<CircleCollider2D>().enabled = false;
        }
    }

    public override void ButtonUnpressed(GameObject box)
    {
        foreach (GameObject rock in rocks)
        {
            rock.GetComponent<SpriteRenderer>().enabled = true;
            rock.GetComponent<CircleCollider2D>().enabled = true;
        }
    }
}
