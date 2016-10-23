using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    enum Coeficient
    {
        C12,
        C13
    }
    enum TipDisciplina
    {
        distribuita,
        examen
    }

    class Disciplina
    {
        private string NumeMaterie;
        private int AnStudiu;
        private Coeficient Coeficient;
        private TipDisciplina TipDisciplina;


        public Disciplina(string NumeMaterie, int AnStudiu, Coeficient Coeficient, TipDisciplina TipDisciplina)
        {
            this.NumeMaterie = NumeMaterie;
            this.AnStudiu = AnStudiu;
            this.Coeficient = Coeficient;
            this.TipDisciplina = TipDisciplina;
        }
    }

    class Note
    {
        private string NumeMaterie;
        private int NotaExamen;
        private int NotaActivitatePeParcurs;

        public Note(string NumeMaterie, int NotaExamen, int NotaActivitatePeParcurs)
        {
            this.NumeMaterie = NumeMaterie;
            this.NotaExamen = NotaExamen;
            this.NotaActivitatePeParcurs = NotaActivitatePeParcurs;
        }
    }

    class Student
    {
        private string Nume;
        private int AnStudiu;

        List<Note> Note = new List<Note>();
        List<Disciplina> Disciplina = new List<Disciplina>();

        public Student(string Nume, int AnStudiu, string email)
        {
            this.Nume = Nume;
            this.AnStudiu = AnStudiu;
        }
    }

    class Profesor
    {

        private string Nume;

        private List<Note> Note = new List<Note>();
        private List<Disciplina> Disciplina = new List<Disciplina>();

        public Profesor(string Nume, string telefon, string email)
        {
            this.Nume = Nume;
        }

    }

    public class Decanat
    {
        string NumeFacultate;
        private List<Student> Student = new List<Student>();
        private List<Profesor> Profesor = new List<Profesor>();
        private List<Disciplina> Disciplina = new List<Disciplina>();
    }

}
