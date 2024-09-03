using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Alunos_Curso {
    internal class Program {
        static void Main(string[] args) {

           
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            cursoA.Add(21);
            cursoA.Add(35);
            cursoA.Add(22);

            cursoB.Add(21);
            cursoB.Add(50);

            cursoC.Add(42);
            cursoC.Add(35);
            cursoC.Add(13);

            HashSet<int> totalAlunos = new HashSet<int>();
            
            totalAlunos = cursoA;
            totalAlunos.UnionWith(cursoB);
            totalAlunos.UnionWith(cursoC);

            Console.WriteLine($"\nTotal de alunos inscritos: {totalAlunos.Count()}");
            

        }
    }
}
