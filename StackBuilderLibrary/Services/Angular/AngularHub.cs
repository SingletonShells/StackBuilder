using System;

namespace StackBuilderLibrary.Services.Angular;

public class AngularHub
{
    AngularFileGenerator angularHub = new AngularFileGenerator();
    public void createAngular(string projectName, string directory) => angularHub.createProject(projectName, directory);
}
