using System;
using System.Collections.Generic;
using System.Text;

namespace Num2Word
{
	public class Num2Words
	{
		string[] teen = { "Zero","Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Ninteen" };
		string[] ones = { "Zero","One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
		string[] tens = { "Zero","Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty"};
		private string getUnitName(string number)
		{
			string word = "";
			int u, t, h;
			if (number.Length == 3)
			{
				h = (int)Char.GetNumericValue(number[0]);
				t = (int)Char.GetNumericValue(number[1]);
				u = (int)Char.GetNumericValue(number[2]);

				if (h == 0 && t == 0 && u == 0)//000
				{
					word = "";
				}
				if (h == 0 && t == 0 && u != 0)//001
				{
					word = word + " " +ones[u];
				}
				if (h == 0 && t != 0 && u == 0)//010
				{
					word = word + tens[t];
				}
				if (h == 0 && t != 0 && u != 0)//011
				{
					if (t == 1)
					{
						word = word + " "+teen[u];
					}
					else
					{
						word = word + tens[t] + " " +ones[u];
					}
				}
				if (h != 0 && t == 0 && u == 0)//100
				{
					word = word + ones[h] + " Hundred";
				}
				if (h != 0 && t == 0 && u != 0)//101
				{
					word = word + ones[h] + " Hundred " + ones[u];
				}
				if (h != 0 && t != 0 && u == 0)//110
				{ 
					word = word + ones[h] + " Hundred " + tens[t];
				}
				if (h != 0 && t != 0 && u != 0)//111
				{
					word = word + ones[h] + " Hundred ";
					if (t == 1)
					{
						word = word + teen[u];
					}
					else
					{
						word = word + tens[t] + " "+ones[u];
					}
				}
			}
			else if (number.Length == 2)
			{
				
				t = (int)Char.GetNumericValue(number[0]);
				u = (int)Char.GetNumericValue(number[1]);
				
				if (t == 0 && u == 0)
				{
					word = "";
				}
				if (t == 0 && u != 0)
				{
					word = word + ones[u];
				}
				if (t != 0 && u == 0)
				{
					word = word + tens[t];
				}
				if (t != 0 && u != 0)
				{
					if (t == 1)
					{
						word = word + teen[u];
					}
					else
					{

						word = word + tens[t] + " " + ones[u];
					}
				}
			}
			else if (number.Length == 1)
			{
				u = (int)Char.GetNumericValue(number[0]);
				word = word + ones[u];
			}
			return word;
		}
 		public string getInWords(long number)
		{
			if (0 > number && number > 99999999999)
			{
				return "Null";
			}
			string words = "";
			string temp = Convert.ToString(number);
			string s1, s2, s3, s4, s5;
			if (temp.Length == 11)
			{
				s1 = "" + temp[0] + temp[1];
				s2 = "" + temp[2] + temp[3];
				s3 = "" + temp[4] + temp[5];
				s4 = "" + temp[6] + temp[7];
				s5 = "" + temp[8] + temp[9] + temp[10];

				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Arab ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Crore ");
				words = (getUnitName(s3) == "" ? words + "" : words + getUnitName(s3) + " Lakh ");
				words = (getUnitName(s4) == "" ? words + "" : words + getUnitName(s4) + " Thousand ");
				words = words + getUnitName(s5);
			}
			if (temp.Length == 10)
			{
				s1 = "0" + temp[0];
				s2 = "" + temp[1] + temp[2];
				s3 = "" + temp[3] + temp[4];
				s4 = "" + temp[5] + temp[6];
				s5 = "" + temp[7] + temp[8] + temp[9];

				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Arab ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Crore ");
				words = (getUnitName(s3) == "" ? words + "" : words + getUnitName(s3) + " Lakh ");
				words = (getUnitName(s4) == "" ? words + "" : words + getUnitName(s4) + " Thousand ");
				words = words + getUnitName(s5);
			}
			if (temp.Length == 9)
			{
				s1 = "" + temp[0] + temp[1];
				s2 = "" + temp[2] + temp[3];
				s3 = "" + temp[4] + temp[5];
				s4 = "" + temp[6] + temp[7] + temp[8];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Crore ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Lakh ");
				words = (getUnitName(s3) == "" ? words + "" : words + getUnitName(s3) + " Thousand ");
				words = words + getUnitName(s4);
			}
			if (temp.Length == 8)
			{
				s1 = "0" + temp[0];
				s2 = "" + temp[1] + temp[2];
				s3 = "" + temp[3] + temp[4];
				s4 = "" + temp[5] + temp[6] + temp[7];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Crore ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Lakh ");
				words = (getUnitName(s3) == "" ? words + "" : words + getUnitName(s3) + " Thousand ");
				words = words + getUnitName(s4);
			}
			if (temp.Length == 7)
			{
				s1 = "" + temp[0] + temp[1];
				s2 = "" + temp[2] + temp[3];
				s3 = "" + temp[4] + temp[5] + temp[6];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Lakh ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Thousand ");
				words = words + getUnitName(s3);
			}
			if (temp.Length == 6)
			{
				s1 = "0" + temp[0];
				s2 = "" + temp[1] + temp[2];
				s3 = "" + temp[3] + temp[4] + temp[5];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Lakh ");
				words = (getUnitName(s2) == "" ? words + "" : words + getUnitName(s2) + " Thousand ");
				words = words + getUnitName(s3);
			}
			if (temp.Length == 5)
			{
				s1 = "" + temp[0] + temp[1];
				s2 = "" + temp[2] + temp[3]+ temp[4];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Thousand ");
				words = words + getUnitName(s2);
			}
			if (temp.Length == 4)
			{
				s1 = "0" + temp[0];
				s2 = "" + temp[1] + temp[2] + temp[3];
				words = (getUnitName(s1) == "" ? words + "" : words + getUnitName(s1) + " Thousand ");
				words = words + getUnitName(s2);
			}
			if (temp.Length == 3)
			{
				s1 = "" + temp[0] + temp[1] + temp[2];
				words = words + getUnitName(s1);
			}
			if (temp.Length == 2)
			{
				s1 = "" + temp[0] + temp[1];
				words = words + getUnitName(s1);
			}
			if (temp.Length == 1)
			{
				words = words + getUnitName(temp);
			}
			return words;
		}
	}
}
