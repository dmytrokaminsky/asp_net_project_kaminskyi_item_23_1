using System.ComponentModel.DataAnnotations;

namespace asp_net_project_kaminskyi_item_23_1_web.Models
{
    public class User
    {
        [Required(ErrorMessage = "Cuctom error message")]
        [Length(1, 2, ErrorMessage ="Field {0} has wrong lenth, it has to bee between {1} and {2}.")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
