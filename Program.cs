Console.WriteLine("Hello, World!!!");
Console.WriteLine("測試 GitHub Copilot PR Extensions.......");
Console.WriteLine("輸入1執行測試 PR 1234; 輸入 2 則正常結束程式。");

var key = Console.ReadKey(intercept: true);
Console.WriteLine();

if (key.KeyChar == '1')
{
    Console.WriteLine("測試 PR 1234 的內容，這裡應該會有一些變更的程式碼。");
}
else if (key.KeyChar == '2')
{
    Console.WriteLine("正常結束程式。");
}
