using CalleStore.ViewModels;

namespace CalleStore.Services;

public interface IHomeService
{
    Task<HomeVM> GetIndexData();
}