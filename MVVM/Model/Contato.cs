using System.ComponentModel;

namespace MVVM.Model
{
    public class Contato : INotifyPropertyChanged
    {
#pragma warning disable CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.
        public event PropertyChangedEventHandler PropertyChanged = null!;
#pragma warning restore CS8612 // Nullability of reference types in type doesn't match implicitly implemented member.

        // Esta rotina é chamada cada vez que o valor da propridade 
        // for definida. Isso vai disparar um evento para notificar 
        // a WPF via data binding que algo mudou
        private void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        private string _nome = null!;
        private string _sobrenome = null!;
        private string _telefone = null!;
        private string _email = null!;

        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public string Sobrenome
        {
            get { return _sobrenome; }
            set
            {
                _sobrenome = value;
                OnPropertyChanged("Sobrenome");
            }
        }
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                _telefone = value;
                OnPropertyChanged("Telefone");
            }
        }
    }
}
