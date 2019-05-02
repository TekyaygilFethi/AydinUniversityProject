using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.Business.EducationComplexManagerData;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class NoteManager
    {
        IRepository<Note> noteRepository;

        public NoteManager(IRepository<Note> repo)
        {
            noteRepository = repo;
        }

        public void DeleteNote(Note note)
        {
            noteRepository.Delete(note);
        }

        public void AddNote(Note note)
        {
            noteRepository.Add(note);
        }

        public void EditNote(EditNoteFormData note)
        {
            var oldNote=GetNote(note.ID);
            oldNote.Description = note.Description;
            oldNote.EffectRate = note.EffectRate;
            oldNote.ResultPoint = note.ResultPoint;
            
        }

        public Note GetNote(int ID)
        {
            return noteRepository.GetByID(ID);
        }

    }
}
