# New-SFService
Creates the specified Service Fabric service.
## Description

This api allows creating a new Service Fabric stateless or stateful service under a specified Service Fabric 
application. The description for creating the service includes partitioning information and optional properties for 
placement and load balancing. Some of the properties can later be modified using `UpdateService` API.



## Required Parameters
#### -ApplicationId

The identity of the application. This is typically the full name of the application without the 'fabric:' URI scheme.
                    Starting from version 6.0, hierarchical names are delimited with the "~" character.
                    For example, if the application name is "fabric:/myapp/app1", the application identity would be 
"myapp~app1" in 6.0+ and "myapp/app1" in previous versions.



#### -ServiceName

The full name of the service with 'fabric:' URI scheme.



#### -ServiceTypeName

Name of the service type as specified in the service manifest.



#### -Count

The number of partitions.



#### -Names

Array of size specified by the ‘Count’ parameter, for the names of the partitions.



#### -LowKey

String indicating the lower bound of the partition key range that
                    should be split between the partitions.



#### -HighKey

String indicating the upper bound of the partition key range that
                    should be split between the partitions.



#### -TargetReplicaSetSize

The target replica set size as a number.



#### -MinReplicaSetSize

The minimum replica set size as a number.



#### -HasPersistedState

A flag indicating whether this is a persistent service which stores states on the local disk. If it is then the value 
of this property is true, if not it is false.



#### -InstanceCount

The instance count.



## Optional Parameters
#### -ApplicationName

The name of the application, including the 'fabric:' URI scheme.



#### -InitializationData

The initialization data as an array of bytes. Initialization data is passed to service instances or replicas when they 
are created.



#### -PlacementConstraints

The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for 
restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes 
where NodeType is blue specify the following: "NodeColor == blue)".



#### -CorrelationScheme

The correlation scheme.



#### -ServiceLoadMetrics

The service load metrics.



#### -ServicePlacementPolicies

The service placement policies.



#### -DefaultMoveCost

The move cost for the service. Possible values include: 'Zero', 'Low', 'Medium', 'High'
                    
                    Specifies the move cost for the service.



#### -IsDefaultMoveCostSpecified

Indicates if the DefaultMoveCost property is specified.



#### -ServicePackageActivationMode

The activation mode of service package to be used for a service. Possible values include: 'SharedProcess', 
'ExclusiveProcess'
                    
                    The activation mode of service package to be used for a Service Fabric service. This is specified 
at the time of creating the Service.



#### -ServiceDnsName

The DNS name of the service. It requires the DNS system service to be enabled in Service Fabric cluster.



#### -ScalingPolicies

Scaling policies for this service.



#### -Flags

Flags indicating whether other properties are set. Each of the associated properties corresponds to a flag, specified 
below, which, if set, indicate that the property is specified.
                    This property can be a combination of those flags obtained using bitwise 'OR' operator.
                    For example, if the provided value is 6 then the flags for QuorumLossWaitDuration (2) and 
StandByReplicaKeepDuration(4) are set.
                    
                    - None - Does not indicate any other properties are set. The value is zero.
                    - ReplicaRestartWaitDuration - Indicates the ReplicaRestartWaitDuration property is set. The value 
is 1.
                    - QuorumLossWaitDuration - Indicates the QuorumLossWaitDuration property is set. The value is 2.
                    - StandByReplicaKeepDuration - Indicates the StandByReplicaKeepDuration property is set. The value 
is 4.



#### -ReplicaRestartWaitDurationSeconds

The duration, in seconds, between when a replica goes down and when a new replica is created.



#### -QuorumLossWaitDurationSeconds

The maximum duration, in seconds, for which a partition is allowed to be in a state of quorum loss.



#### -StandByReplicaKeepDurationSeconds

The definition on how long StandBy replicas should be maintained before being removed.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



