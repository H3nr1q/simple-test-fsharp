namespace MathTestsMSTests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting
open Soma

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member this.TesteMSTest () =
        let actual = teste.add 1 4
        Assert.AreEqual(5, actual)
