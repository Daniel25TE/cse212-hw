using System.ComponentModel;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    // 1. Add code in FeatureCollection.cs to describe the JSON using classes and properties 
    // on those classes so that the call to Deserialize above works properly.
    public List<Feature> Features { get; set; }
}
public class Feature
{
    public Properties Properties { get; set; }
}
public class Properties
{
    public double? Mag { get; set; }
    public string Place { get; set; }
}