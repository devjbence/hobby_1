namespace Model.Enums
{
    /// <summary>
    /// Objektum elhelyezkedése
    /// </summary>
    public enum ObjectsDepth
    {
        /// <summary>
        /// Az objektum a háttérben helyezkedik el. Ekkor csak látvány elem. Fizikai kontaktus vele nincsen.
        /// Pl. egy távoli hegy.
        /// </summary>
        Background,

        /// <summary>
        /// Az objektum a játékossal azonos mélységi szinten helyezkedik el, azaz potenciális akadály.
        /// </summary>
        Middle,

        /// <summary>
        /// Az objektum az előtérben helyezkedik el. Ekkor csak látvány elem. Fizikai kontaktus vele nincsen.
        /// Pl. egy virág, vagy egy fal ami a képernyőhöz közel esik.
        /// </summary>
        Foreground
    }
}
