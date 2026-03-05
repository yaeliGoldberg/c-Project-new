namespace Tools;

public class LogManager
{

    private const string LOG ="Log";

    public static string GetCurrentFolderPath()
    {
        // נתיב בסיסי של תיקיית Log בתוך bin
        string basePath = Path.Combine(Environment.CurrentDirectory, LOG);

        // שנה
        string yearFolder = Path.Combine(basePath, DateTime.Now.Year.ToString());
        if (!Directory.Exists(yearFolder))
        {
            Directory.CreateDirectory(yearFolder);
        }

        // חודש
        string monthFolder = Path.Combine(yearFolder, DateTime.Now.Month.ToString("D2")); // D2 = 01,02...
        if (!Directory.Exists(monthFolder))
        {
            Directory.CreateDirectory(monthFolder);
        }

        // יום
        string dayFolder = Path.Combine(monthFolder, DateTime.Now.Day.ToString("D2"));
        if (!Directory.Exists(dayFolder))
        {
            Directory.CreateDirectory(dayFolder);
        }

        // מחזירה את נתיב תיקיית היום
        return dayFolder;
    }

    public static string GetCurrentFilePath()
    {
        string folderPath = GetCurrentFolderPath(); // תיקיית היום
        string fileName = $"Log_{DateTime.Now:yyyy_MM_dd}.txt";
        return Path.Combine(folderPath, fileName);
    }


    public static void WriteLog(string project, string funcName, string message)
    {
        // שולף את נתיב הקובץ המתאים לפי היום/חודש/שנה
        string filePath = GetCurrentFilePath();

        // בונה שורת לוג בפורמט קבוע
        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{project}.{funcName}:\t{message}";

        // מוסיף את השורה לקובץ (אם הקובץ לא קיים – נוצר אוטומטית)
        File.AppendAllText(filePath, logEntry + Environment.NewLine);
    }

    public static void CleanOldLogFolders()
    {
        string logsRoot = Path.Combine(Environment.CurrentDirectory, "Logs");
        if (!Directory.Exists(logsRoot))
            return;

        var directories = Directory.GetDirectories(logsRoot);

        // סף לניקוי לפי 60 יום אחורה
        DateTime threshold = DateTime.Now.AddDays(-60);

        foreach (var dir in directories)
        {
            string folderName = Path.GetFileName(dir);
            // Expecting folder name format: Logs_yyyyMM
            if (folderName.StartsWith("Logs_") && folderName.Length == 11)
            {
                string datePart = folderName.Substring(5); // yyyyMM
                if (DateTime.TryParseExact(datePart, "yyyyMM", null, System.Globalization.DateTimeStyles.None, out DateTime folderDate))
                {
                    // השוואה לפי תאריך מדויק
                    // כאן נבדוק את היום הראשון של החודש מול threshold
                    DateTime folderFirstDay = new DateTime(folderDate.Year, folderDate.Month, 1);
                    if (folderFirstDay < threshold)
                    {
                        Directory.Delete(dir, true);
                    }
                }
            }
        }
    }



}
