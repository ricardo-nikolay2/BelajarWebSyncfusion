namespace BelajarWebSyncfusion.Entity
{
    public class Pipa
    {
        public decimal? Od { get; set; }
        public decimal? Thickness { get; set; }
        public decimal? Length { get; set; }
        public decimal? Qty { get; set; }

        public decimal? BeratPipa { get; set; }


        public decimal? HargaSetelahDiskon { get; set; }


        public decimal? HitungBerat()
        {
            BeratPipa = ((Od - Thickness) * Thickness * 0.02466m * Length * Qty / 1000);
            return BeratPipa;
        }


       
    }

    
}
