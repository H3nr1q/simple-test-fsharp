module MathTestsNunit

open NUnit.Framework
open Soma


[<Test>]
let TestNunit () =
    let actual = teste.add 1 4 
    Assert.That(actual, Is.EqualTo 5)
