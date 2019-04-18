using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.EducationOpsManagers
{
    public class NoteManager : BaseManager
    {
        IRepository<Note> noteRepository;

        public NoteManager()
        {
            noteRepository = base.GetRepository<Note>();
        }

        public void DeleteNote(Note note)
        {
            noteRepository.Delete(note);
        }

        public void AddNote(Note note)
        {
            noteRepository.Add(note);
        }

        public void EditNote(Note note)
        {
            noteRepository.Update(note);
        }

        public Note GetNote(int ID)
        {
            return noteRepository.GetByID(ID);
        }

    }
}
