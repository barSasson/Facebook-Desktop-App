namespace B16_Ex01_Sapir_201028867_Bar_200959286
{
    using System.Drawing.Imaging;

    // System.Drawing.Imaging.ColorMatrix Wrapper
    public class Filter
    {
        public ColorMatrix PixelFilter { get; set; }

        public string Name { get; set; }

        public Filter(ColorMatrix i_Filter, string i_Name = "Untitled Filter")
        {
            PixelFilter = i_Filter;
            Name = i_Name;
        }

        public Filter(float[][] i_Filter, string i_Name = "Untitled Filter")
        {
            PixelFilter = new ColorMatrix(i_Filter);
            Name = i_Name;
        }

        // Used for Xml serialization
        public Filter()
        {
        }
    }
}
