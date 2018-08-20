using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public class Donnees
    {
        public static BindingList<Client> TabClients = new BindingList<Client>();

        public static BindingList<Contact> TabContacts = new BindingList<Contact>();
    }
}