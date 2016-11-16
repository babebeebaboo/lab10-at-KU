using System;
class cpe3
{
    //string [] cpe;
    static void Main() 
    {
        Console.Write("Input n : ");
        int n = int.Parse(Console.ReadLine());
        string [] cpe = new string [2*n-1];
        mkPattern(cpe,n);
        printGif(cpe,n);
    }

    static void mkPattern(string [] cpe, int n)
    {
        for(int row = 0;row < 2*n-1; row++)
        {
            drawLeftArrow(n,row,cpe);
            cpe[row] += " ";
            drawC(n,row,cpe);
            cpe[row] += " ";
            drawP(n,row,cpe);
            cpe[row] += " ";
            drawE(n,row,cpe);
            cpe[row] += " ";
            drawRightArrow(n,row,cpe);
        }
    }

    static void printGif(string [] cpe,int n)
    {
        int count = 0;
        bool countUp = true;
        while(true){
            Console.Clear();
            for(int row = 0;row<cpe.Length;row++)
            {
                for(int nbSpace = 0;nbSpace < n*count;nbSpace++)
                    Console.Write(" ");
                Console.WriteLine(cpe[row]);
            }
            count = updateCount(count, countUp);
            countUp = updateCountStatus(count, countUp);
            System.Threading.Thread.Sleep((int)System.TimeSpan.FromSeconds(0.5).TotalMilliseconds);
        }
    }

    static int updateCount (int count, bool countUp)
    {
        if(countUp == true)
            count++;
        else
            count--;
        return count;
    }

    static bool updateCountStatus(int count,bool countUp)
    {
        int maxCount = 6;
        if(count == maxCount)
            countUp = false;
        if(count == 0)
            countUp = true;
        return countUp;
    }

    static void drawLeftArrow(int n, int row, string [] cpe)
    {
        if(row < n)
        {
            for(int nbSpace = 0;nbSpace < n-row-1;nbSpace++)
                cpe[row] += " ";
            for(int nbX = 0;nbX <= row;nbX++)
                cpe[row] += "X";
        } 
        else 
        {
            for(int nbSpace = n;nbSpace <= row;nbSpace++)
                cpe[row] += " ";
            for(int nbX = row;nbX < 2*n-1;nbX++)
                cpe[row] += "X";
        }
    }
    
    static void drawRightArrow(int n, int row, string [] cpe)
    {
        if(row < n)
        {
            for(int nbX = 0;nbX <= row;nbX++)
                cpe[row] += "X";
        } 
        else 
        {
            for(int nbX = row;nbX < 2*n-1;nbX++)
                cpe[row] += "X";
        }
    }

    static void drawC(int n, int row, string [] cpe)
    {
        if(row == 0 || row == 2*(n-1))
        {
            for(int nbX = 0;nbX < n;nbX++)
                cpe[row] += "X";
        } 
        else 
        {
            cpe[row] += "X";
            for(int nbSpace = 0;nbSpace < n-1;nbSpace++)
                cpe[row] += " ";
        }
    }

    static void drawP(int n, int row, string [] cpe)
    {
        if(row == 0 || row == n-1)
        {
            for(int nbX = 0;nbX < n;nbX++)
                cpe[row] += "X";
        }
        else if(row > 0 && row < n-1)
        {
            cpe[row] += "X";
            for(int nbSpace = 0 ;nbSpace < n-2;nbSpace++)
                cpe[row] += " ";
            cpe[row] += "X";
        }
        else
        {
            cpe[row] += "X";
            for(int nbSpace = 0 ;nbSpace < n-1;nbSpace++)
                cpe[row] += " ";
        }
    }

    static void drawE(int n, int row, string [] cpe)
    {
        if(row==0 || row == n-1 || row ==2*(n-1))
        {
            for(int nbX = 0;nbX < n;nbX++)
                cpe[row] += "X";
        }
        else
        {
            cpe[row] += "X";
            for(int nbSpace = 0;nbSpace < n-1;nbSpace++)
                cpe[row] += " ";
        }
    }
}
