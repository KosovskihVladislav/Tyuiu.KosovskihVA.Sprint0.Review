﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KosovskihVA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(35, DataService.Calc(2, 2, 3));
        }
    }
}
