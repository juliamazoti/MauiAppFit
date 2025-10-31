using MauiAppFit.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppFit.ViewModels
{
    internal class ListaAtividadesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Pegando o que foi digitado pelo usuário

        public string ParametroBusca { get; set; }

        // Gerencia se mostra ao usuário o RefreshView

        bool estaAtualizando = false;

        public bool EstaAtualizando
        {
            get => estaAtualizando;

            set
            {
                estaAtualizando |= value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("EstaAtualizando"));
            }
        }

        //  Coleção que armazena as atividades do usuário

        ObservableCollection<Atividade> listaAtividades =
            new ObservableCollection<Atividade>();
        public ObservableCollection<Atividade> ListaAtividades
        {
            get => listaAtividades;
        }

        }

    }