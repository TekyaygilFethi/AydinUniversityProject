using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;

namespace AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers
{
    public class EducationOpsComplexManager : BaseComplexManager
    {
        EducationManager educationManager;
        ScoreManager scoreManager;
        NoteManager noteManager;
        PeriodManager periodManager;
        LessonManager lessonManager;
        StudentManager studentManager;

        public EducationOpsComplexManager()
        {
            educationManager = base.GetManager<EducationManager>();
            scoreManager = base.GetManager<ScoreManager>();
            noteManager = base.GetManager<NoteManager>();
            periodManager = base.GetManager<PeriodManager>();
        }

        public TransactionObject AddEducation(AddEducationFormData auFormData)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                Period currentPeriod = periodManager.GetPeriod(auFormData.Year, auFormData.Semester);
                Student selectedStudent = studentManager.GetStudent(auFormData.StudentID);

                if (!(educationManager.IsEducationExists(currentPeriod.ID, auFormData.LessonName)))
                {
                    Lesson newLesson = new Lesson
                    {
                        Name = auFormData.LessonName
                    };

                    Education newEducation = new Education
                    {
                        Lesson = newLesson,
                        Period = currentPeriod,
                        Student = selectedStudent
                    };

                    currentPeriod.Educations.Add(newEducation);
                    newLesson.Educations.Add(newEducation);
                    selectedStudent.Educations.Add(newEducation);

                    Save();
                }
                else
                {
                    response.IsSuccess = false;
                    response.Explanation = "You can't add the same \"Lesson\" name to same \"Period\" ";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }

            return response;
        }

        #region Lesson Ops
        public TransactionObject EditLesson(int lessonID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                lessonManager.EditLesson(lessonManager.GetLesson(lessonID));
                Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;

        }

        public TransactionObject DeleteLesson(int lessonID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                lessonManager.DeleteLesson(lessonManager.GetLesson(lessonID));
                Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }
        #endregion

        #region Note Ops
        public TransactionObject EditNote(int noteID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                noteManager.EditNote(noteManager.GetNote(noteID));
                
                Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public TransactionObject DeleteNote(int noteID)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                noteManager.DeleteNote(noteManager.GetNote(noteID));

                Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }
        #endregion


    }
}
