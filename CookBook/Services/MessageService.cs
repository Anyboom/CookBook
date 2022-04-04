using Microsoft.VisualBasic;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.Services
{
    class MessageService
    {
        public static string InputBox(string text) => Interaction.InputBox(text, Variables.TitleProject);
        public static void ShowError(string message) => MessageBox.Show(message, Variables.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        public static void ShowWarn(string message) => MessageBox.Show(message, Variables.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        public static void ShowInfo(string message) => MessageBox.Show(message, Variables.TitleProject, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        public static DialogResult ShowQuestion(string message, MessageBoxButtons buttons) => MessageBox.Show(message, Variables.TitleProject, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
    }
}
