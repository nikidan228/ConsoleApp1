public class BlockedCard : Card
{
	private string _blockReason;
    private object CardNumber;
    private object CardHolder;
    private object ExpirationDate;
    private object CVV;
    private bool IsBlocked;

    public string BlockReason
	{
		get { return _blockReason; }
		set
		{
			if (!string.IsNullOrEmpty(value))
				_blockReason = value;
			else
				throw new ArgumentException("Block reason cannot be empty");
		}
	}

	void PrintInfo()
	{
		Console.WriteLine($"Card number: {CardNumber}");
		Console.WriteLine($"Card holder: {CardHolder}");
		Console.WriteLine($"Expiration date: {ExpirationDate}");
		Console.WriteLine($"CVV: {CVV}");
		Console.WriteLine($"Status: {(IsBlocked ? "Blocked" : "Active")}");
		if (IsBlocked)
		{
			Console.WriteLine($"Block reason: {BlockReason}");
		}
	}
}