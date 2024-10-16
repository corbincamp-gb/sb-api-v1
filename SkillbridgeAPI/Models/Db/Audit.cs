﻿namespace SkillBridgeAPI.Models.Db;

public partial class Audit
{
    public Guid Id { get; set; }

    public DateTime AuditDateTimeUtc { get; set; }

    public string? AuditType { get; set; }

    public string? AuditUser { get; set; }

    public string? TableName { get; set; }

    public string? KeyValues { get; set; }

    public string? OldValues { get; set; }

    public string? NewValues { get; set; }

    public string? ChangedColumns { get; set; }
}
