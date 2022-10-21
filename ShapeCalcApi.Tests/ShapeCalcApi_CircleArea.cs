using Xunit;

using ShapeCalcApi;

namespace ShapeCalcApi.UnitTests
{
    public class ShapeCalcApi_CircleArea
    {
        [Fact]
        public void GetCircleArea_InputIs2_Return12()
        {
            var calculator = new Calculator();
            double result = calculator.GetCircleArea(2);

            Assert.True(result == 12.57, "circle with radius 2 has area of 12.57");
        }
    }
}