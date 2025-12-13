using System;
using System.Linq;
using Model;
using View;

namespace Presenter
{
    public class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;

            _view.AddRequested += OnAddRequested;
            _view.DeleteRequested += OnDeleteRequested;
        }

        public void Run()
        {
            _view.ShowStudents(_model.GetAll());
            _view.Run();
        }

        private void OnAddRequested(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.InputName) ||
                string.IsNullOrWhiteSpace(_view.InputSpeciality) ||
                string.IsNullOrWhiteSpace(_view.InputGroup) ||
                string.IsNullOrWhiteSpace(_view.InputId))
            {
                _view.ShowError("Вы должны заполнить все поля!");
                return;
            }

            if (_model.GetAll().Any(s => s.Id == _view.InputId))
            {
                _view.ShowError("Студент с таким номером билета уже существует.");
                return;
            }

            _model.AddStudent(_view.InputId, _view.InputName, _view.InputSpeciality, _view.InputGroup);
            _view.ClearInputs();
            _view.ShowStudents(_model.GetAll());
        }

        private void OnDeleteRequested(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_view.InputId))
            {
                _view.ShowError("Введите номер студенческого билета!");
                return;
            }

            _model.DeleteStudent(_view.InputId);
            _view.ClearInputs();
            _view.ShowStudents(_model.GetAll());
        }
    }
}
