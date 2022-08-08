namespace BelajarWebSyncfusion.Entity
{
    public class RumusCoil
    {
       
            public decimal? berat { get; set; }
            public decimal? tebal { get; set; }
            public decimal? lebar { get; set; }
            public decimal? panjang { get; set; }

            public decimal? RumusPanjangCoil()
            {
                //decimal panjang;

                panjang = berat * 1000 / (tebal * lebar * 7.85m);
                //panjang = Math.Round((decimal)panjang, 2);
                return panjang; 

            }


       
    }
}
