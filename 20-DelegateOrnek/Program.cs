namespace _20_DelegateOrnek
{
    internal class Program
    {
        public delegate void LoggerHandler(string msg);
        static void Main(string[] args)
        {
            LoggerHandler logger = new LoggerHandler(FileLog);
            logger += DbLog;
            logger += SmsLog;
            logger += MailLog;

            logger -= SmsLog;

            try
            {
                int a = 2, b = 0;
                int sonuc = a / b;
            }
            catch (Exception ex)
            {
                //FileLog(ex.Message);
                //DbLog(ex.StackTrace);
                //MailLog(ex.StackTrace);
                //SmsLog(ex.StackTrace);
                logger.Invoke(ex.Message);

            }
        }

        //
        public static void Logla(LoggerHandler loger,string msg)
        {
            loger.Invoke(msg);
        }
        public static void FileLog(string msg)
        {
            Console.WriteLine($"Dosyaya {msg} yazildi");
        }
        public static void DbLog(string msg)
        {
            Console.WriteLine($"Database e {msg} yazildi");
        }
        public static void MailLog(string msg)
        {
            Console.WriteLine($"Mail {msg} atildi");
        }
        public static void SmsLog(string msg)
        {
            Console.WriteLine($"Sms {msg} atildi");
        }
    }
}
