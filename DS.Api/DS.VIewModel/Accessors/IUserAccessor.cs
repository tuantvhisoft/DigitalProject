using System;
namespace DS.ViewModel.Accessors
{
    public interface IUserAccessor
    {
        string GetUserId();
        string GetUserEmail();
        //Task<CreatedByDto?> GetCreatedInfo(DateTime CreatedAt, string userId);
        //Task<LastModifiedByDto?> GetLastModifiedInfo(DateTime? LastModifiedAt, string? userId);
    }
}

