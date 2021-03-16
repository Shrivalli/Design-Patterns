using System;

namespace ChainOfResponsibility
{

    class HR : AbstractHandler
    {
        public override void Handle(LeaveRequest Request)
        {
            if(Request.LeaveDays>=5)
            {
                Console.WriteLine("{0},{1} will accept your request",
                    Request.Employee, this.GetType().Name);
               
            }
            else if(leaveRequestHandler!=null )
            {
                leaveRequestHandler.Handle(Request);
               
            }

        }
    }

    class ProjectManager : AbstractHandler
    {
        public override void Handle(LeaveRequest Request)
        {
            if (Request.LeaveDays >= 3 && Request.LeaveDays<5)
            {
                Console.WriteLine("{0},{1} will accept your request",
                    Request.Employee, this.GetType().Name);

            }
            else if (leaveRequestHandler != null)
            {
                leaveRequestHandler.Handle(Request);

            }
        }
    }
    class Supervisor : AbstractHandler
    {
        public override void Handle(LeaveRequest Request)
        {
            if (Request.LeaveDays > 0 && Request.LeaveDays<3)
            {
                Console.WriteLine("{0},{1} will accept your request",
                    Request.Employee, this.GetType().Name);

            }
            else if (leaveRequestHandler != null)
            {
                leaveRequestHandler.Handle(Request);

            }
        }
    }
    abstract class AbstractHandler : ILeaveRequestHandler
    {
        public ILeaveRequestHandler leaveRequestHandler;
        public abstract void Handle(LeaveRequest leave);
        
        public void SetNext(ILeaveRequestHandler leaveRequest)
        {
            this.leaveRequestHandler = leaveRequest;
            
        }
    }
    interface ILeaveRequestHandler
    {

        void SetNext(ILeaveRequestHandler leaveRequest);

        void Handle(LeaveRequest leave);

    }
}
