﻿// Copyright (c) Cragon. All rights reserved.

namespace Cs
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UnityEngine;

    public class ControllerPlayer : Controller
    {
        //---------------------------------------------------------------------
        public override void Create()
        {
            Debug.Log("ControllerPlayer.Create()");
        }

        //---------------------------------------------------------------------
        public override void Destory()
        {
        }

        //---------------------------------------------------------------------
        public override void HandleEvent(Event ev)
        {
        }
    }
}