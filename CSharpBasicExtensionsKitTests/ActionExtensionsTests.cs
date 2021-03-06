﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasicExtensionsKit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpBasicExtensionsKitTests
{
    [TestClass]
    public class ActionExtensionsTests
    {
        [TestMethod]
        public void Call_WhenNull_DoNotCallAction()
        {
            Action action = null;
            action.Call();
        }

        [TestMethod]
        public void Call_WhenNotNull_DoNotCallAction()
        {
            var bCalled = false;
            Action action = () => bCalled = true;
            action.Call();

            Assert.IsTrue(bCalled);
        }

        [TestMethod]
        public void Call_WhenNotNull_WithParam()
        {
            var bCalled = false;
            Action<bool> action = (x) => bCalled = x;
            action.Call(true);

            Assert.IsTrue(bCalled);
        }
    }
}
