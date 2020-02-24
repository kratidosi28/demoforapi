using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using Registration.Models.Enums.Main;
using Registration.BoundedContext.SqlContext;
namespace Registration.Models.Main
{
    [Table("Registered",Schema="dbo")]
    public partial class Registered
    {
		#region Id Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion Id Annotations

        public int Id { get; set; }

		#region FirstName Annotations

        [Required]
        [MaxLength(50)]
		#endregion FirstName Annotations

        public string FirstName { get; set; }

		#region LastName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LastName Annotations

        public string LastName { get; set; }

		#region Email Annotations

        [Required]
        [MaxLength(50)]
		#endregion Email Annotations

        public string Email { get; set; }

		#region MobileNo Annotations

        [Required]
        [MaxLength(50)]
		#endregion MobileNo Annotations

        public string MobileNo { get; set; }


        public Registered()
        {
        }
	}
}