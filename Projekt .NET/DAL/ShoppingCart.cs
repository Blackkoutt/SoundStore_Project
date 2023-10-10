namespace Projekt_.NET.DAL
{
    public class ShoppingCart
    {
        private List<int> AlbumID;

        public void Load(string cookie)
        {
            AlbumID = new List<int>();
            if (cookie == null)
                return;
            else
            {
                var idAlbum = cookie.Split(' ');
                for(int i = 0; i < idAlbum.Length - 1; i++)
                {
                    int id = int.Parse(idAlbum[i]);
                    AlbumID.Add(id);
                }
            }
        }
        public string Save()
        {
            string result = "";
            foreach (var id in AlbumID)
                result = result + $"{id} ";
            return result;
        }
        public void Add(int id)
        {
            AlbumID.Add (id);
        }
        public void Remove(int id) 
        {
            AlbumID.RemoveAll(x => (x == id));

        }
        public int Find(int id)
        {
            return AlbumID.FindIndex(p => (p == id));
        }
        public bool Contains(int id)
        {
            return AlbumID.Contains(id);
        }
        public List<int> List()
        {
            return AlbumID;
        }
        public void Clear()
        {
            AlbumID.Clear();
        }
    }
}
