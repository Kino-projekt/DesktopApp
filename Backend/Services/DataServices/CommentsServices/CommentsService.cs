using DesktopApp.Backend.Data;

namespace DesktopApp.Backend.Services.DataServices.CommentsServices
{
    public interface CommentsService
    {
        void SendComment(Comment comment);
    }
}