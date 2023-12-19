// Reverse an array without affecting special characters.
using System;
public class Solution 
{ 
	public static void Reverse(char []str) 
	{ 
		// Initialize left and right pointers 
		int r = str.Length - 1, l = 0; 
    
		while (l < r) 
		{ 
			// Ignore special characters 
			if (!char.IsLetter(str[l])) 
				l++; 
			else if(!char.IsLetter(str[r])) 
				r--; 

			// Both str[l] and str[r] are not spacial 
			else
			{ 
				char tmp = str[l]; 
				str[l] = str[r]; 
				str[r] = tmp; 
				l++; 
				r--; 
			} 
		} 
	} 

	public static void Main() 
	{ 
		String str = "a!!!b.c.d,e'f,ghi"; 
		char[] charArray = str.ToCharArray(); 

		Console.WriteLine("Input string: " + str); 
							Reverse(charArray); 
		String revStr = new String(charArray); 

		Console.WriteLine("Output string: " + revStr); 
	} 
} 
