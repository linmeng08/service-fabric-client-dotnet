# Restart-SFReplica
Restarts a service replica of a persisted service running on a node.
## Description

Restarts a service replica of a persisted service running on a node. Warning - There are no safety checks performed 
when this API is used. Incorrect use of this API can lead to availability loss for stateful services.



## Required Parameters
#### -NodeName

The name of the node.



#### -PartitionId

The identity of the partition.



#### -ReplicaId

The identifier of the replica.



