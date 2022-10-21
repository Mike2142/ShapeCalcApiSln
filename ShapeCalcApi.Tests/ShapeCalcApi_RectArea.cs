using Xunit;

using ShapeCalcApi;

namespace ShapeCalcApi.UnitTests
{
    public class ShapeCalcApi_RectangleArea
    {
        [Fact]
        public void GetRectArea_InputIs2_3_Return6()
        {
            var calculator = new Calculator();
            double result = calculator.GetRectArea(2.1, 3);

            Assert.True(result == 6.3, "rectangular with sides of 2.1 and 3 has area of 6.3");
        }
    }
}