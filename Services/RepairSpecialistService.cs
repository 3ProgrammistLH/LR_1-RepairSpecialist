using Kokarev_LR_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kokarev_LR_1.Services
{
    public class RepairSpecialistService
    {
        // Создаем список для хранения данных из источника
        List<RepairSpecialist> repairSpecialistList = new();
        /* Метод GetRepairSpecialist() служит для извлечения и сруктурирования данных
        в соответсвии с существующей моделью данных */
        public async Task<IEnumerable<RepairSpecialist>> GetRepairSpecialist()
        {
            // Если список содержит какие-то элементы то вернется последовательность с содержимым этого списка
            if (repairSpecialistList?.Count > 0)
                return repairSpecialistList;

            /* В данном блоке кода осуществляется подключение, чтение
            и дессериализация файла - источника данных */
            using var stream = await FileSystem.OpenAppPackageFileAsync("RepairSpecialist.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            repairSpecialistList = JsonSerializer.Deserialize<List<RepairSpecialist>>(contents);
            return repairSpecialistList;
        }
    }
}
