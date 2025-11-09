namespace launcher.c1;

// Masz klasy Teacher i GradeBook, gdzie Teacher bezpośrednio modyfikuje prywatne pola klasy GradeBook. Twoim zadaniem jest usunięcie tej "zażyłości" i poprawienie struktury kodu.
public class GradeBook
{
    private int _grade;
    private bool _isFinalized;
    public int Grade { get { return _grade; } }
    public bool IsFinalized { get { return _isFinalized; } }

    public void SetGrade(int grade)
    {
        _grade = grade;
    }

    public void FinalizeGrade()
    {
        _isFinalized = true;
    }
}

public class TeacherLongMethod
{
    public void FinalizeGrades(GradeBook gradeBook)
    {
        gradeBook.SetGrade(90);
        gradeBook.FinalizeGrade();
        // gradeBook.Grade = 90; // Bezpośrednie ustawianie prywatnych pól
        // gradeBook.IsFinalized = true; // Bezpośrednie ustawianie prywatnych pól
    }
}
// Kroki do wykonania:
//
// Usuń bezpośredni dostęp do prywatnych pól klasy GradeBook w metodach klasy Teacher.
// Wprowadź metody publiczne w klasie GradeBook do modyfikowania jej stanu (SetGrade, Finalize).
// Zastąp bezpośrednie ustawienia metodami publicznymi.
