namespace CheckToListOfDict
{
    public class DictionaryIdComparer : IEqualityComparer<IDictionary<string, object>>
    {
        public bool Equals(IDictionary<string, dynamic> x, IDictionary<string, dynamic> y)
        {
            if (x == null || y == null)
                return false;

            return x.TryGetValue("Id", out var xId) && y.TryGetValue("Id", out var yId) && xId == yId;
        }

        public int GetHashCode(IDictionary<string, dynamic> obj)
        {
            if (obj == null)
                return 0;

            return obj.TryGetValue("Id", out var id) ? id.GetHashCode() : 0;
        }
    }
}
