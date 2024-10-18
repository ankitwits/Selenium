using OnlineWebapplication.Driver;


namespace OnlineWebapplication.Factory
{
    internal class BrowserFactory
    {
        public static IBrowser GetBrowser(string browsertype)
        {
            switch (browsertype.ToLower())
            {
                case "chrome":
                    return new ChromeBrowser();
                case "endge":
                    return new EdgeBrowser();

                default:
                    throw new NotImplementedException();
            
            
            
            }
              
                   
                       
        }
        
        
    }
}
