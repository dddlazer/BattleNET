﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * BattleNET v1.3.4 - BattlEye Library and Client            *
 *                                                         *
 *  Copyright (C) 2018 by it's authors.                    *
 *  Some rights reserved. See license.txt, authors.txt.    *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

using System;

namespace BattleNET
{
    public delegate void BattlEyeConnectEventHandler(BattlEyeConnectEventArgs args);
    public delegate void BattlEyeDisconnectEventHandler(BattlEyeDisconnectEventArgs args);

    public class BattlEyeConnectEventArgs : EventArgs
    {
        public BattlEyeConnectEventArgs(BattlEyeLoginCredentials loginDetails, BattlEyeConnectionResult connectionResult)
        {
            LoginDetails = loginDetails;
            ConnectionResult = connectionResult;
            Message = Helpers.StringValueOf(connectionResult);
        }

        public BattlEyeLoginCredentials LoginDetails { get; }
        public BattlEyeConnectionResult ConnectionResult { get; }
        public string Message { get; }
    }

    public class BattlEyeDisconnectEventArgs : EventArgs
    {
        public BattlEyeDisconnectEventArgs(BattlEyeLoginCredentials loginDetails, BattlEyeDisconnectionType? disconnectionType)
        {
            LoginDetails = loginDetails;
            DisconnectionType = disconnectionType;
            Message = Helpers.StringValueOf(disconnectionType);
        }

        public BattlEyeLoginCredentials LoginDetails { get; }
        public BattlEyeDisconnectionType? DisconnectionType { get; }
        public string Message { get; }
    }
}
