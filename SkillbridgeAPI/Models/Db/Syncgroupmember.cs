﻿namespace SkillBridgeAPI.Models.Db;

public partial class Syncgroupmember
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Scopename { get; set; } = null!;

    public Guid Syncgroupid { get; set; }

    public int Syncdirection { get; set; }

    public Guid Databaseid { get; set; }

    public int Memberstate { get; set; }

    public int Hubstate { get; set; }

    public DateTime MemberstateLastupdated { get; set; }

    public DateTime HubstateLastupdated { get; set; }

    public DateTime? Lastsynctime { get; set; }

    public DateTime? LastsynctimeZerofailuresMember { get; set; }

    public DateTime? LastsynctimeZerofailuresHub { get; set; }

    public Guid? JobId { get; set; }

    public Guid? HubJobId { get; set; }

    public bool Noinitsync { get; set; }

    public bool? Memberhasdata { get; set; }

    public virtual Userdatabase Database { get; set; } = null!;

    public virtual Syncgroup Syncgroup { get; set; } = null!;
}
