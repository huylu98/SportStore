namespace ServerApp.Models {
    public class Rating {
        public long RatingID { get; set; }
        public int Stars { get; set; }
        public Product Product { get; set; }
    }
}