using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ILeaveRequestHandler hr = new HR();
            ILeaveRequestHandler projectmanager = new ProjectManager();
            ILeaveRequestHandler super = new Supervisor();

              super.SetNext(projectmanager);
                projectmanager.SetNext(hr);

            LeaveRequest l1 = new LeaveRequest("Vamshi",2);

            LeaveRequest l2 = new LeaveRequest("Sirisha",8);

            LeaveRequest l3 = new LeaveRequest("Harsha", 4);

            super.Handle(l1);
            super.Handle(l2);
            super.Handle(l3);

            Console.ReadKey();





        }
    }
}
