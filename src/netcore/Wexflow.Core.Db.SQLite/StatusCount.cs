﻿namespace Wexflow.Core.Db.SQLite
{
    public class StatusCount : Core.Db.StatusCount
    {
        public const string COLUMN_NAME_ID = "ID";
        public const string COLUMN_NAME_PENDING_COUNT = "PENDING_COUNT";
        public const string COLUMN_NAME_RUNNING_COUNT = "RUNNING_COUNT";
        public const string COLUMN_NAME_DONE_COUNT = "DONE_COUNT";
        public const string COLUMN_NAME_FAILED_COUNT = "FAILED_COUNT";
        public const string COLUMN_NAME_WARNING_COUNT = "WARNING_COUNT";
        public const string COLUMN_NAME_DISABLED_COUNT = "DISABLED_COUNT";
        public const string COLUMN_NAME_STOPPED_COUNT = "STOPPED_COUNT";
        public const string COLUMN_NAME_REJECTED_COUNT = "DISAPPROVED_COUNT";

        public const string TABLE_STRUCT = "(" + COLUMN_NAME_ID + " INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, " + COLUMN_NAME_PENDING_COUNT + " INTEGER, " + COLUMN_NAME_RUNNING_COUNT + " INTEGER, " + COLUMN_NAME_DONE_COUNT + " INTEGER, " + COLUMN_NAME_FAILED_COUNT + " INTEGER, " + COLUMN_NAME_WARNING_COUNT + " INTEGER, " + COLUMN_NAME_DISABLED_COUNT + " INTEGER, " + COLUMN_NAME_STOPPED_COUNT + " INTEGER, " + COLUMN_NAME_REJECTED_COUNT + " INTEGER)";

        public long Id { get; set; }
    }
}