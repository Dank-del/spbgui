﻿// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using Octokit;
using SPB.Security;

namespace SPB.GameObjects.ServerObjects
{
    /// <summary>
    /// This class represents the parameters to update datas in DataBase.
    /// </summary>
    public class DataBaseUpdateRequest : UpdateFileRequest
    {
        //-------------------------------------------------
        #region Contructors Region
        public DataBaseUpdateRequest(StrongString theMessage, StrongString theContext, StrongString theSha) :
            base(theMessage.GetValue(), 
                QString.Parse(theContext).GetString(), 
                theSha.GetValue())
        {
            // do nothing here...
        }
        public DataBaseUpdateRequest(StrongString theMessage, 
            QString theContext, StrongString theSha) :
            base(theMessage.GetValue(),
                theContext.GetString(),
                theSha.GetValue())
        {
            // do nothing here...
        }
        public DataBaseUpdateRequest(StrongString theMessage,
            QString theContext, QString theSha) :
            base(theMessage.GetValue(),
                theContext.GetString(),
                theSha.GetValue())
        {
            // do nothing here...
        }
        #endregion
        //-------------------------------------------------
    }
}
