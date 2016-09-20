namespace _06_Book_Titles
{
    public class Book
    {
        string somestring = "";
        
        public string Title
        {
            get { return CutString(somestring); }
            set { this.somestring = value; }
        }

        

        public string CutString(string something)
        {
            string result = "";
            string[] anarray = something.Split(' ');
           
 
            for(int i = 0; i<anarray.Length; i++)
            {
                if(anarray[i] == "the" || anarray[i] == "a" || anarray[i] == "an" 
                    || anarray[i] == "and" || anarray[i] =="in" || anarray[i] == "of")
                {
                    if(i == 0)
                    {
                        result += anarray[i].Substring(0, 1).ToUpper() + anarray[i].Substring(1) + " ";
                    }
                    else
                    {
                        result += anarray[i] + " ";
                    }
                }
                else
                {
                    result += anarray[i].Substring(0, 1).ToUpper() + anarray[i].Substring(1) + " ";
                }
            }
            return result.Trim();
        }
        
    }
}