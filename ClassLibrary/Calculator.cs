using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Calculator
    {
            private readonly ILogger _logger;

            public Calculator(ILogger logger)
            {
                _logger = logger;
            }

            public int Divide(int a, int b)
            {
                try
                {
                    _logger.Info($"Dividing {a} by {b}");
                    var result = a / b;
                    _logger.Debug($"Result of division: {result}");
                    return result;
                }
                catch (DivideByZeroException ex)
                {
                    _logger.Error($"Division by zero: {ex.Message}");
                    throw;
                }
            }
    }
}
