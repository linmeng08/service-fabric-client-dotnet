# Enable-SFPartitionBackup
Enables periodic backup of the stateful persisted partition.
## Description

Enables periodic backup of stateful persisted partition. Each partition is backed up as per the specified backup 
policy description. In case the application or service, which is partition is part of, is already enabled for backup 
then this operation would override the policy being used to take the periodic backup of this partition.
                Note only C# based Reliable Actor and Reliable Stateful services are currently supported for periodic 
backup.



## Required Parameters
#### -PartitionId

The identity of the partition.



#### -BackupPolicyName

Name of the backup policy to be used for enabling periodic backups.



