using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ComplexManagersBases;
using AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers;
using AydinUniversityProject.Business.ManagerFolder.Managers.UserOpsManagers;
using AydinUniversityProject.Business.UnitOfWorkFolder;
using AydinUniversityProject.Data.Business;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using AydinUniversityProject.Data.POCOs;
using System;
using System.Collections.Generic;

namespace AydinUniversityProject.Business.ManagerFolder.ComplexManagers.StudentOpsComplexManagers
{
    public class EducationOpsComplexManager : BaseComplexManager
    {
        EducationManager educationManager;
        NoteManager noteManager;
        PeriodManager periodManager;
        LessonManager lessonManager;
        StudentManager studentManager;

        IUnitOfWork uow;

        public EducationOpsComplexManager()
        {
            uow = new UnitOfWork(new Database.Context.AydinUniversityProjectContext());

            educationManager = uow.GetManager<EducationManager, Education>();
            noteManager = uow.GetManager<NoteManager, Note>();
            periodManager = uow.GetManager<PeriodManager, Period>();
            lessonManager = uow.GetManager<LessonManager, Lesson>();
            studentManager = uow.GetManager<StudentManager, Student>();
        }

        public TransactionObject AddLesson(AddLessonFormData alFormData)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                Education education = educationManager.GetEducation(alFormData.StudentID, alFormData.LessonID);

                Student selectedStudent = studentManager.GetStudent(alFormData.StudentID);
                Lesson selectedLesson = lessonManager.GetLesson(alFormData.LessonID);

                if (education != null)
                {
                    Period currentPeriod = periodManager.GetPeriod(alFormData.Year, alFormData.Term);


                    Note note = new Note
                    {
                        ResultPoint = alFormData.Result,
                        Description = alFormData.Description,
                        EffectRate = alFormData.Effect,
                        Education = education
                    };

                    note.Education = education;
                    education.Notes.Add(note);


                    noteManager.AddNote(note);
                                    }
                else
                {
                    education = new Education();
                    education.Student = selectedStudent;
                    selectedStudent.Educations.Add(education);

                    education.Lesson = selectedLesson;
                    selectedLesson.Educations.Add(education);


                    Note note = new Note
                    {
                        ResultPoint = alFormData.Result,
                        Description = alFormData.Description,
                        EffectRate = alFormData.Effect,
                        Education = education
                    };

                    education.Notes.Add(note);

                    note.Education = education;

                    noteManager.AddNote(note);
                    educationManager.AddEducation(education);

                }
                
                double avg = 0;
                education.Notes.ForEach(note => avg += (note.EffectRate / 100) * note.ResultPoint);
                education.Average = avg;

                uow.Save();
                    response.IsSuccess = true;


            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }


            return response;
        }

        public TransactionObject DeleteEducation(int ID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                educationManager.DeleteEducation(ID);
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public List<Education> GetEducationsOfStudent(int ID)
        {
            return studentManager.GetStudent(ID).Educations;
        }
        
        public Education GetEducation(int ID)
        {
            return educationManager.GetEducation(ID);
        }

        #region Lesson Ops
        public TransactionObject EditLesson(int lessonID)
        {
            TransactionObject response = new TransactionObject();
            try
            {
                lessonManager.EditLesson(lessonManager.GetLesson(lessonID));
                uow.Save();
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
                uow.Save();
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Explanation = base.GetExceptionMessage(ex);
            }
            return response;
        }

        public List<Lesson> GetLessonsOfTerm(int year, int term)
        {
            return lessonManager.GetLessonsOfPeriod(year, term);
        }

        public Lesson GetLesson(int lessonID)
        {
            return lessonManager.GetLesson(lessonID);
        }

        public List<Lesson> GetAllLessons()
        {
           return lessonManager.GetAllLessons();
        }
        #endregion

        #region Note Ops
        public TransactionObject EditNote(EditNoteFormData note)
        {
            TransactionObject response = new TransactionObject();

            try
            {
                noteManager.EditNote(note);

                uow.Save();
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

                uow.Save();
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

        #region Period Ops
        public Period GetPeriod(int year, int semester)
        {
            return periodManager.GetPeriod(year, semester);
        }
        #endregion
    }
}