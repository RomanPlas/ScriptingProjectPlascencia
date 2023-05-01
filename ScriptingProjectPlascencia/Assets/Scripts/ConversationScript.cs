using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    public int intelligence = 5;

    
        void Start()
        {
            switch (intelligence)
            {
                case 5:
                    print("Why hello there good sir! Let me teach you!");
                    break;
                case 4:
                    print("Hello and good day");
                    break;
                case 3:
                    print("Whatdaya want");
                    break;
                case 2:
                    print("Gorg SMASH!");
                    break;
                case 1:
                    print("Ulg, glib, Pblblblb");
                    break;
                default:
                    print("Incorrect intelligence level");
                    break;
            }

        }
    



    
    
}
