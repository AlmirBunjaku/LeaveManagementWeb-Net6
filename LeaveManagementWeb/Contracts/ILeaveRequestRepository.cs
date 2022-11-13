using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM request);
        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelLeaveRequest(int leaveRequestId);
    }
}
