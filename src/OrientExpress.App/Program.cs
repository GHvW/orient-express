using System;
using System.Linq.Expressions;

namespace OrientExpress.App {

    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Expression<Func<int, int, int>> add = (x, y) => x + y;

            var body = add.Body;
            var type = add.Type;
            var it = add.NodeType;
            var i = add.Parameters;
            var j = add.ToString();
            var yet = add.Name;
            var another = add.CanReduce;

            Console.WriteLine($"Body: {body}, Type: {type}, Node Type: {it}, To stringed: {j}, Name: {yet}");
        }
    }
}
