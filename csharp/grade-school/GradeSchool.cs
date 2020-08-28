using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<int, List<string>> _StudentRoster = new Dictionary<int, List<string>>();

    public void Add(string student, int grade)
    {
        if (!_StudentRoster.ContainsKey(grade))
        {
            _StudentRoster.Add(grade, new List<string>{student});
        }
        else
        {
            _StudentRoster[grade].Add(student);
            _StudentRoster[grade].Sort();
        }
    }

    public IEnumerable<string> Roster()
    {
        List<string> students = new List<string>();
        List<int> grades = new List<int> (_StudentRoster.Keys);
        foreach (int grade in grades.OrderBy(g => g))
        {
            foreach (string student in _StudentRoster[grade])
            {
                students.Add(student);
            }
        }
        return students;
    }

    public IEnumerable<string> Grade(int grade)
    {
        throw new NotImplementedException();
    }
}