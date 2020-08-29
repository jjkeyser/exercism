using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private SortedDictionary<int,SortedSet<string>> _SchoolRoster = new SortedDictionary<int, SortedSet<string>>();

    public void Add(string student, int grade)
    {
        if (!_SchoolRoster.ContainsKey(grade))
        {
            _SchoolRoster.Add(grade, new SortedSet<string>{student});
        }
        else
        {
            _SchoolRoster[grade].Add(student);
        }
    }

    public IEnumerable<string> Roster()
    {
        var students = new List<string>();
        foreach (int grade in _SchoolRoster.Keys)
        {
            foreach (string student in _SchoolRoster[grade])
            {
                students.Add(student);
            }
        }
        return students;
    }

    public IEnumerable<string> Grade(int grade) => _SchoolRoster.ContainsKey(grade) ? _SchoolRoster[grade].ToArray() : new String[0];
}