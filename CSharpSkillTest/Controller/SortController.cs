using CSharpSkillTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSkillTest.Controller
{
    public class SortController
    {
        private readonly SortModel _model;
        private ISortStrategy _strategy;

        public SortController(SortModel model)
        {
            _model = model;
        }

        public void SetStrategy(ISortStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SortInput()
        {
            _model.Output = _strategy.Sort(_model.Input);
        }

        public string GetOutput() => _model.Output;
    }
}
