using System;
using System.Collections.Generic;
using bus;

namespace ViewContracts
{
    public interface IView
    {
        event EventHandler AddRequested;
        event EventHandler DeleteRequested;

        string InputName { get; }
        string InputSpeciality { get; }
        string InputGroup { get; }
        string InputId { get; }

        void ShowStudents(IEnumerable<Student> students);
        void ShowError(string message);
        void ClearInputs();
        void Run();
    }
}
