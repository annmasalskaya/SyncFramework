using System;


namespace SF.Entites {

    interface ISoftDeletable 
    {
        bool isDeleted { get; set; }

        DateTime? DeletedTimestamp { get; set; }

        void OnDeleting(SFDbContext context);
    }
}
