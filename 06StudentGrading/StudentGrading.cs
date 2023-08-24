//97 - 100   A +
//93 - 96    A
//90 - 92    A-
//87 - 89    B+
//83 - 86    B
//80 - 82    B-
//77 - 79    C+
//73 - 76    C
//70 - 72    C-
//67 - 69    D+
//63 - 66    D
//60 - 62    D-
//0  - 59    F

//Student Grade

//Sophia:         92.2    A -
//Andrew:         89.6    B +
//Emma:           85.6    B
//Logan:          91.2    A -

// initialize variables - graded assignments 
int examAssignments = 5; // 시험 과목수

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 }; 
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// student name
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

// 현재 학생 시험 등급
string currentStudentLetterGrade = "";

// current현재의

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;


    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    int gradeAssignments = 0;

    foreach (int score in studentScores)
    {
        gradeAssignments += 1;
        if (gradeAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";



    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");


}





Console.WriteLine("Press the Enter key to conticue");
Console.ReadLine();


//int sophia1 = 90;
//int sophia2 = 86;
//int sophia3 = 87;
//int sophia4 = 98;
//int sophia5 = 100;

//int andrew1 = 92;
//int andrew2 = 89;
//int andrew3 = 81;
//int andrew4 = 96;
//int andrew5 = 90;

//int emma1 = 90;
//int emma2 = 85;
//int emma3 = 87;
//int emma4 = 98;
//int emma5 = 68;

//int logan1 = 90;
//int logan2 = 95;
//int logan3 = 87;
//int logan4 = 88;
//int logan5 = 96;

// 시험 합계 정수 변수
//int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
//int andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
//int emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
//int loganSum = logan1 + logan2 + logan3 + logan4 + logan5; ;

// 시험 평균 실수 변수
//decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
//decimal andrewScore = (decimal)andrewSum / currentAssignments;
//decimal emmaScore = (decimal)emmaSum / currentAssignments; 
//decimal loganScore = (decimal)loganSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA");

//Console.WriteLine("Press the Enter key to contnue");
//Console.ReadLine();



















