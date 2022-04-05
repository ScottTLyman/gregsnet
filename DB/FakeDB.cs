using gregsnet.Models;

namespace gregsnet.DB;
public static class FakeDB
{
  public static List<Car> Cars { get; set; } = new List<Car>(){
new Car("Honda", "Wombat", "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F210129094224-common-wombat-stock.jpg", 2001, 2001),
new Car("Suzuki", "Forrest-er", "https://static.onecms.io/wp-content/uploads/sites/20/2020/06/03/MSDFOGU_EC001_preview.jpg", 1994, 1),
new Car("Brown", "TM-01", "https://images.hgmsites.net/hug/delorean-time-machine-from-back-to-the-future-photo-by-petersen-automotive-museum_100792849_h.jpg", 1982, 1000000)
};
}