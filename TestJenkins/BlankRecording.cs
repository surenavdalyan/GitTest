﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TestJenkins
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BlankRecording recording.
    /// </summary>
    [TestModule("930e727f-f4b3-4ab8-bfc1-42479f348513", ModuleType.Recording, 1)]
    public partial class BlankRecording : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TestJenkinsRepository repository.
        /// </summary>
        public static TestJenkinsRepository repo = TestJenkinsRepository.Instance;

        static BlankRecording instance = new BlankRecording();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BlankRecording()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BlankRecording Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
