using System;
using System.Collections.Generic;

namespace View
{
    public interface IView
    {
        event EventHandler AddRequested;
        event EventHandler DeleteRequested;

        string InputName { get; }
        string InputSpeciality { get; }
        string InputGroup { get; }
        string InputId { get; }

        void ShowStudents(IEnumerable<object[]> students);
        void ShowError(string message);
        void ClearInputs();
        void Run();
    }
}
