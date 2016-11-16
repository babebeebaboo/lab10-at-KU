/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: wordSearch02.cs                   
//DATE: 20 Oct 2016                          
/////////////////////////////////////////////

using System;
class test
{
	static void Main()
	{
		Console.Write("Input Sentence: ");
		string inp = Console.ReadLine();
		string inpup = inp.ToUpper();
		Console.Write("Input Word: ");
		string word = Console.ReadLine();
		string wordup = word.ToUpper();
		bool found=false;
		string ans = "";
		for(int i=0;i<inpup.Length;i++){
			if(inpup[i] == wordup[0] && inpup.Length-wordup.Length-i>0)
			{
				bool same=true;
				for(int j=1;j<wordup.Length;j++)
					if(inpup[i+j] != wordup[j])
						{
							same=false;
							break;
						}
				
				if(same)
				{
					found=true;
					ans = ans+"[";
					for(int j=0;j<wordup.Length;j++)ans = ans+inp[i+j];
					ans = ans+"]";
					i+=word.Length-1;
				}
					
			}
			else 
				ans = ans+inp[i];
		}
		if(found)Console.WriteLine("Found\n{0}",ans);
		else Console.WriteLine("Not found");
	}
}
