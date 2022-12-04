using HC_API.Utils.Interface;
using System.Text;

namespace HC_API.Utils.Concrete
{
    public class FileLogger : ILoggerService
    {
        private StringBuilder _sb;
        public StringBuilder sb
        {
            get
            {
                if (_sb == null)
                {
                    _sb = new StringBuilder();
                }
                return _sb;
            }
        }

        public void Log(string message)
        {
            string path = @"C:\Logs\HC_Logs.txt"; //todo: Dosyanın kaydedileceği dizin, dinamik hale getirilecek.
            try
            {
                sb.AppendLine(); //Bir satır altına ekleme işlemi yapar.
                File.AppendAllText(path, message);
            }
            catch (Exception ex)
            {
                sb.Append("PROBLEM HERE!");
                sb.AppendLine();
                File.AppendAllText(path, ex.Message);
            }
        }
    }
}
