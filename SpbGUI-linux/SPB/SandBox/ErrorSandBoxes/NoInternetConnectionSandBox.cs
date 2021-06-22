﻿// Spam Protection Bot GUI
// Copyright (C) 2019 - 2021 ALiwoto
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of the source code.

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SPB.Controls.Elements;

namespace SPB.SandBox.ErrorSandBoxes
{
    public sealed partial class NoInternetConnectionSandBox : ErrorSandBox
    {
        //-------------------------------------------------
        #region Constant's Region
        /// <summary>
        /// The name of MessageLabel1 in the Resources without _name,
        /// 
        /// </summary>
        public const string SandBoxLabel1NameInRes = "SandBoxLabel1";
        /// <summary>
        /// The name of MessageLabel2 in the Resources without _name,
        /// 
        /// </summary>
        public const string SandBoxLabel2NameInRes = "SandBoxLabel2";
        /// <summary>
        /// The name of Button1 in the Resources without _name,
        /// 
        /// </summary>
        public const string SandBoxButton1NameInRes = "SandBoxButton1";
        /// <summary>
        /// The name of Button1 in the Resources without _name,
        /// 
        /// </summary>
        public const string SandBoxButton2NameInRes = "SandBoxButton2";
        /// <summary>
        /// The background Image key in the <see cref="SandBoxBase.MyRes"/>.
        /// </summary>
        public const string SandBoxBackGNameInRes = "BackGName";
        #endregion
        //-------------------------------------------------
        #region Properties Region
        /// <summary>
        /// the title flat element of this sandbox.
        /// </summary>
        public FlatElement TitleElement { get; private set; }
        /// <summary>
        /// the body element of this sandbox.
        /// </summary>
        public FlatElement BodyElement { get; private set; }
        /// <summary>
        /// the exit button of this sandbox.
        /// </summary>
        public ButtonElement ExitButton { get; private set; }
        /// <summary>
        /// the retry button element in sandbox.
        /// </summary>
        public ButtonElement RetryButton { get; private set; }
        public Texture2D LeftTexture { get; private set; }
        public Texture2D RightTexture { get; private set; }
        public Texture2D LineTexture { get; private set; }
        public Point LeftTextureRealLocation { get; private set; }
        public Point LineTextureRealLocation { get; private set; }
        public Point RightTextureRealLocation { get; private set; }
        public Rectangle LeftTextureRectangle { get; private set; }
        public Rectangle LineTextureRectangle { get; private set; }
        public Rectangle RightTextureRectangle { get; private set; }
        public bool ClosedForRetry
        {
            get
            {
                return ClosedByMe;
            }
            set
            {
                ClosedByMe = value;
            }
        }
        #endregion
        //-------------------------------------------------
        #region field's Region
        
        #endregion
        //-------------------------------------------------
        #region Constructor's Region
        internal NoInternetConnectionSandBox() : base()
        {
            InitializeComponent();
        }
        #endregion
        //-------------------------------------------------
        #region Destructor's Region
        ~NoInternetConnectionSandBox()
        {
            return;
        }
        #endregion
        //-------------------------------------------------
    }
}
