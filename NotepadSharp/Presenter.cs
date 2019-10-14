using System;
using NotepadSharpBusinessLogic;

namespace NotepadSharp
{
    class Presenter
    {
        private readonly IFileManager fileManager;
        private readonly INotepadForm notepadForm;
        private string currentPath;

        public Presenter(IFileManager fileManager, INotepadForm notepadForm)
        {
            this.notepadForm = notepadForm;
            this.fileManager = fileManager;

            this.notepadForm.SetSymbolCount(0);
            this.notepadForm.ContentChanged += NotepadForm_ContentChanged;
            this.notepadForm.OpenFileClick += NotepadForm_OpenFileClick;
            this.notepadForm.SaveAsFileClick += NotepadForm_SaveAsFileClick;
            this.notepadForm.SaveFileClick += NotepadForm_SaveFileClick;
        }

        private void NotepadForm_SaveAsFileClick(object sender, EventArgs e)
        {
            string filePath = notepadForm.FilePath;
            currentPath = filePath;
            NotepadForm_SaveFileClick(sender, e);

        }

        private void NotepadForm_SaveFileClick(object sender, EventArgs e)
        {
            string content = notepadForm.Content;
            fileManager.SaveContent(content, currentPath);
        }

        private void NotepadForm_OpenFileClick(object sender, EventArgs e)
        {
            string filePath = notepadForm.FilePath;
            currentPath = filePath;
            string content = fileManager.GetContent(filePath);
            notepadForm.Content = content;

            int symbolCount = fileManager.Count(content);
            notepadForm.SetSymbolCount(symbolCount);

        }

        private void NotepadForm_ContentChanged(object sender, EventArgs e)
        {
            string content = notepadForm.Content;

            int symbolCount = fileManager.Count(content);

            notepadForm.SetSymbolCount(symbolCount);
        }


    }
}
