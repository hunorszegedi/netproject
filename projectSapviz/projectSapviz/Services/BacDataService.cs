using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text;

namespace projectSapviz.Services
{
    public class BacDataService
    {
        private readonly HttpClient _http;

        public BacDataService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<BacRecord>> GetRecordsAsync()
        {
            var stream = await _http.GetStreamAsync("data/ms_final.csv");

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ",",
                MissingFieldFound = null,
                BadDataFound = null,
                HeaderValidated = null
            };

            using var reader = new StreamReader(stream, Encoding.UTF8);
            using var csv = new CsvReader(reader, config);

            csv.Context.RegisterClassMap<BacRecordMap>(); // fontos, ha van BacRecordMap

            return csv.GetRecords<BacRecord>().ToList();
        }
    }
}
