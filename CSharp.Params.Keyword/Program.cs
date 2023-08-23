//params


//LogAudit(new object[] { 1, "abc", true });


LogAudit(1, "abc", true);

LogAudit(10, 200);

//LogAudit();


static void LogAudit(params object[] values)
{
    foreach (var value in values)
    {
        Console.WriteLine(value);
    }
}