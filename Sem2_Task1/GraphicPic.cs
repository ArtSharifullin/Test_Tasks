

namespace Sem2_Task1
{
    public class GraphicPic
    {
        private List<Segment> segments;

        public GraphicPic(string filename) 
        {
            var segs = File.ReadAllLines(filename);
            var result = new List<Segment>(); 

            foreach (var i in segs)
            {
                var seg = i.Split(',');
                if (seg.Length < 4)
                {
                    throw new Exception("Какой-то из сегментов в файле не имеет координаты");
                }
                
                var s = new Segment(int.Parse(seg[0]), int.Parse(seg[1]), 
                    int.Parse(seg[2]), int.Parse(seg[3]));

                var f = true;
                if (result.Count > 0)
                {
                    foreach (var o in result)
                    {
                        if (o.X1 == s.X1 && o.Y1 == s.Y1 && o.X2 == s.X2 && o.Y2 == s.Y2)
                        {
                            f = false;
                            break;
                        }
                    }
                }
                if (f) { result.Add(s); }
            }
            segments = result;

        }

        public GraphicPic(List<Segment> s) 
        {
            segments = s;
        }

        public void Show()
        {
            Console.WriteLine("  N    x1    y1    x2    y2    angle    length");
            var count = 1;
            foreach (var seg in segments)
            {
                var s = $"{count,3}   {seg.X1,3}   {seg.Y1,3}   {seg.X2,3}   {seg.Y2,3}     {seg.Angle(),3}      {seg.Len(),3}";
                count++;
                Console.WriteLine(s);
            }
        }

        public void Insert(Segment s) 
        {
            var f = true;
            foreach (var seg in segments)
            {
                if (seg.X1 == s.X1 && seg.Y1 == s.Y1 && seg.X2 == s.X2 && seg.Y2 == s.Y2)
                {
                    f = false;
                    break;
                }
            }
            if (f) { segments.Add(s); }
        }

        public GraphicPic angleList()
        {
            var answer = new List<Segment>();
            int[] correct_angles = { 45, 135, -45, -135, 30, -30, 150, -150 };
            foreach (var seg in segments)
            {
                if (correct_angles.Contains(seg.Angle())) 
                {
                    answer.Add(seg);
                }
            }
            return new GraphicPic(answer);
        }

        public GraphicPic lengthList(int a, int b)
        {
            var res = new List<Segment>();
            foreach (var seg in segments)
            {
                var l = seg.Len();
                if (l > a && l < b) { res.Add(seg); }
            }
            return new GraphicPic(res);
        }

        public void Sort()
        {
            //упорядочить список отрезков по возрастанию длин. 
            var n = segments.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (segments[j].Len() > segments[j + 1].Len())
                    {
                        var tempVar = segments[j];
                        segments[j] = segments[j + 1];
                        segments[j + 1] = tempVar;
                    }
        }


    }

    public class Segment
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Segment(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public double Len()
        {
            var dx = X2 - X1;
            var dy = Y2 - Y1;
            var res = Math.Sqrt((dx * dx) + (dy * dy));
            return Math.Round(res,1);
        }

        public int Angle()
        {
            var dx = X2 - X1;
            var dy = Y2 - Y1;
            var a = Math.Atan2(dy, dx);
            return Convert.ToInt32(a * (180 / Math.PI));
        }
    }
}
