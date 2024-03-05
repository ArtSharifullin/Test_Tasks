using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_Task1
{
    public class GraphicPic
    {
        private List<Segment> segments;

        public GraphicPic(string filename) 
        {
            var result = new List<Segment>();
            var segs = filename.Split(' ');
            foreach (var i in segs)
            {
                var seg = i.Split(",");
                if (seg.Length < 4)
                {
                    throw new Exception("Какой-то из сегментов в файле не имеет координаты");
                }
                seg[0] = int.TryParse;
                var s = new Segment(seg[0], seg[1], seg[2], seg[3]);
            }
            
        }

        public void Show()
        {
            //вывод всех отрезков и информации о них на экран; 
        }

        public void Insert(Segment s) 
        {
            //вставка отрезка в список. При вставке учесть,
            //существует ли подобный элемент в списке, если да – то не добавлять;
        }

        public GraphicPic angleList()
        {
            //построить новый список, состоящий из отрезков,
            //которые наклонены к оси абсцисс под углами 30 и 45 градусов
            throw new NotImplementedException();
        }

        public GraphicPic lengthList()
        {
            //построить новый список из отрезков, длина которых находится в интервале [a,b] 
            throw new Exception();
        }

        public void Sort()
        {
            //упорядочить список отрезков по возрастанию длин. 
        }


    }

    public class Segment
    {
        private int X1;
        private int Y1;
        private int X2;
        private int Y2;

        public Segment(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
    }
}
