

namespace Refactoring.Part02.Reports;

public class CsvReportExporter : ReportProcessor
{

    public override string Format(List<string[]> rows) =>
        string.Join(Environment.NewLine, rows.Select(r => string.Join(",", r)));

}
