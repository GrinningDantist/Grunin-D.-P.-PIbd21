using System.Drawing;

namespace Ships
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);

        void Repaint(Color color);
    }
}
