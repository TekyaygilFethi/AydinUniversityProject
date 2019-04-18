﻿using AydinUniversityProject.Business.ManagerFolder.BaseManagers.ManagerBases;
using AydinUniversityProject.Business.RepositoryFolder;
using AydinUniversityProject.Data.POCOs;

namespace AydinUniversityProject.Business.ManagerFolder.Managers.ContactOpsManagers
{
    public class ContactManager : BaseManager
    {
        IRepository<Contact> contactRepository;

        public ContactManager()
        {
            contactRepository = base.GetRepository<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contactRepository.Add(contact);
        }

        public void EditContact(Contact contact)
        {
            contactRepository.Update(contact);
        }

        public Contact GetContact(int ID)
        {
            return contactRepository.GetByID(ID);
        }

    }
}
