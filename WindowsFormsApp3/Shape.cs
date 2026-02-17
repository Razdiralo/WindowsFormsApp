using System.Xml.Serialization;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Shape
    {
        public string Type { get; set; } = "";
        public string Text { get; set; } = "";

        public float Size { get; set; } = 1f;

        public PointF Position { get; set; }

        [XmlIgnore]
        public Color Color { get; set; } = Color.Black;

        [XmlElement("Color")]
        public string ColorHtml
        {
            get => ColorTranslator.ToHtml(Color);
            set => Color = ColorTranslator.FromHtml(value);
        }

        public bool ShouldSerializeText() => !string.IsNullOrEmpty(Text);
        public bool ShouldSerializeColorHtml() => Color != Color.Black;
    }
}