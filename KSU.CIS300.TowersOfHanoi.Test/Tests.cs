///
/// TestCases.cs
/// Author: Josh Weese
///
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using KSU.CIS300.TowersOfHanoi;
using System;

namespace KSU.CIS300.TowerOfHanoi.Test
{
    [TestFixture]
    public class TestCases
    {
        UserInterface ui;
        [SetUp]
        public void Setup()
        {
            ui = new UserInterface();
            ui.TestMode = true;
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveFromEmpty()
        {
            Stack<int> from = new Stack<int>();
            Stack<int> to = new Stack<int>();
            bool result = ui.CheckMove(from, to);
            Assert.IsFalse(result);
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveToEmpty()
        {
            Stack<int> from = new Stack<int>();
            from.Push(1);
            Stack<int> to = new Stack<int>();
            bool result = ui.CheckMove(from, to);
            Assert.IsTrue(result);
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveBiggerDisc()
        {
            Stack<int> from = new Stack<int>();
            from.Push(10);
            Stack<int> to = new Stack<int>();
            to.Push(5);
            bool result = ui.CheckMove(from, to);
            Assert.IsFalse(result);
        }

        [Test]
        [Category("A CheckMove")]
        public void CheckMoveSmallerDisc()
        {
            Stack<int> from = new Stack<int>();
            from.Push(5);
            Stack<int> to = new Stack<int>();
            to.Push(10);
            bool result = ui.CheckMove(from, to);
            Assert.IsTrue(result);
        }

        [Test]
        [Category("B Move")]
        public void MoveInvalid()
        {
            Stack<int> from = new Stack<int>();
            from.Push(10);
            Stack<int> to = new Stack<int>();
            to.Push(5);
            bool result = ui.MoveDisc(from, to);
            Assert.IsFalse(result);
            Assert.AreEqual(1, from.Count);
            Assert.AreEqual(1, to.Count);
            Assert.AreEqual(10, from.Pop());
            Assert.AreEqual(5, to.Pop());
        }

        [Test]
        [Category("B Move")]
        public void MoveValid()
        {
            Stack<int> from = new Stack<int>();
            from.Push(5);
            Stack<int> to = new Stack<int>();
            to.Push(10);
            bool result = ui.MoveDisc(from, to);
            Assert.IsTrue(result);
            Assert.AreEqual(1, ui.Moves);
            Assert.AreEqual(0, from.Count);
            Assert.AreEqual(2, to.Count);
            Assert.AreEqual(5, to.Pop());
            Assert.AreEqual(10, to.Pop());
        }

        [Test]
        [Category("C MoveEither")]
        public void MoveEitherX()
        {
            Stack<int> from = new Stack<int>();
            from.Push(5);
            Stack<int> to = new Stack<int>();
            to.Push(10);
            ui.MoveEither(from, to);

            Assert.AreEqual(1, ui.Moves);
            Assert.AreEqual(0, from.Count);
            Assert.AreEqual(2, to.Count);
            Assert.AreEqual(5, to.Pop());
            Assert.AreEqual(10, to.Pop());
        }

        [Test]
        [Category("C MoveEither")]
        public void MoveEitherY()
        {
            Stack<int> x = new Stack<int>();
            x.Push(10);
            Stack<int> y = new Stack<int>();
            y.Push(5);
            ui.MoveEither(x, y);
            Assert.AreEqual(1, ui.Moves);
            Assert.AreEqual(0, y.Count);
            Assert.AreEqual(2, x.Count);
            Assert.AreEqual(5, x.Pop());
            Assert.AreEqual(10, x.Pop());
        }

        [Test]
        [Category("C MoveEither")]
        public void MoveEitherNeither()
        {
            Stack<int> x = new Stack<int>();
            Stack<int> y = new Stack<int>();
            ui.MoveEither(x, y);
            Assert.AreEqual(0, y.Count);
            Assert.AreEqual(0, x.Count);
        }

        private void LoadPuzzle(int count)
        {
            ui.NewPuzzle(count);
        }

        [Test]
        [Category("D Solve")]
        public void SolveEven()
        {
            LoadPuzzle(6);
            ui.Solve(ui.PegB, ui.PegC, 0);
            Assert.AreEqual(0, ui.PegA.Count);
            Assert.AreEqual(0, ui.PegB.Count);
            Assert.AreEqual(6, ui.PegC.Count);
            Assert.AreEqual(Math.Pow(2, 6) - 1, ui.Moves);
        }

        [Test]
        [Category("D Solve")]
        public void SolveOdd()
        {
            LoadPuzzle(7);
            ui.Solve(ui.PegC, ui.PegB, 0);
            Assert.AreEqual(0, ui.PegA.Count);
            Assert.AreEqual(0, ui.PegB.Count);
            Assert.AreEqual(7, ui.PegC.Count);
            Assert.AreEqual(Math.Pow(2, 7) - 1, ui.Moves);
        }



    }
}
