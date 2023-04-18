using NUnit.Framework;

namespace ValidParentheses;

[TestFixture]
public class SampleTests
{
    [Test]
    public void TestValidParentheses()
    {
        DoTest(true, "()");
        DoTest(true, "((()))");
        DoTest(true, "()()()");
        DoTest(true, "(()())()");
        DoTest(true, "()(())((()))(())()");
    }

    [Test]
    public void TestInvalidParentheses()
    {
        DoTest(false, ")(");
        DoTest(false, "()()(");
        DoTest(false, "((())");
        DoTest(false, "())(()");
        DoTest(false, ")()");
        DoTest(false, ")");
    }

    [Test]
    public void TestEmptyString()
    {
        DoTest(true, "");
    }

    private void DoTest(bool expected, string str)
    {
        Assert.AreEqual(expected, Kata.ValidParentheses(str), $"Incorrect answer for str = \"{str}\"");
    }
}