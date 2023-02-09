string input = Console.ReadLine();

Stack<char> openBrackets = new Stack<char>();
bool isBalanced = false;
foreach (char bracket in input)
{
	if (bracket == '{' || bracket == '[' || bracket == '(')
	{
		openBrackets.Push(bracket);
	}
	else if (bracket == '}' || bracket == ']' || bracket == ')')
	{
		if (openBrackets.Count == 0)
		{
			isBalanced = false;
			break;
		}
		char lastOpen = openBrackets.Pop();
		if (lastOpen == '{' && bracket == '}')
		{
			isBalanced = true;
		}
		else if (lastOpen == '[' && bracket == ']')
		{
            isBalanced = true;
        }
		else if (lastOpen == '(' && bracket == ')')
		{
            isBalanced = true;
		}
		else
		{
			isBalanced = false;
			break;
		}
		

		
	}

}

if (isBalanced)
{
	Console.WriteLine("YES");
}
else
{
	Console.WriteLine("NO");
}