

class Nullable_Ex2
{
    BidManager _bidManager = new BidManager();

    /*
     * _bidManager could be null, GetBids could return null array, etc.
     */
    internal string GetTopBidderName()
    {
        return _bidManager.GetBids()[0,0];
    }

    private string? GetTopBidderName_TakeTwo()
    {

        if (_bidManager == null) return null;

        string[,]? bids = _bidManager.GetBids();
        if (bids == null)
        {
            return null;
        }

        string? topBidName = bids[0,0];
        if (topBidName == null)
        {
            return null;
        }

        return topBidName;

    }

    /*
     * Both of these operators evaluate the part before it to see if it is null.
     * Is it is, no further evaluation happens and the whole expression evaluates to null.
     */
    private string? GetTopBidderName_TakeThree()
    {
        return _bidManager?.GetBids()?[0,0]; //notice, if 1d array could add another ? at end, doesn't work with [][]
    }


}

class BidManager()
{
    
    private string[,] bidInfoArray = new string[3, 2]; // Example: 3 bidders

    // Populate the array
    private void populateBids()
    {
        string[,] bidInfoArray = new string[3, 2]
        {
            { "Alice", "250" },
            { "Bob", "194" },
            { "Charlize", "200" }
        };

    }
    internal string[,] GetBids()
    {
        return bidInfoArray;
    }
}