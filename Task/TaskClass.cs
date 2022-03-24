using System;

namespace Task
{
    ///<summary>
    /// StatusTask contine situatiile in care o sarcina se va putea afla.
    ///</summary>
    public enum StatusTask
    {
        TODO,
        DOING,
        DONE
    }
    ///<summary>
    /// Clasa Task in care va fi definit formatul unei sarcini.
    ///</summary>
    public class TaskClass
    {
        ///<summary>
        /// _taskName este parametrul care va contine numele sarcinii de lucru.
        ///</summary>
        private string _taskName;
        ///<summary>
        /// _taskDetails este parametrul ce va contine detaliile despre sarcina.
        ///</summary>
        private string _taskDetails;
        ///<summary>
        /// _pathImage este parametrul ce va contine calea spre o imagine descriptiva a sarcinii.
        ///</summary>
        private string _pathImage;
        ///<summary>
        /// _progressTask este parametrul ce va contine descrie situatia in care se alfa sarcina.
        ///</summary>
        private StatusTask _progressTask;
        ///<summary>
        /// _startTask este parametrul ce va contine data la care este inceputa o sarcina.
        ///</summary>
        private DateTime _startTask;
        ///<summary>
        /// _endTask este parametrul ce va contine data la care ar trebui finalizata o sarcina.
        ///</summary>
        private DateTime _endDate;
        ///<summary>
        /// _numeUser este parametrul ce va contine numele autorului sarcinii.
        ///</summary>
        private string _numeUser;


        ///<summary>
        /// Constructorul clasei Task.
        ///</summary>
        public TaskClass(string taskName, string taskDetails, string path, DateTime startTask, DateTime endDate, StatusTask progressTask, String numUser)
        {
            _taskName = taskName;
            _taskDetails = taskDetails;
            _pathImage = path;
            _startTask = startTask;
            _endDate = endDate;
            _progressTask = progressTask;
            _numeUser = numUser;
        }

        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _taskName.
        ///</summary>
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }
        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _taskDetails.
        ///</summary>
        public string TaskUserName
        {
            get { return _numeUser; }
            set { _numeUser = value; }
        }
        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _TaskDetails.
        ///</summary>
        public string TaskDetails
        {
            get { return _taskDetails; }
            set { _taskDetails = value; }
        }

        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _pathImage.
        ///</summary>
        public string TaskPathImage
        {
            get { return _pathImage; }
            set { _pathImage = value; }
        }

        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _progressTask.
        ///</summary>
        public StatusTask TasProgress
        {
            get { return _progressTask; }
            set { _progressTask = value; }
        }

        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _startTask.
        ///</summary>

        public DateTime TaskStartTime
        {
            get { return _startTask; }
            set { _startTask = value; }
        }

        ///<summary>
        /// Metoda se setare si returnare a parametrului privat _endDate.
        ///</summary>
        public DateTime TaskEndTime
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
    }
}
