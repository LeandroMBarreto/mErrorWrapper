﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MlIB.Reply.Tests.Unit.Stubs;

namespace MlIB.Reply.Tests.Unit.Features
{
    [TestClass]
    public class prototype
    {

        [TestMethod]
        [Ignore]
        public void Reply_Exception_voidMethod_ok_NotThrowing()
        {
            var res = M.Reply.From(VoidMethods.PlayStaticSound);

            Assert.IsFalse(res.HasError);
        }

        [TestMethod]
        [Ignore]
        public void Reply_Exception_voidMethod_ok_Throwing()
        {
            var res = M.Reply.From(VoidMethods.PlayInexistentSound);
            
            var ex = new InvalidOperationException("ain't hear no song at all but buggy noises.");

            Assert.IsTrue(res.HasError);
            Assert.IsTrue(res.HasErrorMessage);
            Assert.AreEqual(ex.Message, res.ErrorMessage);
            Assert.AreEqual(ex.GetType(), res.Value.GetType());
        }

    }
}
