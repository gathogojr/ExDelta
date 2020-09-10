### Using EntitySetPath

**REF: Projects.xml**
```xml
      <Function Name="KeyProjects" IsBound="true" EntitySetPath="bindingParameter">
        <Parameter Name="bindingParameter" Type="Collection(ExDelta.Models.Project)"/>
        <ReturnType Type="Collection(ExDelta.Models.Project)"/>
      </Function>
      <Function Name="KeyMilestones" IsBound="true" EntitySetPath="bindingParameter/Milestones">
        <Parameter Name="bindingParameter" Type="Collection(ExDelta.Models.Project)"/>
        <ReturnType Type="Collection(ExDelta.Models.Milestone)"/>
      </Function>
      <EntityContainer Name="Container">
        <EntitySet Name="Projects" EntityType="ExDelta.Models.Project"/>
      </EntityContainer>
```

**REF: ProjectsController**
```c#
// ...
        [EnableQuery]
        public IQueryable<Project> KeyProjects()
        {
            return _db.Projects;
        }

        [EnableQuery]
        public IQueryable<Milestone> KeyMilestones()
        {
            return _db.Milestones;
        }
// ...
```

#### Working examples of $expand on Edm Function

http://localhost:16152/odata/Projects/KeyProjects?$expand=Milestones($filter=contains(Name, 'tion'))
http://localhost:16152/odata/Projects/KeyMilestones?$expand=Tasks($filter=contains(Description, 'Install'))
```
Inspite of not exposing `Milestones` entity set, you're able `$expand` the `Milestone` collection returned by `KeyMilestones` Edm function and even apply a `$filter`