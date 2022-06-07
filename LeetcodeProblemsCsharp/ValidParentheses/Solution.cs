// https://leetcode.com/problems/valid-parentheses/
public class Solution
{
    public static bool IsValid(string s)
    {
        /*
         * Only chars '(' -> ')', '{', '}', '[', ']'
         *  have a helper method that returns the opposite: '(' return ')'
         *  open brackets must be closed
         *  open brackets must be in the correct order
         *  
         *  Alg
         *      use a stack
         *      if you see an open paranthese, push the opposite
         *      if you see a closed paranthese, pop it and check that it's equals to the item
         *          if it's not, then reject and return false
         *    
         *   Edge case
         *      ({[]})      ){] ]
         *      (){}[{}]
         *      ()
         *      ([)
         *      
         *   Examples
         *      ()
         *      ()[]{}
         *      {[]}
         */
        if (s.Count() <= 1) return false;
        else if (s.Count() % 2 == 1) return false;

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (IsOpenParenthese(c))
                stack.Push(GetClosedParenthese(c));
            else if (stack.Count == 0 || stack.Pop() != c) 
                return false;
        }

        return stack.Count() == 0;
    }

    private static bool IsOpenParenthese(char c)
    {
        return new char[] { '(', '{', '[' }.Contains(c);
    }

    private static char GetClosedParenthese(char c)
    {
        return c switch
        {
            '(' => ')',
            '{' => '}',
            '[' => ']',
            _ => throw new NotImplementedException()
        };
    }
}
