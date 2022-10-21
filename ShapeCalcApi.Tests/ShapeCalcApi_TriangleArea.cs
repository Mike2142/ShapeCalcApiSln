using Xunit;

using ShapeCalcApi;

namespace ShapeCalcApi.UnitTests
{
    public class ShapeCalcApi_TriangleArea
    {
        [Fact]
        public void GetTriangleArea_InputIs2_3_4_Return3()
        {
            var calculator = new Calculator();
            double result = calculator.GetTriangleArea(2.1, 3, 4);

            Assert.True(result == 3.08, "triangle with side of 2.1, 3 and 4 has area of 3.08");
        }
    }
}