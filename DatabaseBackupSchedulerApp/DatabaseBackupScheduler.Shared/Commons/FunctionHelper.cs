using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupScheduler.Shared.Commons
{
    public static class FunctionHelper
    {
        public static string ErrorStringBuilder(string message,
            string details)
        {
            StringBuilder errors = new();
            errors.AppendLine($"{message}");
            errors.AppendLine("");
            errors.AppendLine($"Details:");
            errors.AppendLine($"{details}");
            return errors.ToString();
        }

        public static string ErrorListToStringBuilder(List<string> error)
        {
            StringBuilder errors = new();
            foreach (var item in error)
                errors.AppendLine($"-{item}");
            return errors.ToString();
        }
    }
}
