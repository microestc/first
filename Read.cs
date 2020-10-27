namespace First
{
    public class Read
    {
        public string Id {get;set;}

        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        
    }
}