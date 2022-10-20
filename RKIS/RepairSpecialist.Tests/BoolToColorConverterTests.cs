using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kokarev_LR_RKIS.Testing.Converters;

namespace RepairSpecialist.Tests
{
    public class BoolToColorConverterTests
    {
        // Атрибут [Fact] объявляет метод теста,
        // который выполняется средством выполнения тестов.
        [Fact]
        public void Convert_returns_backgroundcolor_when_item_is_selected()
        {
            // Создаем объект для тестирования
            var converter = new BoolToColorConverter();
            // Передаем методу тестовые параметры
            var result = converter.Convert(true, null, null, null);
            // Проверяем соответствие конечного результата ожидаемому
            Assert.Equal(Colors.BlueViolet, result);
        }
        [Fact]
        public void Convert_returns_transparent_when_item_is_not_selected()
        {
            // Arrange
            var converter = new BoolToColorConverter();
            // Act
            var result = converter.Convert(false, null, null, null);
            // Assert
            Assert.Equal(Colors.Transparent, result);
        }
    }
}
