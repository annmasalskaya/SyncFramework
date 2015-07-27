using System;


namespace SF.Entites {

    interface ISoftDeletable 
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedTimestamp { get; set; }

        void OnDeleting(SFDbContext context);
    }
}
