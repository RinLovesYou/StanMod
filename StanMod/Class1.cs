using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StanMod
{
    public class Class1 : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.R)) {
                var objs = Resources.FindObjectsOfTypeAll<RotatingDoor>();
                foreach (var obj in objs)
                {
                    if (obj is null)
                        continue;
                    obj.isLocked = false;
                }
            }
        }
    }

}
